namespace Library.App
{
    partial class frmNewBook
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbBookCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numPublishYear = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.bookImage = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPublishYear)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbBookCategory);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numPublishYear);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBookAuthor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBookTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(227, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات کتاب";
            // 
            // cbBookCategory
            // 
            this.cbBookCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBookCategory.FormattingEnabled = true;
            this.cbBookCategory.Location = new System.Drawing.Point(6, 157);
            this.cbBookCategory.Name = "cbBookCategory";
            this.cbBookCategory.Size = new System.Drawing.Size(260, 21);
            this.cbBookCategory.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "دسته بندی : ";
            // 
            // numPublishYear
            // 
            this.numPublishYear.Location = new System.Drawing.Point(6, 112);
            this.numPublishYear.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numPublishYear.Name = "numPublishYear";
            this.numPublishYear.Size = new System.Drawing.Size(260, 21);
            this.numPublishYear.TabIndex = 5;
            this.numPublishYear.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "سال انتشار : ";
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.Location = new System.Drawing.Point(6, 68);
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(260, 21);
            this.txtBookAuthor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "نویسنده : ";
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(6, 26);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(260, 21);
            this.txtBookTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "عنوان کتاب : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSelectImage);
            this.groupBox2.Controls.Add(this.bookImage);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 328);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تصویر کتاب";
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(6, 286);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(188, 23);
            this.btnSelectImage.TabIndex = 3;
            this.btnSelectImage.Text = "انتخاب تصویر";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // bookImage
            // 
            this.bookImage.Image = global::Library.App.Properties.Resources.images;
            this.bookImage.Location = new System.Drawing.Point(6, 26);
            this.bookImage.Name = "bookImage";
            this.bookImage.Size = new System.Drawing.Size(194, 254);
            this.bookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bookImage.TabIndex = 0;
            this.bookImage.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(357, 227);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "افزودن";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 352);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNewBook";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "افزودن کتاب";
            this.Load += new System.EventHandler(this.frmNewBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPublishYear)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numPublishYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox bookImage;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.ComboBox cbBookCategory;
        private System.Windows.Forms.Label label4;
    }
}