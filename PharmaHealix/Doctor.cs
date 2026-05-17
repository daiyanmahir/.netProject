using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace PharmaHealix
{
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 240, 230, 210);

            foreach (TabPage tab in tabControl1.TabPages)
            {
                tab.BackColor = Color.Transparent; // Sets each page to transparent
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabRecords;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPrescription;
        }

        private void medbtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabAvailability;
        }

        private void headpan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabAvailability_Click(object sender, EventArgs e)
        {

        }

        private void dgvAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSendPrescription_Click(object sender, EventArgs e)
        {
            lblMedicineError.Visible = false;
            lblDosageError.Visible = false;
            lblFrequencyError.Visible = false;
            lblQuantityError.Visible = false;
            lblRouteError.Visible = false;
            lblDiagnosisError.Visible = false;

            // Create a flag tracking if the entire form is valid
            bool isValid = true;

            // 2. Validate Medicine Dropdown Selection
            if (cbMedicineList.SelectedIndex == -1)
            {
                lblMedicineError.Visible = true;
                isValid = false;
            }

            // 3. Validate Dosage Text
            if (string.IsNullOrWhiteSpace(txtDosage.Text))
            {
                lblDosageError.Visible = true;
                isValid = false;
            }

            // 4. Validate Frequency Text
            if (string.IsNullOrWhiteSpace(txtFrequency.Text))
            {
                lblFrequencyError.Visible = true;
                isValid = false;
            }

            // 5. Validate Quantity (Must be a valid positive integer)
            if (!int.TryParse(txtQuantity.Text, out int qty) || qty <= 0)
            {
                lblQuantityError.Visible = true;
                isValid = false;
            }

            // 6. Validate Route Dropdown Selection
            if (cbRoute.SelectedIndex == -1)
            {
                lblRouteError.Visible = true;
                isValid = false;
            }

            // 7. Validate Diagnosis Field
            if (string.IsNullOrWhiteSpace(txtDiagnosis.Text))
            {
                lblDiagnosisError.Visible = true;
                isValid = false;
            }

            // 8. Block execution if any validation checks failed
            if (!isValid)
            {
                return; // Stops right here, leaving the red error labels visible for the doctor to fix
            }
        }
    }
}
