using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace RmsPrinting
{
    public partial class FrmConnectionSettings : Form
    {
        public FrmConnectionSettings()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

                config.AppSettings.Settings.Remove("server");
                config.AppSettings.Settings.Add("server", txb_server.Text);

                config.AppSettings.Settings.Remove("port");
                config.AppSettings.Settings.Add("port", txb_port.Text);

                config.AppSettings.Settings.Remove("user");
                config.AppSettings.Settings.Add("user", txb_username.Text);

                config.AppSettings.Settings.Remove("password");
                config.AppSettings.Settings.Add("password", txb_password.Text != "" ? StringCipher.Encrypt(txb_server.Text, "abc") : "");

                config.AppSettings.Settings.Remove("database");
                config.AppSettings.Settings.Add("database", txb_database.Text);

                config.Save(ConfigurationSaveMode.Minimal);

                MessageBox.Show("Saved");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Occurred: " + ex.Message);
            }

            
        }

        private void FrmConnectionSettings_Load(object sender, EventArgs e)
        {
            ConfigurationManager.RefreshSection("appSettings");
            try
            {
                txb_server.Text = ConfigurationManager.AppSettings.Get("server");
                txb_port.Text = ConfigurationManager.AppSettings.Get("port");
                txb_username.Text = ConfigurationManager.AppSettings.Get("user");

                string password = ConfigurationManager.AppSettings.Get("password");
                txb_password.Text = password != "" ? StringCipher.Decrypt(password, "abc") : "";
                txb_database.Text = ConfigurationManager.AppSettings.Get("database");
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error Occurred: " + ex.Message);
                
            }

            
        }
    }
}
