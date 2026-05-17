using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PharmaHealix
{
    internal sealed class Db
    {
        //1. Address

        //public string connection = "Data Source=DESKTOP-5903S8A\\SQLEXPRESS;Initial Catalog=PharmaHealix;Integrated Security=True; TrustServerCertificate=True;";//Abid

        public string connection = "Data Source=LAPTOP-5SNR2K20\\SQLEXPRESS;Initial Catalog=PharmaHealix;Integrated Security=True; TrustServerCertificate=True;";

        //string connection = "Data Source=LAPTOP-5SNR2K20\\SQLEXPRESS;Initial Catalog=PharmaHealix;Integrated Security=True;";

        public Db() 
        {

        }
        public void NonQuery(string query,params Object[] p)
        {
            //2. Establish Connection

            SqlConnection con = new SqlConnection(connection);

            try
            {
                

                //3. Open Connection

                con.Open();

                //4.Prepare Query

                SqlCommand cmd = new SqlCommand(query, con);
                //5.Execute Query
                for (int i = 0; i < p.Length; i++)
                {
                    cmd.Parameters.AddWithValue("@" + i, p[i]);
                }

                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show("An Error Occurred" + e.Message);

            }
            finally
            {
                //6.Close Connection
                con.Close();
            }
        }
        public object Scalar(string query,params Object[] p)
        {

            //2 Establish Connection

            SqlConnection con = new SqlConnection(connection);

            try
            {
                //3.Open Connection

                con.Open();

                //4.Prepare Query
                SqlCommand cmd = new SqlCommand(query, con);
                for (int i = 0; i < p.Length; i++)
                {
                    cmd.Parameters.AddWithValue("@" + i, p[i]);
                }

                //5.Execute Query

                return cmd.ExecuteScalar();
            }
     
            catch (Exception e)
            {
                MessageBox.Show("An Error Occurred" + e.Message);
                return null;
            }
            finally
            {
                //6.Close Connection
                con.Close();

            }


        }

        public DataTable Reader(string query, params object[] p)
        {
            //2. Establish Connection
            SqlConnection con = new SqlConnection(connection);

            try
            {
                //3. Open Connection
                con.Open();

                //4. Prepare Connection
                SqlCommand cmd = new SqlCommand(query, con);

                for (int i = 0; i < p.Length; i++)
                {
                    cmd.Parameters.AddWithValue("@" + i, p[i]);
                }

                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                adp.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("An Error Occurred"+e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

    }

}
