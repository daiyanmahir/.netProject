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
    public partial class AdminAppointmentForm : Form
    {
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
    }
    }
    }

