using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaHealix
{
    public partial class AdminInventoryForm : Form
    {
        public AdminInventoryForm()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            AdminUserForm form = new AdminUserForm();
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
            // Already on Inventory page
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

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMedicineId.Clear();
            txtMedicineName.Clear();

            dtpExpiryDate.Value = DateTime.Now;
        }
    }
    }
}
