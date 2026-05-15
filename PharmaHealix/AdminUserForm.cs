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
    public partial class AdminUserForm : Form
    {
        public AdminUserForm()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            // Already on User page
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            AdminPatientForm form = new AdminPatientForm();
            form.Show();
            this.Hide();
        }

        private void btnInventory_Click(object sender, EventArgs e)
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

        private void AdminUserForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtEmail.Clear();

            cmbDepartment.SelectedIndex = -1;

            chkMBBS.Checked = false;
            chkFCPS.Checked = false;
            chkMD.Checked = false;
            chkBPharm.Checked = false;

            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            rdoOther.Checked = false;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
