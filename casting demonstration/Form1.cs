using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace casting_demonstration
{
    public partial class Form1 : Form
    {
        //initializing variables
        double input;
        int outputVal;

        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (inputbox.Text == "")                                        //checks to make sure something was actually entered into the box
                {
                    MessageBox.Show("enter some numbers into the textbox please");
                    return;
                }
                else                                                            //converts the double to an integer by truncating 
                {
                    input = double.Parse(inputbox.Text);                        //the input is taken directly from the input box

                    outputVal = (int)input;                                     //the output is designated by the input being "casted" to an integer from a double

                    output.Text = outputVal.ToString();                         //the output is displayed as an integer in string format
                }
            }
            catch                                                               //this makes sure no letters or any character other than a number    
            {                                                                   //is entered so the program doesnt crash
                MessageBox.Show("numbers only");
                inputbox.Text = "";
                input = 0;

                return;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)              //resets everything to 0/empty
        {
            input = 0;

            outputVal = 0;

            inputbox.Text = "";

            output.Text = "";
        }

    }
}
