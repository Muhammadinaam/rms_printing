namespace RmsPrinting
{
    partial class FrmGeneralSettings
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxbFooter = new System.Windows.Forms.RichTextBox();
            this.rtxbHeader = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 274);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Header";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Footer";
            // 
            // rtxbFooter
            // 
            this.rtxbFooter.Location = new System.Drawing.Point(15, 157);
            this.rtxbFooter.Name = "rtxbFooter";
            this.rtxbFooter.Size = new System.Drawing.Size(201, 110);
            this.rtxbFooter.TabIndex = 3;
            this.rtxbFooter.Text = "";
            // 
            // rtxbHeader
            // 
            this.rtxbHeader.Location = new System.Drawing.Point(15, 25);
            this.rtxbHeader.Name = "rtxbHeader";
            this.rtxbHeader.Size = new System.Drawing.Size(201, 110);
            this.rtxbHeader.TabIndex = 1;
            this.rtxbHeader.Text = "";
            // 
            // FrmGeneralSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 329);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtxbFooter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtxbHeader);
            this.Controls.Add(this.label1);
            this.Name = "FrmGeneralSettings";
            this.Text = "General Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxbFooter;
        private System.Windows.Forms.RichTextBox rtxbHeader;
    }
}