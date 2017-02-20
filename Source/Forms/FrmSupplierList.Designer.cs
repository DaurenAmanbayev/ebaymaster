namespace EbayMaster
{
    partial class FrmSupplierList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSupplierList));
            this.contextMenuStripSupplier = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemEditSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDelSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFinishSelecting = new System.Windows.Forms.Button();
            this.pagedDgvSupplier = new EbayMaster.PagedDataGridView();
            this.contextMenuStripSupplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripSupplier
            // 
            this.contextMenuStripSupplier.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemEditSupplier,
            this.ToolStripMenuItemDelSupplier});
            this.contextMenuStripSupplier.Name = "contextMenuStripSupplier";
            this.contextMenuStripSupplier.Size = new System.Drawing.Size(135, 48);
            // 
            // ToolStripMenuItemEditSupplier
            // 
            this.ToolStripMenuItemEditSupplier.Name = "ToolStripMenuItemEditSupplier";
            this.ToolStripMenuItemEditSupplier.Size = new System.Drawing.Size(134, 22);
            this.ToolStripMenuItemEditSupplier.Text = "编辑供应商";
            this.ToolStripMenuItemEditSupplier.Click += new System.EventHandler(this.ToolStripMenuItemEditSupplier_Click);
            // 
            // ToolStripMenuItemDelSupplier
            // 
            this.ToolStripMenuItemDelSupplier.Name = "ToolStripMenuItemDelSupplier";
            this.ToolStripMenuItemDelSupplier.Size = new System.Drawing.Size(134, 22);
            this.ToolStripMenuItemDelSupplier.Text = "删除供应商";
            this.ToolStripMenuItemDelSupplier.Click += new System.EventHandler(this.ToolStripMenuItemDelSupplier_Click);
            // 
            // btnFinishSelecting
            // 
            this.btnFinishSelecting.Location = new System.Drawing.Point(384, 441);
            this.btnFinishSelecting.Name = "btnFinishSelecting";
            this.btnFinishSelecting.Size = new System.Drawing.Size(95, 29);
            this.btnFinishSelecting.TabIndex = 2;
            this.btnFinishSelecting.Text = "选择";
            this.btnFinishSelecting.UseVisualStyleBackColor = true;
            this.btnFinishSelecting.Click += new System.EventHandler(this.btnFinishSelecting_Click);
            // 
            // pagedDgvSupplier
            // 
            this.pagedDgvSupplier.Location = new System.Drawing.Point(6, 1);
            this.pagedDgvSupplier.Name = "pagedDgvSupplier";
            this.pagedDgvSupplier.Size = new System.Drawing.Size(856, 522);
            this.pagedDgvSupplier.TabIndex = 1;
            // 
            // FrmSupplierList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 527);
            this.Controls.Add(this.btnFinishSelecting);
            this.Controls.Add(this.pagedDgvSupplier);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSupplierList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "供应商列表";
            this.Load += new System.EventHandler(this.FrmSupplierList_Load);
            this.contextMenuStripSupplier.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStripSupplier;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEditSupplier;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDelSupplier;
        private PagedDataGridView pagedDgvSupplier;
        private System.Windows.Forms.Button btnFinishSelecting;
    }
}