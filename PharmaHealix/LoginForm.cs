using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaHealix
{
    public partial class Loginform : Form
    {
        private string CName
        {
            get { return createnametxt.Text; }
            set { createnametxt.Text= value; }
        }
        private string Phone
        {
            get { return createphonetxt.Text; }
            set { createphonetxt.Text = value; }
        }
        private string CUsername
        {
            get { return createusernametxt.Text; }
            set { createusernametxt.Text = value; }
        }
        private string Address
        {
            get { return createaddresstxt.Text; }
            set { createaddresstxt.Text = value; }
        }
        private string Answer
        {
            get { return createanstxt.Text; }
            set { createanstxt.Text = value; }
        }
        private string CPass
        {
            get { return createpasstxt.Text; }
            set {createpasstxt.Text = value; }
        }
        private int CPassLength()
        {
            return createpasstxt.Text.Length;
        }

        private string EUsername
        {
            get { return createusernametxt.Text; }
            set { createusernametxt.Text = value; }
        }
        private string EPass
        {
            get { return enterpasstxt.Text; }
            set { enterpasstxt.Text = value; }
        }

        public Loginform()
        {
            InitializeComponent();
            securityquestioncb.SelectedIndex = 0;

        }

        public void CreateAcc(bool check)
        {
            if (check)
            {
                createaccountpan.BringToFront();
                createaccountpan.Visible = true;
            }


        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewguestbtn_Click(object sender, EventArgs e)
        {
            MainForm guestdashboard = new MainForm("Guest");
            guestdashboard.Show();
            this.Hide();

        }


        private void signupbtn_Click(object sender, EventArgs e)
        {
            FormValidation();
           


        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

           
            Pharmacist p = new Pharmacist();
            p.Show();
            this.Hide();

        }

        private void enterusernametxt_Enter(object sender, EventArgs e)
        {
            if (enterusernametxt.Text == "Enter your username")
            {
                enterusernametxt.Text = "";
                enterusernametxt.ForeColor = Color.Black;
            }
        }

        private void enterpasstxt_Enter(object sender, EventArgs e)
        {
            if (createpasstxt.Text == "Enter your password")
            {
                createpasstxt.Text = "";
                createpasstxt.ForeColor = Color.Black;
                createpasstxt.PasswordChar = '*';
            }
        }

        private void hidebtn_Click(object sender, EventArgs e)
        {
            if (enterpasstxt.PasswordChar == '*')
            {
                enterpasstxt.PasswordChar = '\0';
            }
            else
            {
                enterpasstxt.PasswordChar = '*';
            }

        }

        private void createpanhidebtn_Click(object sender, EventArgs e)
        {
            if (createpasstxt.PasswordChar == '*')
            {
                createpasstxt.PasswordChar = '\0';
            }
            else
            {
                createpasstxt.PasswordChar = '*';
            }
        }

        private void nametxt_Enter(object sender, EventArgs e)
        {
            if (createnametxt.Text == "Name")
            {
                createnametxt.Text = "";
                createnametxt.ForeColor = Color.Black;
            }

        }
        private void createaddresstxt_Enter(object sender, EventArgs e)
        {
            if (createaddresstxt.Text == "Address")
            {
                createaddresstxt.Text = "";
                createaddresstxt.ForeColor = Color.Black;
            }

        }
        private void createusernametxt_Enter(object sender, EventArgs e)
        {
            if (createusernametxt.Text == "Enter your username")
            {
                createusernametxt.Text = "";
                createusernametxt.ForeColor = Color.Black;
            }

        }
        private void createphonetxt_Enter(object sender, EventArgs e)
        {
            if (createphonetxt.Text == "Phone number")
            {
                createphonetxt.Text = "";
                createphonetxt.ForeColor = Color.Black;
            }
        }
        private void createanstxt_Enter(object sender, EventArgs e)
        {
            if (createanstxt.Text == "Type your answer")
            {
                createanstxt.Text = "";
                createanstxt.ForeColor = Color.Black;
            }

        }
        private void createpasstxt_Enter(object sender, EventArgs e)
        {

            if (createpasstxt.Text == "Enter your password (at least 5 characters)")
            {
                createpasstxt.Text = "";
                createpasstxt.ForeColor = Color.Black;
                createpasstxt.PasswordChar = '*';
            }

        }
        private void Resetcreatepan()
        {

            createphonepan.Visible = false;
            createnamepan.Visible = false;
            createusernamepan.Visible = false;
            createaddresspan.Visible = false;
            createanspan.Visible = false;
            createpasspan.Visible = false;

            securityquestioncb.SelectedIndex = 0;
            createnametxt.Text = "Name";
            createaddresstxt.Text = "Address";
            createusernametxt.Text = "Enter your username";
            enterpasstxt.Text = "Enter your password (at least 5 characters)";
            createanstxt.Text = "Type your answer";
            createphonetxt.Text = "Phone number";

            createnametxt.ForeColor = Color.Gray;
            createaddresstxt.ForeColor = Color.Gray;
            createusernametxt.ForeColor = Color.Gray;
            createpasstxt.ForeColor = Color.Gray;
            createphonetxt.ForeColor = Color.Gray;
            createanstxt.ForeColor = Color.Gray;


        }
       
        private void FormValidation()
        {
          
            createphonepan.Visible = false;
            createnamepan.Visible = false;
            createusernamepan.Visible = false;
            createaddresspan.Visible = false;
            createanspan.Visible = false;
            createpasspan.Visible = false;

            bool Error = false;

            if (Phone == "" || Phone == "Phone number")
            {
                createphonepan.Visible = true;
                Error = true;
            }
            if (Name == "" || Name== "Name")
            {
                createnamepan.Visible = true;
                Error = true;
            }
            if (CUsername== "" || CUsername == "Username")
            {
                createusernamepan.Visible = true;
                Error = true;
            }
            if (Address== "" ||Address == "Address")
            {
                createaddresspan.Visible = true;
                Error = true;
            }


            if (Answer == "" || Answer == "Type your answer")
            {
                createanspan.Visible = true;
                Error = true;
            }

            if (CPass == "" || CPass == "Enter your password (at least 5 characters)")
            {
                createpasspan.Visible = true;
                Error = true;
            }
            if (CPass.Length < 4)
            {
                createpasspan.Visible = true;
                Error=true;
                MessageBox.Show("Password must be more than 5 characters!");
            }

            if (Error)
            {
                MessageBox.Show("Please fill all required fields");
                return;
            }

            MessageBox.Show("Signup Successful!");

            Resetcreatepan();
            createaccountpan.Hide();




        }
        private void LoginValidation()
        {
            Enteruserpan.Visible = false;
            Enterpasspan.Visible = false;
            bool Error = false;
            if(EUsername==""||EUsername== "Enter your username")
            {
                Enteruserpan.Visible = true;
                Error = true;
            } 
            if(EPass==""||EPass== "Enter your password")
            {
                Enterpasspan.Visible = true;
                Error = true;
            }
            if (Error)
            {
                MessageBox.Show("Please fill all required fields");
                return;
            }

        }

        private void forgetpasslbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
    }
