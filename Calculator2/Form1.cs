//Michael Sibbald C00206817


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator2
{
    

    public partial class Calculator : Form
    {
        public String answer;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }


        private void Clear(object sender, EventArgs e)
        {
            output.Text = "";
        }

        private void Backspace(object sender, EventArgs e)
        {
            if(output.Text.Length > 1)
            {
                do
                {
                    output.Text = output.Text.Substring(0, output.TextLength - 1);
                }
                while (output.Text[output.Text.Length - 1] == ' ');
            }
            else if (output.Text.Length == 1)
            {
                output.Text = output.Text.Substring(0, output.TextLength - 1);
            }
            
        }

        private void Seven(object sender, EventArgs e)
        {
            output.Text += "7";
        }

        private void Eight(object sender, EventArgs e)
        {
            output.Text += "8";
        }

        private void Nine(object sender, EventArgs e)
        {
            output.Text += "9";
        }

        private void Plus(object sender, EventArgs e)
        {
            if (output.Text.Length == 1)
            {
                output.Text += " + ";
            }
            else if (output.Text.Length > 1 &&
                    output.Text[output.Text.Length - 2] != '*' &&
                    output.Text[output.Text.Length - 2] != '/' &&
                    output.Text[output.Text.Length - 2] != '+' &&
                    output.Text[output.Text.Length - 2] != '-')
            {
                output.Text += " + ";
            }
        }

        private void Four(object sender, EventArgs e)
        {
            output.Text += "4";
        }

        private void Five(object sender, EventArgs e)
        {
            output.Text += "5";
        }

        private void Six(object sender, EventArgs e)
        {
            output.Text += "6";
        }

        private void Minus(object sender, EventArgs e)
        {
            if (output.Text.Length == 1)
            {
                output.Text += " - ";
            }
            else if (output.Text.Length > 1 && output.Text[output.Text.Length - 2] != '-')
            {
                output.Text += " - ";
            }
        }

        private void Multiply(object sender, EventArgs e)
        {
            if (output.Text.Length == 1)
            {
                output.Text += " * ";
            }
            else if (output.Text.Length > 1 &&
                    output.Text[output.Text.Length - 2] != '*' &&
                    output.Text[output.Text.Length - 2] != '/' &&
                    output.Text[output.Text.Length - 1] != '.' &&
                    output.Text[output.Text.Length - 2] != '+' &&
                    output.Text[output.Text.Length - 2] != '-')
            {
                output.Text += " * ";
            }
        }

        private void Three(object sender, EventArgs e)
        {
            output.Text += "3";
        }

        private void Two(object sender, EventArgs e)
        {
            output.Text += "2";
        }

        private void One(object sender, EventArgs e)
        {
            output.Text += "1";  
        }

        private void Divide(object sender, EventArgs e)
        {
            if (output.Text.Length == 1)
            {
                output.Text += " / ";
            }
            else if(output.Text.Length > 1 &&
                    output.Text[output.Text.Length - 2] != '/' &&
                    output.Text[output.Text.Length - 2] != '*' &&
                    output.Text[output.Text.Length - 1] != '.' &&
                    output.Text[output.Text.Length - 2] != '+' &&
                    output.Text[output.Text.Length - 2] != '-')
            {
                output.Text += " / ";
            }

        }

        private void Equal(object sender, EventArgs e)
        {
            String calculation = output.Text;
            String newOut;

            if(output.Text.Length == 1)
            {
                newOut = new DataTable().Compute(calculation, null).ToString();
                output.Text = newOut;
            }
            else if(output.Text.Length > 1 && output.Text[output.Text.Length - 2] != '/' && output.Text[output.Text.Length - 2] != '*')
            {
                newOut = new DataTable().Compute(calculation, null).ToString();
                output.Text = newOut;
            }

        }

        private void Zero(object sender, EventArgs e)
        {
            output.Text += "0";
        }

        private void Point(object sender, EventArgs e)
        {
            String subString = "";
            int lastSpcePos = output.Text.LastIndexOf(' ');

            if (output.Text.Length == 0 || output.Text[output.Text.Length - 1] == ' ')
            {
                output.Text += ".";
            }
            else if (output.Text.IndexOf(' ') >= 0)
            {
                subString = output.Text.Substring(lastSpcePos);
                if (subString.IndexOf('.') < 0)
                {
                    output.Text += ".";
                }
            }
            else
            {
                subString = output.Text.Substring(0, output.Text.Length);
                if (subString.IndexOf('.') < 0)
                {
                    output.Text += ".";
                }
            }


            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ans(object sender, EventArgs e)
        {
            output.Text += answer;
        }

        private void CE(object sender, EventArgs e)
        {
            if(output.Text.IndexOf(" ") > 0)
            {
                output.Text = output.Text.Substring(0, output.Text.LastIndexOf(" "));
            }
            
        }
    }
}
