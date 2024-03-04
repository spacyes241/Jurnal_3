using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juranal_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool test;
     


        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!test)
            {
                Output.Text = "" + "+";
                test = true;
            }
            else
            {
                Output.Text = Output.Text + "" + "+";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!test)
            {
                Output.Text = "" + 0;
                test = true;
            } else
            {
                Output.Text = Output.Text + "" + 0;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (!test)
            {
                Output.Text = "" + 1;
                test = true;
            }
            else
            {
                Output.Text = Output.Text + "" + 1 ;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!test)
            {
                Output.Text = "" + 7;
                test = true;
            }
            else
            {
                Output.Text = Output.Text + "" + 7;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
             if (!test)
            {
                Output.Text = "" + 2;
                test = true;
            }
            else
            {
                Output.Text = Output.Text + "" + 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!test)
            {
                Output.Text = "" + 9;
                test = true;
            }
            else
            {
                Output.Text = Output.Text + "" + 9;
            }
        }

        private void but6_Click(object sender, EventArgs e)
        {
            if (!test)
            {
                Output.Text = "" + 6;
                test = true;
            }
            else
            {
                Output.Text = Output.Text + "" + 6;
            }
        }

        private void but5_Click(object sender, EventArgs e)
        {
            if (!test)
            {
                Output.Text = "" + 5;
                test = true;
            }
            else
            {
                Output.Text = Output.Text + "" + 5;
            }
        }

        private void but4_Click(object sender, EventArgs e)
        {
            if (!test)
            {
                Output.Text = "" + 4;
                test = true;
            }
            else
            {
                Output.Text = Output.Text + "" + 4;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!test)
            {
                Output.Text = "" + 3;
                test = true;
            }
            else
            {
                Output.Text = Output.Text + "" + 3;
            }
        }

        private void but8_Click(object sender, EventArgs e)
        {
            if (!test)
            {
                Output.Text = "" + 8;
                test = true;
            }
            else
            {
                Output.Text = Output.Text + "" + 8;
            }
        }

        private void butequal_Click(object sender, EventArgs e)
        {
            Output.Text = "1366";
        }
    }
}
