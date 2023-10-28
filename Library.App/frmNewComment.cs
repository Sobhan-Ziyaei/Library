using Library.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.App
{
    public partial class frmNewComment : Form
    {
        UnitOfWork db = new UnitOfWork();
        public frmNewComment()
        {
            InitializeComponent();
        }

        private void frmNewComment_Load(object sender, EventArgs e)
        {
            cbBooks.DataSource = db.BookRepository.Get();
            cbBooks.DisplayMember = "BookTitle";
            cbBooks.ValueMember = "BookId";
        }

        private void btnSaveCommnent_Click(object sender, EventArgs e)
        {
            //var newComment = new DataLayer.Comment
            //{
            //    CommentText = txtComment.Text,
            //    CommentDate = DateTime.Now,
            //    BookId = 10,
            //    UserId = 1,

            //};
            //db.CommentRepository.Insert(newComment);
            //db.CommentRepository.Save();
            //DialogResult = DialogResult.OK;
        }
    }
}
