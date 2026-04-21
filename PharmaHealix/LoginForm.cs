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
        private string email="daiyan@gmail.com";
        private string pass = "1234";
        public Loginform()
        {
            InitializeComponent();


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

        private void loginbtn_Click_1(object sender, EventArgs e)
        {
            
            if (enteremailtxt.Text == "" || enteremailtxt.Text == "Enter your email")
            {
                emailvallbl.Text = "Please enter your email";
            }
            if (enterpasstxt.Text == "" || enterpasstxt.Text == "Enter your password")
            {
                passvallbl.Text = "Please enter your password";
            }
            if (enteremailtxt.Text != "" && enterpasstxt.Text != "")
            {
                if(enteremailtxt.Text != email && enterpasstxt.Text == pass)
                {

                    emailvallbl.Text = "Wrong Email! Write again";
                }
                if (enteremailtxt.Text == email && enterpasstxt.Text != pass)
                {

                    passvallbl.Text = "Wrong Password! Write again";
                }              
                if(enteremailtxt.Text != email && enterpasstxt.Text != pass)
                {
                    emailvallbl.Text = "Wrong Email! Write again";
                    passvallbl.Text = "Wrong password! Write again";
                }
                if(enteremailtxt.Text == email && enterpasstxt.Text == pass)
                {
                    MessageBox.Show("Logged As Patient");
                    MainForm patient = new MainForm("Patient");
                    patient.Show();
                    this.Hide();

                }

            }
           
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
    }
}
