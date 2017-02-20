namespace EbayMaster
{
    partial class FrmDeliveryNoteList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeliveryNoteList));
            this.contextMenuStripDeliveryNote = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemDelDeliveryNote = new System.Windows.Forms.ToolStripMenuItem();
            this.pagedDgvDeliveryNote = new EbayMaster.PagedDataGridView();
            this.contextMenuStripDeliveryNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripDeliveryNote
            // 
            this.contextMenuStripDeliveryNote.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDelDeliveryNote});
            this.contextMenuStripDeliveryNote.Name = "contextMenuStripDeliveryNote";
            this.contextMenuStripDeliveryNote.Size = new System.Drawing.Size(135, 26);
            // 
            // ToolStripMenuItemDelDeliveryNote
            // 
            this.ToolStripMenuItemDelDeliveryNote.Name = "ToolStripMenuItemDelDeliveryNote";
            this.ToolStripMenuItemDelDeliveryNote.Size = new System.Drawing.Size(134, 22);
            this.ToolStripMenuItemDelDeliveryNote.Text = "删除发货单";
            this.ToolStripMenuItemDelDeliveryNote.Click += new System.EventHandler(this.ToolStripMenuItemDelDeliveryNote_Click);
            // 
            // pagedDgvDeliveryNote
            // 
            this.pagedDgvDeliveryNote.Location = new System.Drawing.Point(12, -2);
            this.pagedDgvDeliveryNote.Name = "pagedDgvDeliveryNote";
            this.pagedDgvDeliveryNote.Size = new System.Drawing.Size(795, 488);
            this.pagedDgvDeliveryNote.TabIndex = 2;
            // 
            // FrmDeliveryNoteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 494);
            this.Controls.Add(this.pagedDgvDeliveryNote);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDeliveryNoteList";
            this.Text = "View the invoice (Edit: double-click/Enter delete: right)";
            this.Load += new System.EventHandler(this.FrmDeliveryNoteList_Load);
            this.contextMenuStripDeliveryNote.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStripDeliveryNote;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDelDeliveryNote;
        private PagedDataGridView pagedDgvDeliveryNote;
    }
}