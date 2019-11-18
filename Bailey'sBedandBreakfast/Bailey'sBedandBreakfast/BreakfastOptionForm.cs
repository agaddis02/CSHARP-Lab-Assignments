using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bailey_sBedandBreakfast
{
    public partial class BreakfastOptionForm : Form
    {
        public BreakfastOptionForm()
        {
            InitializeComponent();
        }
        private const double CONT_BREAKFAST_PRICE = 6, FULL_BREAKFAST_PRICE = 9.95, DELUXE_BREAKFAST_PRICE = 16.50;

        private void fullRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            priceLabel.Text = "Price: " + FULL_BREAKFAST_PRICE.ToString("C");
        }

        private void deluxeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            priceLabel.Text = "Price: " + DELUXE_BREAKFAST_PRICE.ToString("C");
        }

        private void contRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            priceLabel.Text = "Price: " + CONT_BREAKFAST_PRICE.ToString("C");
        }

        private void BreakfastOptionForm_Load(object sender, EventArgs e)
        {
            priceLabel.Text = "Price: " + CONT_BREAKFAST_PRICE.ToString("C");
        }
    }
}
