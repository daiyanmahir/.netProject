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

        private string user, username,doctor,appointmenttime;
        private DateTime appointmentdate;
        
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
            searchtxt.Text ="Search for Medicine";
            searchtxt.ForeColor = Color.Gray;
            appointmenthistorypan.Hide();
            numericUpDown.Value = 1;
            viewcartpan.Hide();
            orderhistorypan.Hide();

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
            String search = searchtxt.Text;
            if (search == "" || search == "Search for Medicine")
            {
                MessageBox.Show("Please enter a medicine name to search.");
                return;
            }
            else
            {
                string q = "Select count(*) from medicinetable where Medicinename=@0";
                int count = Convert.ToInt32(new Db().Scalar(q, search));
                if (count > 0)
                {
                    string r = "SELECT * FROM MedicineTable WHERE MedicineName = @0";

                    DataTable dt = new Db().Reader(r, search);
                    medibackpan.Visible = true;
                    medibackpan.BringToFront();
                    medinametxt.Text = dt.Rows[0]["MedicineName"].ToString();
                    categorytxt.Text = dt.Rows[0]["Category"].ToString();
                    descriptiontxt.Text = dt.Rows[0]["Description"].ToString();
                    striptxt.Text = dt.Rows[0]["StripPrice"].ToString();
                    unitpricetxt.Text= dt.Rows[0]["UnitPrice"].ToString();
                    pricetxt.Text = dt.Rows[0]["UnitPrice"].ToString();
                    dosetxt.Text = dt.Rows[0]["Dose"].ToString();
                    instructiontxt.Text = dt.Rows[0]["Instruction"].ToString();
                    sideeffectstxt.Text = dt.Rows[0]["SideEffect"].ToString();
                    if (dt.Rows[0]["Image"]!= DBNull.Value) {
                        mediimagepan.BackgroundImage = Image.FromFile(dt.Rows[0]["Image"].ToString());
                    }
                    else
                    {
                        mediimagepan.BackgroundImage = null;
                    }
                }

                else
                {
                    MessageBox.Show("Medicine Not Found!");
                    medibackpan.Visible = false;
                }
            }
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

        private void appsearchbtn_Click(object sender, EventArgs e)
        {
            string searchId = appsearchtxt.Text;
            string s = "Select count(*) From AppointmentTable where AppointmentID=@0";
            int count = Convert.ToInt32(new Db().Scalar(s, searchId));
            if (count>0) {
                string q =
                            "SELECT A.AppointmentID, " +
                            "U.Name AS [Doctor Name], " +
                            "A.AppointmentDate AS [Date], " +
                            "A.AppointmentTime AS [Time], " +
                            "A.Status " +
                            "FROM AppointmentTable A, DoctorTable D, UserTable U " +
                            "WHERE A.DoctorID = D.DoctorID " +
                            "And D.Username = U.Username " +
                            "And A.PatientUsername = @0 " +
                            "And A.AppointmentID=@1";

                DataTable apphistorytable = new Db().Reader(q, username,searchId);
                appdataGridView.DataSource = apphistorytable;
                appdataGridView.AutoGenerateColumns = true;
            }
            else
            {
                appdataGridView.DataSource = null;
                MessageBox.Show("The Appointment ID entered is not Found!");
                return;
            }
        }

      
        private void appointmenhistorytbtn_Click(object sender, EventArgs e)
        {
            if (user == "Patient")
            {
                appointmenthistorypan.Visible = true;
                appointmenthistorypan.BringToFront();
                string q =
                            "Select A.AppointmentID, " +
                            "U.Name as [Doctor Name], " +
                            "A.AppointmentDate as [Date], " +
                            "A.AppointmentTime as [Time], " +
                            "A.Status " +
                            "From AppointmentTable A, DoctorTable D, UserTable U " +
                            "Where A.DoctorID = D.DoctorID " +
                            "And D.Username = U.Username " +
                            "And A.PatientUsername = @0";

                DataTable apphistorytable = new Db().Reader(q, username);
                appdataGridView.DataSource = apphistorytable;
                appdataGridView.AutoGenerateColumns = true;
            }
            else
            {
                MessageBox.Show("Please Sign in First!");
            }
            

        }

        private void addtocartbtn_Click(object sender, EventArgs e)
        {
            if (user == "Patient")
            {
                int quantity = Convert.ToInt32(numericUpDown.Value);
                if (quantity < 1 || quantity > 10)
                {
                    MessageBox.Show("You can only add between 1 and 10 items to your cart.");
                    if (numericUpDown.Value > 10)
                    {
                        numericUpDown.Value = 10;
                    }
                    else if (numericUpDown.Value < 1)
                    {
                        numericUpDown.Value = 1;
                    }
                }
                else
                {
                    string m = "Select Stock From MedicineTable Where MedicineName=@0";
                    int stock = Convert.ToInt32(new Db().Scalar(m, medinametxt.Text));
                    if (stock >= quantity && stock > 0)
                    {
                        string r = "Select MedicineID from MedicineTable Where MedicineName=@0";

                        int medicineid = Convert.ToInt32(new Db().Scalar(r, medinametxt.Text));
                        string q = "Insert Into CartTable (PatientUsername,MedicineID,Quantity) Values(@0,@1,@2)";
                        new Db().NonQuery(q, username, medicineid, quantity);

                        stock = stock - quantity;

                        string update = "Update MedicineTable set stock=@0 where MedicineID=@1";
                        new Db().NonQuery(update, stock, medicineid);
                        numericUpDown.Value = 1;

                        MessageBox.Show("Successfully Added to Cart!");

                    }
                    else
                    {
                        MessageBox.Show("Insufficient Stock!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Sign in First!");
            }
        }

        private void cartbtn_Click(object sender, EventArgs e)
        {
            if (user == "Patient")
            {
                viewcartpan.Visible = true;
                viewcartpan.BringToFront();
                string q = "SELECT C.CartId as [Cart ID], " +
                           "M.MedicineID as [Medicine ID], " +
                           "M.MedicineName as [Medicine Name], " +
                           "C.Quantity as [Quantity], " +
                           "M.UnitPrice as [Unit Price], " +
                           "(C.Quantity * M.UnitPrice) AS [Total Price] " +
                           "From CartTable C, MedicineTable M " +
                           "Where C.MedicineId = M.MedicineId " +
                           "And C.PatientUsername = @0";

                DataTable dt = new Db().Reader(q, username);
                cartdataGridView.DataSource = dt;
                cartdataGridView.AutoGenerateColumns = true;
            }
            else
            {
                MessageBox.Show("Please Sign in First!");

            }
        }

        private void orderbtn_Click(object sender, EventArgs e)
        {
            string countQ = "Select COUNT(*) MedicineID From CartTable Where PatientUsername=@0";
            int count=Convert.ToInt32(new Db().Scalar(countQ,username));
            if (count > 0)
            {
                //Order Table Insertion

                                string q = "Select SUM(C.Quantity * M.UnitPrice) " +
                                           "From CartTable C, MedicineTable M " +
                                           "Where C.MedicineId = M.MedicineId " +
                                           "And C.PatientUsername = @0";

                int total = Convert.ToInt32(new Db().Scalar(q, username));
                string s = "Insert Into OrderTable(PatientUsername,OrderDate,TotalAmount,Status) values(@0,@1,@2,@3)";
                new Db().NonQuery(s, username, DateTime.Today, total, "Pending");

                //OrderTableDetails Insertion from Cart and OrderTable

                string OID = "Select MAX(OrderID) FROM OrderTable Where PatientUsername = @0";
                //error
                int orderId = Convert.ToInt32(new Db().Scalar(OID, username));

                               string cart = "Select C.CartId, " +
                                             "M.MedicineID, " +
                                             "M.MedicineName, " +
                                             "C.Quantity, " +
                                             "M.UnitPrice AS [UnitPrice] " +
                                             "From CartTable C, MedicineTable M " +
                                             "Where C.MedicineId = M.MedicineId " +
                                             "And C.PatientUsername = @0";
                DataTable cartdt = new Db().Reader(cart, username);

                for (int i = 0; i < cartdt.Rows.Count; i++)
                {
                    int medicineId = Convert.ToInt32(cartdt.Rows[i]["MedicineId"]);
                    int quantity = Convert.ToInt32(cartdt.Rows[i]["Quantity"]);
                    double unitPrice = Convert.ToDouble(cartdt.Rows[i]["UnitPrice"]);

                    string details = "Insert into OrderDetailsTable(OrderID, MedicineID, Quantity, UnitPrice) Values(@0,@1,@2,@3)";

                    new Db().NonQuery(details, orderId, medicineId, quantity, unitPrice);
                }
                //Cart Clean 
                string r = "Delete From CartTable where Patientusername=@0";

                new Db().NonQuery(r, username);

                MessageBox.Show("Order Has Been Placed.");

                //Refresh Table
                cartdt = new Db().Reader(cart, username);
                cartdataGridView.DataSource = cartdt;
                cartdataGridView.AutoGenerateColumns = true;
            }
            else
            {
                MessageBox.Show("Cart Is Empty!");
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string countQ = "Select COUNT(*) MedicineID From CartTable Where PatientUsername=@0";
            int count = Convert.ToInt32(new Db().Scalar(countQ, username));
            if (count > 0)
            {
                // Restore all stocks
                string cartQ =
                       "Select MedicineID, Quantity " +
                       "From CartTable WHERE PatientUsername=@0";

                DataTable dt = new Db().Reader(cartQ, username);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int medicineId = Convert.ToInt32(dt.Rows[i]["MedicineID"]);
                    int quantity = Convert.ToInt32(dt.Rows[i]["Quantity"]);

                    string stockQ =
                        "Select Stock From MedicineTable where MedicineID=@0";

                    int stock = Convert.ToInt32(new Db().Scalar(stockQ, medicineId));

                    stock += quantity;

                    string updateQuery =
                        "Update MedicineTable Set Stock=@0 where MedicineID=@1";

                    new Db().NonQuery(updateQuery, stock, medicineId);
                }
                // clear cart
                string q = "Delete from CartTable Where PatientUsername=@0";
                new Db().NonQuery(q, username);

                MessageBox.Show("Cart cleared!");

                string cart = "Select C.CartId, " +
                              "M.MedicineID, " +
                              "M.MedicineName, " +
                              "C.Quantity, " +
                              "M.UnitPrice AS [UnitPrice] " +
                              "From CartTable C, MedicineTable M " +
                              "Where C.MedicineId = M.MedicineId " +
                              "And C.PatientUsername = @0";
                DataTable cartdt = new Db().Reader(cart, username);
                cartdataGridView.DataSource = cartdt;
                cartdataGridView.AutoGenerateColumns = true;
            }
            else
            {
                MessageBox.Show("Cart Is Empty!");
            }


        }

        private void orderhistorybtn_Click(object sender, EventArgs e)
        {
            if (user == "Patient")
            {
                orderhistorypan.Visible = true;
                orderhistorypan.BringToFront();
                string q = "Select O.OrderID as [Order ID], " +
                   "O.OrderDate as [Date], " +
                   "M.MedicineName as [Medicine Name], " +
                   "D.Quantity as [Quantity], " +
                   "(D.Quantity * D.UnitPrice) as [Total Price], " +
                   "O.Status as [Status] " +
                   "From OrderTable O, OrderDetailsTable D, MedicineTable M " +
                   "Where O.OrderID = D.OrderID " +
                   "And D.MedicineID = M.MedicineID " +
                   "And O.PatientUsername = @0";

                DataTable dt = new Db().Reader(q, username);
                orderhistorydataGridView.DataSource = dt;
                orderhistorydataGridView.AutoGenerateColumns = true;
            }
            else
            {
                MessageBox.Show("Please Sign in First!");
            }
        }

        private void appdoctorcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (appdoctorcb.SelectedIndex != -1 && appdoctorcb.SelectedValue != null)
            {

                string d = Convert.ToString(appdoctorcb.SelectedValue);

                string m = "Select username From usertable where name=@0";
                string du = Convert.ToString(new Db().Scalar(m, doctor));
                string p = "Select DoctorId From DoctorTable where username=@0";
                int did = Convert.ToInt32(new Db().Scalar(p, du));
                string query = "Select Speciality From DoctorTable where DoctorID = @0";
                string speacility = Convert.ToString(new Db().Scalar(query, did));
                appdesignationtxt.Text = speacility;
            }
            else
            {
                appdesignationtxt.Text = "";
            }

        }

        private void appointmentbtn_Click(object sender, EventArgs e)
        {
            if (user == "Patient")
            {
                appointmentpan.Visible = true;
                appointmentpan.BringToFront();
                string p = "select name, phone, address from UserTable where username=@0";
                DataTable dt = new Db().Reader(p, username);
                appnametxt.Text = Convert.ToString(dt.Rows[0]["Name"]);
                appphonetxt.Text = Convert.ToString(dt.Rows[0]["Phone"]);
                appaddresstxt.Text = Convert.ToString(dt.Rows[0]["Address"]);

                string q = "select name from UserTable where role=@0";
                string r = "Select COUNT(*) FROM UserTable Where role=@0";

                int count = Convert.ToInt32(new Db().Scalar(r, "Doctor"));
                DataTable dt2 = new Db().Reader(q, "Doctor");
                appdoctorcb.Items.Clear();
                for (int i = 0; i < count; i++)
                {
                    appdoctorcb.Items.Add(Convert.ToString(dt2.Rows[i]["Name"]));
                }
            }
            else
            {
                MessageBox.Show("Please Sign in First!");
            }
            
        }
        
        private void setappointmentbtn_Click(object sender, EventArgs e)
        {
            doctor = appdoctorcb.Text;
            appointmentdate = appdateTimePicker.Value.Date;
            appointmenttime=apptimecb.Text;

            bool flag=false;
            if (doctor == "")
            {
                flag = true;
            }
            if(appointmenttime == "")
            {
                flag = true;
            }
            if (flag)
            {
                MessageBox.Show("Doctor or Appointment Time not selected!");
                return;
            }
            else {
                string m = "Select username from usertable where name=@0";
                string du = Convert.ToString(new Db().Scalar(m, doctor));
                string p = "Select DoctorId from DoctorTable where username=@0";
                int did = Convert.ToInt32(new Db().Scalar(p, du));


                string q = "Select COUNT(*) From AppointmentTable WHERE DoctorId=@0 and AppointmentDate=@1 and AppointmentTime=@2 ";
                int count = Convert.ToInt32(new Db().Scalar(q, did, appointmentdate, appointmenttime));
                if (count > 0)
                {
                    MessageBox.Show("No Appointments Available At This Time!");
                    return;
                }
                else if (appointmentdate < DateTime.Today)
                {
                    MessageBox.Show("Invalid Date");
                    return;
                }
                else
                {
                    string r = "Insert Into AppointmentTable(PatientUsername,DoctorID,AppointmentDate,AppointmentTime,Status) Values(@0,@1,@2,@3,@4)";
                    new Db().NonQuery(r, username, did, appointmentdate, appointmenttime, "Pending");

                    MessageBox.Show("Appointment Requested!\n" +
                        "Fee-->1200Tk");
                    //Reset

                    appdoctorcb.SelectedIndex = -1;
                    apptimecb.SelectedIndex = -1;
                    appdateTimePicker.Value = DateTime.Today;

                    appointmentdate = DateTime.Today;
                    appointmenttime = "";
                    doctor = "";

                }
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            //Reset
            appointmentpan.Hide();
     
            appdoctorcb.SelectedIndex = -1;
            apptimecb.SelectedIndex = -1;
            appdateTimePicker.Value = DateTime.Today;

            appointmentdate = DateTime.Today;
            appointmenttime = "";
            doctor = "";
            appdesignationtxt.Text ="";

        }
    }
    
}
