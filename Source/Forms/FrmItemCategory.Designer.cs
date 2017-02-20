namespace EbayMaster
{
    partial class FrmItemCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItemCategory));
            this.buttonDeleteCategory = new System.Windows.Forms.Button();
            this.textBoxParentCategory = new System.Windows.Forms.TextBox();
            this.labelParentCategoryName = new System.Windows.Forms.Label();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddNewCategory = new System.Windows.Forms.Button();
            this.treeViewAllCategories = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // buttonDeleteCategory
            // 
            this.buttonDeleteCategory.Location = new System.Drawing.Point(398, 257);
            this.buttonDeleteCategory.Name = "buttonDeleteCategory";
            this.buttonDeleteCategory.Size = new System.Drawing.Size(75, 25);
            this.buttonDeleteCategory.TabIndex = 13;
            this.buttonDeleteCategory.Text = "删除类别";
            this.buttonDeleteCategory.UseVisualStyleBackColor = true;
            this.buttonDeleteCategory.Click += new System.EventHandler(this.buttonDeleteCategory_Click);
            // 
            // textBoxParentCategory
            // 
            this.textBoxParentCategory.Location = new System.Drawing.Point(381, 119);
            this.textBoxParentCategory.Name = "textBoxParentCategory";
            this.textBoxParentCategory.Size = new System.Drawing.Size(195, 20);
            this.textBoxParentCategory.TabIndex = 12;
            this.textBoxParentCategory.Text = "无";
            // 
            // labelParentCategoryName
            // 
            this.labelParentCategoryName.AutoSize = true;
            this.labelParentCategoryName.Location = new System.Drawing.Point(322, 122);
            this.labelParentCategoryName.Name = "labelParentCategoryName";
            this.labelParentCategoryName.Size = new System.Drawing.Size(43, 13);
            this.labelParentCategoryName.TabIndex = 11;
            this.labelParentCategoryName.Text = "父类别";
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Location = new System.Drawing.Point(381, 55);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(195, 20);
            this.textBoxCategoryName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "类别名称";
            // 
            // buttonAddNewCategory
            // 
            this.buttonAddNewCategory.Location = new System.Drawing.Point(398, 193);
            this.buttonAddNewCategory.Name = "buttonAddNewCategory";
            this.buttonAddNewCategory.Size = new System.Drawing.Size(75, 25);
            this.buttonAddNewCategory.TabIndex = 8;
            this.buttonAddNewCategory.Text = "添加类别";
            this.buttonAddNewCategory.UseVisualStyleBackColor = true;
            this.buttonAddNewCategory.Click += new System.EventHandler(this.buttonAddNewCategory_Click);
            // 
            // treeViewAllCategories
            // 
            this.treeViewAllCategories.Location = new System.Drawing.Point(18, 14);
            this.treeViewAllCategories.Name = "treeViewAllCategories";
            this.treeViewAllCategories.Size = new System.Drawing.Size(282, 304);
            this.treeViewAllCategories.TabIndex = 7;
            this.treeViewAllCategories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewAllCategories_AfterSelect);
            // 
            // FrmItemCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 333);
            this.Controls.Add(this.buttonDeleteCategory);
            this.Controls.Add(this.textBoxParentCategory);
            this.Controls.Add(this.labelParentCategoryName);
            this.Controls.Add(this.textBoxCategoryName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddNewCategory);
            this.Controls.Add(this.treeViewAllCategories);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmItemCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmItemCategory";
            this.Load += new System.EventHandler(this.FrmItemCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeleteCategory;
        private System.Windows.Forms.TextBox textBoxParentCategory;
        private System.Windows.Forms.Label labelParentCategoryName;
        private System.Windows.Forms.TextBox textBoxCategoryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddNewCategory;
        private System.Windows.Forms.TreeView treeViewAllCategories;
    }
}