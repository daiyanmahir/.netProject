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
using Microsoft.Data.SqlClient;


namespace PharmaHealix
{
    public partial class Doctor : Form
    {
        private string selectedAppointmentID = "";
        private string selectedPatientUsername = "";
        private Db database = new Db();

        private string currentDoctorId;

        public Doctor(string doctorId)
        {
            InitializeComponent();
            this.currentDoctorId = doctorId;
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 240, 230, 210);

            foreach (TabPage tab in tabControl1.TabPages)
            {
                tab.BackColor = Color.Transparent; 
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

            
            if (string.IsNullOrWhiteSpace(txtSelectedID.Text) || string.IsNullOrWhiteSpace(txtSelectedName.Text))
            {
                MessageBox.Show("No active patient selected! Please select a patient from the 'Check Appointments' tab first.", "Execution Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isValid = true;


            if (string.IsNullOrWhiteSpace(txtMedicineName.Text))
            {
                lblMedicineError.Visible = true;
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtDosage.Text))
            {
                lblDosageError.Visible = true;
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtFrequency.Text))
            {
                lblFrequencyError.Visible = true;
                isValid = false;
            }

            if (!int.TryParse(txtQuantity.Text, out int qty) || qty <= 0)
            {
                lblQuantityError.Visible = true;
                isValid = false;
            }

            if (cbRoute.SelectedIndex == -1)
            {
                lblRouteError.Visible = true;
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtDiagnosis.Text))
            {
                lblDiagnosisError.Visible = true;
                isValid = false;
            }
            if (!isValid)
            {
                return; 
            }

            
            string usageInstructions = string.IsNullOrWhiteSpace(rtbUsageInstructions.Text) ? "None" : rtbUsageInstructions.Text.Trim();
            string pharmacistNotes = string.IsNullOrWhiteSpace(rtbPharmacistNote.Text) ? "None" : rtbPharmacistNote.Text.Trim();

            
            string commaSeparatedPrescriptionText = $"{txtDiagnosis.Text.Trim()}, {txtMedicineName.Text.Trim()}, {txtDosage.Text.Trim()}, {txtFrequency.Text.Trim()}, {qty}, {cbRoute.SelectedItem}, {usageInstructions}, {pharmacistNotes}";

            string insertPrescriptionQuery = @"INSERT INTO PrescriptionTable (AppointmentID, DoctorID, PatientUsername, PrescriptionText, PrescriptionDate) 
                                               VALUES (@AppointmentID, @DoctorID, @PatientUsername, @PrescriptionText, GETDATE())";
            string updateStatusQuery = @"UPDATE AppointmentTable 
                                         SET Status = 'Complete' 
                                         WHERE AppointmentID = @AppointmentID";
            using (SqlConnection conn = new SqlConnection(new Db().connection))
            {
                try
                {
                    conn.Open();

                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            
                            int currentAppointmentID = Convert.ToInt32(txtSelectedID.Text.Trim());

                            using (SqlCommand insertCmd = new SqlCommand(insertPrescriptionQuery, conn, transaction))
                            {
                                insertCmd.Parameters.AddWithValue("@AppointmentID", currentAppointmentID);
                                insertCmd.Parameters.AddWithValue("@DoctorID", currentDoctorId); // Default query identity index placeholder
                                insertCmd.Parameters.AddWithValue("@PatientUsername", txtSelectedName.Text.Trim()); // FIX: Use txtSelectedName
                                insertCmd.Parameters.AddWithValue("@PrescriptionText", commaSeparatedPrescriptionText);
                                insertCmd.ExecuteNonQuery();
                            }

                            using (SqlCommand updateCmd = new SqlCommand(updateStatusQuery, conn, transaction))
                            {
                                updateCmd.Parameters.AddWithValue("@AppointmentID", currentAppointmentID);
                                updateCmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Prescription successfully saved and appointment status updated to 'Complete'!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClearPrescriptionForm();

                            btnRefreshAppts_Click(sender, e);
                        }
                        catch (Exception ex)
                        { 
                            transaction.Rollback();
                            throw new Exception("Transaction processing execution failed. Reverting structural updates. Details: " + ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Processing Error: " + ex.Message, "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ClearPrescriptionForm()
        {
            txtPatientID.Clear();
            txtPatientName.Clear();
            txtDiagnosis.Clear();
            txtDosage.Clear();
            txtFrequency.Clear();
            txtQuantity.Clear();
            rtbUsageInstructions.Clear();
            rtbPharmacistNote.Clear();
            txtMedicineName.Clear();
            cbRoute.SelectedIndex = -1;
            txtCurrentDate.Value = DateTime.Today;
            selectedAppointmentID = "";
            selectedPatientUsername = "";

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void checkappbtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabAppointments;
        }
        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show(
            "Are you sure you want to log out of the PharmaHealix system?",
            "Confirm Logout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );
            if (confirmResult == DialogResult.Yes)
            {
                Loginform loginScreen = new Loginform();
                loginScreen.Show();
                this.Close();
            }
        }
        private void btnRefreshAppts_Click(object sender, EventArgs e)
        {
            string selectedDate = dtpFilterDate.Value.ToString("yyyy-MM-dd");

            string query = @"SELECT AppointmentID, PatientUsername, AppointmentTime, Status 
                             FROM AppointmentTable 
                             WHERE AppointmentDate = @AppointmentDate AND DoctorID = @DoctorID";

            using (SqlConnection conn = new SqlConnection(new Db().connection))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@AppointmentDate", selectedDate);
                    adapter.SelectCommand.Parameters.AddWithValue("@DoctorID", currentDoctorId);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvPatientSchedule.DataSource = dt;
                    lblApptCount.Text = dt.Rows.Count.ToString();

                    if (dgvPatientSchedule.Columns.Count > 0)
                    {
                        dgvPatientSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading schedule: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dgvPatientSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPatientSchedule.Rows[e.RowIndex];
                
                selectedAppointmentID = row.Cells["AppointmentID"].Value.ToString();
                selectedPatientUsername = row.Cells["PatientUsername"].Value.ToString();  
                
            }
        }
        private void btnStartConsultation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedAppointmentID))
            {
                MessageBox.Show("Please select a patient from the schedule list first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tabControl1.SelectedTab = tabPrescription;

            txtSelectedName.Text = selectedPatientUsername;
            txtSelectedID.Text = selectedAppointmentID;

        }
        private void btnCancelAppt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedAppointmentID))
            {
                MessageBox.Show("Please select an appointment record row first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult confirm = MessageBox.Show("Are you sure you want to cancel this appointment tracking entry?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;
            string updateQuery = "UPDATE AppointmentTable SET Status = 'Cancelled' WHERE AppointmentID = @AppointmentID";
            using (SqlConnection conn = new SqlConnection(new Db().connection))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@AppointmentID", selectedAppointmentID);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Appointment tracking record updated to 'Cancelled'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnRefreshAppts_Click(sender, e);
                    selectedAppointmentID = "";
                    selectedPatientUsername = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to save tracking adjustments: " + ex.Message, "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }





        
        private void LoadMedicineStock(string searchToken)
        {
            string medicineQuery = @"SELECT MedicineID, MedicineName, Category, Stock, UnitPrice 
                                     FROM MedicineTable";

            if (!string.IsNullOrWhiteSpace(searchToken))
            {
                medicineQuery += " WHERE MedicineName LIKE @SearchToken OR MedicineID LIKE @SearchToken";
            }

            using (SqlConnection conn = new SqlConnection(new Db().connection))
            {
                try
                {
                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(medicineQuery, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(searchToken))
                        {
                            adapter.SelectCommand.Parameters.AddWithValue("@SearchToken", "%" + searchToken.Trim() + "%");
                        }

                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvInventory.DataSource = dt;

                        if (dgvInventory.Columns.Count > 0)
                        {
                            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading inventory database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnStockSearch_Click(object sender, EventArgs e)
        {
            LoadMedicineStock(txtSearchMedicine.Text);
        }

        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string selectedMedID = dgvInventory.Rows[e.RowIndex].Cells["MedicineID"].Value.ToString();

                string detailQuery = "SELECT MedicineName, Description, SideEffect FROM MedicineTable WHERE MedicineID = @MedicineID";

                using (SqlConnection conn = new SqlConnection(new Db().connection))
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(detailQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@MedicineID", selectedMedID);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    txtGenericName.Text = reader["MedicineName"].ToString();
                                    rtbDescription.Text = reader["Description"].ToString();
                                    rtbSideEffects.Text = reader["SideEffect"].ToString();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error pulling descriptive payload data details: " + ex.Message, "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }






        private void LoadPrescriptionData(string searchName = "")
        {
            string query = @"SELECT 
            p.PrescriptionID AS [Prescription ID],
            u.Name AS [Patient Name],
            p.PatientUsername AS [Patient Username],
            p.AppointmentID AS [Appointment ID],
            p.PrescriptionText AS [Prescription Details],
            p.PrescriptionDate AS [Date Prescribed]
            FROM PrescriptionTable p
            INNER JOIN UserTable u ON p.PatientUsername = u.Username
            WHERE p.DoctorID = @DoctorID";

            if (!string.IsNullOrEmpty(searchName))
            {
                query += " AND u.Name LIKE @SearchName";
            }

            query += " ORDER BY p.PrescriptionDate DESC";

           

            using (SqlConnection conn = new SqlConnection(new Db().connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DoctorID", currentDoctorId);
                    if (!string.IsNullOrEmpty(searchName))
                    {
                        cmd.Parameters.AddWithValue("@SearchName", "%" + searchName.Trim() + "%");
                    }

                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error displaying patient records: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                if (selectedRow.Cells["Patient Name"].Value != null)
                {
                    txtPatientName.Text = selectedRow.Cells["Patient Name"].Value.ToString();
                    txtPatientID.Text = selectedRow.Cells["Patient Username"].Value.ToString();
                    rtbMedicalHistory.Text = selectedRow.Cells["Prescription Details"].Value.ToString();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchPatient.Text.Trim();
            LoadPrescriptionData(searchTerm);
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearchPatient.Clear();
            txtPatientName.Clear();
            txtPatientID.Clear();
            rtbMedicalHistory.Clear();

            dataGridView1.ClearSelection();
            LoadPrescriptionData();
        }
    }
}