using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanNumeralConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            // make variable from inputTextbox
            var input = int.Parse(inputTextbox.Text);

            // check if input is less than 0 or greater than 10, if not - show error
            if (input <= 0 || input > 10) {
                MessageBox.Show("Please enter a number between 1 and 10");
            }
            else  {
                // switch input numbers for roman numerals, display roman numeral in outputLabel
                switch (input)
                {
                    case 1:
                        outputLabel.Text = "I";
                        break;
                    case 2:
                        outputLabel.Text = "II";
                        break;
                    case 3:
                        outputLabel.Text = "III";
                        break;
                    case 4:
                        outputLabel.Text = "IV";
                        break;
                    case 5:
                        outputLabel.Text = "V";
                        break;
                    case 6:
                        outputLabel.Text = "VI";
                        break;
                    case 7:
                        outputLabel.Text = "VII";
                        break;
                    case 8:
                        outputLabel.Text = "VIII";
                        break;
                    case 9:
                        outputLabel.Text = "IX";
                        break;
                    case 10:
                        outputLabel.Text = "X";
                        break;
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clear textbox and label
            inputTextbox.Text = String.Empty;
            outputLabel.Text = String.Empty;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // close form
            this.Close();
        }
    }
}
