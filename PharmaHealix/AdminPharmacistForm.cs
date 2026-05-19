using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaHealix
{
    public partial class AdminPharmacistForm : Form
    {
        Db db = new Db();

        string oldusername = "";

        int id;

        public AdminPharmacistForm()
        {
            InitializeComponent();


        }


        private bool PharmacistValidation()
        {
            bool Error = false;

            if (txtName.Text == "")
            {
                MessageBox.Show("Please Enter Name");
                Error = true;
            }

            else if (txtName.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Name Cannot Contain Numbers");
                Error = true;
            }

            else if (txtUsername.Text == "")
            {
                MessageBox.Show("Please Enter Username");
                Error = true;
            }

            else if (txtPhone.Text == "")
            {
                MessageBox.Show("Please Enter Phone Number");
                Error = true;
            }

            else if (txtPhone.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Phone Number Must Contain Only Numbers");
                Error = true;
            }

            else if (txtPhone.Text.Length != 11)
            {
                MessageBox.Show("Phone Number Must Be 11 Digits");
                Error = true;
            }

            else if (txtPhone.Text.StartsWith("01") == false)
            {
                MessageBox.Show("Phone Number Must Start With 01");
                Error = true;
            }

            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter Password");
                Error = true;
            }

            else if (txtPassword.Text.Length < 5)
            {
                MessageBox.Show("Password Must Be At Least 5 Characters");
                Error = true;
            }

            else if (txtSalary.Text == "")
            {
                MessageBox.Show("Please Enter Salary");
                Error = true;
            }

            else if (decimal.TryParse(txtSalary.Text, out decimal salary) == false)
            {
                MessageBox.Show("Salary Must Be Number");
                Error = true;
            }



            //decimal salary;

            //if (decimal.TryParse(txtSalary.Text, out salary) == false)
            //{
            //MessageBox.Show("Salary Must Be Number");
            //Error = true;
            //}

            else if (rdoMale.Checked == false && rdoFemale.Checked == false)
            {
                MessageBox.Show("Please Select Gender");
                Error = true;
            }

            else if (cmbQuestion.Text == "")
            {
                MessageBox.Show("Please Select Question");
                Error = true;
            }

            else if (txtAnswer.Text == "")
            {
                MessageBox.Show("Please Enter Answer");
                Error = true;
            }

            else if (rtxtAddress.Text == "")
            {
                MessageBox.Show("Please Enter Address");
                Error = true;
            }

           // decimal salary;

           // if (decimal.TryParse(txtSalary.Text, out salary) == false)
            //{
               // MessageBox.Show("Salary Must Be Number");
               // Error = true;
           // }

           
            if (Error)
            {
                return false;
            }

            return true;
        }

        private void btnPharmacist_Click(object sender, EventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            AdminDoctorForm doctorForm = new AdminDoctorForm();
            doctorForm.Show();
            this.Hide();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            AdminPatientForm patientForm = new AdminPatientForm();
            patientForm.Show();
            this.Hide();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            AdminInventoryForm inventoryForm = new AdminInventoryForm();
            inventoryForm.Show();
            this.Hide();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            AdminAppointmentForm appointmentForm = new AdminAppointmentForm();
            appointmentForm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Loginform login = new Loginform();
            login.Show();
            this.Hide();
        }

        private void lblPharmacistID_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(db.connection);

            conn.Open();

            string query = "select UserTable.Name, UserTable.Phone, UserTable.Username, UserTable.Address, UserTable.Question, UserTable.Answer, UserTable.Password, StaffTable.StaffID, StaffTable.Gender, StaffTable.Salary from UserTable inner join StaffTable on UserTable.Username = StaffTable.Username where UserTable.Role='Pharmacist'";

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            adp.Fill(ds);

            DataTable dt = ds.Tables[0];

            dgvPharmacist.DataSource = dt;

            dgvPharmacist.AutoGenerateColumns = true;

            conn.Close();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (PharmacistValidation() == false)
            {
                return;
            }


            SqlConnection checkconn = new SqlConnection(db.connection);

            checkconn.Open();

            string checkquery = "select count(*) from UserTable where Username='" + txtUsername.Text + "'";

            SqlCommand checkcmd = new SqlCommand(checkquery, checkconn);

            int count = Convert.ToInt32(checkcmd.ExecuteScalar());

            checkconn.Close();

            if (count > 0)
            {
                MessageBox.Show("Username Already Exists");
                return;
            }



            string gender = "";

            if (rdoMale.Checked)
            {
                gender = "Male";
            }

            if (rdoFemale.Checked)
            {
                gender = "Female";
            }

           
           
            SqlConnection conn = new SqlConnection(db.connection);

            conn.Open();

            string query1 = "Insert into UserTable(Name,Phone,Username,Address,Question,Answer,Password,Role) values('" + txtName.Text + "','" + txtPhone.Text + "','" + txtUsername.Text + "','" + rtxtAddress.Text + "','" + cmbQuestion.Text + "','" + txtAnswer.Text + "','" + txtPassword.Text + "','Pharmacist')";

            SqlCommand cmd1 = new SqlCommand(query1, conn);

            cmd1.ExecuteNonQuery();

            string query2 = "Insert into StaffTable(Username,Gender,Salary) values('" + txtUsername.Text + "','" + gender + "'," + Convert.ToDecimal(txtSalary.Text) + ")";
            //string query2 = "Insert into StaffTable(Username,Gender,Salary) values('" + txtUsername.Text + "','" + gender + "'," + Salary + ")";

            SqlCommand cmd2 = new SqlCommand(query2, conn);

            cmd2.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Pharmacist Added");

           
            txtName.Text = "";
            txtUsername.Text = "";
            txtPhone.Text = "";
            txtPassword.Text = "";
            txtSalary.Text = "";
            txtAnswer.Text = "";
            rtxtAddress.Text = "";

            cmbQuestion.SelectedIndex = -1;

            rdoMale.Checked = false;
            rdoFemale.Checked = false;

        }
 

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (PharmacistValidation() == false)
            {
                return;
            }

            string gender = "";

            if (rdoMale.Checked)
            {
                gender = "Male";
            }

            if (rdoFemale.Checked)
            {
                gender = "Female";
            }

            SqlConnection conn = new SqlConnection(db.connection);

            conn.Open();

            string checkquery = "select * from UserTable where Username='" + txtUsername.Text.Replace("'", "''") + "' AND Username<>'" + oldusername + "'";

            SqlCommand checkcmd = new SqlCommand(checkquery, conn);

            SqlDataReader reader = checkcmd.ExecuteReader();

            if (reader.HasRows)
            {
                MessageBox.Show("Username Already Exists");

                reader.Close();
                conn.Close();

                return;
            }

            reader.Close();

            string query1 = "Update UserTable set Name='" + txtName.Text.Replace("'", "''") + "', Phone='" + txtPhone.Text.Replace("'", "''") + "', Username='" + txtUsername.Text.Replace("'", "''") + "', Address='" + rtxtAddress.Text.Replace("'", "''") + "', Question='" + cmbQuestion.Text.Replace("'", "''") + "', Answer='" + txtAnswer.Text.Replace("'", "''") + "', Password='" + txtPassword.Text.Replace("'", "''") + "' where Username='" + oldusername + "' AND Role='Pharmacist'";

            SqlCommand cmd1 = new SqlCommand(query1, conn);

            cmd1.ExecuteNonQuery();

            decimal salary = Convert.ToDecimal(txtSalary.Text);

            string query2 = "Update StaffTable set Username='" + txtUsername.Text.Replace("'", "''") + "', Gender='" + gender + "', Salary=" + salary + " where StaffID=" + id;

            SqlCommand cmd2 = new SqlCommand(query2, conn);

            cmd2.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Pharmacist Updated");

            conn.Open();

            string showquery = "select UserTable.Name, UserTable.Phone, UserTable.Username, UserTable.Address, UserTable.Question, UserTable.Answer, UserTable.Password, StaffTable.StaffID, StaffTable.Gender, StaffTable.Salary from UserTable inner join StaffTable on UserTable.Username = StaffTable.Username where UserTable.Role='Pharmacist'";

            SqlCommand showcmd = new SqlCommand(showquery, conn);

            SqlDataAdapter adp = new SqlDataAdapter(showcmd);

            DataSet ds = new DataSet();

            adp.Fill(ds);

            DataTable dt = ds.Tables[0];

            dgvPharmacist.DataSource = dt;

            dgvPharmacist.AutoGenerateColumns = true;

            conn.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(db.connection);

            conn.Open();

            DialogResult result = MessageBox.Show("Are You Sure?", "Delete", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string query1 = "Delete from StaffTable where Username='" + txtUsername.Text.Replace("'", "''") + "'";

                SqlCommand cmd1 = new SqlCommand(query1, conn);

                cmd1.ExecuteNonQuery();

                string query2 = "Delete from UserTable where Username='" + txtUsername.Text.Replace("'", "''") + "' AND Role='Pharmacist'";

                SqlCommand cmd2 = new SqlCommand(query2, conn);

                cmd2.ExecuteNonQuery();

                MessageBox.Show("Pharmacist Deleted");

                txtName.Text = "";
                txtUsername.Text = "";
                txtPhone.Text = "";
                txtPassword.Text = "";
                txtSalary.Text = "";
                txtAnswer.Text = "";
                rtxtAddress.Text = "";

                cmbQuestion.SelectedIndex = -1;

                rdoMale.Checked = false;
                rdoFemale.Checked = false;

                string showquery = "select UserTable.Name, UserTable.Phone, UserTable.Username, UserTable.Address, UserTable.Question, UserTable.Answer, UserTable.Password, StaffTable.StaffID, StaffTable.Gender, StaffTable.Salary from UserTable inner join StaffTable on UserTable.Username = StaffTable.Username where UserTable.Role='Pharmacist'";

                SqlCommand showcmd = new SqlCommand(showquery, conn);

                SqlDataAdapter adp = new SqlDataAdapter(showcmd);

                DataSet ds = new DataSet();

                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                dgvPharmacist.DataSource = dt;

                dgvPharmacist.AutoGenerateColumns = true;
            }

            conn.Close();



        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           
            txtName.Text = "";
            txtUsername.Text = "";
            txtPhone.Text = "";
            txtPassword.Text = "";
            txtSalary.Text = "";
            txtAnswer.Text = "";

            rtxtAddress.Text = "";

            cmbQuestion.SelectedIndex = -1;

            rdoMale.Checked = false;
            rdoFemale.Checked = false;
        }

        private void dgvPharmacist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            txtName.Text = dgvPharmacist.Rows[e.RowIndex].Cells[0].Value.ToString();

            txtPhone.Text = dgvPharmacist.Rows[e.RowIndex].Cells[1].Value.ToString();

            txtUsername.Text = dgvPharmacist.Rows[e.RowIndex].Cells[2].Value.ToString();

            oldusername = txtUsername.Text;

            rtxtAddress.Text = dgvPharmacist.Rows[e.RowIndex].Cells[3].Value.ToString();

            cmbQuestion.Text = dgvPharmacist.Rows[e.RowIndex].Cells[4].Value.ToString();

            txtAnswer.Text = dgvPharmacist.Rows[e.RowIndex].Cells[5].Value.ToString();

            txtPassword.Text = dgvPharmacist.Rows[e.RowIndex].Cells[6].Value.ToString();



            string gender = dgvPharmacist.Rows[e.RowIndex].Cells[8].Value.ToString();

            if (gender == "Male")
            {
                rdoMale.Checked = true;
            }

            if (gender == "Female")
            {
                rdoFemale.Checked = true;
            }

            txtSalary.Text = dgvPharmacist.Rows[e.RowIndex].Cells[9].Value.ToString();

        }

        private void dgvPharmacist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
