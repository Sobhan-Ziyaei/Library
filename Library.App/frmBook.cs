using Library.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.App
{
    public partial class frmBook : Form
    {
        UnitOfWork db = new UnitOfWork();
        public frmBook()
        {
            InitializeComponent();
        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        void BindGrid()
        {
            dgBook.AutoGenerateColumns = false;
            dgBook.DataSource = null;
            dgBook.DataSource = db.BookRepository.Get();
            dgBook.Refresh();
        }

        private void txtBookFilterSearch_TextChanged(object sender, EventArgs e)
        {
            dgBook.DataSource = db.BookRepository.Get(x => x.BookTitle.Contains(txtBookFilterSearch.Text) || x.BookAuthor.Contains(txtBookFilterSearch.Text) || x.BookPublishYear.Contains(txtBookFilterSearch.Text) || x.BookCategory.Contains(txtBookFilterSearch.Text));
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dgBook.CurrentRow != null)
            {
                int bookId = int.Parse(dgBook.CurrentRow.Cells[0].Value.ToString());
                var book = db.BookRepository.GetById(bookId);

                if (book != null)
                {
                    if (MessageBox.Show($"آیا از حذف کتاب {book.BookTitle} مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        db.BookRepository.Delete(book);
                        db.BookRepository.Save();
                        BindGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("لطفاً یک سطر را انتخاب کنید");
            }
        }

        private void btnNewBook_Click(object sender, EventArgs e)
        {
            frmNewBook frmNewBook = new frmNewBook();
            if (frmNewBook.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(dgBook.CurrentRow.Cells[0].Value.ToString());
            frmNewBook frmNewBook = new frmNewBook();
            frmNewBook.bookId = bookId;
            if (frmNewBook.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }
    }
}
