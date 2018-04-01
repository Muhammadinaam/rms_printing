using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Configuration;

namespace RmsPrinting
{
    public partial class FrmPrinters : Form
    {
        DataTable pos_printers_dt = new DataTable();
        DataTable kitchen_printers_dt = new DataTable();

        public FrmPrinters()
        {
            InitializeComponent();
        }

        private void FrmPrinters_Load(object sender, EventArgs e)
        {
            pos_printers_dt.Columns.Add("Printer"); 
            kitchen_printers_dt.Columns.Add("Category");
            kitchen_printers_dt.Columns.Add("Printer");

            dgv_pos_printers.DataSource = pos_printers_dt;
            dgv_kitchen_printers.DataSource = kitchen_printers_dt;

            
            try
            {
                string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

                string pos_printers = path + @"/pos_printers.dat";
                string kitchen_printers = path + @"/kitchen_printers.dat";

                DataTable pos_printers_dt_load = Program.loadDTfromFile(pos_printers);
                DataTable kitchen_printers_dt_load = Program.loadDTfromFile(kitchen_printers);

                if (pos_printers_dt_load != null)
                {
                    pos_printers_dt = pos_printers_dt_load;
                }

                if (kitchen_printers_dt_load != null)
                {
                    kitchen_printers_dt = kitchen_printers_dt_load;
                }

                dgv_pos_printers.DataSource = pos_printers_dt;
                dgv_kitchen_printers.DataSource = kitchen_printers_dt;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Occurred: " + ex.Message);
            }
        }

        private void btn_add_pos_printer_Click(object sender, EventArgs e)
        {
            FrmAddPrinter f = new FrmAddPrinter();
            f.txb_category.ReadOnly = true;
            if (f.ShowDialog() == DialogResult.OK)
            {
                
                pos_printers_dt.Rows.Add( f.cbx_printers.SelectedItem );
                
            }
        }

        private void btn_remove_pos_printer_Click(object sender, EventArgs e)
        {
            if (dgv_pos_printers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select printer to delete");
                return;
            }

            if (MessageBox.Show("Are you sure?", "Delte Printer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dgv_pos_printers.Rows.Remove(dgv_pos_printers.SelectedRows[0]);
            }
        }

        private void btn_add_kitchen_printer_Click(object sender, EventArgs e)
        {
            FrmAddPrinter f = new FrmAddPrinter();
            if (f.ShowDialog() == DialogResult.OK)
            {
                
                kitchen_printers_dt.Rows.Add(f.txb_category.Text, f.cbx_printers.SelectedItem);

            }
        }

        private void btn_remove_kitchen_printer_Click(object sender, EventArgs e)
        {
            if (dgv_kitchen_printers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select printer to delete");
                return;
            }

            if (MessageBox.Show("Are you sure?", "Delte Printer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dgv_kitchen_printers.Rows.Remove(dgv_kitchen_printers.SelectedRows[0]);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

            string pos_printers = path + @"/pos_printers.dat";
            string kitchen_printers = path + @"/kitchen_printers.dat";

            Program.saveDTtoFile(pos_printers_dt, pos_printers);
            Program.saveDTtoFile(kitchen_printers_dt, kitchen_printers);

            this.Close();
        }
    }
}
