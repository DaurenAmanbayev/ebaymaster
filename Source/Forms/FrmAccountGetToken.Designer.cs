namespace EbayMaster
{
    partial class FrmAccountGetToken
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccountGetToken));
            this.buttonGetTokenStep1 = new System.Windows.Forms.Button();
            this.buttonGetTokenStep2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxToken = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFinish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGetTokenStep1
            // 
            this.buttonGetTokenStep1.Location = new System.Drawing.Point(120, 26);
            this.buttonGetTokenStep1.Name = "buttonGetTokenStep1";
            this.buttonGetTokenStep1.Size = new System.Drawing.Size(286, 41);
            this.buttonGetTokenStep1.TabIndex = 0;
            this.buttonGetTokenStep1.Text = "Step 1:  Login ebay complete confirmation";
            this.buttonGetTokenStep1.UseVisualStyleBackColor = true;
            this.buttonGetTokenStep1.Click += new System.EventHandler(this.buttonGetTokenStep1_Click);
            // 
            // buttonGetTokenStep2
            // 
            this.buttonGetTokenStep2.Enabled = false;
            this.buttonGetTokenStep2.Location = new System.Drawing.Point(120, 146);
            this.buttonGetTokenStep2.Name = "buttonGetTokenStep2";
            this.buttonGetTokenStep2.Size = new System.Drawing.Size(286, 41);
            this.buttonGetTokenStep2.TabIndex = 1;
            this.buttonGetTokenStep2.Text = "Step 2: Wait 10 seconds, click this button to get the token";
            this.buttonGetTokenStep2.UseVisualStyleBackColor = true;
            this.buttonGetTokenStep2.Click += new System.EventHandler(this.buttonGetTokenStep2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EbayMaster.Properties.Resources.downarrow;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(229, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 66);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EbayMaster.Properties.Resources.downarrow;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(229, 197);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 66);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxToken);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(28, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 182);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // textBoxToken
            // 
            this.textBoxToken.Location = new System.Drawing.Point(47, 25);
            this.textBoxToken.Multiline = true;
            this.textBoxToken.Name = "textBoxToken";
            this.textBoxToken.ReadOnly = true;
            this.textBoxToken.Size = new System.Drawing.Size(404, 137);
            this.textBoxToken.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "token";
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(226, 473);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(75, 25);
            this.buttonFinish.TabIndex = 5;
            this.buttonFinish.Text = "Carry Out";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // FrmAccountGetToken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 510);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonGetTokenStep2);
            this.Controls.Add(this.buttonGetTokenStep1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAccountGetToken";
            this.Text = "Get Token";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGetTokenStep1;
        private System.Windows.Forms.Button buttonGetTokenStep2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxToken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFinish;
    }
}