namespace EbayMaster
{
    partial class FrmUploadTrackingNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUploadTrackingNumber));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCarrier = new System.Windows.Forms.TextBox();
            this.textBoxTrackingNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUploadTrackingNumber = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "物流商";
            // 
            // textBoxCarrier
            // 
            this.textBoxCarrier.Location = new System.Drawing.Point(125, 37);
            this.textBoxCarrier.Name = "textBoxCarrier";
            this.textBoxCarrier.Size = new System.Drawing.Size(159, 20);
            this.textBoxCarrier.TabIndex = 1;
            // 
            // textBoxTrackingNumber
            // 
            this.textBoxTrackingNumber.Location = new System.Drawing.Point(125, 101);
            this.textBoxTrackingNumber.Name = "textBoxTrackingNumber";
            this.textBoxTrackingNumber.Size = new System.Drawing.Size(159, 20);
            this.textBoxTrackingNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "跟踪号";
            // 
            // buttonUploadTrackingNumber
            // 
            this.buttonUploadTrackingNumber.Location = new System.Drawing.Point(149, 177);
            this.buttonUploadTrackingNumber.Name = "buttonUploadTrackingNumber";
            this.buttonUploadTrackingNumber.Size = new System.Drawing.Size(75, 25);
            this.buttonUploadTrackingNumber.TabIndex = 4;
            this.buttonUploadTrackingNumber.Text = "确认上传";
            this.buttonUploadTrackingNumber.UseVisualStyleBackColor = true;
            this.buttonUploadTrackingNumber.Click += new System.EventHandler(this.buttonUploadTrackingNumber_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(132, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "例如：China Post";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(132, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "例如：LK523307787CN";
            // 
            // FrmUploadTrackingNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 215);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonUploadTrackingNumber);
            this.Controls.Add(this.textBoxTrackingNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCarrier);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUploadTrackingNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUploadTrackingNumber";
            this.Load += new System.EventHandler(this.FrmUploadTrackingNumber_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCarrier;
        private System.Windows.Forms.TextBox textBoxTrackingNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUploadTrackingNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}