using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_1B
{

    /*
     * Adam Gaddis
     * this program takes the users miles and converts them into kilometers
     * */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //Constant Declare
            const double KILOMETER_PER_MILE = 0.62137;

            // int variable 
            double miles = Convert.ToDouble(boxMiles.Text);

            // Calculations
            double kilometers = miles / KILOMETER_PER_MILE;

            // Output
            lblKilometers.Text = kilometers.ToString("F3");
        }


    }
}
