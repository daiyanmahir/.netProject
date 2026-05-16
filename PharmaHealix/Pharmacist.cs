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
        
       /*  private string pharmacistName
        {
            get { return pharmacistprofilenametxt.Text; }
            set { pharmacistprofilenametxt.Text = value; }
        }
        private string pharmacistPhone
        {
            get { return pharmacistphonetxt.Text; }
            set { pharmacistphonetxt.Text = value; }
        }
        private string pharmacistUsername
        {
            get { return pharmacistprofileusernametxt.Text; }
            set { pharmacistprofileusernametxt.Text = value; }
        }
        private string pharmacistAddress
        {
            get { return pharmacistprofileaddtxt.Text; }
            set { pharmacistprofileaddtxt.Text = value; }
        }
        private string pharmacistAnswer
        {
            get { return pharmacistanswertxt.Text; }
            set { pharmacistanswertxt.Text = value; }
        }
        private string pharmacistPass
        {
            get { return pharmacistprofilepasstxt.Text; }
            set { pharmacistprofilepasstxt.Text = value; }
        }

        



        */




        public Pharmacist()
        {
            InitializeComponent();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void patientlistbtn_Click(object sender, EventArgs e)
        {
            pharmacistprofilepan.Visible = false;
            inventorypan.Visible = false;
            orderpan.Visible = false;
            patientlistpan.Visible = true;
        }

        private void orderbtn_Click(object sender, EventArgs e)
        {
            pharmacistprofilepan.Visible = false;
            inventorypan.Visible = false;
            patientlistpan.Visible = false;
            orderpan.Visible = true;
        }

        private void inventorybtn_Click(object sender, EventArgs e)
        {
            pharmacistprofilepan.Visible = false;
            patientlistpan.Visible=false;
            orderpan.Visible=false;
            inventorypan.Visible = true;
        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            patientlistpan.Visible = false;
            orderpan.Visible = false;
            inventorypan.Visible=false;
            pharmacistprofilepan.Visible=true;
        }

        private void Exitbtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pharmacistlogoutbtn_Click(object sender, EventArgs e)
        {
            Loginform l = new Loginform();
            this.Hide();
            l.Show();
        }

        
    }
}
