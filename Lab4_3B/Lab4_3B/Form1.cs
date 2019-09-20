using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_3B
{
    public partial class Form1 : Form
    {
        /*
         * Adam Gaddis
         * program for basic calculator using form
         * */
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            // Declare variables
            double num1, num2, output;
            string sign;

            // Store values from form
            num1 = Convert.ToDouble(num1Box.Text);
            num2 = Convert.ToDouble(num2Box.Text);
            sign = operatorBox.Text;

            // logical switch operator depending on sign given
            switch (sign)
            {
                case "+":
                    output = num1 + num2;
                    outputLbl.Text = num1 + " " + sign + " " + num2 + " = " + output;
                    break;
                case "-":
                    output = num1 - num2;
                    outputLbl.Text = num1 + " " + sign + " " + num2 + " = " + output;
                    break;
                case "*":
                    output = num1 * num2;
                    outputLbl.Text = num1 + " " + sign + " " + num2 + " = " + output;
                    break;
                case "/":
                    output = num1 / num2;
                    outputLbl.Text = num1 + " " + sign + " " + num2 + " = " + output;
                    break;
                case "^":
                    output = Math.Pow(num1,num2);
                    outputLbl.Text = num1 + " " + sign + " " + num2 + " = " + output;
                    break;


            }
        }
    }
}
