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

        private void medibackpan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void headpan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cartbtn2_Click(object sender, EventArgs e)
        {

        }

        private void doctorbtn_Click(object sender, EventArgs e)
        {

        }

        private void userpan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userpanlbl2_Click(object sender, EventArgs e)
        {

        }

        private void humaniconpan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userpanlbl1_Click(object sender, EventArgs e)
        {

        }

        private void patientpan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void welcomelbl_Click(object sender, EventArgs e)
        {

        }

        private void prescriptionlbl_Click(object sender, EventArgs e)
        {

        }

        private void Whatareyoulookinglbl_Click(object sender, EventArgs e)
        {

        }

        private void prescriptionuploadbtn_Click(object sender, EventArgs e)
        {

        }

        private void cartbtn_Click(object sender, EventArgs e)
        {

        }

        private void searchpan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchiconpan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adpan2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adlbl23_Click(object sender, EventArgs e)
        {

        }

        private void adlbl22_Click(object sender, EventArgs e)
        {

        }

        private void adlbl21_Click(object sender, EventArgs e)
        {

        }

        private void adpan1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adlbl12_Click(object sender, EventArgs e)
        {

        }

        private void adlbl11_Click(object sender, EventArgs e)
        {

        }

        private void medipan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void medinametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void addtocartbtn_Click(object sender, EventArgs e)
        {

        }

        private void sideeffectstxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void instructiontxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dosetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void unitpricetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pricetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void striptxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void unitpricelbl_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sideeffectslbl_Click(object sender, EventArgs e)
        {

        }

        private void instructionlbl_Click(object sender, EventArgs e)
        {

        }

        private void doselbl_Click(object sender, EventArgs e)
        {

        }

        private void pricelbl_Click(object sender, EventArgs e)
        {

        }

        private void striplbl_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void descriptiontxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void descriptionlbl_Click(object sender, EventArgs e)
        {

        }

        private void categorytxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void medinfolbl_Click(object sender, EventArgs e)
        {

        }

        private void mediimagepan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mediinfopan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void categorylbl_Click(object sender, EventArgs e)
        {

        }
    }
}
