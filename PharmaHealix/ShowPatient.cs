using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaHealix
{
    public partial class ShowPatient : Form
    {
        public ShowPatient()
        {
            InitializeComponent();
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            String Query = "Select * From UserTable;";

            //1 Address
            string connection = "Data Source=LAPTOP-5SNR2K20\\SQLEXPRESS;Initial Catalog=PharmaHealix;Integrated Security=True;";
            //2 Establish Connection

            SqlConnection con = new SqlConnection(connection);


            //3.Open Connection
            try
            {
                con.Open();

                //4.Prepare Query
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView.DataSource = dt;
                dataGridView.AutoGenerateColumns = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Wrong!Please try again." + ex);
            }
            finally
            {
                con.Close();
            }


    }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
