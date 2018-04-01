using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RmsPrinting
{
    static class Program
    {

        public static MySqlConnection GlobalConn = new MySqlConnection();
        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }

        public static void saveDTtoFile(DataTable dt, string FileNameWithPath)
        {
            try
            {
                FileStream fs = new FileStream(FileNameWithPath, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, dt);
                fs.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Occurred: " + ex.Message);
            }

        }

        public static DataTable loadDTfromFile(string FileNameWithPath)
        {
            FileStream fs = null;
            try
            {
                DataTable dt = new DataTable();
                fs = new FileStream(FileNameWithPath, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                dt = (DataTable)bf.Deserialize(fs);
                fs.Close();
                return dt;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Occurred: " + ex.Message);
                if (fs != null)
                    fs.Close();
                return null;
            }

        }
    }
}
