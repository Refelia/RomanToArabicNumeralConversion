using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanNumeralsToArabicConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void romanNumeralRadioButton_CheckedChanged(object sender, EventArgs e)
        {
           
             
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                //Declare a variable.
               string arabic = NumberConversion.ConvertFromArabicToRoman(int.Parse(inputTextBox.Text));

                //Display the result into the outputLabel
                resultOutputLabel.Text = arabic.ToString();
                
              
                
            }
            catch(Exception ex)
            {
               //Display the default message
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear all input and output.
            inputTextBox.Text = "";
            resultOutputLabel.Text = "";

            //Set the focus.
            inputTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Declare a variable.
                int roman = NumberConversion.ConvertFromRomanToArabic(string.Format(inputTextBox.Text));

                //Display the result to the output label.
                resultOutputLabel.Text = roman.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
