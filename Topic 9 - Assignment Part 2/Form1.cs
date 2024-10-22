using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_9___Assignment_Part_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            lblPlus.Visible = true;
            lblMinus.Visible = false;
            lblTimes.Visible = false;
            lblDivide.Visible = false;
            lblPlus.Text = ("8 + 8 = " + (8 + 8));
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            lblMinus.Visible = true;
            lblTimes.Visible = false;
            lblPlus.Visible = false;
            lblDivide.Visible = false;
            lblMinus.Text = ("8 - 8 = " + (8 - 8));
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            lblTimes.Visible = true;
            lblMinus.Visible = false;
            lblPlus.Visible = false;
            lblDivide.Visible = false;
            lblTimes.Text = ("8 x 8 = " + (8 * 8));
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            lblDivide.Visible = true;
            lblMinus.Visible = false;
            lblPlus.Visible = false;
            lblTimes.Visible = false;
            lblDivide.Text = ("8 / 8 = " + (8 / 8));
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
