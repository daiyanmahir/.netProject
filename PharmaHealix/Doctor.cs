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

        private void reportsbtn_Click(object sender, EventArgs e)
        {
            //tabControl1.SelectedTab = tabReports;
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
    }
}
