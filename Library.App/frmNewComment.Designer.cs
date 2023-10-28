namespace Library.App
{
    partial class frmNewComment
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnSaveCommnent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBooks = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "نظر : ";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(12, 69);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(460, 187);
            this.txtComment.TabIndex = 2;
            // 
            // btnSaveCommnent
            // 
            this.btnSaveCommnent.Location = new System.Drawing.Point(397, 276);
            this.btnSaveCommnent.Name = "btnSaveCommnent";
            this.btnSaveCommnent.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCommnent.TabIndex = 3;
            this.btnSaveCommnent.Text = "ثبت نظر";
            this.btnSaveCommnent.UseVisualStyleBackColor = true;
            this.btnSaveCommnent.Click += new System.EventHandler(this.btnSaveCommnent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "عنوان کتاب : ";
            // 
            // cbBooks
            // 
            this.cbBooks.FormattingEnabled = true;
            this.cbBooks.Location = new System.Drawing.Point(281, 6);
            this.cbBooks.Name = "cbBooks";
            this.cbBooks.Size = new System.Drawing.Size(121, 21);
            this.cbBooks.TabIndex = 5;
            // 
            // frmNewComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.cbBooks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaveCommnent);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNewComment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "اضافه کردن نظر";
            this.Load += new System.EventHandler(this.frmNewComment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnSaveCommnent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBooks;
    }
}