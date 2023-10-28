namespace Library.App
{
    partial class Form1
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
            this.btnBookCategory = new System.Windows.Forms.ToolStripButton();
            this.btnBook = new System.Windows.Forms.ToolStripButton();
            this.btnEditUser = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBookCategory,
            this.btnBook,
            this.btnEditUser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 62);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnBookCategory
            // 
            this.btnBookCategory.Image = global::Library.App.Properties.Resources._1371475930_filenew;
            this.btnBookCategory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBookCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBookCategory.Name = "btnBookCategory";
            this.btnBookCategory.Size = new System.Drawing.Size(63, 59);
            this.btnBookCategory.Text = "دسته‌بندی ";
            this.btnBookCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBookCategory.Click += new System.EventHandler(this.btnBookCategory_Click);
            // 
            // btnBook
            // 
            this.btnBook.Image = global::Library.App.Properties.Resources._1371476070_self1;
            this.btnBook.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(44, 59);
            this.btnBook.Text = "کتب";
            this.btnBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Image = global::Library.App.Properties.Resources._1371476468_preferences_contact_list;
            this.btnEditUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(86, 59);
            this.btnEditUser.Text = "تغییر کلمه عبور";
            this.btnEditUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کتابخانه ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnBookCategory;
        private System.Windows.Forms.ToolStripButton btnBook;
        private System.Windows.Forms.ToolStripButton btnEditUser;
    }
}

