namespace EbayMaster
{
    partial class FrmAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccount));
            this.listBoxAllAccounts = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPayPalPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPayPalUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPayPalSignature = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPayPalAccount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEbayToken = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEbayAccount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddOrUpdateAccount = new System.Windows.Forms.Button();
            this.buttonDelAccount = new System.Windows.Forms.Button();
            this.buttonGetToken = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxAllAccounts
            // 
            this.listBoxAllAccounts.FormattingEnabled = true;
            this.listBoxAllAccounts.Location = new System.Drawing.Point(27, 24);
            this.listBoxAllAccounts.Name = "listBoxAllAccounts";
            this.listBoxAllAccounts.Size = new System.Drawing.Size(205, 407);
            this.listBoxAllAccounts.TabIndex = 0;
            this.listBoxAllAccounts.SelectedIndexChanged += new System.EventHandler(this.listBoxAllAccounts_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPayPalPassword);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxPayPalUsername);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxPayPalSignature);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxPayPalAccount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxEbayToken);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxEbayAccount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(265, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 415);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // textBoxPayPalPassword
            // 
            this.textBoxPayPalPassword.Location = new System.Drawing.Point(118, 289);
            this.textBoxPayPalPassword.Name = "textBoxPayPalPassword";
            this.textBoxPayPalPassword.Size = new System.Drawing.Size(153, 20);
            this.textBoxPayPalPassword.TabIndex = 24;
            this.textBoxPayPalPassword.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "PayPal Password";
            this.label6.Visible = false;
            // 
            // textBoxPayPalUsername
            // 
            this.textBoxPayPalUsername.Location = new System.Drawing.Point(118, 250);
            this.textBoxPayPalUsername.Name = "textBoxPayPalUsername";
            this.textBoxPayPalUsername.Size = new System.Drawing.Size(153, 20);
            this.textBoxPayPalUsername.TabIndex = 22;
            this.textBoxPayPalUsername.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "PayPal Username";
            this.label5.Visible = false;
            // 
            // textBoxPayPalSignature
            // 
            this.textBoxPayPalSignature.Location = new System.Drawing.Point(118, 342);
            this.textBoxPayPalSignature.Multiline = true;
            this.textBoxPayPalSignature.Name = "textBoxPayPalSignature";
            this.textBoxPayPalSignature.Size = new System.Drawing.Size(368, 52);
            this.textBoxPayPalSignature.TabIndex = 20;
            this.textBoxPayPalSignature.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "PayPal Signature";
            this.label4.Visible = false;
            // 
            // textBoxPayPalAccount
            // 
            this.textBoxPayPalAccount.Location = new System.Drawing.Point(118, 209);
            this.textBoxPayPalAccount.Name = "textBoxPayPalAccount";
            this.textBoxPayPalAccount.Size = new System.Drawing.Size(153, 20);
            this.textBoxPayPalAccount.TabIndex = 18;
            this.textBoxPayPalAccount.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "PayPal Account";
            this.label3.Visible = false;
            // 
            // textBoxEbayToken
            // 
            this.textBoxEbayToken.Location = new System.Drawing.Point(118, 68);
            this.textBoxEbayToken.Multiline = true;
            this.textBoxEbayToken.Name = "textBoxEbayToken";
            this.textBoxEbayToken.ReadOnly = true;
            this.textBoxEbayToken.Size = new System.Drawing.Size(368, 112);
            this.textBoxEbayToken.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "ebay token";
            // 
            // textBoxEbayAccount
            // 
            this.textBoxEbayAccount.Location = new System.Drawing.Point(118, 22);
            this.textBoxEbayAccount.Name = "textBoxEbayAccount";
            this.textBoxEbayAccount.ReadOnly = true;
            this.textBoxEbayAccount.Size = new System.Drawing.Size(153, 20);
            this.textBoxEbayAccount.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ebay Account No";
            // 
            // btnAddOrUpdateAccount
            // 
            this.btnAddOrUpdateAccount.Location = new System.Drawing.Point(588, 442);
            this.btnAddOrUpdateAccount.Name = "btnAddOrUpdateAccount";
            this.btnAddOrUpdateAccount.Size = new System.Drawing.Size(106, 36);
            this.btnAddOrUpdateAccount.TabIndex = 14;
            this.btnAddOrUpdateAccount.Text = "Add / Update Account";
            this.btnAddOrUpdateAccount.UseVisualStyleBackColor = true;
            this.btnAddOrUpdateAccount.Visible = false;
            this.btnAddOrUpdateAccount.Click += new System.EventHandler(this.btnAddOrUpdateAccount_Click);
            // 
            // buttonDelAccount
            // 
            this.buttonDelAccount.Location = new System.Drawing.Point(92, 442);
            this.buttonDelAccount.Name = "buttonDelAccount";
            this.buttonDelAccount.Size = new System.Drawing.Size(106, 36);
            this.buttonDelAccount.TabIndex = 15;
            this.buttonDelAccount.Text = "Delete Account";
            this.buttonDelAccount.UseVisualStyleBackColor = true;
            this.buttonDelAccount.Click += new System.EventHandler(this.buttonDelAccount_Click);
            // 
            // buttonGetToken
            // 
            this.buttonGetToken.Location = new System.Drawing.Point(454, 442);
            this.buttonGetToken.Name = "buttonGetToken";
            this.buttonGetToken.Size = new System.Drawing.Size(106, 36);
            this.buttonGetToken.TabIndex = 16;
            this.buttonGetToken.Text = "Get Token";
            this.buttonGetToken.UseVisualStyleBackColor = true;
            this.buttonGetToken.Click += new System.EventHandler(this.buttonGetToken_Click);
            // 
            // FrmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 480);
            this.Controls.Add(this.buttonGetToken);
            this.Controls.Add(this.buttonDelAccount);
            this.Controls.Add(this.btnAddOrUpdateAccount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxAllAccounts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAccount";
            this.Text = "Account Settings";
            this.Load += new System.EventHandler(this.FrmAccount_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAllAccounts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPayPalPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPayPalUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPayPalSignature;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPayPalAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEbayToken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEbayAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddOrUpdateAccount;
        private System.Windows.Forms.Button buttonDelAccount;
        private System.Windows.Forms.Button buttonGetToken;
    }
}