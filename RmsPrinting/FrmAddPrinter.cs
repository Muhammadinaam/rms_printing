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
    public partial class FrmAddPrinter : Form
    {
        public FrmAddPrinter()
        {
            InitializeComponent();
        }

        private void FrmAddPrinter_Load(object sender, EventArgs e)
        {
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cbx_printers.Items.Add(printer);
            }

            if (cbx_printers.Items.Count > 0)
            {
                cbx_printers.SelectedItem = cbx_printers.Items[0];
            }
            else
                btn_add.Enabled = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
