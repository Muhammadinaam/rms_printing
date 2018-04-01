namespace RmsPrinting
{
    partial class FrmAddPrinter
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
            this.txb_category = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_printers = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // txb_category
            // 
            this.txb_category.Location = new System.Drawing.Point(12, 25);
            this.txb_category.Name = "txb_category";
            this.txb_category.Size = new System.Drawing.Size(263, 20);
            this.txb_category.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Printer";
            // 
            // cbx_printers
            // 
            this.cbx_printers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_printers.FormattingEnabled = true;
            this.cbx_printers.Location = new System.Drawing.Point(12, 80);
            this.cbx_printers.Name = "cbx_printers";
            this.cbx_printers.Size = new System.Drawing.Size(263, 21);
            this.cbx_printers.TabIndex = 3;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(192, 138);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(83, 23);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // FrmAddPrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 173);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cbx_printers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_category);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddPrinter";
            this.Text = "Add Printer";
            this.Load += new System.EventHandler(this.FrmAddPrinter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.TextBox txb_category;
        public System.Windows.Forms.ComboBox cbx_printers;
    }
}