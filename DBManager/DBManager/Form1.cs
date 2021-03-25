using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuMigration_Click(object sender, EventArgs e)
        {
            DialogResult ret = openFileDialog1.ShowDialog();
            if (ret != DialogResult.OK) return;
            string nFile = openFileDialog1.FileName; //full name
            
            StreamReader sr = new StreamReader(nFile);

            //==========================================
            //Header 처리 프로세스
            //==========================================
            string buf = sr.ReadLine();
            if (buf == null) return ;
            string[] sArr = buf.Split(',');
            for (int i = 0; i < sArr.Length; i++)
            {
                dataGrid.Columns.Add(sArr[i], sArr[i]);
            }

            //==========================================
            //Row데이터 처리 프로세스
            //==========================================
            while (true)
            {
                buf = sr.ReadLine();
                if (buf == null) break;
                sArr = buf.Split(',');
                dataGrid.Rows.Add(sArr);
                //int ridx = dataGrid.Rows.Add(); // line 1 생성
                //for (int i = 0; i < sArr.Length; i++)
                //{
                //    dataGrid.Rows[ridx].Cells[i].Value = sArr[i];
                //}
               
            }
            
        }

        SqlConnection sqlCon = new SqlConnection();
        SqlCommand sqlCmd = new SqlCommand();   

        string sConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=[filename];Integrated Security=True;Connect Timeout=30";

        private void mnuDBOpen_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ret = openFileDialog1.ShowDialog();
                if (ret != DialogResult.OK) return;
                string nFile = openFileDialog1.FileName; //full name
                string NFile = openFileDialog1.SafeFileName;

                
                sqlCmd.Connection = sqlCon;
                //            sqlCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KOSTA\source\repos\DBManager\testDB.mdf;Integrated Security=True;Connect Timeout=30";
                sqlCon.ConnectionString = sConn.Replace("[filename]", nFile);

                sqlCon.Open();
                sb1.Text = NFile + " Open success";
                sb1.BackColor = Color.Green;

                DataTable dt = sqlCon.GetSchema("Tables");
                for(int i=0; i<dt.Rows.Count; i++)
                {
                    string s = dt.Rows[i].ItemArray[2].ToString();
                    sbButton1.DropDownItems.Add(s);
                }

                string sample = "column1,column2";
                string[] sa = sample.Split(',');
                string buf = "";

                foreach (string col in sa) //각 배열요소; col은 모든 배열 요소
                {
                    //buf += string.Format("{0,-" + 30 + "}", col);
                    buf += $"{col,30}";
                }
                sb2.Text = buf;

            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message);
                sb1.Text = "Database Cannot Open";
                sb1.BackColor = Color.Red;
            }           
        }

        private void mnuDBClose_Click(object sender, EventArgs e)
        {
            sqlCon.Close();
            sb1.Text = "DB File Name";
            sb1.BackColor = Color.Gray;
            sb2.Text = "Database Closed";

            sbButton1.DropDownItems.Clear();

        }
        
        public static string getToken(int index, char deli, string str)
        {
            string[] Str = str.Split(deli);
            string ret = Str[index];
            return ret;

        }

        string TableName;
        int RunSql(string s1)
        {
            try
            {
                string sql = s1.Trim();
                sqlCmd.CommandText = sql; 
                
                if (getToken(0,' ',sql).ToLower()=="select")
                {
                    SqlDataReader sr = sqlCmd.ExecuteReader();

                    TableName = getToken(3, ' ', sql);
                    sbButton1.Text = TableName;
                    dataGrid.Rows.Clear(); dataGrid.Columns.Clear();

                    for(int i=0; i<sr.FieldCount; i++)
                    {
                        dataGrid.Columns.Add(sr.GetName(i), sr.GetName(i));
                    }

                    
                    for (int i=0; sr.Read(); i++) //1 record read : 1줄
                    {
                        //string buf = "";
                        int ridx = dataGrid.Rows.Add();

                        for(int j=0; j<sr.FieldCount; j++)
                        {
                            object str = sr.GetValue(j);
                            //buf += $" {str}";
                            dataGrid.Rows[ridx].Cells[j].Value = $"{str}";
                        }
                        //textBox1.Text += $"\r\n{buf}";
                    }
                    sr.Close();
                }
                else
                {
                    sqlCmd.ExecuteNonQuery();
                }
                
                sb2.Text = "Success";
                sb2.BackColor = Color.AliceBlue;
                // select문 제외 -- no return value -- update, insert, delete, create, alt
            }
            catch(SqlException e1)
            {
                MessageBox.Show(e1.Message);
                sb2.Text = "Error";
                sb2.BackColor = Color.OrangeRed;
            }
            catch (InvalidOperationException e2)
            {
                MessageBox.Show(e2.Message);

            }
            return 0;
                        
        }

        private void mnuExecSql_Click(object sender, EventArgs e)
        {
            
            RunSql(textBox1.Text);
           //sqlCmd.ExecuteReader(); //select

        }
        string selectedText;
        private void mnuExecSelectSql_Click(object sender, EventArgs e)
        {
            selectedText = textBox1.SelectedText;
            RunSql(selectedText);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (mnuKeyEnter.Checked==false) return;
            if(e.KeyCode == Keys.Enter)
            {
                string tb = textBox1.Text;
                string[] sArr = tb.Split('\n');
                int n = sArr.Length;
                string sql = sArr[n - 1].Trim();
                RunSql(sql);
            }
        }

        private void dataGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = ".";
        }

        private void mnuUpdate_Click(object sender, EventArgs e)
        {
            for(int i=0; i<dataGrid.Rows.Count; i++)
            {
                for (int j = 0; j < dataGrid.Columns.Count; j++)
                {
                    string s = dataGrid.Rows[i].Cells[j].ToolTipText;
// update [Table] set [field]=[CellText] where [1st_Col Name]=[ist_Col.CellText]
                    if (s == ".")
                    {
                        string tn = TableName;
                        string fn = dataGrid.Columns[j].HeaderText;
                        object ct = dataGrid.Rows[i].Cells[j].Value;
                        string kn = dataGrid.Columns[0].HeaderText;
                        object kt = dataGrid.Rows[i].Cells[0].Value;
                        string sql = $"update {tn} set {fn}={ct} where {kn}={kt}";
                        RunSql(sql);
                    }
                }            
            }
        }

        private void sb3_Click(object sender, EventArgs e)
        {
//            string sql = $"select * from {sb3.Text}";
//            RunSql(sql);
        }

        private void sbButton1_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string s = e.ClickedItem.Text; //사용할 테이블명
            string sql = $"select * from {s}";
            RunSql(sql);
        }
        string column;
        private void Column_Click(object sender, EventArgs e)
        {
            ColName dlg = new ColName("Input Column Name");
            DialogResult ret = dlg.ShowDialog();
            if (ret == DialogResult.OK)
            {
                column = dlg.colName;

                dataGrid.Columns.Add(column, column);
            }

        }

        private void Row_Click(object sender, EventArgs e)
        {
            dataGrid.Rows.Add();
        }

        private void mnuKeyEnter_Click(object sender, EventArgs e)
        {
            mnuKeyEnter.Checked = !mnuKeyEnter.Checked;
        }
        
        private void mnuSaveas_Click(object sender, EventArgs e)
        {
            ColName dlg = new ColName("Input Table Name");
            DialogResult ret = dlg.ShowDialog();
            if (ret != DialogResult.OK) return;

            string tName = dlg.colName;
            string sql = $"Create table {tName} (";
            
            for(int i=0; i<dataGrid.ColumnCount; i++)
            {
                sql += $"{dataGrid.Columns[i].HeaderText} nchar(20)";
                if (i < dataGrid.ColumnCount - 1) sql += ", ";
            }
            sql += ")";

            RunSql(sql);

            for(int i=0; i<dataGrid.RowCount; i++)
            {
                sql = $"Insert into {tName} values (";
                for (int j = 0; j < dataGrid.ColumnCount; j++)
                {
                    string cell = (string)dataGrid.Rows[i].Cells[j].Value;
                    sql += $"'{cell}'";

                    if (j < dataGrid.ColumnCount - 1) sql += ", ";
                }
                sql += ")";
                RunSql(sql);
            }
           

        }
    }
}
