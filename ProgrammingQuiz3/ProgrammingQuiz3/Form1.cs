using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz3A


{

    /*
     * Adam Gaddis
     * This program converts the users given inches into cenitmeters
     * */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            // create variables
            double inches, centimeters;

            // store inchest from text box
            inches = Convert.ToDouble(inchesBox.Text);


            // convert inches into centimeters
            centimeters = inches * 2.54;

            // Print centimeters to label 
            centiLbl.Text = centimeters.ToString("F3");

        }
    }
}
