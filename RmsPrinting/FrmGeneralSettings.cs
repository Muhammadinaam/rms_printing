using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RmsPrinting
{
    public partial class FrmGeneralSettings : Form
    {
        string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

        public FrmGeneralSettings()
        {
            InitializeComponent();

            try
            {
                rtxbHeader.LoadFile(path + "/header.txt");
                rtxbFooter.LoadFile(path + "/footer.txt");
            }
            catch (Exception)
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            rtxbHeader.SaveFile(path + "/header.txt");
            rtxbFooter.SaveFile(path + "/footer.txt");
        }
    }
}
