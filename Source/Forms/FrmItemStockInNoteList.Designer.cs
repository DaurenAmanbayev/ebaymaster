namespace EbayMaster
{
    partial class FrmItemStockInNoteList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItemStockInNoteList));
            this.contextMenuStripItemStockInNote = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemDelItemStockInNote = new System.Windows.Forms.ToolStripMenuItem();
            this.pagedDgvItem = new EbayMaster.PagedDataGridView();
            this.contextMenuStripItemStockInNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripItemStockInNote
            // 
            this.contextMenuStripItemStockInNote.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDelItemStockInNote});
            this.contextMenuStripItemStockInNote.Name = "contextMenuStripDeliveryNote";
            this.contextMenuStripItemStockInNote.Size = new System.Drawing.Size(135, 26);
            // 
            // ToolStripMenuItemDelItemStockInNote
            // 
            this.ToolStripMenuItemDelItemStockInNote.Name = "ToolStripMenuItemDelItemStockInNote";
            this.ToolStripMenuItemDelItemStockInNote.Size = new System.Drawing.Size(134, 22);
            this.ToolStripMenuItemDelItemStockInNote.Text = "删除入库单";
            this.ToolStripMenuItemDelItemStockInNote.Click += new System.EventHandler(this.ToolStripMenuItemDelItemStockInNote_Click);
            // 
            // pagedDgvItem
            // 
            this.pagedDgvItem.Location = new System.Drawing.Point(0, 2);
            this.pagedDgvItem.Name = "pagedDgvItem";
            this.pagedDgvItem.Size = new System.Drawing.Size(702, 496);
            this.pagedDgvItem.TabIndex = 1;
            // 
            // FrmItemStockInNoteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 511);
            this.Controls.Add(this.pagedDgvItem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmItemStockInNoteList";
            this.Text = "查看入库单 (删除：右击）";
            this.Load += new System.EventHandler(this.FrmItemStockInNoteList_Load);
            this.contextMenuStripItemStockInNote.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStripItemStockInNote;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDelItemStockInNote;
        private PagedDataGridView pagedDgvItem;
    }
}