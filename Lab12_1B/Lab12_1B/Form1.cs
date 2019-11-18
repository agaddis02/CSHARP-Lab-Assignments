using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12_1B
{
    public partial class Form1 : Form
    {
        double price = 0;

        const double BED1 = 450, BED2 = 550, BED3 = 700, BATH2 = 75, LAKEVIEW = 50;
        public Form1()
        {
            InitializeComponent();
        }

        private void radio1BD_CheckedChanged(object sender, EventArgs e)
        {
            if(radio1BD.Checked)
            {
                price += BED1;
            }
            else
            {
                price -= BED1;
            }
        }

        private void radio2BD_CheckedChanged(object sender, EventArgs e)
        {
            if (radio2BD.Checked)
            {
                price += BED2;
            }
            else
            {
                price -= BED2;
            }
        }

        private void radio3BD_CheckedChanged(object sender, EventArgs e)
        {
            if (radio3BD.Checked)
            {
                price += BED3;
            }
            else
            {
                price -= BED3;
            }
        }

        private void radio1BR_CheckedChanged(object sender, EventArgs e)
        {
            if (radio1BR.Checked)
            {
                price += 0;
            }
            else
            {
                price -= 0;
            }
        }

        private void radio2BR_CheckedChanged(object sender, EventArgs e)
        {
            if (radio2BR.Checked)
            {
                price += BATH2;
            }
            else
            {
                price -= BATH2;
            }
        }

        private void checkLakeV_CheckedChanged(object sender, EventArgs e)
        {
            if (checkLakeV.Checked)
            {
                price += LAKEVIEW;
            }
            else
            {
                price -= LAKEVIEW;
            }
        }

        private void lblCalcR_Click(object sender, EventArgs e)
        {
            lblRent.Text = "Your Estimated rent is: " + price.ToString("C");
        }
    }
}
