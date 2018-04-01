namespace RmsPrinting
{
    partial class FrmConnectionSettings
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
            this.txb_server = new System.Windows.Forms.TextBox();
            this.txb_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_database = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // txb_server
            // 
            this.txb_server.Location = new System.Drawing.Point(15, 37);
            this.txb_server.Name = "txb_server";
            this.txb_server.Size = new System.Drawing.Size(222, 20);
            this.txb_server.TabIndex = 1;
            // 
            // txb_port
            // 
            this.txb_port.Location = new System.Drawing.Point(15, 76);
            this.txb_port.Name = "txb_port";
            this.txb_port.Size = new System.Drawing.Size(222, 20);
            this.txb_port.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // txb_username
            // 
            this.txb_username.Location = new System.Drawing.Point(15, 115);
            this.txb_username.Name = "txb_username";
            this.txb_username.Size = new System.Drawing.Size(222, 20);
            this.txb_username.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username";
            // 
            // txb_password
            // 
            this.txb_password.Location = new System.Drawing.Point(15, 154);
            this.txb_password.Name = "txb_password";
            this.txb_password.Size = new System.Drawing.Size(222, 20);
            this.txb_password.TabIndex = 7;
            this.txb_password.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // txb_database
            // 
            this.txb_database.Location = new System.Drawing.Point(15, 193);
            this.txb_database.Name = "txb_database";
            this.txb_database.Size = new System.Drawing.Size(222, 20);
            this.txb_database.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Database";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(162, 241);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // FrmConnectionSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 276);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txb_database);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_server);
            this.Controls.Add(this.label1);
            this.Name = "FrmConnectionSettings";
            this.Text = "Connection Settings";
            this.Load += new System.EventHandler(this.FrmConnectionSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_server;
        private System.Windows.Forms.TextBox txb_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_database;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_save;
    }
}