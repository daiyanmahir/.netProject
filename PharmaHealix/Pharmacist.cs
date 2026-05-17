using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PharmaHealix
{
    public partial class Pharmacist : Form
    {
        private string username;
         private string PhName
         {
             get { return pharmacistprofilenametxt.Text; }
             set { pharmacistprofilenametxt.Text = value; }
         }
         private string PhPhone
         {
             get { return pharmacistphonetxt.Text; }
             set { pharmacistphonetxt.Text = value; }
         }
         private string PhUsername
         {
             get { return pharmacistprofileusernametxt.Text; }
             set { pharmacistprofileusernametxt.Text = value; }
         }
         private string PhAddress
         {
             get { return pharmacistprofileaddtxt.Text; }
             set { pharmacistprofileaddtxt.Text = value; }
         }
         private string PhAnswer
         {
             get { return pharmacistanswertxt.Text; }
             set { pharmacistanswertxt.Text = value; }
         }
         private string PhPass
        {
            get { return pharmacistprofilepasstxt.Text; }
            set { pharmacistprofilepasstxt.Text = value; }
        }

        public Pharmacist(string n)
        {
            this.username = n;
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
            patientlistpan.Visible = false;
            orderpan.Visible = false;
            inventorypan.Visible = true;
        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            patientlistpan.Visible = false;
            orderpan.Visible = false;
            inventorypan.Visible = false;
            pharmacistprofilepan.Visible = true;
            editprofile();
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

        private void pharmacistprofileupdatebtn_Click(object sender, EventArgs e)
        {

            errorphonepan.Visible = false;
            errorpharmacistnamepan.Visible = false;
            errorusernamepan.Visible = false;
            erroraddpan.Visible = false;
            erroranspan.Visible = false;
            errorpasspan.Visible = false;

            bool Error = false;
            bool Flag = false;

            if (PhPhone == "")
            {
                errorphonepan.Visible = true;
                Error = true;
            }

            bool PDigits = true;

            foreach (char c in PhPhone)
            {
                if (!char.IsDigit(c))
                {
                    PDigits = false;
                    break;
                }
            }

            if (!PDigits || PhPhone.Length != 11 || !PhPhone.StartsWith("01"))
            {
                errorphonepan.Visible = true;
                Flag = true;
            }
            if (PhName == "")
            {
                errorpharmacistnamepan.Visible = true;
                Error = true;
            }
            if (PhName != "")
            {
                foreach (char c in PhName)
                {
                    if (char.IsDigit(c))
                    {
                        errorpharmacistnamepan.Visible = true;
                        Flag = true;
                        break;
                    }
                }
            }
            if (PhUsername == "")
            {

                errorusernamepan.Visible = true;
                Error = true;
            }
            bool UDigits = true;

            foreach (char c in PhUsername)
            {
                if (!char.IsDigit(c))
                {
                    UDigits = false;
                    break;
                }
            }

            if (PhUsername.Length < 4 || UDigits)
            {
                errorusernamepan.Visible = true;
                Flag = true;
            }
            if (PhUsername != "" && PhUsername != username)
            {
                string query = "SELECT COUNT(*) FROM UserTable WHERE Username = @0";
                int count = Convert.ToInt32(new Db().Scalar(query, PhUsername));
                if (count > 0)
                {
                    errorusernamepan.Visible = true;
                    Flag = true;
                }
            }
            if (PhAddress == "")
            {
                erroraddpan.Visible = true;
                Error = true;
            }


            if (PhAnswer == "")
            {
                erroranspan.Visible = true;
                Error = true;
            }

            if (PhPass == "")
            {
                errorpasspan.Visible = true;
                Error = true;
            }
            else if (PhPass.Length < 5)
            {
                errorpasspan.Visible = true;
                Flag = true;
            }

            if (Error)
            {
                MessageBox.Show("Please fill all required fields");
                return;
            }
            else if (Flag)
            {
                MessageBox.Show(
                                "Fix the following:\n" +
                                "-> Username: 4+ chars, not only numbers, must be unique\n" +
                                "-> Password: at least 5 characters\n" +
                                "-> Name: letters only (no numbers)\n" +
                                "-> Phone (11 digits, starts with 01)"
                                );
            }
            else
            {

                string query = "UPDATE UserTable SET Name = @0, Phone = @1, Username = @2, Address = @3, Question = @4, Answer = @5, Password = @6 WHERE Username = @7";
                new Db().NonQuery(query, PhName, PhPhone, PhUsername, PhAddress, comboBox1.Text, PhAnswer, PhPass,username);
                username = PhUsername;


                MessageBox.Show("Update Successful!");
                editprofile();
            }
        }
        private void editprofile()
        {
            string q = "select * from UserTable where username=@0";
            DataTable dt = new Db().Reader(q, username);
            pharmacistprofilenametxt.Text = Convert.ToString(dt.Rows[0]["Name"]);
            pharmacistphonetxt.Text = Convert.ToString(dt.Rows[0]["Phone"]);
            pharmacistprofileusernametxt.Text = Convert.ToString(dt.Rows[0]["Username"]);
            pharmacistprofileaddtxt.Text = Convert.ToString(dt.Rows[0]["Address"]);
            comboBox1.Text = Convert.ToString(dt.Rows[0]["Question"]);
            pharmacistprofilepasstxt.Text = Convert.ToString(dt.Rows[0]["Password"]);
            pharmacistanswertxt.Text = Convert.ToString(dt.Rows[0]["Answer"]);

        }
        
         
    }
}
