using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_v1
{
    public partial class calculator_App : Form
        
    {
        int Number = 0;
        int Number1 = 0;
        char op = '-';
        public calculator_App()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0") //button  +/-
            {
                label1.Text += "0";

            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")  // Button 0
            {
                label1.Text += "0";
                

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (label1.Text !="0")
            {
                label1.Text += "1";
                Number += 1;

            }
            else
            {
                label1.Text = "1";
                Number += 1;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text += "2";
                Number += 2;
            }
            else
            {
                label1.Text = "2";
                Number += 2;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text += "3";
                Number += 3;
            }
            else
            {
                label1.Text = "3";
                Number += 3;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text += "4";
                Number += 4;
            }
            else
            {
                label1.Text = "4";
                Number += 4;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text += "5";
                Number += 5;
            }
            else
            {
                label1.Text = "5";
                Number += 5;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text += "6";
                Number += 6;
            }
            else
            {
                label1.Text = "6";
                Number += 6;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text += "7";
                Number += 7;
            }
            else
            {
                label1.Text = "7";
                Number += 7;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text += "8";
                Number += 8;
            }
            else
            {
                label1.Text = "8";
                Number += 8;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text += "9";
                Number += 9;
            }
            else
            {
                label1.Text = "9";
                Number += 9;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Number = 0;
           Number1 = 0;    
            label1.Text = "0"; // AC
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            op = '-';
            Number1 = Number;
            Number = 0;
            label1.Text = "0";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case '-':
                {
                        int m = Number1- int.Parse(label1.Text);
                        label1.Text = m.ToString();
                    break;
                }
                case '+':
                    {
                        int m = Number1 + int.Parse(label1.Text);
                        label1.Text = m.ToString();
                        break;
                    }
                case '*':
                    {
                        int m = Number1 * int.Parse(label1.Text);
                        label1.Text = m.ToString();
                        break;
                    }
                case '/':
                    {
                        int m = Number1 / int.Parse(label1.Text);
                        label1.Text = m.ToString();
                        break;
                    }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            op = '+';
            Number1 = Number;
            Number = 0;
            label1.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            op = '*';
            Number1 = Number;
            Number = 0;
            label1.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            op = '/';
            Number1 = Number;
            Number = 0;
            label1.Text = "0";
        }
    }
}
