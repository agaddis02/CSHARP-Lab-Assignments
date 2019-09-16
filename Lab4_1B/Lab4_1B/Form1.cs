using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_1B
{

    /*
     * Adam Gaddis
     * This program has you enter 2 numbers, and tells you which one is closser too 30.
     * */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double num1, num2, benchMark;

            num1 = Convert.ToDouble(num1Box.Text);
            num2 = Convert.ToDouble(num2Box.Text);

            benchMark = 30;

            bool num1Closer = (num1 > num2) && num1 <= benchMark;
            bool num2Closer = (num2 > num1) && num2 <= benchMark;
            bool num1Over = (num1 > benchMark) && num2 <= benchMark;
            bool num2Over = (num2 > benchMark) && num1 <= benchMark;


            if (num1Closer)
            {
                valueReader.Text = "Number 1 is closer to 30";
            }
            else if (num2Closer)
            {
                valueReader.Text = "Number 2 is closer to 30";
            }
            else if (num1Over)
            {
                valueReader.Text = "Number 2 is closer to 30";
            }
            else if (num2Over)
            {
                valueReader.Text = "Number 1 is closer to 30";

            }
            else
            {
                valueReader.Text = "Both numbers are over 30";
            }
            
        }
    }
}
