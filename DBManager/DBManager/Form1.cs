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
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message);
                sb1.Text = "Database Cannot Open";
                sb1.BackColor = Color.Red;
            }
            
        }

        
        int RunSql(string sql)
        {
            try
            {
                sqlCmd.CommandText = sql; 
                sqlCmd.ExecuteNonQuery(); // select문 제외 -- no return value -- update, insert, delete, create, alt
            }
            catch(SqlException e1)
            {
                MessageBox.Show(e1.Message);
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

        private void mnuExecSelectSql_Click(object sender, EventArgs e)
        {
           RunSql(textBox1.SelectedText);
        }
    }
}
