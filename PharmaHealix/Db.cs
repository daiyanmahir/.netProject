using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaHealix
{
    internal sealed class Db
    {  
        public Db() 
        {

        }
        public void NonQuery(string query)
        {

            //1. Address
            string connection = "Data Source=LAPTOP-5SNR2K20\\SQLEXPRESS;Initial Catalog=PharmaHealix;Integrated Security=True;Trust Server Certificate=True;";
            //2. Establish Connection

            SqlConnection con = new SqlConnection(connection);

            //3. Open Connection

            con.Open();

            //4.Prepare Query

            SqlCommand cmd = new SqlCommand(query, con);
            //5.Execute Query

            cmd.ExecuteNonQuery();


            //6.Close Connection


        }
     /*   public void Scalar(string query)
        {

            //1 Address
            string connection = "Data Source=LAPTOP-5SNR2K20\\SQLEXPRESS;Initial Catalog=PharmaHealix;Integrated Security=True;Trust Server Certificate=True;";
            //2 Establish Connection

            SqlConnection con = new SqlConnection(connection);

            //3.Open Connection

            con.Open();

            //4.Prepare Query
            SqlCommand cmd = new SqlCommand(query, con);
            //5.Execute Query
        }
        public void Reader(string query)
        {

            //1 Address
            string connection = "Data Source=LAPTOP-5SNR2K20\\SQLEXPRESS;Initial Catalog=PharmaHealix;Integrated Security=True;Trust Server Certificate=True;";
            //2 Establish Connection

            SqlConnection con = new SqlConnection(connection);

            //3.Open Connection

            con.Open();

            //4.Prepare Query
            SqlCommand cmd = new SqlCommand(query, con);
            //5.Execute Query
        }
     */

    }

}
