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
    public partial class AdminDoctorForm : Form
    {
        Db db = new Db();

        int id;


        public AdminDoctorForm()
        {
            InitializeComponent();
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

        private void AdminUserForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtUsername.Text = "";
            txtPhone.Text = "";
            txtPassword.Text = "";
            txtFee.Text = "";
            txtAnswer.Text = "";

            rtxtAddress.Text = "";

            cmbQuestion.SelectedIndex = -1;

            rdoMale.Checked = false;
            rdoFemale.Checked = false;

            cbMBBS.Checked = false;
            cbFCPS.Checked = false;
            cbMD.Checked = false;



        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkMD_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnPharmacist_Click(object sender, EventArgs e)
        {
            AdminPharmacistForm pharmacistForm = new AdminPharmacistForm();
            pharmacistForm.Show();
            this.Hide();
        }

        private void txtDoctorID_TextChanged(object sender, EventArgs e)
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

            string query = "select UserTable.Name, UserTable.Phone, UserTable.Username, UserTable.Address, UserTable.Question, UserTable.Answer, UserTable.Password, DoctorTable.DoctorID, DoctorTable.Gender, DoctorTable.Speciality, DoctorTable.Fee from UserTable inner join DoctorTable on UserTable.Username = DoctorTable.Username where UserTable.Role='Doctor'";
             

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            adp.Fill(ds);

            DataTable dt = ds.Tables[0];

            dgvDoctor.DataSource = dt;

            dgvDoctor.AutoGenerateColumns = true;

            conn.Close();
        }

        private bool DoctorValidation()
        {
            if (txtName.Text == "" ||
                txtUsername.Text == "" ||
                txtPhone.Text == "" ||
                txtPassword.Text == "" ||
                txtFee.Text == "" ||
                txtAnswer.Text == "" ||
                rtxtAddress.Text == "")
            {
                MessageBox.Show("Please Fill All Information");
                return false;
            }

            if (rdoMale.Checked == false && rdoFemale.Checked == false)
            {
                MessageBox.Show("Please Select Gender");
                return false;
            }

            if (cbMBBS.Checked == false &&
                cbFCPS.Checked == false &&
                cbMD.Checked == false)
            {
                MessageBox.Show("Please Select Degree");
                return false;
            }

            if (cmbQuestion.Text == "")
            {
                MessageBox.Show("Please Select Question");
                return false;
            }

            decimal fee;

            if (decimal.TryParse(txtFee.Text, out fee) == false)
            {
                MessageBox.Show("Fee Must Be Number");
                return false;
            }

            return true;
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



            SqlConnection conn = new SqlConnection(db.connection);

            conn.Open();


            if (DoctorValidation() == false)
            {
                return;
            }


            string speciality = "";

            if (cbMBBS.Checked)
            {
                speciality = "MBBS";
            }

            if (cbFCPS.Checked)
            {
                speciality += " FCPS";
            }

            if (cbMD.Checked)
            {
                speciality += " MD";
            }

            string query1 = "Insert into UserTable(Name,Phone,Username,Address,Question,Answer,Password,Role) values('" + txtName.Text + "','" + txtPhone.Text + "','" + txtUsername.Text + "','" + rtxtAddress.Text + "','" + cmbQuestion.Text + "','" + txtAnswer.Text + "','" + txtPassword.Text + "','Doctor')";

            SqlCommand cmd1 = new SqlCommand(query1, conn);

            cmd1.ExecuteNonQuery();

            decimal fee = Convert.ToDecimal(txtFee.Text);

            string query2 = "Insert into DoctorTable(Username,Gender,Speciality,Fee) values('" + txtUsername.Text + "','" + gender + "','" + speciality + "'," + fee + ")";

            SqlCommand cmd2 = new SqlCommand(query2, conn);

            cmd2.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Doctor Added");
            txtName.Text = "";
            txtUsername.Text = "";
            txtPhone.Text = "";
            txtPassword.Text = "";
            txtFee.Text = "";
            txtAnswer.Text = "";
            rtxtAddress.Text = "";

            rdoMale.Checked = false;
            rdoFemale.Checked = false;

            cbMBBS.Checked = false;
            cbFCPS.Checked = false;
            cbMD.Checked = false;

            cmbQuestion.SelectedIndex = -1;
        }

        private void dgvDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvDoctor.Rows[e.RowIndex].Cells[7].Value);

            txtName.Text = dgvDoctor.Rows[e.RowIndex].Cells[0].Value.ToString();

            txtPhone.Text = dgvDoctor.Rows[e.RowIndex].Cells[1].Value.ToString();

            txtUsername.Text = dgvDoctor.Rows[e.RowIndex].Cells[2].Value.ToString();

            rtxtAddress.Text = dgvDoctor.Rows[e.RowIndex].Cells[3].Value.ToString();

            cmbQuestion.Text = dgvDoctor.Rows[e.RowIndex].Cells[4].Value.ToString();

            txtAnswer.Text = dgvDoctor.Rows[e.RowIndex].Cells[5].Value.ToString();

            txtPassword.Text = dgvDoctor.Rows[e.RowIndex].Cells[6].Value.ToString();

            string gender = dgvDoctor.Rows[e.RowIndex].Cells[8].Value.ToString();

            if (gender == "Male")
            {
                rdoMale.Checked = true;
            }

            if (gender == "Female")
            {
                rdoFemale.Checked = true;
            }

            string speciality = dgvDoctor.Rows[e.RowIndex].Cells[9].Value.ToString();

            if (speciality.Contains("MBBS"))
            {
                cbMBBS.Checked = true;
            }

            if (speciality.Contains("FCPS"))
            {
                cbFCPS.Checked = true;
            }

            if (speciality.Contains("MD"))
            {
                cbMD.Checked = true;
            }

            txtFee.Text = dgvDoctor.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (DoctorValidation() == false)
            {
                return;
            }



            SqlConnection conn = new SqlConnection(db.connection);

            conn.Open();

            string gender = "";

            if (rdoMale.Checked)
            {
                gender = "Male";
            }

            if (rdoFemale.Checked)
            {
                gender = "Female";
            }

            string speciality = "";

            if (cbMBBS.Checked)
            {
                speciality = "MBBS";
            }

            if (cbFCPS.Checked)
            {
                speciality += " FCPS";
            }

            if (cbMD.Checked)
            {
                speciality += " MD";
            }

            string query1 = "Update UserTable set Name='" + txtName.Text + "', Phone='" + txtPhone.Text + "', Address='" + rtxtAddress.Text + "', Question='" + cmbQuestion.Text + "', Answer='" + txtAnswer.Text + "', Password='" + txtPassword.Text + "' where Username='" + txtUsername.Text + "'";

            SqlCommand cmd1 = new SqlCommand(query1, conn);

            cmd1.ExecuteNonQuery();

             

            decimal fee;

            if (decimal.TryParse(txtFee.Text, out fee) == false)
            {
                MessageBox.Show("Fee Must Be Number");
                return;
            }

           


            string query2 = "Update DoctorTable set Gender='" + gender + "', Speciality='" + speciality + "', Fee=" + fee + " where DoctorID=" + id;

            SqlCommand cmd2 = new SqlCommand(query2, conn);

            cmd2.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Doctor Updated");

            btnShow.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(db.connection);

            conn.Open();

            string query1 = "Delete from DoctorTable where DoctorID=" + id;

            SqlCommand cmd1 = new SqlCommand(query1, conn);

            cmd1.ExecuteNonQuery();

            string query2 = "Delete from UserTable where Username='" + txtUsername.Text + "'";

            SqlCommand cmd2 = new SqlCommand(query2, conn);

            cmd2.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Doctor Deleted");

            btnShow.PerformClick();
        }
    }
    }

