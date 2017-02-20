namespace EbayMaster
{
    partial class FrmDBConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDBConnection));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelSQLServer = new System.Windows.Forms.Panel();
            this.textBoxSQLServerPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSQLServerUserId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSQLServerDBName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSQLServerDBAddr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelAccess = new System.Windows.Forms.Panel();
            this.buttonNavigateItemImage = new System.Windows.Forms.Button();
            this.textBoxAccessFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbSqlServer = new System.Windows.Forms.RadioButton();
            this.rbAccess = new System.Windows.Forms.RadioButton();
            this.buttonSaveConfig = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panelSQLServer.SuspendLayout();
            this.panelAccess.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database types";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelSQLServer);
            this.groupBox1.Controls.Add(this.panelAccess);
            this.groupBox1.Controls.Add(this.rbSqlServer);
            this.groupBox1.Controls.Add(this.rbAccess);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 303);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // panelSQLServer
            // 
            this.panelSQLServer.Controls.Add(this.textBoxSQLServerPassword);
            this.panelSQLServer.Controls.Add(this.label6);
            this.panelSQLServer.Controls.Add(this.textBoxSQLServerUserId);
            this.panelSQLServer.Controls.Add(this.label5);
            this.panelSQLServer.Controls.Add(this.textBoxSQLServerDBName);
            this.panelSQLServer.Controls.Add(this.label4);
            this.panelSQLServer.Controls.Add(this.textBoxSQLServerDBAddr);
            this.panelSQLServer.Controls.Add(this.label3);
            this.panelSQLServer.Location = new System.Drawing.Point(7, 144);
            this.panelSQLServer.Name = "panelSQLServer";
            this.panelSQLServer.Size = new System.Drawing.Size(501, 202);
            this.panelSQLServer.TabIndex = 13;
            this.panelSQLServer.Visible = false;
            // 
            // textBoxSQLServerPassword
            // 
            this.textBoxSQLServerPassword.Location = new System.Drawing.Point(206, 168);
            this.textBoxSQLServerPassword.Name = "textBoxSQLServerPassword";
            this.textBoxSQLServerPassword.Size = new System.Drawing.Size(200, 20);
            this.textBoxSQLServerPassword.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "SQL Server密码";
            // 
            // textBoxSQLServerUserId
            // 
            this.textBoxSQLServerUserId.Location = new System.Drawing.Point(206, 119);
            this.textBoxSQLServerUserId.Name = "textBoxSQLServerUserId";
            this.textBoxSQLServerUserId.Size = new System.Drawing.Size(200, 20);
            this.textBoxSQLServerUserId.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "SQL Serve Username";
            // 
            // textBoxSQLServerDBName
            // 
            this.textBoxSQLServerDBName.Location = new System.Drawing.Point(206, 69);
            this.textBoxSQLServerDBName.Name = "textBoxSQLServerDBName";
            this.textBoxSQLServerDBName.Size = new System.Drawing.Size(200, 20);
            this.textBoxSQLServerDBName.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "SQL Server Database Name";
            // 
            // textBoxSQLServerDBAddr
            // 
            this.textBoxSQLServerDBAddr.Location = new System.Drawing.Point(206, 15);
            this.textBoxSQLServerDBAddr.Name = "textBoxSQLServerDBAddr";
            this.textBoxSQLServerDBAddr.Size = new System.Drawing.Size(200, 20);
            this.textBoxSQLServerDBAddr.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "SQL Server Database Server";
            // 
            // panelAccess
            // 
            this.panelAccess.Controls.Add(this.buttonNavigateItemImage);
            this.panelAccess.Controls.Add(this.textBoxAccessFilePath);
            this.panelAccess.Controls.Add(this.label2);
            this.panelAccess.Location = new System.Drawing.Point(6, 83);
            this.panelAccess.Name = "panelAccess";
            this.panelAccess.Size = new System.Drawing.Size(502, 53);
            this.panelAccess.TabIndex = 12;
            // 
            // buttonNavigateItemImage
            // 
            this.buttonNavigateItemImage.Location = new System.Drawing.Point(426, 15);
            this.buttonNavigateItemImage.Name = "buttonNavigateItemImage";
            this.buttonNavigateItemImage.Size = new System.Drawing.Size(66, 25);
            this.buttonNavigateItemImage.TabIndex = 9;
            this.buttonNavigateItemImage.Text = "Browse...";
            this.buttonNavigateItemImage.UseVisualStyleBackColor = true;
            this.buttonNavigateItemImage.Click += new System.EventHandler(this.buttonNavigateItemImage_Click);
            // 
            // textBoxAccessFilePath
            // 
            this.textBoxAccessFilePath.Location = new System.Drawing.Point(104, 17);
            this.textBoxAccessFilePath.Name = "textBoxAccessFilePath";
            this.textBoxAccessFilePath.Size = new System.Drawing.Size(316, 20);
            this.textBoxAccessFilePath.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Access the file path";
            // 
            // rbSqlServer
            // 
            this.rbSqlServer.AutoSize = true;
            this.rbSqlServer.Location = new System.Drawing.Point(303, 39);
            this.rbSqlServer.Name = "rbSqlServer";
            this.rbSqlServer.Size = new System.Drawing.Size(99, 17);
            this.rbSqlServer.TabIndex = 2;
            this.rbSqlServer.Text = "MS SQL Server";
            this.rbSqlServer.UseVisualStyleBackColor = true;
            this.rbSqlServer.CheckedChanged += new System.EventHandler(this.rbSqlServer_CheckedChanged);
            // 
            // rbAccess
            // 
            this.rbAccess.AutoSize = true;
            this.rbAccess.Checked = true;
            this.rbAccess.Location = new System.Drawing.Point(166, 39);
            this.rbAccess.Name = "rbAccess";
            this.rbAccess.Size = new System.Drawing.Size(79, 17);
            this.rbAccess.TabIndex = 1;
            this.rbAccess.TabStop = true;
            this.rbAccess.Text = "MS Access";
            this.rbAccess.UseVisualStyleBackColor = true;
            this.rbAccess.CheckedChanged += new System.EventHandler(this.rbAccess_CheckedChanged);
            // 
            // buttonSaveConfig
            // 
            this.buttonSaveConfig.Location = new System.Drawing.Point(240, 328);
            this.buttonSaveConfig.Name = "buttonSaveConfig";
            this.buttonSaveConfig.Size = new System.Drawing.Size(86, 42);
            this.buttonSaveConfig.TabIndex = 12;
            this.buttonSaveConfig.Text = "Save Settings";
            this.buttonSaveConfig.UseVisualStyleBackColor = true;
            this.buttonSaveConfig.Click += new System.EventHandler(this.buttonSaveConfig_Click);
            // 
            // FrmDBConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 379);
            this.Controls.Add(this.buttonSaveConfig);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDBConnection";
            this.Text = "Database connection settings";
            this.Load += new System.EventHandler(this.FrmDBConnection_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelSQLServer.ResumeLayout(false);
            this.panelSQLServer.PerformLayout();
            this.panelAccess.ResumeLayout(false);
            this.panelAccess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSqlServer;
        private System.Windows.Forms.RadioButton rbAccess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNavigateItemImage;
        private System.Windows.Forms.Panel panelSQLServer;
        private System.Windows.Forms.Panel panelAccess;
        private System.Windows.Forms.TextBox textBoxAccessFilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSQLServerPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSQLServerUserId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSQLServerDBName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSQLServerDBAddr;
        private System.Windows.Forms.Button buttonSaveConfig;
    }
}