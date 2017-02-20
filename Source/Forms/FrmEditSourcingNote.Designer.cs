namespace EbayMaster
{
    partial class FrmEditSourcingNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditSourcingNote));
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.buttonSelectSupplier = new System.Windows.Forms.Button();
            this.textBoxSupplier = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelErrMsg = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTotalFee = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxShippingFee = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxExtraFee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCalTotalFee = new System.Windows.Forms.Button();
            this.buttonFinishEditing = new System.Windows.Forms.Button();
            this.dgvItems = new EbayMaster.CustomGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(403, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Time";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(462, 33);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(155, 20);
            this.dateTimePickerDate.TabIndex = 2;
            // 
            // buttonSelectSupplier
            // 
            this.buttonSelectSupplier.Location = new System.Drawing.Point(281, 34);
            this.buttonSelectSupplier.Name = "buttonSelectSupplier";
            this.buttonSelectSupplier.Size = new System.Drawing.Size(116, 25);
            this.buttonSelectSupplier.TabIndex = 1;
            this.buttonSelectSupplier.Text = "Selection of suppliers";
            this.buttonSelectSupplier.UseVisualStyleBackColor = true;
            this.buttonSelectSupplier.Click += new System.EventHandler(this.buttonSelectSupplier_Click);
            // 
            // textBoxSupplier
            // 
            this.textBoxSupplier.Location = new System.Drawing.Point(108, 36);
            this.textBoxSupplier.Name = "textBoxSupplier";
            this.textBoxSupplier.ReadOnly = true;
            this.textBoxSupplier.Size = new System.Drawing.Size(156, 20);
            this.textBoxSupplier.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Suppliers";
            // 
            // labelErrMsg
            // 
            this.labelErrMsg.AutoSize = true;
            this.labelErrMsg.ForeColor = System.Drawing.Color.Red;
            this.labelErrMsg.Location = new System.Drawing.Point(49, 283);
            this.labelErrMsg.Name = "labelErrMsg";
            this.labelErrMsg.Size = new System.Drawing.Size(38, 13);
            this.labelErrMsg.TabIndex = 25;
            this.labelErrMsg.Text = "errmsg";
            this.labelErrMsg.Visible = false;
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(96, 350);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(521, 20);
            this.textBoxComment.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Notes";
            // 
            // textBoxTotalFee
            // 
            this.textBoxTotalFee.Location = new System.Drawing.Point(96, 400);
            this.textBoxTotalFee.Name = "textBoxTotalFee";
            this.textBoxTotalFee.ReadOnly = true;
            this.textBoxTotalFee.Size = new System.Drawing.Size(155, 20);
            this.textBoxTotalFee.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Total costs";
            // 
            // textBoxShippingFee
            // 
            this.textBoxShippingFee.Location = new System.Drawing.Point(462, 307);
            this.textBoxShippingFee.Name = "textBoxShippingFee";
            this.textBoxShippingFee.Size = new System.Drawing.Size(155, 20);
            this.textBoxShippingFee.TabIndex = 5;
            this.textBoxShippingFee.Text = "0.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Freight";
            // 
            // textBoxExtraFee
            // 
            this.textBoxExtraFee.Location = new System.Drawing.Point(97, 307);
            this.textBoxExtraFee.Name = "textBoxExtraFee";
            this.textBoxExtraFee.Size = new System.Drawing.Size(155, 20);
            this.textBoxExtraFee.TabIndex = 4;
            this.textBoxExtraFee.Text = "0.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Other costs";
            // 
            // buttonCalTotalFee
            // 
            this.buttonCalTotalFee.Location = new System.Drawing.Point(253, 434);
            this.buttonCalTotalFee.Name = "buttonCalTotalFee";
            this.buttonCalTotalFee.Size = new System.Drawing.Size(75, 25);
            this.buttonCalTotalFee.TabIndex = 8;
            this.buttonCalTotalFee.Text = "Count";
            this.buttonCalTotalFee.UseVisualStyleBackColor = true;
            this.buttonCalTotalFee.Click += new System.EventHandler(this.buttonCalTotalFee_Click);
            // 
            // buttonFinishEditing
            // 
            this.buttonFinishEditing.Location = new System.Drawing.Point(366, 434);
            this.buttonFinishEditing.Name = "buttonFinishEditing";
            this.buttonFinishEditing.Size = new System.Drawing.Size(75, 25);
            this.buttonFinishEditing.TabIndex = 9;
            this.buttonFinishEditing.Text = "Finish";
            this.buttonFinishEditing.UseVisualStyleBackColor = true;
            this.buttonFinishEditing.Click += new System.EventHandler(this.buttonFinishEditing_Click);
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(28, 79);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowTemplate.Height = 23;
            this.dgvItems.Size = new System.Drawing.Size(637, 191);
            this.dgvItems.TabIndex = 3;
            this.dgvItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellClick);
            this.dgvItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvItems_KeyDown);
            this.dgvItems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvItems_KeyPress);
            // 
            // FrmEditSourcingNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 482);
            this.Controls.Add(this.buttonCalTotalFee);
            this.Controls.Add(this.buttonFinishEditing);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxTotalFee);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxShippingFee);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxExtraFee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelErrMsg);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.buttonSelectSupplier);
            this.Controls.Add(this.textBoxSupplier);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditSourcingNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creates a purchase-record purchase expenses";
            this.Load += new System.EventHandler(this.FrmEditSourcingNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Button buttonSelectSupplier;
        private System.Windows.Forms.TextBox textBoxSupplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelErrMsg;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTotalFee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxShippingFee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxExtraFee;
        private System.Windows.Forms.Label label5;
        private CustomGrid dgvItems;
        private System.Windows.Forms.Button buttonCalTotalFee;
        private System.Windows.Forms.Button buttonFinishEditing;
    }
}