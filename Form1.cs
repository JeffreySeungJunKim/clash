using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 8;
            trackBar2.Minimum = 0;
            trackBar2.Maximum = 8;
            trackBar3.Minimum = 0;
            trackBar3.Maximum = 8;
            trackBar4.Minimum = 0;
            trackBar4.Maximum = 8;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            Army1.Text =(trackBar1.Value).ToString();
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            Army2.Text = (trackBar2.Value).ToString();
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            Army3.Text = (trackBar3.Value).ToString();
        }

        private void trackBar4_ValueChanged(object sender, EventArgs e)
        {
            Army4.Text = (trackBar4.Value).ToString();
        }

        private void Army1_Validated(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(Army1.Text);
            }
            catch (FormatException ex)
            {
                Army1.Text = "";
            }
            if (Army1.Text == "")
                trackBar1.Value = 0;
            else if(Convert.ToInt32(Army1.Text) > trackBar1.Maximum)
            {
                trackBar1.Value = trackBar1.Maximum;
                Army1.Text = trackBar1.Maximum.ToString();
            }
            else
                trackBar1.Value = Convert.ToInt32(Army1.Text);
        }

        private void Army2_Validated(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(Army2.Text);
            }
            catch (FormatException ex)
            {
                Army2.Text = "";
            }
            if (Army2.Text == "")
                trackBar2.Value = 0;
            else if (Convert.ToInt32(Army2.Text) > trackBar2.Maximum)
            {
                trackBar2.Value = trackBar2.Maximum;
                Army2.Text = trackBar2.Maximum.ToString();
            }
            else
                trackBar2.Value = Convert.ToInt32(Army2.Text);
        }

        private void Army3_Validated(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(Army3.Text);
            }
            catch (FormatException ex)
            {
                Army3.Text = "";
            }
            if (Army3.Text == "")
                trackBar3.Value = 0;
            else if (Convert.ToInt32(Army3.Text) > trackBar3.Maximum)
            {
                trackBar3.Value = trackBar3.Maximum;
                Army3.Text = trackBar3.Maximum.ToString();
            }
            else
                trackBar3.Value = Convert.ToInt32(Army3.Text);
        }

        private void Army4_Validated(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(Army4.Text);
            }
            catch (FormatException ex)
            {
                Army4.Text = "";
            }
            if (Army4.Text == "")
                trackBar4.Value = 0;
            else if (Convert.ToInt32(Army4.Text) > trackBar4.Maximum)
            {
                trackBar4.Value = trackBar4.Maximum;
                Army4.Text = trackBar4.Maximum.ToString();
            }
            else
                trackBar4.Value = Convert.ToInt32(Army4.Text);
        }
    }
}
