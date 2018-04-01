using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace RmsPrinting
{
    static class MySqlFunctions
    {

        public static bool SqlNonQuery(string query, MySqlConnection conn)
        {


            MySqlCommand cmd;
            string s0 = query;

            try
            {


                cmd = new MySqlCommand(s0, conn);

                cmd.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred: " + ex.Message);
                return false;
            }
        }

        public static MySqlConnection OpenSqlConnection(string server, string db, string u, string p, string port)
        {
            string connStr = string.Format("server={0};database={1};user={2};port={3};password={4};Allow User Variables=true;", 
                server, db, u, port, p);

            
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {

                conn.Open();

                return conn;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred: " + ex.Message);
                conn.Close(); conn.ClearPoolAsync(conn);
                conn.Dispose();

                return null;
            }
        }

        public static DataTable GetTable(string query, MySqlConnection conn)
        {

            if (conn == null)
            {
                MessageBox.Show("Connection is Null", "Connectivity Error: GetTable()", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable(); //empty datatable
            }

            if (conn.State != ConnectionState.Open)
            {
                
                MessageBox.Show("Connection is not open", "Connectivity Error: GetTable()", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable(); //empty datatable
            }



            DataTable dt = new DataTable();

            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                //da.SelectCommand.CommandTimeout = 0;
                dt.Clear();
                da.Fill(dt);

                

                da.Dispose();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred: " + ex.Message);
                return null;
            }
            
        }
    }
}
