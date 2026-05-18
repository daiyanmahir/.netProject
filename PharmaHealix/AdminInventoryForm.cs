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



        public AdminInventoryForm()
        {
            InitializeComponent();
        }


        private bool InventoryValidation()
        {
            bool Error = false;

            if (txtMedicineName.Text == "")
            {
                MessageBox.Show("Please Enter Medicine Name");
                Error = true;
            }

            else if (txtMedicineName.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Medicine Name Cannot Contain Numbers");
                Error = true;
            }

            else if (txtCategory.Text == "")
            {
                MessageBox.Show("Please Enter Category");
                Error = true;
            }

            else if (rtxtDescription.Text == "")
            {
                MessageBox.Show("Please Enter Description");
                Error = true;
            }

            else if (txtStripPrice.Text == "")
            {
                MessageBox.Show("Please Enter Strip Price");
                Error = true;
            }

            else if (txtUnitPrice.Text == "")
            {
                MessageBox.Show("Please Enter Unit Price");
                Error = true;
            }

            else if (txtStock.Text == "")
            {
                MessageBox.Show("Please Enter Stock");
                Error = true;
            }

            else if (rtxtDose.Text == "")
            {
                MessageBox.Show("Please Enter Dose");
                Error = true;
            }

            else if (rtxtSideEffect.Text == "")
            {
                MessageBox.Show("Please Enter Side Effect");
                Error = true;
            }

            decimal stripPrice;

            if (decimal.TryParse(txtStripPrice.Text, out stripPrice) == false)
            {
                MessageBox.Show("Strip Price Must Be Number");
                Error = true;
            }

            decimal unitPrice;

            if (decimal.TryParse(txtUnitPrice.Text, out unitPrice) == false)
            {
                MessageBox.Show("Unit Price Must Be Number");
                Error = true;
            }

            int stock;

            if (int.TryParse(txtStock.Text, out stock) == false)
            {
                MessageBox.Show("Stock Must Be Number");
                Error = true;
            }

            else if (stock < 0)
            {
                MessageBox.Show("Stock Cannot Be Negative");
                Error = true;
            }

            else if (stripPrice < 0 || unitPrice < 0)
            {
                MessageBox.Show("Price Cannot Be Negative");
                Error = true;
            }

            else if (dtpExpireDate.Value.Date <= DateTime.Now.Date)
            {
                MessageBox.Show("Expire Date Must Be Future Date");
                Error = true;
            }

            if (Error)
            {
                return false;
            }

            return true;
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
            if (e.RowIndex < 0)
            {
                return;
            }



            txtMedicineName.Text = dgvInventory.Rows[e.RowIndex].Cells[1].Value.ToString();

            txtCategory.Text = dgvInventory.Rows[e.RowIndex].Cells[2].Value.ToString();

            rtxtDescription.Text = dgvInventory.Rows[e.RowIndex].Cells[3].Value.ToString();

            txtStripPrice.Text = dgvInventory.Rows[e.RowIndex].Cells[4].Value.ToString();

            txtUnitPrice.Text = dgvInventory.Rows[e.RowIndex].Cells[5].Value.ToString();

            rtxtDose.Text = dgvInventory.Rows[e.RowIndex].Cells[6].Value.ToString();

            rtxtSideEffect.Text = dgvInventory.Rows[e.RowIndex].Cells[7].Value.ToString();

            txtStock.Text = dgvInventory.Rows[e.RowIndex].Cells[8].Value.ToString();

            dtpExpireDate.Text = dgvInventory.Rows[e.RowIndex].Cells[9].Value.ToString();

            txtImage.Text = dgvInventory.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

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
            if (InventoryValidation() == false)
            {
                return;
            }

            SqlConnection checkconn = new SqlConnection(db.connection);

            checkconn.Open();

            string checkquery = "select count(*) from MedicineTable where MedicineName='" + txtMedicineName.Text + "'";

            SqlCommand checkcmd = new SqlCommand(checkquery, checkconn);

            int count = Convert.ToInt32(checkcmd.ExecuteScalar());

            checkconn.Close();

            if (count > 0)
            {
                MessageBox.Show("Medicine Already Exists");
                return;
            }





            SqlConnection conn = new SqlConnection(db.connection);

            conn.Open();

            decimal stripPrice = Convert.ToDecimal(txtStripPrice.Text);

            decimal unitPrice = Convert.ToDecimal(txtUnitPrice.Text);

            int stock = Convert.ToInt32(txtStock.Text);



            string imagename = txtImage.Text.Replace("'", "''");

            string query = "Insert into MedicineTable(MedicineName,Category,Description,StripPrice,UnitPrice,Dose,SideEffect,Stock,ExpireDate,Image) values('" + txtMedicineName.Text.Replace("'", "''") + "','" + txtCategory.Text.Replace("'", "''") + "','" + rtxtDescription.Text.Replace("'", "''") + "'," + stripPrice + "," + unitPrice + ",'" + rtxtDose.Text.Replace("'", "''") + "','" + rtxtSideEffect.Text.Replace("'", "''") + "'," + stock + ",'" + dtpExpireDate.Value.ToString("yyyy-MM-dd") + "','" + imagename + "')";

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

            if (InventoryValidation() == false)
            {
                return;
            }



            SqlConnection conn = new SqlConnection(db.connection);

            conn.Open();

            decimal stripPrice = Convert.ToDecimal(txtStripPrice.Text);

            decimal unitPrice = Convert.ToDecimal(txtUnitPrice.Text);

            int stock = Convert.ToInt32(txtStock.Text);

            string query = "Update MedicineTable set MedicineName='" + txtMedicineName.Text.Replace("'", "''") + "', Category='" + txtCategory.Text.Replace("'", "''") + "', Description='" + rtxtDescription.Text.Replace("'", "''") + "', StripPrice=" + stripPrice + ", UnitPrice=" + unitPrice + ", Dose='" + rtxtDose.Text.Replace("'", "''") + "', SideEffect='" + rtxtSideEffect.Text.Replace("'", "''") + "', Stock=" + stock + ", ExpireDate='" + dtpExpireDate.Value.ToString("yyyy-MM-dd") + "', Image='" + txtImage.Text.Replace("'", "''") + "' where MedicineName='" + txtMedicineName.Text.Replace("'", "''") + "'";


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

            string query = "Delete from MedicineTable where MedicineName='" + txtMedicineName.Text + "'";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Medicine Deleted");

            btnShow.PerformClick();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {

            txtImage.Text = "";

            txtMedicineName.Text = "";

            txtCategory.Text = "";

            txtStripPrice.Text = "";

            txtUnitPrice.Text = "";

            txtStock.Text = "";

            rtxtDescription.Text = "";

            rtxtDose.Text = "";

            rtxtSideEffect.Text = "";

            dtpExpireDate.Value = DateTime.Now;

           

        }


    }
}

