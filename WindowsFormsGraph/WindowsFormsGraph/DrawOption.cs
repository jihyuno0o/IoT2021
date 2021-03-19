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
    public partial class DrawOption : Form
    {
        public int X;
        public int Y;
        public int N;
        public DrawOption(int x, int y, int t)
        {
            X = x; Y = y; N = t;
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            X = int.Parse(tbX.Text);
            Y = int.Parse(tbY.Text);
            N = int.Parse(tbInt.Text);
        }

        private void DrawOption_Load(object sender, EventArgs e)
        {
            tbX.Text = $"{X}";
            tbY.Text = $"{Y}";
            tbInt.Text = $"{N}";
        }
    }
}
