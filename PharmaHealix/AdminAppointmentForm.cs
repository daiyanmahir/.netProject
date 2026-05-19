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
    public partial class AdminAppointmentForm : Form
    {
        Db db = new Db();
        int id;

        public AdminAppointmentForm()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            AdminDoctorForm form = new AdminDoctorForm();
            form.Show();
            this.Hide();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            AdminPatientForm form = new AdminPatientForm();
            form.Show();
            this.Hide();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            AdminInventoryForm form = new AdminInventoryForm();
            form.Show();
            this.Hide();
        }



        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            AdminDoctorForm doctorForm = new AdminDoctorForm();
            doctorForm.Show();
            this.Hide();
        }

        private void btnPharmacist_Click(object sender, EventArgs e)
        {
            AdminPharmacistForm pharmacistForm = new AdminPharmacistForm();
            pharmacistForm.Show();
            this.Hide();
        }

        private void btnPatient_Click_1(object sender, EventArgs e)
        {
            AdminPatientForm patientForm = new AdminPatientForm();
            patientForm.Show();
            this.Hide();
        }

        private void btnInventory_Click_1(object sender, EventArgs e)
        {
            AdminInventoryForm inventoryForm = new AdminInventoryForm();
            inventoryForm.Show();
            this.Hide();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Loginform login = new Loginform();
            login.Show();
            this.Hide();
        }

        private void AdminAppointmentForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShow_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(db.connection);

            conn.Open();

            string query = "select * from AppointmentTable";

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            adp.Fill(ds);

            DataTable dt = ds.Tables[0];

            dgvAppointment.DataSource = dt;

            dgvAppointment.AutoGenerateColumns = true;

            conn.Close();
        }

       

        private void btnDelete_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(db.connection);

            conn.Open();

            string statusquery = "select Status from AppointmentTable where AppointmentID=" + id;

            SqlCommand statuscmd = new SqlCommand(statusquery, conn);

            //string status = statuscmd.ExecuteScalar().ToString();

            object resultstatus = statuscmd.ExecuteScalar();

            if (resultstatus == null)
            {
                MessageBox.Show("Please Select Appointment Properly");

                conn.Close();

                return;
            }

            string status = resultstatus.ToString();

            conn.Close();

            if (status != "Pending")
            {
                MessageBox.Show("Only Pending Appointments Can Be Deleted");
                return;
            }

            DialogResult result = MessageBox.Show("Are You Sure?", "Delete", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                conn.Open();

                string query = "Delete from AppointmentTable where AppointmentID=" + id;

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Appointment Deleted");

                string showquery = "select * from AppointmentTable";

                conn.Open();

                SqlCommand showcmd = new SqlCommand(showquery, conn);

                SqlDataAdapter adp = new SqlDataAdapter(showcmd);

                DataSet ds = new DataSet();

                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                dgvAppointment.DataSource = dt;

                dgvAppointment.AutoGenerateColumns = true;

                conn.Close();

            }
        }

        private void dgvAppointment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }


            id = Convert.ToInt32(dgvAppointment.Rows[e.RowIndex].Cells[0].Value);


        }
    }
}

    

