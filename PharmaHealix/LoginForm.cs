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
        //private string email="daiyan@gmail.com";
        //private string pass = "1234";
        public Loginform()
        {
            InitializeComponent();
            securityquestioncb.SelectedIndex = 0;


            if (securityquestioncb.SelectedIndex > 0)
            {
                securityquestioncb.ForeColor = Color.Black; 
            }
            else
            {
                securityquestioncb.ForeColor = Color.Gray; 
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
            createaccountpan.Hide();

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

        private void firstnametxt_Enter(object sender, EventArgs e)
        {
            if (firstnametxt.Text == "First Name")
            {
                firstnametxt.Text = "";
                firstnametxt.ForeColor = Color.Black;
            }

        }
        private void lastnametxt_Enter(object sender, EventArgs e)
        {
            if (lastnametxt.Text == "Last Name")
            {
                lastnametxt.Text = "";
                lastnametxt.ForeColor = Color.Black;
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
            if (createphonetxt.Text == "Enter your phone number")
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
            firstnametxt.Text = "First Name";
            lastnametxt.Text = "Last Name";
            createemailtxt.Text = "Enter your email";
            enterpasstxt.Text = "Enter your password";
            createanstxt.Text = "Type your answer";
            createphonetxt.Text = "Enter your phone number";

            firstnametxt.ForeColor = Color.Gray;
            lastnametxt.ForeColor = Color.Gray;
            createemailtxt.ForeColor = Color.Gray;
            createpasstxt.ForeColor = Color.Gray;
            createphonetxt.ForeColor = Color.Gray;
            createanstxt.ForeColor = Color.Gray;


        }
    }
}
