using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_1C
{

    /*
     * Adam Gaddis
     * this program calculates the total cost of renting a moving truck using hours and miles
     * */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculation_Click(object sender, EventArgs e)
        {
            // Creation of variables
            const double BASE_COST = 200;
            double miles, hours, price;

            // Store values
            miles = Convert.ToDouble(milesBox.Text);
            hours = Convert.ToDouble(hoursBox.Text);

            // Calculations
            price = BASE_COST + (miles * 2) + (hours * 150);

            lblCost.Text = price.ToString("C");

        }
    }
}
