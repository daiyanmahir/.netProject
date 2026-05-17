using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PharmaHealix
{
    public partial class MainForm : Form
    {

        private string user, username,doctor,appointmentdate,appointmenttime;
        



        private string EName
        {
            get { return editnametxt.Text; }
            set { editnametxt.Text = value; }
        }
        private string EPhone
        {
            get { return editphonetxt.Text; }
            set { editphonetxt.Text = value; }
        }
        private string EUsername
        {
            get { return editusernametxt.Text; }
            set { editusernametxt.Text = value; }
        }
        private string EAddress
        {
            get { return editaddresstxt.Text; }
            set { editaddresstxt.Text = value; }
        }
        private string EAnswer
        {
            get { return editanstxt.Text; }
            set { editanstxt.Text = value; }
        }
        private string EPass
        {
            get { return editpasstxt.Text; }
            set { editpasstxt.Text = value; }
        }

        public MainForm(string s,string n)
        {
            this.user=s;
            this.username=n;
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
        private void editpansavebtn_Click(object sender, EventArgs e)
        {
            editphonepan.Visible = false;
            editnamepan.Visible = false;
            editusernamepan.Visible = false;
            editaddresspan.Visible = false;
            editanspan.Visible = false;
            editpasspan.Visible = false;

            bool Error = false;
            bool Flag = false;

            if (EPhone == "")
            {
                editphonepan.Visible = true;
                Error = true;
            }

            bool PDigits = true;

            foreach (char c in EPhone)
            {
                if (!char.IsDigit(c))
                {
                    PDigits = false;
                    break;
                }
            }

            if (!PDigits || EPhone.Length != 11 || !EPhone.StartsWith("01"))
            {
                editphonepan.Visible = true;
                Flag = true;
            }
            if (EName == "")
            {
                editnamepan.Visible = true;
                Error = true;
            }
            if (EName != "")
            {
                foreach (char c in EName)
                {
                    if (char.IsDigit(c))
                    {
                        editnamepan.Visible = true;
                        Flag = true;
                        break;
                    }
                }
            }
            if (EUsername == "")
            {

                editusernamepan.Visible = true;
                Error = true;
            }
            bool UDigits = true;

            foreach (char c in EUsername)
            {
                if (!char.IsDigit(c))
                {
                    UDigits = false;
                    break;
                }
            }

            if (EUsername.Length < 4 || UDigits)
            {
                editusernamepan.Visible = true;
                Flag = true;
            }
            if (EUsername != "" && EUsername!=username)
            {
                string query = "SELECT COUNT(*) FROM UserTable WHERE Username = @0";
                int count = Convert.ToInt32(new Db().Scalar(query, EUsername));
                if (count > 0)
                {
                    editusernamepan.Visible = true;
                    Flag = true;
                }
            }
            if (EAddress == "")
            {
                editaddresspan.Visible = true;
                Error = true;
            }


            if (EAnswer == "")
            {
                editanspan.Visible = true;
                Error = true;
            }

            if (EPass == "")
            {
                editpasspan.Visible = true;
                Error = true;
            }
            else if (EPass.Length < 5)
            {
                editpasspan.Visible = true;
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
                new Db().NonQuery(query, EName, EPhone, EUsername, EAddress, editsecurityquestioncb.Text, EAnswer, EPass,username);
                username = EUsername;

                MessageBox.Show("Update Successful!");
                editprofile();
            }


        }

        private void editpanminimizebtn_Click(object sender, EventArgs e)
        {
           editpan.Visible=false;
        }


        private void minimizebtn_Click(object sender, EventArgs e)
        {
            patientpan.Visible = false;
        }

        private void editprofile()
        {
            string q = "select * from UserTable where username=@0";
            DataTable dt = new Db().Reader(q, username);
            editnametxt.Text = Convert.ToString(dt.Rows[0]["Name"]);
            editphonetxt.Text = Convert.ToString(dt.Rows[0]["Phone"]);
            editusernametxt.Text = Convert.ToString(dt.Rows[0]["Username"]);
            editaddresstxt.Text = Convert.ToString(dt.Rows[0]["Address"]);
            editsecurityquestioncb.Text = Convert.ToString(dt.Rows[0]["Question"]);
            editpasstxt.Text = Convert.ToString(dt.Rows[0]["Password"]);
            editanstxt.Text = Convert.ToString(dt.Rows[0]["Answer"]);
        }
        private void editprofilebtn_Click(object sender, EventArgs e)
        {

            editpan.Visible = true;
            editpan.BringToFront();
            editprofile();

        }

        private void editpanhidebtn_Click(object sender, EventArgs e)
        {
            if (editpasstxt.PasswordChar == '*')
            {
                editpasstxt.PasswordChar = '\0';
            }
            else
            {
                editpasstxt.PasswordChar = '*';
            }
        }

        private void appointmentbtn_Click(object sender, EventArgs e)
        {
            appointmentpan.Visible = true;
            appointmentpan.BringToFront();
            string p = "select name, phone, address from UserTable where username=@0";
            DataTable dt = new Db().Reader(p, username);
            appnametxt.Text = Convert.ToString(dt.Rows[0]["Name"]);
            appphonetxt.Text = Convert.ToString(dt.Rows[0]["Phone"]);
            appaddresstxt.Text = Convert.ToString(dt.Rows[0]["Address"]);

            string q = "select name from UserTable where role=@0";
            string r = "SELECT COUNT(*) FROM UserTable WHERE role=@0";

            int count = Convert.ToInt32(new Db().Scalar(r,"Doctor"));
            DataTable dt2=new Db().Reader(q, "Doctor");
            for(int i = 0; i < count; i++)
            {
                appdoctorcb.Items.Add(Convert.ToString(dt2.Rows[i]["Name"]));
            }

            
        }
        
        private void setappointmentbtn_Click(object sender, EventArgs e)
        {
            doctor = appdoctorcb.Text;
            //appointment
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {

        }
    }
    
}
