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

        private void patientlistbtn_Click(object sender, EventArgs e)
        {
            inventorypan.Visible = false;
            orderpan.Visible = false;
            patientlistpan.Visible = true;
        }

        private void orderbtn_Click(object sender, EventArgs e)
        {
            inventorypan.Visible = false;
            patientlistpan.Visible = false;
            orderpan.Visible = true;
        }

        private void inventorybtn_Click(object sender, EventArgs e)
        {
           patientlistpan.Visible=false;
            orderpan.Visible=false;
            inventorypan.Visible = true;
        }
    }
}
