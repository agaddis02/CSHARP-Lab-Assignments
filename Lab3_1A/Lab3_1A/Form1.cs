using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_1A
/*
 * Adam Gaddis
 * convertor that changes your change less than one dollar, into the amount of quarters, dimes, nickels, and pennies needed to equal the amount 
 */
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        

        private void convertBtn_Click(object sender, EventArgs e)
        {

            int amount = Convert.ToInt32(totalAmount.Text);

            // Declare Variables
            int quarters = 25;
            int dimes = 10;
            int nickels = 5;
            int pennies = 1;

            // Calculations
            int nbrQuarters = (amount / quarters);
            amount %= quarters;
            int nbrDimes = (amount / dimes);
            amount %= dimes;
            int nbrNickels = (amount / nickels);
            amount %= nickels;
            int nbrPennies = (amount / pennies);

            
            lblQuarters.Text = nbrQuarters.ToString();
            lblDimes.Text = nbrDimes.ToString();
            lblNickel.Text = nbrNickels.ToString();
            lblPennies.Text = nbrPennies.ToString();
            
            
        }
    }
}
