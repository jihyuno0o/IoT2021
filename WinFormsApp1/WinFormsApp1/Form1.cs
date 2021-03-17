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

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool status = true;
        private void btnTest_Click(object sender, EventArgs e)
        {
            if (status)
                btnTest.Text = "want to";
            else
                btnTest.Text = "go home";
            status = !status;
        }

        private void btnFileOpen_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.Cancel) return; //파일이 선택되지 않으면

            string fName = openFileDialog1.FileName; //File full path
            StreamReader sr = new StreamReader(fName);
            string buf = sr.ReadToEnd();
            sr.Close();
            tbMemo.Text = buf;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.Cancel) return; //파일이 선택되지 않으면

            string fName = saveFileDialog1.FileName; //File full path
            StreamWriter sw = new StreamWriter(fName);
            string buf = tbMemo.Text;
            sw.Write(buf);
            sw.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string src = textBox1.Text;
            textBox2.Text = src.ToUpper();
            //textBox3.Text = "length : " + src.Length.ToString();
            textBox3.Text = $"length: {src.Length,5:X}";
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            if (frm2.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = frm2.cb1.Text + "\r\n" +
                                frm2.cb2.Text + "\r\n" +
                                frm2.cb3.Text;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_2(object sender, EventArgs e)
        {
     
        }
    }
}
