﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;

namespace RmsPrinting
{
    public partial class FrmMain : Form
    {
        DataTable pos_printers_dt = new DataTable();
        DataTable kitchen_printers_dt = new DataTable();

        string not_connected_message = "Not connected with Database. Please check connection settings or Database Server";

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {


            openConnection();

            

            timer1.Start();
            PrintTimer.Start();

        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to stop Printing", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private bool checkConnectivity()
        {
            if (Program.GlobalConn == null)
            {
                lbl_status.Text = not_connected_message;
                return false;
            }

            if ( Program.GlobalConn.State != ConnectionState.Open)
            {
                lbl_status.Text = not_connected_message;
                return false;
            }

            return true;
        }

        private void openConnection()
        {
            ConfigurationManager.RefreshSection("appSettings");
            try
            {
                string server = ConfigurationManager.AppSettings.Get("server");
                string port = ConfigurationManager.AppSettings.Get("port");
                string username = ConfigurationManager.AppSettings.Get("user");

                string password = ConfigurationManager.AppSettings.Get("password");
                password = password != "" ? StringCipher.Decrypt(password, "abc") : "";
                string database = ConfigurationManager.AppSettings.Get("database");

                Program.GlobalConn = MySqlFunctions.OpenSqlConnection(server, database,
                    username, password, port);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Occurred: " + ex.Message);


            }
        }

        private void databaseConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConnectionSettings f = new FrmConnectionSettings();
            f.ShowDialog();
        }

        private void printersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrinters f = new FrmPrinters();
            f.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value > 99)
            {
                progressBar1.Value = 0;
            }
            else
                progressBar1.Value = progressBar1.Value + 1;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

            string pos_printers = path + @"/pos_printers.dat";
            string kitchen_printers = path + @"/kitchen_printers.dat";

            pos_printers_dt = Program.loadDTfromFile(pos_printers);
            kitchen_printers_dt = Program.loadDTfromFile(kitchen_printers);

            

            DataTable dt_print_jobs = MySqlFunctions.GetTable("SELECT * FROM print_jobs where executed_at is null;", Program.GlobalConn);

            foreach (DataRow r in dt_print_jobs.Rows)
            {
                if (r["print_type"].ToString() == "New Order")
                {
                    PrintOrderForKitchens(r["entity_id"].ToString(), r["id"].ToString(), "New Order");
                }
                else if (r["print_type"].ToString() == "Reprint for Kitchens")
                {
                    PrintOrderForKitchens(r["entity_id"].ToString(), r["id"].ToString(), "Reprint");
                }
                else if (r["print_type"].ToString() == "Edit Order")
                {
                    PrintOrderEdit(r["entity_id"].ToString(), r["id"].ToString());
                }
                else if (r["print_type"].ToString() == "Customer Print")
                {
                    PrintOrderForCustomer(r["entity_id"].ToString(), r["id"].ToString());
                }
            }
        }

        private void PrintOrderEdit(string edit_id, string job_id)
        {
            OrderEditDataSet ds = new OrderEditDataSet();


            DataTable edit = MySqlFunctions.GetTable(
                "select tos_edits.id, tos_edits.to_id as order_id, " +
                "tables.portion, tables.name as table_name from tos_edits " +
                "join tables on tables.id = tos_edits.new_table_id " +
                "where tos_edits.id = '"+edit_id+"'", Program.GlobalConn);



            DataTable detail = MySqlFunctions.GetTable(
                "select tos_edits_details.to_edit_id as edit_id, " +
                "tos_edits_details.edit_type, items.category, " +
                "items.code as code, items.name as item_name, tos_edits_details.qty  " +
                "from tos_edits_details " +
                "join items on items.id = tos_edits_details.item_id" +
                " where tos_edits_details.to_edit_id = '"+edit_id+"'", Program.GlobalConn);


            foreach (DataRow r in edit.Rows)
            {
                ds.OrderEdit.AddOrderEditRow(
                        r["id"].ToString(),
                        r["order_id"].ToString(),
                        r["portion"].ToString(),
                        r["table_name"].ToString()
                    );

                
            }

            foreach (DataRow r in detail.Rows)
            {
                ds.OrderEditDetails.AddOrderEditDetailsRow(
                        (OrderEditDataSet.OrderEditRow)ds.OrderEdit.Rows[0],
                        r["edit_type"].ToString(),
                        r["category"].ToString(),
                        r["code"].ToString(),
                        r["item_name"].ToString(),
                        r["qty"].ToString()
                    );
            }

            OrderEditReport report = new OrderEditReport();
            report.SetDataSource(ds);


            foreach (DataRow r in kitchen_printers_dt.Rows)
            {
                report.PrintOptions.PrinterName = r["Printer"].ToString();
                report.PrintToPrinter(1, false, 0, 0);
            }

            MySqlFunctions.SqlNonQuery("update print_jobs set executed_at = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + "' " +
                "where id = '" + job_id + "'", Program.GlobalConn);


        }

        private void PrintOrderForCustomer(string order_id, string job_id)
        {
            NewOrderDataSet ds = new NewOrderDataSet();


            DataTable order = MySqlFunctions.GetTable(
                "select tos.id, order_types.name as order_type, tos.order_datetime, " +
                "tables.portion, tables.name as table_name, tos.deliver_to_name, tos.deliver_to_phone, " +
                "tos.deliver_to_address, tos.received_through, tos.order_amount_ex_st as ex_st, " +
                "tos.sales_tax as st, tos.order_amount_inc_st as inc_st " +
                "from tos " +
                "join order_types on order_types.id = tos.order_type_id " +
                "join tables on tables.id = tos.table_id " +
                "where tos.id = " + order_id + "; ", Program.GlobalConn);



            DataTable detail = MySqlFunctions.GetTable(
                "select tos_details.to_id as order_id, items.category, items.code as item_code , items.name as item_name, " +
                "tos_details.qty, tos_details.rate, tos_details.amount " +
                "from tos_details " +
                "join items on items.id = tos_details.item_id " +
                " where tos_details.to_id = " + order_id + "; ", Program.GlobalConn);


            foreach (DataRow r in order.Rows)
            {
                ds.Order.AddOrderRow(
                    r["id"].ToString(),
                    r["order_type"].ToString(),
                    (System.DateTime)r["order_datetime"],
                    r["portion"].ToString(),
                    r["table_name"].ToString(),
                    r["deliver_to_name"].ToString(),
                    r["deliver_to_phone"].ToString(),
                    r["deliver_to_address"].ToString(),
                    r["received_through"].ToString(),
                    (decimal)r["ex_st"],
                    (decimal)r["st"],
                    (decimal)r["inc_st"]
                    );
            }

            foreach (DataRow r in detail.Rows)
            {
                ds.OrderDetail.AddOrderDetailRow(
                    (NewOrderDataSet.OrderRow)ds.Order.Rows[0],
                    r["category"].ToString(),
                    r["item_code"].ToString(),
                    r["item_name"].ToString(),
                    (decimal)r["qty"],
                    (decimal)r["rate"],
                    (decimal)r["amount"]

                    );
            }

            PrintForCustomer report = new PrintForCustomer();
            report.SetDataSource(ds);


            foreach (DataRow r in pos_printers_dt.Rows)
            {
                report.PrintOptions.PrinterName = r["Printer"].ToString();
                report.PrintToPrinter(1, false, 0, 0);
            }

            MySqlFunctions.SqlNonQuery("update print_jobs set executed_at = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + "' " +
                "where id = '" + job_id + "'", Program.GlobalConn);


        }

        private void PrintOrderForKitchens(string order_id, string job_id, string title = "New Order")
        {
            


            NewOrderDataSet ds = new NewOrderDataSet();

            
            DataTable order = MySqlFunctions.GetTable(
                "select tos.id, order_types.name as order_type, tos.order_datetime, " +
                "tables.portion, tables.name as table_name, tos.deliver_to_name, tos.deliver_to_phone, " +
                "tos.deliver_to_address, tos.received_through, tos.order_amount_ex_st as ex_st, " +
                "tos.sales_tax as st, tos.order_amount_inc_st as inc_st " +
                "from tos " +
                "join order_types on order_types.id = tos.order_type_id " +
                "join tables on tables.id = tos.table_id " +
                "where tos.id = " +order_id+"; ", Program.GlobalConn);



            DataTable detail = MySqlFunctions.GetTable(
                "select tos_details.to_id as order_id, items.category, items.code as item_code , items.name as item_name, " +
                "tos_details.qty, tos_details.rate, tos_details.amount " +
                "from tos_details " +
                "join items on items.id = tos_details.item_id " +
                " where tos_details.to_id = "+order_id+"; ", Program.GlobalConn);


            foreach (DataRow r in order.Rows)
            {
                ds.Order.AddOrderRow(
                    r["id"].ToString(),
                    r["order_type"].ToString(),
                    (System.DateTime)r["order_datetime"],
                    r["portion"].ToString(),
                    r["table_name"].ToString(),
                    r["deliver_to_name"].ToString(),
                    r["deliver_to_phone"].ToString(),
                    r["deliver_to_address"].ToString(),
                    r["received_through"].ToString(),
                    (decimal)r["ex_st"],
                    (decimal)r["st"],
                    (decimal)r["inc_st"]
                    );
            }

            foreach (DataRow r in detail.Rows)
            {
                ds.OrderDetail.AddOrderDetailRow(
                    (NewOrderDataSet.OrderRow)ds.Order.Rows[0],
                    r["category"].ToString(),
                    r["item_code"].ToString(),
                    r["item_name"].ToString(),
                    (decimal)r["qty"],
                    (decimal)r["rate"],
                    (decimal)r["amount"]

                    );
            }

            NewOrderReport report = new NewOrderReport();
            report.DataDefinition.FormulaFields["ReportTitle"].Text = "'" + title + "'";
            report.SetDataSource(ds);


            foreach (DataRow r in kitchen_printers_dt.Rows)
            {
                report.PrintOptions.PrinterName = r["Printer"].ToString();
                report.PrintToPrinter(1, false, 0, 0);
            }

            MySqlFunctions.SqlNonQuery("update print_jobs set executed_at = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + "' " +
                "where id = '" + job_id + "'", Program.GlobalConn);

            
        }

        private void PrintTimer_Tick(object sender, EventArgs e)
        {
            if (checkConnectivity() == false)
                return;

            if (backgroundWorker1.IsBusy == false)
                backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                PrintTimer.Stop();
                timer1.Stop();
                lbl_status.Text = "Error Occurred. Please restart after removing error";

                MessageBox.Show(e.Error.ToString());
                
            }
        }
    }
}