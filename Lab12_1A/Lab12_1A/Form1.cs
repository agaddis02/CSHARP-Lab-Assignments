using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12_1A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void radioMP_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(40, 1, 55);
        }

        private void radioGrey_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(211, 211, 211);
        }

        private void radioRB_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 35, 102);
        }

        private void radioLY_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(253, 160, 41);
        }
    }
}
