using Library.DataLayer;
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
    public partial class frmComment : Form
    {
        UnitOfWork db = new UnitOfWork();
        public frmComment()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmComment_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void cbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBooks.SelectedItem != null)
            {
                int selectedBookId = (int)cbBooks.SelectedValue;

                // درخواست نظرات مرتبط با کتاب انتخابی
                //List<Comment> comments = db.CommentRepository.Get(c => c.BookId == selectedBookId).ToList();

                // نمایش نظرات در DataGridView
                //dgBookComment.DataSource = comments;
            }
        }

        void BindGrid()
        {
            dgBookComment.AutoGenerateColumns = false;
            cbBooks.DataSource = db.BookRepository.Get();
            cbBooks.DisplayMember = "BookTitle";
            cbBooks.ValueMember = "BookId";
            cbBooks.SelectedIndexChanged += new EventHandler(cbBooks_SelectedIndexChanged);

            // اجرای تابع برای کتاب انتخابی
            cbBooks_SelectedIndexChanged(cbBooks, EventArgs.Empty);

        }


        private void btnNewComment_Click(object sender, EventArgs e)
        {
            frmNewComment frmNewComment = new frmNewComment();
            if (frmNewComment.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }
    }
}
