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
    public partial class AdminDoctorForm : Form
    {
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
            txtDoctorID.Clear();
            txtDoctorName.Clear();
            

            cmbDepartment.SelectedIndex = -1;

            chkMBBS.Checked = false;
            chkFCPS.Checked = false;
            chkMD.Checked = false;
            
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            
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
    }
}
