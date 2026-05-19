using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PharmaHealix
{
    public partial class Loginform : Form
    {
        //Properties
        private string CName
        {
            get { return createnametxt.Text; }
            set { createnametxt.Text = value; }
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
            set { createpasstxt.Text = value; }
        }

        private string EUsername
        {
            get { return enterusernametxt.Text; }
            set { enterusernametxt.Text = value; }
        }
        private string EPass
        {
            get { return enterpasstxt.Text; }
            set { enterpasstxt.Text = value; }
        }
        private string FPass
        {
            get { return fpasstxt.Text; }
            set { fpasstxt.Text = value; }
        }
        private string FUsername
        {
            get { return fusernametxt.Text; }
            set { fusernametxt.Text = value; }
        }
        private string FAns
        {
            get { return fanstxt.Text; }
            set { fanstxt.Text = value; }
        }

        //Constructor 
        public Loginform()
        {
            InitializeComponent();
            securityquestioncb.SelectedIndex = 0;

        }
        //Methods
        public void CreateAcc(bool check)
        {
            if (check)
            {
                createaccountpan.BringToFront();
                createaccountpan.Visible = true;
            }


        }

        //Log In Page
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
            createusernametxt.Text = "enter your username";
            createpasstxt.Text = "Enter your password (at least 5 characters)";
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
            bool Flag = false;

            if (Phone == "" || Phone == "Phone number")
            {
                createphonepan.Visible = true;
                Error = true;
            }

            bool PDigits = true;

            foreach (char c in Phone)
            {
                if (!char.IsDigit(c))
                {
                    PDigits = false;
                    break;
                }
            }

            if (!PDigits || Phone.Length != 11 || !Phone.StartsWith("01"))
            {
                createphonepan.Visible = true;
                Flag = true;
            }
            if (CName == "" || CName == "Name")
            {
                createnamepan.Visible = true;
                Error = true;
            }
            if (CName != "" && CName != "Name")
            {
                foreach (char c in CName)
                {
                    if (char.IsDigit(c))
                    {
                        createnamepan.Visible = true;
                        Flag = true;
                        break;
                    }
                }
            }
            if (CUsername == "" || CUsername == "enter your username")
            {

                createusernamepan.Visible = true;
                Error = true;
            }
            bool UDigits = true;

            foreach (char c in CUsername)
            {
                if (!char.IsDigit(c))
                {
                    UDigits = false;
                    break;
                }
            }

            if (CUsername.Length < 4 || UDigits)
            {
                createusernamepan.Visible = true;
                Flag = true;
            }
            if (CUsername != "" && CUsername != "enter your username")
            {
                string query = "Select Count(*) FROM UserTable Where Username = @0";
                int count = Convert.ToInt32(new Db().Scalar(query, CUsername));
                if (count > 0)
                {
                    createusernamepan.Visible = true;
                    Flag = true;
                }
            }
            if (Address == "" || Address == "Address")
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
            else if (CPass.Length < 5)
            {
                createpasspan.Visible = true;
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

                string query = "Insert into UserTable(Name,Phone,Username,Address,Question,Answer,Password,Role)Values(@0,@1,@2,@3,@4,@5,@6,@7)";
                new Db().NonQuery(query, CName, Phone, CUsername, Address, securityquestioncb.Text, Answer, CPass, "Patient");


                MessageBox.Show("Signup Successful!");
                Resetcreatepan();
            }



        }
        private void LoginValidation()
        {
            Enteruserpan.Visible = false;
            Enterpasspan.Visible = false;
            bool Error = false;
            if (EUsername == "" || EUsername == "enter your username")
            {
                Enteruserpan.Visible = true;
                Error = true;
            }
            if (EPass == "" || EPass == "Enter your password")
            {
                Enterpasspan.Visible = true;
                Error = true;
            }
            if (Error)
            {
                MessageBox.Show("Please fill all required fields");
                return;
            }
            else
            {
                    
                string q1 = "SELECT COUNT(*) FROM UserTable WHERE Username = @0 AND Password = @1";
                int count = Convert.ToInt32(new Db().Scalar(q1, EUsername,EPass));
                if (count >0)
                {
                    string q2 = "SELECT Role FROM UserTable WHERE Username = @0";
                    string role = Convert.ToString(new Db().Scalar(q2, EUsername));
                    if (role == "Patient")
                    {
                        MessageBox.Show("Login Successful!");
                        MainForm m = new MainForm(role,EUsername);
                        m.Show();
                    }
                    else if (role == "Doctor")
                    {
                        MessageBox.Show("Login Successful!");
                        string q3 = "Select DoctorID From DoctorTable Where Username = @0";
                        string doctorId = Convert.ToString(new Db().Scalar(q3, EUsername));
                        Doctor d = new Doctor(doctorId);
                        d.Show();
                       
                    }
                    else if(role == "Pharmacist")
                    {
                        MessageBox.Show("Login Successful!");
                        Pharmacist p = new Pharmacist(EUsername);
                        p.Show();
                    }
                    else if (role == "Admin")
                    {
                        MessageBox.Show("Login Successful!");
                        AdminDoctorForm a = new AdminDoctorForm();
                        a.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                    return;

                }
                LoginformReset();
                this.Hide();
            }


        }
        private void LoginformReset()
        {
            EUsername = "Enter your username";
            EPass = "Enter your password";
            enterusernametxt.ForeColor = Color.Gray;
            enterpasstxt.ForeColor = Color.Gray;


        }
        //Events  
        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewguestbtn_Click(object sender, EventArgs e)
        {
            MainForm guestdashboard = new MainForm("Guest","");
            guestdashboard.Show();
            this.Hide();

        }


        private void signupbtn_Click(object sender, EventArgs e)
        {
            FormValidation();

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            LoginValidation();

        }

        private void enterusernametxt_Enter(object sender, EventArgs e)
        {
            if (enterusernametxt.Text == "enter your username")
            {
                enterusernametxt.Text = "";
                enterusernametxt.ForeColor = Color.Black;
            }
        }

        private void enterpasstxt_Enter(object sender, EventArgs e)
        {
            if (EPass == "Enter your password")
            {
                EPass = "";
                enterpasstxt.ForeColor = Color.Black;
                enterpasstxt.PasswordChar = '*';
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
            if (createusernametxt.Text == "enter your username")
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

        // Forget Password
        private void forgetpasslbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgetpasspan.Visible = true;
            forgetpasspan.BringToFront();

          
        }

        private void fcrossbtn_Click(object sender, EventArgs e)
        {
            forgetpasspan.Hide();
            // reset pan
            fpasspan.Visible = false;


            fusernametxt.Text = "enter your username";
            fpasstxt.Text = "Enter your password (at least 5 characters)";
            fanstxt.Text = "Type your answer";


            fusernametxt.ForeColor = Color.Gray;
            fpasstxt.ForeColor = Color.Gray;
            fanstxt.ForeColor = Color.Gray;
        }

        private void changepassbtn_Click(object sender, EventArgs e)
        {
            fpasspan.Visible = false;

            string q1 = "Select Count(*) FROM UserTable Where Username = @0 and Question=@1 and Answer=@2";
            int count = Convert.ToInt32(new Db().Scalar(q1, FUsername, fsecurityquestioncb.Text, FAns));
            if (count > 0)
            {
                bool flag = false;
                if (FPass == "" || FPass == "Enter your password (at least 5 characters)")
                {
                    fpasspan.Visible = true;
                    flag = true;
                }
                else if (FPass.Length < 5)
                {
                    fpasspan.Visible = true;
                    flag = true;
                }
                if (flag)
                {
                    MessageBox.Show("Password: at least 5 characters");
                    return;
                }
                else
                {
                    string query = "Update UserTable SET Password = @1 where Username=@0";
                    new Db().NonQuery(query,FUsername, FPass);
                    MessageBox.Show("Password reset successful. You can now log in.");

                    forgetpasspan.Hide();
                    // reset pan
                    fpasspan.Visible = false;


                    fusernametxt.Text = "enter your username";
                    fpasstxt.Text = "Enter your password (at least 5 characters)";
                    fanstxt.Text = "Type your answer";


                    fusernametxt.ForeColor = Color.Gray;
                    fpasstxt.ForeColor = Color.Gray;
                    fanstxt.ForeColor = Color.Gray;
                }
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.");
                return;
            }

        }
        private void fusernametxt_Enter(object sender, EventArgs e)
        {
            if (fusernametxt.Text == "enter your username")
            {
                fusernametxt.Text = "";
                fusernametxt.ForeColor = Color.Black;
            }
        }

        private void fpasstxt_Enter(object sender, EventArgs e)
        {
            if (fpasstxt.Text == "Enter your password (at least 5 characters)")
            {
                fpasstxt.Text = "";
                fpasstxt.ForeColor = Color.Black;
                fpasstxt.PasswordChar = '*';
            }
        }
        private void fanstxt_Enter(object sender, EventArgs e)
        {
            if (fanstxt.Text == "Type your answer")
            {
                fanstxt.Text = "";
                fanstxt.ForeColor = Color.Black;
            }

        }

        private void fhidebtn_Click(object sender, EventArgs e)
        {
            if (fpasstxt.PasswordChar == '*')
            {
                fpasstxt.PasswordChar = '\0';
            }
            else
            {
                fpasstxt.PasswordChar = '*';
            }
        }

    }
}
