namespace Library.App
{
    partial class frmComment
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
            this.commentToolStrip = new System.Windows.Forms.ToolStrip();
            this.dgBookComment = new System.Windows.Forms.DataGridView();
            this.btnNewComment = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBooks = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookComment)).BeginInit();
            this.SuspendLayout();
            // 
            // commentToolStrip
            // 
            this.commentToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewComment});
            this.commentToolStrip.Location = new System.Drawing.Point(0, 0);
            this.commentToolStrip.Name = "commentToolStrip";
            this.commentToolStrip.Size = new System.Drawing.Size(584, 62);
            this.commentToolStrip.TabIndex = 0;
            this.commentToolStrip.Text = "toolStrip1";
            // 
            // dgBookComment
            // 
            this.dgBookComment.AllowUserToAddRows = false;
            this.dgBookComment.AllowUserToDeleteRows = false;
            this.dgBookComment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBookComment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBookComment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgBookComment.Location = new System.Drawing.Point(12, 133);
            this.dgBookComment.Name = "dgBookComment";
            this.dgBookComment.ReadOnly = true;
            this.dgBookComment.Size = new System.Drawing.Size(572, 316);
            this.dgBookComment.TabIndex = 1;
            this.dgBookComment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnNewComment
            // 
            this.btnNewComment.Image = global::Library.App.Properties.Resources._1371475973_document_edit;
            this.btnNewComment.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewComment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewComment.Name = "btnNewComment";
            this.btnNewComment.Size = new System.Drawing.Size(66, 59);
            this.btnNewComment.Text = "افزودن نظر";
            this.btnNewComment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewComment.Click += new System.EventHandler(this.btnNewComment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "کتاب : ";
            // 
            // cbBooks
            // 
            this.cbBooks.FormattingEnabled = true;
            this.cbBooks.Location = new System.Drawing.Point(394, 80);
            this.cbBooks.Name = "cbBooks";
            this.cbBooks.Size = new System.Drawing.Size(128, 21);
            this.cbBooks.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CommentId";
            this.Column1.HeaderText = "CommentId";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "User1";
            this.Column2.HeaderText = "کاربر";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CommentText";
            this.Column3.HeaderText = "نظر";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // frmComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.cbBooks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgBookComment);
            this.Controls.Add(this.commentToolStrip);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmComment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "نظرات";
            this.Load += new System.EventHandler(this.frmComment_Load);
            this.commentToolStrip.ResumeLayout(false);
            this.commentToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookComment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip commentToolStrip;
        private System.Windows.Forms.ToolStripButton btnNewComment;
        private System.Windows.Forms.DataGridView dgBookComment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}