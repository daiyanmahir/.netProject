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
    public partial class AdminPatientForm : Form
    {
        public AdminPatientForm()
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
            // Already on Patient page
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            AdminInventoryForm form = new AdminInventoryForm();
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
    }
}
