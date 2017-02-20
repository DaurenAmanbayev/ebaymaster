namespace EbayMaster
{
    partial class FrmSelectShippingService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelectShippingService));
            this.listBoxShippingService = new System.Windows.Forms.ListBox();
            this.buttonSelectShippingService = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxShippingService
            // 
            this.listBoxShippingService.FormattingEnabled = true;
            this.listBoxShippingService.Location = new System.Drawing.Point(21, 13);
            this.listBoxShippingService.Name = "listBoxShippingService";
            this.listBoxShippingService.Size = new System.Drawing.Size(331, 264);
            this.listBoxShippingService.TabIndex = 0;
            this.listBoxShippingService.SelectedIndexChanged += new System.EventHandler(this.listBoxShippingService_SelectedIndexChanged);
            this.listBoxShippingService.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxShippingService_MouseDoubleClick);
            // 
            // buttonSelectShippingService
            // 
            this.buttonSelectShippingService.Location = new System.Drawing.Point(145, 309);
            this.buttonSelectShippingService.Name = "buttonSelectShippingService";
            this.buttonSelectShippingService.Size = new System.Drawing.Size(75, 25);
            this.buttonSelectShippingService.TabIndex = 1;
            this.buttonSelectShippingService.Text = "确认";
            this.buttonSelectShippingService.UseVisualStyleBackColor = true;
            this.buttonSelectShippingService.Click += new System.EventHandler(this.buttonSelectShippingService_Click);
            // 
            // FrmSelectShippingService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 347);
            this.Controls.Add(this.buttonSelectShippingService);
            this.Controls.Add(this.listBoxShippingService);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSelectShippingService";
            this.Text = "FrmSelectShippingService";
            this.Load += new System.EventHandler(this.FrmSelectShippingService_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxShippingService;
        private System.Windows.Forms.Button buttonSelectShippingService;
    }
}