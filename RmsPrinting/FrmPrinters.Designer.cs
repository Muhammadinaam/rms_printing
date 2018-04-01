namespace RmsPrinting
{
    partial class FrmPrinters
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_pos_printers = new System.Windows.Forms.DataGridView();
            this.dgv_kitchen_printers = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add_pos_printer = new System.Windows.Forms.Button();
            this.btn_add_kitchen_printer = new System.Windows.Forms.Button();
            this.btn_remove_pos_printer = new System.Windows.Forms.Button();
            this.btn_remove_kitchen_printer = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pos_printers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kitchen_printers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "POS Printers";
            // 
            // dgv_pos_printers
            // 
            this.dgv_pos_printers.AllowUserToAddRows = false;
            this.dgv_pos_printers.AllowUserToDeleteRows = false;
            this.dgv_pos_printers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pos_printers.Location = new System.Drawing.Point(15, 25);
            this.dgv_pos_printers.MultiSelect = false;
            this.dgv_pos_printers.Name = "dgv_pos_printers";
            this.dgv_pos_printers.ReadOnly = true;
            this.dgv_pos_printers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pos_printers.Size = new System.Drawing.Size(279, 169);
            this.dgv_pos_printers.TabIndex = 1;
            // 
            // dgv_kitchen_printers
            // 
            this.dgv_kitchen_printers.AllowUserToAddRows = false;
            this.dgv_kitchen_printers.AllowUserToDeleteRows = false;
            this.dgv_kitchen_printers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kitchen_printers.Location = new System.Drawing.Point(318, 25);
            this.dgv_kitchen_printers.MultiSelect = false;
            this.dgv_kitchen_printers.Name = "dgv_kitchen_printers";
            this.dgv_kitchen_printers.ReadOnly = true;
            this.dgv_kitchen_printers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_kitchen_printers.Size = new System.Drawing.Size(280, 169);
            this.dgv_kitchen_printers.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitchen Printers";
            // 
            // btn_add_pos_printer
            // 
            this.btn_add_pos_printer.Location = new System.Drawing.Point(219, 200);
            this.btn_add_pos_printer.Name = "btn_add_pos_printer";
            this.btn_add_pos_printer.Size = new System.Drawing.Size(75, 23);
            this.btn_add_pos_printer.TabIndex = 4;
            this.btn_add_pos_printer.Text = "Add";
            this.btn_add_pos_printer.UseVisualStyleBackColor = true;
            this.btn_add_pos_printer.Click += new System.EventHandler(this.btn_add_pos_printer_Click);
            // 
            // btn_add_kitchen_printer
            // 
            this.btn_add_kitchen_printer.Location = new System.Drawing.Point(523, 200);
            this.btn_add_kitchen_printer.Name = "btn_add_kitchen_printer";
            this.btn_add_kitchen_printer.Size = new System.Drawing.Size(75, 23);
            this.btn_add_kitchen_printer.TabIndex = 5;
            this.btn_add_kitchen_printer.Text = "Add";
            this.btn_add_kitchen_printer.UseVisualStyleBackColor = true;
            this.btn_add_kitchen_printer.Click += new System.EventHandler(this.btn_add_kitchen_printer_Click);
            // 
            // btn_remove_pos_printer
            // 
            this.btn_remove_pos_printer.Location = new System.Drawing.Point(97, 200);
            this.btn_remove_pos_printer.Name = "btn_remove_pos_printer";
            this.btn_remove_pos_printer.Size = new System.Drawing.Size(116, 23);
            this.btn_remove_pos_printer.TabIndex = 6;
            this.btn_remove_pos_printer.Text = "Remove Selected";
            this.btn_remove_pos_printer.UseVisualStyleBackColor = true;
            this.btn_remove_pos_printer.Click += new System.EventHandler(this.btn_remove_pos_printer_Click);
            // 
            // btn_remove_kitchen_printer
            // 
            this.btn_remove_kitchen_printer.Location = new System.Drawing.Point(401, 200);
            this.btn_remove_kitchen_printer.Name = "btn_remove_kitchen_printer";
            this.btn_remove_kitchen_printer.Size = new System.Drawing.Size(116, 23);
            this.btn_remove_kitchen_printer.TabIndex = 7;
            this.btn_remove_kitchen_printer.Text = "Remove Selected";
            this.btn_remove_kitchen_printer.UseVisualStyleBackColor = true;
            this.btn_remove_kitchen_printer.Click += new System.EventHandler(this.btn_remove_kitchen_printer_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(233, 260);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(148, 23);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // FrmPrinters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 295);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_remove_kitchen_printer);
            this.Controls.Add(this.btn_remove_pos_printer);
            this.Controls.Add(this.btn_add_kitchen_printer);
            this.Controls.Add(this.btn_add_pos_printer);
            this.Controls.Add(this.dgv_kitchen_printers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_pos_printers);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrinters";
            this.Text = "Printers";
            this.Load += new System.EventHandler(this.FrmPrinters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pos_printers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kitchen_printers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_pos_printers;
        private System.Windows.Forms.DataGridView dgv_kitchen_printers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add_pos_printer;
        private System.Windows.Forms.Button btn_add_kitchen_printer;
        private System.Windows.Forms.Button btn_remove_pos_printer;
        private System.Windows.Forms.Button btn_remove_kitchen_printer;
        private System.Windows.Forms.Button btn_save;
    }
}