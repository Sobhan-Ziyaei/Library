namespace Library.App
{
    partial class frmBook
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
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtBookFilterSearch = new System.Windows.Forms.ToolStripTextBox();
            this.dgBook = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNewBook = new System.Windows.Forms.ToolStripButton();
            this.btnEditBook = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteBook = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBook)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewBook,
            this.btnEditBook,
            this.btnDeleteBook,
            this.btnEdit,
            this.toolStripButton1,
            this.toolStripLabel1,
            this.txtBookFilterSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 62);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 59);
            this.toolStripLabel1.Text = "جستجو : ";
            // 
            // txtBookFilterSearch
            // 
            this.txtBookFilterSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBookFilterSearch.Name = "txtBookFilterSearch";
            this.txtBookFilterSearch.Size = new System.Drawing.Size(100, 62);
            this.txtBookFilterSearch.TextChanged += new System.EventHandler(this.txtBookFilterSearch_TextChanged);
            // 
            // dgBook
            // 
            this.dgBook.AllowUserToAddRows = false;
            this.dgBook.AllowUserToDeleteRows = false;
            this.dgBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6});
            this.dgBook.Location = new System.Drawing.Point(12, 65);
            this.dgBook.Name = "dgBook";
            this.dgBook.ReadOnly = true;
            this.dgBook.Size = new System.Drawing.Size(776, 373);
            this.dgBook.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "BookId";
            this.Column1.HeaderText = "BookId";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "BookCategoryId";
            this.Column5.HeaderText = "CategoryId";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BookTitle";
            this.Column2.HeaderText = "عنوان کتاب";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "BookAuthor";
            this.Column3.HeaderText = "نویسنده";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "BookPublishYear";
            this.Column4.HeaderText = "سال انتشار";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "BookCategory";
            this.Column6.HeaderText = "دسته بندی";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // btnNewBook
            // 
            this.btnNewBook.Image = global::Library.App.Properties.Resources._1371475930_filenew;
            this.btnNewBook.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewBook.Name = "btnNewBook";
            this.btnNewBook.Size = new System.Drawing.Size(44, 59);
            this.btnNewBook.Text = "افزودن";
            this.btnNewBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewBook.Click += new System.EventHandler(this.btnNewBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.Image = global::Library.App.Properties.Resources._1371475973_document_edit;
            this.btnEditBook.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(47, 59);
            this.btnEditBook.Text = "ویرایش";
            this.btnEditBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Image = global::Library.App.Properties.Resources._1371476007_Close_Box_Red;
            this.btnDeleteBook.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(44, 59);
            this.btnDeleteBook.Text = "حذف";
            this.btnDeleteBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::Library.App.Properties.Resources._1371476368_Synchronize;
            this.btnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(60, 59);
            this.btnEdit.Text = "بروزرسانی";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Library.App.Properties.Resources.list2;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(46, 59);
            this.toolStripButton1.Text = "نظرات ";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgBook);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBook";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "کتب";
            this.Load += new System.EventHandler(this.frmBook_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNewBook;
        private System.Windows.Forms.ToolStripButton btnEditBook;
        private System.Windows.Forms.ToolStripButton btnDeleteBook;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.DataGridView dgBook;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtBookFilterSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}