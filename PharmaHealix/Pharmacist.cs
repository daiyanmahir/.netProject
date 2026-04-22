using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaHealix
{
    public partial class Pharmacist : Form
    {
        public Pharmacist()
        {
            InitializeComponent();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

 

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            pharmacistpan.Hide();
        }

        private void userbtn_Click(object sender, EventArgs e)
        {
            pharmacistpan.Visible = true;
            pharmacistpan.BringToFront();
        }
    }
}
