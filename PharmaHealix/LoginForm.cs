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
            set { value=createnametxt.Text; } 
        }
        public string Phone
        {
            get { return createphonetxt.Text; }
            set { value = createphonetxt.Text; }
        }
        public string CEmail
        {
            get { return createemailtxt.Text; }
            set { value = createemailtxt.Text; }
        }
        public string Address
        {
            get { return createaddresstxt.Text; }
            set { value = createaddresstxt.Text; }
        }
        public string Answer
        {
            get { return createanstxt.Text; }
            set { value = createanstxt.Text; }
        }
        public string CPass
        {
            get { return createpasstxt.Text; }
            set { value = createpasstxt.Text; }
        }
        public Loginform()
        {
            InitializeComponent();
            securityquestioncb.SelectedIndex = 0;

            if (securityquestioncb.SelectedIndex > 0)
            {
                securityquestioncb.ForeColor = Color.Black; 
            }
         
           
            


        }
        public void CreateAcc(bool check)
        {
            if (check)
            {
                createaccountpan.BringToFront();
                createaccountpan.Visible=true;
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
            if(createnametxt.Text=="Name" || createnametxt.Text == "")
            {

            }
                createaccountpan.Hide();
            Resetcreatepan();


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
            if (enterpasstxt.Text == "Enter your Password")
            {
                enterpasstxt.Text = "";
                enterpasstxt.ForeColor = Color.Black;
                enterpasstxt.PasswordChar = '*';
            }
        }

        private void hidebtn_Click(object sender, EventArgs e)
        {
            if(enterpasstxt.PasswordChar == '*')
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
        private void createemailtxt_Enter(object sender, EventArgs e)
        {
            if (createemailtxt.Text == "Enter your email")
            {
                createemailtxt.Text = "";
               createemailtxt.ForeColor = Color.Black;
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

            if (createpasstxt.Text == "Enter your password")
            {
                createpasstxt.Text = "";
               createpasstxt.ForeColor = Color.Black;
                createpasstxt.PasswordChar = '*';
            }

        }
       private void Resetcreatepan()
        {

            securityquestioncb.SelectedIndex = 0;
            if (securityquestioncb.SelectedIndex > 0)
            {
                securityquestioncb.ForeColor = Color.Black;
            }
            else
            {
                securityquestioncb.ForeColor = Color.Gray;
            }
            createnametxt.Text = "Name";
            createaddresstxt.Text = "Address";
            createemailtxt.Text = "Enter your email";
            enterpasstxt.Text = "Enter your password";
            createanstxt.Text = "Type your answer";
            createphonetxt.Text = "Phone number";

            createnametxt.ForeColor = Color.Gray;
            createaddresstxt.ForeColor = Color.Gray;
            createemailtxt.ForeColor = Color.Gray;
            createpasstxt.ForeColor = Color.Gray;
            createphonetxt.ForeColor = Color.Gray;
            createanstxt.ForeColor = Color.Gray;


        }
        private void FormValidation()
        {
            if (CName == "Name" || CName=="")
            {
                createnamepan.Visible = true;
                return;
            }
            if (Address == "Addess" || Address == "")
            {
                createaddresspan.Visible = true;
                return;
            }
            if (CEmail == "Addess" || CEmail == "")
            {
                createemailpan.Visible = true;
                return;
            }
            if (CPass == "Password" || CPass == "")
            {
                createpasspan.Visible = true;
                return;
            }

        }
    }
}
