namespace backup_manual_sql
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.cmdConnect = new System.Windows.Forms.Button();
            this.cmdDisconnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbDatabases = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDatabaseLoc = new System.Windows.Forms.TextBox();
            this.cmdBrowseBkp = new System.Windows.Forms.Button();
            this.cmdBackup = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtDataRestloc = new System.Windows.Forms.TextBox();
            this.cmdBrowseRestore = new System.Windows.Forms.Button();
            this.cmdRestore = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdLimpa = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtmove = new System.Windows.Forms.TextBox();
            this.cmdBrowsemove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtpwd);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.txtSource);
            this.groupBox1.Controls.Add(this.cmdConnect);
            this.groupBox1.Controls.Add(this.cmdDisconnect);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SQL Server Authentication";
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(252, 74);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(123, 20);
            this.txtpwd.TabIndex = 7;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(81, 74);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(123, 20);
            this.txtid.TabIndex = 6;
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(103, 29);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(300, 20);
            this.txtSource.TabIndex = 5;
            // 
            // cmdConnect
            // 
            this.cmdConnect.Location = new System.Drawing.Point(434, 27);
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.Size = new System.Drawing.Size(75, 23);
            this.cmdConnect.TabIndex = 4;
            this.cmdConnect.Text = "Connect";
            this.cmdConnect.UseVisualStyleBackColor = true;
            this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
            // 
            // cmdDisconnect
            // 
            this.cmdDisconnect.Location = new System.Drawing.Point(434, 72);
            this.cmdDisconnect.Name = "cmdDisconnect";
            this.cmdDisconnect.Size = new System.Drawing.Size(75, 23);
            this.cmdDisconnect.TabIndex = 3;
            this.cmdDisconnect.Text = "Disconnect";
            this.cmdDisconnect.UseVisualStyleBackColor = true;
            this.cmdDisconnect.Click += new System.EventHandler(this.cmdDisconnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pwd:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Source:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdLimpa);
            this.groupBox2.Controls.Add(this.cmbDatabases);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(13, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 110);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Database Selection";
            // 
            // cmbDatabases
            // 
            this.cmbDatabases.FormattingEnabled = true;
            this.cmbDatabases.Location = new System.Drawing.Point(102, 53);
            this.cmbDatabases.Name = "cmbDatabases";
            this.cmbDatabases.Size = new System.Drawing.Size(300, 21);
            this.cmbDatabases.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Database:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDatabaseLoc);
            this.groupBox3.Controls.Add(this.cmdBrowseBkp);
            this.groupBox3.Controls.Add(this.cmdBackup);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(13, 287);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(543, 110);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Database Backup";
            // 
            // txtDatabaseLoc
            // 
            this.txtDatabaseLoc.Location = new System.Drawing.Point(106, 36);
            this.txtDatabaseLoc.Name = "txtDatabaseLoc";
            this.txtDatabaseLoc.Size = new System.Drawing.Size(300, 20);
            this.txtDatabaseLoc.TabIndex = 9;
            // 
            // cmdBrowseBkp
            // 
            this.cmdBrowseBkp.Location = new System.Drawing.Point(437, 32);
            this.cmdBrowseBkp.Name = "cmdBrowseBkp";
            this.cmdBrowseBkp.Size = new System.Drawing.Size(75, 23);
            this.cmdBrowseBkp.TabIndex = 8;
            this.cmdBrowseBkp.Text = "Browse";
            this.cmdBrowseBkp.UseVisualStyleBackColor = true;
            this.cmdBrowseBkp.Click += new System.EventHandler(this.cmdBrowseBkp_Click);
            // 
            // cmdBackup
            // 
            this.cmdBackup.Location = new System.Drawing.Point(437, 70);
            this.cmdBackup.Name = "cmdBackup";
            this.cmdBackup.Size = new System.Drawing.Size(75, 23);
            this.cmdBackup.TabIndex = 7;
            this.cmdBackup.Text = "Backup";
            this.cmdBackup.UseVisualStyleBackColor = true;
            this.cmdBackup.Click += new System.EventHandler(this.cmdBackup_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Location:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmdBrowsemove);
            this.groupBox4.Controls.Add(this.txtmove);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Controls.Add(this.txtDataRestloc);
            this.groupBox4.Controls.Add(this.cmdBrowseRestore);
            this.groupBox4.Controls.Add(this.cmdRestore);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(13, 412);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(543, 110);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Database Restore";
            // 
            // txtDataRestloc
            // 
            this.txtDataRestloc.Location = new System.Drawing.Point(106, 36);
            this.txtDataRestloc.Name = "txtDataRestloc";
            this.txtDataRestloc.Size = new System.Drawing.Size(300, 20);
            this.txtDataRestloc.TabIndex = 9;
            // 
            // cmdBrowseRestore
            // 
            this.cmdBrowseRestore.Location = new System.Drawing.Point(437, 32);
            this.cmdBrowseRestore.Name = "cmdBrowseRestore";
            this.cmdBrowseRestore.Size = new System.Drawing.Size(75, 23);
            this.cmdBrowseRestore.TabIndex = 8;
            this.cmdBrowseRestore.Text = "Browse";
            this.cmdBrowseRestore.UseVisualStyleBackColor = true;
            this.cmdBrowseRestore.Click += new System.EventHandler(this.cmdBrowseRestore_Click);
            // 
            // cmdRestore
            // 
            this.cmdRestore.Location = new System.Drawing.Point(437, 70);
            this.cmdRestore.Name = "cmdRestore";
            this.cmdRestore.Size = new System.Drawing.Size(75, 23);
            this.cmdRestore.TabIndex = 7;
            this.cmdRestore.Text = "Restore";
            this.cmdRestore.UseVisualStyleBackColor = true;
            this.cmdRestore.Click += new System.EventHandler(this.cmdRestore_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Backup Path:";
            // 
            // cmdLimpa
            // 
            this.cmdLimpa.Location = new System.Drawing.Point(433, 46);
            this.cmdLimpa.Name = "cmdLimpa";
            this.cmdLimpa.Size = new System.Drawing.Size(75, 23);
            this.cmdLimpa.TabIndex = 10;
            this.cmdLimpa.Text = "Limpa Base";
            this.cmdLimpa.UseVisualStyleBackColor = true;
            this.cmdLimpa.Click += new System.EventHandler(this.cmdLimpa_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 70);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "With Move:";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtmove
            // 
            this.txtmove.Location = new System.Drawing.Point(102, 70);
            this.txtmove.Name = "txtmove";
            this.txtmove.Size = new System.Drawing.Size(223, 20);
            this.txtmove.TabIndex = 11;
            // 
            // cmdBrowsemove
            // 
            this.cmdBrowsemove.Location = new System.Drawing.Point(331, 70);
            this.cmdBrowsemove.Name = "cmdBrowsemove";
            this.cmdBrowsemove.Size = new System.Drawing.Size(75, 23);
            this.cmdBrowsemove.TabIndex = 12;
            this.cmdBrowsemove.Text = "Browse";
            this.cmdBrowsemove.UseVisualStyleBackColor = true;
            this.cmdBrowsemove.Click += new System.EventHandler(this.cmdBrowsemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 538);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button cmdConnect;
        private System.Windows.Forms.Button cmdDisconnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbDatabases;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDatabaseLoc;
        private System.Windows.Forms.Button cmdBrowseBkp;
        private System.Windows.Forms.Button cmdBackup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtDataRestloc;
        private System.Windows.Forms.Button cmdBrowseRestore;
        private System.Windows.Forms.Button cmdRestore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdLimpa;
        private System.Windows.Forms.Button cmdBrowsemove;
        private System.Windows.Forms.TextBox txtmove;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

