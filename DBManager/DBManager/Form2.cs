using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager
{
    public partial class ColName : Form
    {
        public string colName;
        string sTitle;
        public ColName(string sT = "Input")
        {
            sTitle = sT; 
            InitializeComponent();
        }
        private void ColName_Load(object sender, EventArgs e)
        {
            lbInput.Text = sTitle;
        }
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (tbColname.Text == "")
        //        this.DialogResult = DialogResult.Cancel;
        //    else
        //    {
        //        this.DialogResult = DialogResult.OK;
        //        colName = tbColname.Text;
        //    }
        //    Close();
               
        //}

        private void tbColname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {              
                colName = tbColname.Text;
                this.DialogResult = DialogResult.OK;
            }
            else if (e.KeyCode == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;

        }

        
    }
}
