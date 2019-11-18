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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BelleAireCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(belleAireCheckBox.Checked)
            {
                BelleAireForm belleAireForm = new BelleAireForm();
                belleAireForm.ShowDialog();
                belleAireCheckBox.Checked = false;
            }

        }

        private void LincolnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LincolnForm lincolnForm = new LincolnForm();
            lincolnForm.ShowDialog();
            lincolnCheckBox.Checked = false;
        }

        private void MealButton_Click(object sender, EventArgs e)
        {
            BreakfastOptionForm breakfastOptionForm = new BreakfastOptionForm();
            breakfastOptionForm.ShowDialog();
        }
    }
}
