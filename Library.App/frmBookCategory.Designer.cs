namespace Library.App
{
    partial class frmBookCategory
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNewCatergory = new System.Windows.Forms.ToolStripButton();
            this.btnEditCategory = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnRefreshCategory = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtCategoryFilter = new System.Windows.Forms.ToolStripTextBox();
            this.dgCategory = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewCatergory,
            this.btnEditCategory,
            this.btnDelete,
            this.btnRefreshCategory,
            this.toolStripLabel1,
            this.txtCategoryFilter});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(484, 62);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNewCatergory
            // 
            this.btnNewCatergory.Image = global::Library.App.Properties.Resources.list2;
            this.btnNewCatergory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewCatergory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewCatergory.Name = "btnNewCatergory";
            this.btnNewCatergory.Size = new System.Drawing.Size(68, 59);
            this.btnNewCatergory.Text = "اضافه کردن";
            this.btnNewCatergory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewCatergory.Click += new System.EventHandler(this.btnNewCatergory_Click);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Image = global::Library.App.Properties.Resources._1371475973_document_edit;
            this.btnEditCategory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(74, 59);
            this.btnEditCategory.Text = "ویرایش کردن";
            this.btnEditCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Library.App.Properties.Resources._1371476007_Close_Box_Red;
            this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 59);
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefreshCategory
            // 
            this.btnRefreshCategory.Image = global::Library.App.Properties.Resources._1371476368_Synchronize;
            this.btnRefreshCategory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefreshCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshCategory.Name = "btnRefreshCategory";
            this.btnRefreshCategory.Size = new System.Drawing.Size(60, 59);
            this.btnRefreshCategory.Text = "بروزرسانی";
            this.btnRefreshCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefreshCategory.Click += new System.EventHandler(this.btnRefreshCategory_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 59);
            this.toolStripLabel1.Text = "جستجو : ";
            // 
            // txtCategoryFilter
            // 
            this.txtCategoryFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCategoryFilter.Name = "txtCategoryFilter";
            this.txtCategoryFilter.Size = new System.Drawing.Size(100, 62);
            this.txtCategoryFilter.TextChanged += new System.EventHandler(this.txtCategoryFilter_TextChanged);
            // 
            // dgCategory
            // 
            this.dgCategory.AllowUserToAddRows = false;
            this.dgCategory.AllowUserToDeleteRows = false;
            this.dgCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgCategory.Location = new System.Drawing.Point(12, 65);
            this.dgCategory.Name = "dgCategory";
            this.dgCategory.ReadOnly = true;
            this.dgCategory.Size = new System.Drawing.Size(460, 284);
            this.dgCategory.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CategoryId";
            this.Column1.HeaderText = "CategoryId";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CategoryTitle";
            this.Column2.HeaderText = "عنوان دسته‌بندی";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // frmBookCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.dgCategory);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBookCategory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "دسته‌بندی";
            this.Load += new System.EventHandler(this.frmNewBookCategory_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNewCatergory;
        private System.Windows.Forms.ToolStripButton btnEditCategory;
        private System.Windows.Forms.ToolStripButton btnRefreshCategory;
        private System.Windows.Forms.DataGridView dgCategory;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtCategoryFilter;
    }
}