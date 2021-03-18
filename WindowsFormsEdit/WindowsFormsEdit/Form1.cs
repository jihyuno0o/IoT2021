using myLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEdit
{
    public partial class formMemo : Form
    {
        public formMemo()
        {
            InitializeComponent();
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); //C++ DoModal();
            if (result == DialogResult.OK)
            {
                string fName = openFileDialog1.FileName; //full path
                StreamReader sr = new StreamReader(fName); //StreamReader = c++: CFile
                tbMemo.Text = sr.ReadToEnd();
                sr.Close();

                //int n = myLib.Count('\\', fName);
                //string fileN = myLib.GetToken(n, '\\', fName);

                string fileName = openFileDialog1.SafeFileName;
                this.Text = this.Text + "  [" +fileName+ "]"; 
            }
        }
        //Save as,,,
        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fName = saveFileDialog1.FileName;
                StreamWriter sw = new StreamWriter(fName);
                string buf = tbMemo.Text;
                sw.Write(buf);
                sw.Close();

            }
        }

        //1. file open 후 memo창에 표시한 경우 - 확인 o 수정 x
        //2. new 메뉴 선택 후 문서 편집 - file명 없음
        //3. 기존 문서 중 일부 수정 - open file명 있음

        int txtChanged = 0;
        private void tbMemo_TextChanged(object sender, EventArgs e)
        {
            if (true) txtChanged = 1;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtChanged == 1)
            {

            }
        }

        private void mnuViewFont_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDialog1.ShowDialog();
            if (result == DialogResult.Cancel) return;

            Font font = fontDialog1.Font;
            tbMemo.Font = font;

            sbLabel1.Text = font.Name;
            sbLabel2.Text = font.Size.ToString();
            

        }


        private void mnuViewForecolor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.Cancel) return;

            Color color = colorDialog1.Color;
            tbMemo.ForeColor = color;

            sbLabel3.Text = color.Name;

        }

        private void mnuViewBackcolor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.Cancel) return;

            Color color = colorDialog1.Color;
            tbMemo.BackColor = color;

            sbLabel4.Text = color.Name;

        }

        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            tbMemo.Clear();
        }

        //int Count(char deli, string str)
        //{
        //    string[] Strs = str.Split(deli);
        //    int n = Strs.Length;
        //    return n;
        //}
        //string GetToken(int index, char deli, string str)
        //{
        //    string[] arr = str.Split(deli);

        //    return arr[index];
        //}

    }
}
