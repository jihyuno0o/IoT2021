using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGraph
{
    public partial class Form1 : Form
    {
        Graphics GDC;
        int cX = 10;
        int cY = 10;
        int cN = 2;
        public Form1()
        {
            InitializeComponent();

            GDC = CanvasDraw.CreateGraphics();
        }

        private void mnuDraw_Click(object sender, EventArgs e)
        {
            DrawOption dlg = new DrawOption(cX,cY,cN);
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                cX = dlg.X;
                cY = dlg.Y;
                cN = dlg.N;
            }


        }

        private void CanvasDraw_MouseDown_1(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                 Pen pen = new Pen(Color.Red, cN);
                GDC.DrawEllipse(pen, e.X-cX/2, e.Y-cY/2, cX, cY); //-cX/2하는 이유는 마우스 찍는 점이 원의 중심이 되게 하려고
            }
           
        }

        private void CanvasDraw_Resize(object sender, EventArgs e)
        {
            GDC = CanvasDraw.CreateGraphics();
        }

        private void mnuErase_Click(object sender, EventArgs e)
        {
            GDC.Clear(DefaultBackColor);
        }
    }
}
