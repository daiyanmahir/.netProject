using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PharmaHealix
{
    public partial class MainForm : Form
    {

        private string user;
        public MainForm(string s)
        {
            this.user=s;
            InitializeComponent();
            

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void medilogobtn_Click(object sender, EventArgs e)
        {
            medibackpan.Hide();
            
              
        }

        private void createaccountbtn_Click(object sender, EventArgs e)
        {
            Loginform l = new Loginform();
            l.Show();
            this.Close();
            l.CreateAcc(true);
        }

        private void userpanminimizebtn_Click(object sender, EventArgs e)
        {
            if (user == "Guest")
            {
                userpan.Visible = false;
                
            }
            else if (user == "Patient")
            {
                patientpan.Visible = false;
               
            }
        }

        private void userpansigninbtn_Click(object sender, EventArgs e)
        {
            Loginform l = new Loginform();
            l.Show();
            this.Close();

        }

       

        private void searchbtn_Click(object sender, EventArgs e)
        {
            medibackpan.Visible = true;
            medibackpan.BringToFront();
        }

        private void logoutbtn_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Logged Out");
            Loginform l = new Loginform();
            l.Show();
            this.Close();
        }

        private void userbtn_Click(object sender, EventArgs e)
        {  
        
            if (user == "Patient")
            {
                patientpan.Visible = true;
                patientpan.BringToFront();
            }
            if (user == "Guest")
            {

                userpan.Visible = true;
                userpan.BringToFront();
            }
        }


        private void searchtxt_Enter(object sender, EventArgs e)
        {
            if(searchtxt.Text=="Search for Medicine")
            {
                searchtxt.Text = "";
                searchtxt.ForeColor = Color.Black;
            }
        }

   
    }
}
