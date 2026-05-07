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

        void formValidation(){
        errorpharmacistnamepan.Visible=false;
        errorphonepan.Visible=false;
        errorusernamepan.Visible=false;
            errorpasspan.Visible=false;
            erroranspan.Visible=false;
            erroraddpan.Visible=false;
            bool check = false;
        if(pharmacistName==""||pharmacistName=="Enter Name")
            {
                errorpharmacistnamepan.Visible=true;
                check = true;
            }
            if (pharmacistPhone == "" || pharmacistPhone == "Enter Phone Number")
            {
                errorphonepan.Visible = true;
                check = true;
            }
            if (pharmacistUsername == "" || pharmacistUsername == "Enter Username")
            {
                errorusernamepan.Visible = true;
                check = true;
            }
            if (pharmacistAddress == "" || pharmacistAddress== "Enter Address")
            {
                erroraddpan.Visible = true;
                check = true;
            }
            if (pharmacistAnswer == "" || pharmacistAnswer == "Enter Answer")
            {
                erroranspan.Visible = true;
                check = true;
            }
            if (pharmacistPass == "" || pharmacistPass == "Enter Password")
            {
                errorpasspan.Visible = true;
                check = true;
            }
            if (check)
            {
                MessageBox.Show("Please fill all required fields");
                return;
            }
            else
            {

            }


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

        private void pharmacistprofilenametxt_Enter(object sender, EventArgs e)
        {
            if(pharmacistprofilenametxt.Text== "Enter Name")
            {
                pharmacistprofilenametxt.Text = "";
                pharmacistprofilenametxt.ForeColor = Color.Black;
            }
        }

        private void pharmacistphonetxt_Enter(object sender, EventArgs e)
        {
            if(pharmacistphonetxt.Text=="Enter Phone Number")
            {
                pharmacistphonetxt.Text = "";
                pharmacistphonetxt.ForeColor = Color.Black;
            }
        }

        private void pharmacistprofileusernametxt_Enter(object sender, EventArgs e)
        {
            if (pharmacistprofileusernametxt.Text == "Enter Username")
            {
                pharmacistprofileusernametxt.Text = "";
                pharmacistprofileusernametxt.ForeColor= Color.Black;
            }
        }

        private void pharmacistprofilepasstxt_Enter(object sender, EventArgs e)
        {
            if(pharmacistprofilepasstxt.Text=="Enter Password")
            {

                pharmacistprofilepasstxt.Text = "";
                pharmacistprofilepasstxt.ForeColor= Color.Black;
            }
        }

        private void pharmacistanswertxt_Enter(object sender, EventArgs e)
        {
            if(pharmacistanswertxt.Text=="Enter Answer")
            {
                pharmacistanswertxt.Text = "";
                pharmacistanswertxt.ForeColor= Color.Black;
            }
        }

        private void pharmacistprofileaddtxt_Enter(object sender, EventArgs e)
        {
            if(pharmacistprofileaddtxt.Text=="Enter Address")
            {
                pharmacistprofileaddtxt.Text = "";
                pharmacistprofileaddtxt.ForeColor= Color.Black;
            }
        }
    }
}
