using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaHealix
{
    public partial class Medicine : Form
    {
        public Medicine()
        {
            InitializeComponent();
        }
        

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void medilogobtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm m = new MainForm("");
            m.Show();
        }
        public void Close(bool t)
        {
            if (t)
            {
                this.Close();
            }
        }
    }
}
