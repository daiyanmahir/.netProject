using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PharmaHealix
{
    public partial class AdminPharmacistForm : Form
    {
        Db db = new Db();

        int id;

        public AdminPharmacistForm()
        {
            InitializeComponent();


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
            string gender = "";

            if (rdoMale.Checked)
            {
                gender = "Male";
            }

            if (rdoFemale.Checked)
            {
                gender = "Female";
            }

            if (txtName.Text == "" ||
                txtUsername.Text == "" ||
                txtPhone.Text == "" ||
                txtPassword.Text == "" ||
                txtSalary.Text == "" ||
                cmbQuestion.Text == "" ||
                txtAnswer.Text == "" ||
                rtxtAddress.Text == "")
            {
                MessageBox.Show("Please Fill All Information");

                return;
            }

            decimal salary;

            if (!decimal.TryParse(txtSalary.Text, out salary))
            {
                MessageBox.Show("Salary Must Be Number");

                return;
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

            txtStaffID.Text = "";
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

        private void dgvPharmacist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvPharmacist.Rows[e.RowIndex].Cells[7].Value);

            txtName.Text = dgvPharmacist.Rows[e.RowIndex].Cells[0].Value.ToString();

            txtPhone.Text = dgvPharmacist.Rows[e.RowIndex].Cells[1].Value.ToString();

            txtUsername.Text = dgvPharmacist.Rows[e.RowIndex].Cells[2].Value.ToString();

            rtxtAddress.Text = dgvPharmacist.Rows[e.RowIndex].Cells[3].Value.ToString();

            cmbQuestion.Text = dgvPharmacist.Rows[e.RowIndex].Cells[4].Value.ToString();

            txtAnswer.Text = dgvPharmacist.Rows[e.RowIndex].Cells[5].Value.ToString();

            txtPassword.Text = dgvPharmacist.Rows[e.RowIndex].Cells[6].Value.ToString();

            txtStaffID.Text = dgvPharmacist.Rows[e.RowIndex].Cells[7].Value.ToString();

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
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

            string query1 = "Update UserTable set Name='" + txtName.Text + "', Phone='" + txtPhone.Text + "', Address='" + rtxtAddress.Text + "', Question='" + cmbQuestion.Text + "', Answer='" + txtAnswer.Text + "', Password='" + txtPassword.Text + "' where Username='" + txtUsername.Text + "'";

            SqlCommand cmd1 = new SqlCommand(query1, conn);

            cmd1.ExecuteNonQuery();

            string query2 = "Update StaffTable set Gender='" + gender + "', Salary='" + txtSalary.Text + "' where StaffID=" + id;

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

            string query1 = "Delete from StaffTable where StaffID=" + id;

            SqlCommand cmd1 = new SqlCommand(query1, conn);

            cmd1.ExecuteNonQuery();

            string query2 = "Delete from UserTable where Username='" + txtUsername.Text + "'";

            SqlCommand cmd2 = new SqlCommand(query2, conn);

            cmd2.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Pharmacist Deleted");

            txtStaffID.Text = "";
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStaffID.Text = "";
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
    }
}
