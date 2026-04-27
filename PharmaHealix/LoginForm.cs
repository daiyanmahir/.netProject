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
        public string CName
        {
            get { return createnametxt.Text; }
            set { createnametxt.Text= value; }
        }
        public string Phone
        {
            get { return createphonetxt.Text; }
            set { createphonetxt.Text = value; }
        }
        public string CUsername
        {
            get { return createusernametxt.Text; }
            set { createusernametxt.Text = value; }
        }
        public string Address
        {
            get { return createaddresstxt.Text; }
            set { createaddresstxt.Text = value; }
        }
        public string Answer
        {
            get { return createanstxt.Text; }
            set { createanstxt.Text = value; }
        }
        public string CPass
        {
            get { return createpasstxt.Text; }
            set {createpasstxt.Text = value; }
        }
        public int CPassLength()
        {
            return createpasstxt.Text.Length;
        }

        public string EUsername
        {
            get { return createusernametxt.Text; }
            set { createusernametxt.Text = value; }
        }
        public string EPass
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

            //if (enteremailtxt.Text == "" || enteremailtxt.Text == "Enter your email")
            //{
            //    emailvallbl.Text = "Please enter your email";
            //}
            //if (enterpasstxt.Text == "" || enterpasstxt.Text == "Enter your password")
            //{
            //    passvallbl.Text = "Please enter your password";
            //}
            //if (enteremailtxt.Text != "" && enterpasstxt.Text != "")
            //{
            //    if (enteremailtxt.Text != email && enterpasstxt.Text == pass)
            //    {

            //        emailvallbl.Text = "Wrong Email! Write again";
            //    }
            //    if (enteremailtxt.Text == email && enterpasstxt.Text != pass)
            //    {

            //        passvallbl.Text = "Wrong Password! Write again";
            //    }
            //    if (enteremailtxt.Text != email && enterpasstxt.Text != pass)
            //    {
            //        emailvallbl.Text = "Wrong Email! Write again";
            //        passvallbl.Text = "Wrong password! Write again";
            //    }
            //    if (enteremailtxt.Text == email && enterpasstxt.Text == pass)
            //    {
            //        MessageBox.Show("Logged As Patient");
            //        MainForm patient = new MainForm("Patient");
            //        patient.Show();
            //        this.Hide();

            //    }

            //}
            Pharmacist p = new Pharmacist();
            p.Show();
            this.Hide();

        }

        private void enteremailtxt_Enter(object sender, EventArgs e)
        {
            if (enteremailtxt.Text == "Enter your Email")
            {
                enteremailtxt.Text = "";
                enteremailtxt.ForeColor = Color.Black;
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

            if (createpasstxt.Text == "Enter your password (at least 4 characters)")
            {
                createpasstxt.Text = "";
                createpasstxt.ForeColor = Color.Black;
                createpasstxt.PasswordChar = '*';
            }

        }
        private void Resetcreatepan()
        {

            createaddresspan.Visible = false;
            createanspan.Visible = false;
            createusernamepan.Visible = false;
            createpasspan.Visible = false;

            securityquestioncb.SelectedIndex = 0;
            createnametxt.Text = "Name";
            createaddresstxt.Text = "Address";
            createusernametxt.Text = "Enter your username";
            enterpasstxt.Text = "Enter your password (at least 4 characters)";
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
            //1(4)
            if (Address == "Address" || Address == "")
            {
                createaddresspan.Visible = true;   
                createanspan.Visible = false;
                createusernamepan.Visible = false;
                createpasspan.Visible = false;

            }

            if (Answer == "Type your answer" || Answer == "")
            {
                createanspan.Visible = true;
                createaddresspan.Visible = false;
                createusernamepan.Visible = false;
                createpasspan.Visible = false;

            }

            if (CUsername == "Enter your username" || CUsername == "")
            {
                createusernamepan.Visible = true;
                createaddresspan.Visible = false;
                createanspan.Visible = false;
                
                createpasspan.Visible = false;

            }
            if (((CPassLength() < 4) || (CPass == "Enter your password (at least 4 characters)" || CPass == "")))
            {
                createpasspan.Visible = true;
                createaddresspan.Visible = false;
                createanspan.Visible = false;
                createusernamepan.Visible = false;

               

            }

            //2(6)

            if ((CUsername == "Enter your username" || CUsername == "") &&
                (Address == "Address" || Address == ""))
            {

                createaddresspan.Visible = true;
                createusernamepan.Visible = true;
                
                createanspan.Visible = false;
                
                createpasspan.Visible = false;


            }
            if ((CUsername == "Enter your username" || CUsername == "") &&
                (Answer == "Type your answer" || Answer == ""))
            {

                createanspan.Visible = true;
                createusernamepan.Visible = true;
                
                createaddresspan.Visible = false;
                createpasspan.Visible = false;


            }
            if ((CUsername == "Enter your username" || CUsername == "") &&
                 ((CPassLength() < 4) || (CPass == "Enter your password (at least 4 characters)" || CPass == "")))
            {

                createusernamepan.Visible = true;
                createpasspan.Visible = true;

                createaddresspan.Visible = false;
                createanspan.Visible = false;
                


            }
            if ((Address == "Address" || Address == "") &&
                (Answer == "Type your answer" || Answer == ""))
            {

                createaddresspan.Visible = true;

                createanspan.Visible = true;

                createusernamepan.Visible = false;
                createpasspan.Visible = false;



            }
            if ((Address == "Address" || Address == "") &&
                ((CPassLength() < 4) || (CPass == "Enter your password (at least 4 characters)" || CPass == "")))
            {

                createaddresspan.Visible = true;
                createpasspan.Visible = true;

                
                createanspan.Visible = false;
                createusernamepan.Visible = false;
               


            }
            if ((Answer == "Type your answer" || Answer == "") &&
                ((CPassLength() < 4) || (CPass == "Enter your password (at least 4 characters)" || CPass == "")))
            {

                createanspan.Visible = true;
                createpasspan.Visible = true;

                createaddresspan.Visible = false;
              
                createusernamepan.Visible = false;
                
            }
            //3(4)
            if ((Address == "Address" || Address == "") &&
                (CUsername == "Enter your username" || CUsername == "") &&
                (Answer == "Type your answer" || Answer == ""))
            {

                createaddresspan.Visible = true;
                createanspan.Visible = true;
                createusernamepan.Visible = true;

                
                createpasspan.Visible = false;

            }
            if ((Address == "Address" || Address == "") &&
                (CUsername == "Enter your username" || CUsername == "") &&
                ((CPassLength() < 4) || (CPass == "Enter your password (at least 4 characters)" || CPass == "")))
            {

                createaddresspan.Visible = true;
                createusernamepan.Visible = true;
                createpasspan.Visible = true;
                
                createanspan.Visible = false;
               

            }
            if ((Answer == "Type your answer" || Answer == "") &&
                (CUsername == "Enter your username" || CUsername == "") &&
                ((CPassLength() < 4) || (CPass == "Enter your password (at least 4 characters)" || CPass == "")))
            {

                createanspan.Visible = true;
                createusernamepan.Visible = true;
                createpasspan.Visible = true;

                createaddresspan.Visible = false;
                

            }
            if ((Answer == "Type your answer" || Answer == "") &&
                (Address == "Address" || Address == "") &&
                ((CPassLength() < 4) || (CPass == "Enter your password (at least 4 characters)" || CPass == "")))
            {

                createaddresspan.Visible = true;
                createanspan.Visible = true;
                createpasspan.Visible = true;

                
                createusernamepan.Visible = false;
                

            }
            //4(1)
            if ((Address == "Address" || Address == "") &&
                (CUsername == "Enter your username" || CUsername == "") &&
                (Answer == "Type your answer" || Answer == "") &&
                ((CPassLength() < 4) || (CPass == "Enter your password (at least 4 characters)" || CPass == "")))
            {
                createaddresspan.Visible = true;
                createanspan.Visible = true;
                createusernamepan.Visible = true;
                createpasspan.Visible = true;
               

            }
            if ((Address != "Address" && Address != "") &&
                 (CUsername != "Enter your username" && CUsername != "") &&
                 (Answer != "Type your answer" && Answer != "") &&
                 ((CPassLength() > 4) && (CPass != "Enter your password (at least 4 characters)" && CPass != "")))
            {

                createaddresspan.Visible = false;
                createanspan.Visible = false;
                createusernamepan.Visible = false;
                createpasspan.Visible = false;

                MessageBox.Show("Signup Successful!");
                Resetcreatepan();
                createaccountpan.Hide();
               

                

            }
        }
    }
}