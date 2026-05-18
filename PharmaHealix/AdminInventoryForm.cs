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
    public partial class AdminInventoryForm : Form
    {
        Db db = new Db();

        int id;

        public AdminInventoryForm()
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

       

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            AdminAppointmentForm form = new AdminAppointmentForm();
            form.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminInventoryForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvInventory.Rows[e.RowIndex].Cells[0].Value);

            txtMedicineID.Text = dgvInventory.Rows[e.RowIndex].Cells[0].Value.ToString();

            txtMedicineName.Text = dgvInventory.Rows[e.RowIndex].Cells[1].Value.ToString();

            txtCategory.Text = dgvInventory.Rows[e.RowIndex].Cells[2].Value.ToString();

            rtxtDescription.Text = dgvInventory.Rows[e.RowIndex].Cells[3].Value.ToString();

            txtStripPrice.Text = dgvInventory.Rows[e.RowIndex].Cells[4].Value.ToString();

            txtUnitPrice.Text = dgvInventory.Rows[e.RowIndex].Cells[5].Value.ToString();

            rtxtDose.Text = dgvInventory.Rows[e.RowIndex].Cells[6].Value.ToString();

            rtxtSideEffect.Text = dgvInventory.Rows[e.RowIndex].Cells[7].Value.ToString();

            txtStock.Text = dgvInventory.Rows[e.RowIndex].Cells[8].Value.ToString();

            dtpExpireDate.Text = dgvInventory.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMedicineID.Clear();
            txtMedicineName.Clear();

            dtpExpireDate.Value = DateTime.Now;
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            AdminDoctorForm doctorForm = new AdminDoctorForm();
            doctorForm.Show();
            this.Hide();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

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

        private void btnAppointment_Click_1(object sender, EventArgs e)
        {
            AdminAppointmentForm appointmentForm = new AdminAppointmentForm();
            appointmentForm.Show();
            this.Hide();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Loginform login = new Loginform();
            login.Show();
            this.Hide();
        }

        private void txtMedicineId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(db.connection);

            conn.Open();

            string query = "select * from MedicineTable";

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            adp.Fill(ds);

            DataTable dt = ds.Tables[0];

            dgvInventory.DataSource = dt;

            dgvInventory.AutoGenerateColumns = true;

            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(db.connection);

            conn.Open();

            decimal stripPrice = Convert.ToDecimal(txtStripPrice.Text);

            decimal unitPrice = Convert.ToDecimal(txtUnitPrice.Text);

            int stock = Convert.ToInt32(txtStock.Text);

            string query = "Insert into MedicineTable(MedicineName,Category,Description,StripPrice,UnitPrice,Dose,SideEffect,Stock,ExpireDate,Image) values('" + txtMedicineName.Text + "','" + txtCategory.Text + "','" + rtxtDescription.Text + "'," + stripPrice + "," + unitPrice + ",'" + rtxtDose.Text + "','" + rtxtSideEffect.Text + "'," + stock + ",'" + dtpExpireDate.Value.ToString("yyyy-MM-dd") + "','')";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Medicine Added");

            btnShow.PerformClick();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(db.connection);

            conn.Open();

            decimal stripPrice = Convert.ToDecimal(txtStripPrice.Text);

            decimal unitPrice = Convert.ToDecimal(txtUnitPrice.Text);

            int stock = Convert.ToInt32(txtStock.Text);

            string query = "Update MedicineTable set MedicineName='" + txtMedicineName.Text + "', Category='" + txtCategory.Text + "', Description='" + rtxtDescription.Text + "', StripPrice=" + stripPrice + ", UnitPrice=" + unitPrice + ", Dose='" + rtxtDose.Text + "', SideEffect='" + rtxtSideEffect.Text + "', Stock=" + stock + ", ExpireDate='" + dtpExpireDate.Value.ToString("yyyy-MM-dd") + "' where MedicineID=" + id;

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Medicine Updated");

            btnShow.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(db.connection);

            conn.Open();

            string query = "Delete from MedicineTable where MedicineID=" + id;

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Medicine Deleted");

            btnShow.PerformClick();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtMedicineID.Text = "";

            txtMedicineName.Text = "";

            txtCategory.Text = "";

            txtStripPrice.Text = "";

            txtUnitPrice.Text = "";

            txtStock.Text = "";

            rtxtDescription.Text = "";

            rtxtDose.Text = "";

            rtxtSideEffect.Text = "";

            dtpExpireDate.Value = DateTime.Now;

            picMedicine.Image = null;
        }
    }
    }

