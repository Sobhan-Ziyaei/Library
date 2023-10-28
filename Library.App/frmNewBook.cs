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
    public partial class frmNewBook : Form
    {
        UnitOfWork db = new UnitOfWork();
        public int bookId = 0;
        public frmNewBook()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check if Book Title is empty
            if (string.IsNullOrWhiteSpace(txtBookTitle.Text))
            {
                MessageBox.Show("لطفا عنوان کتاب را وارد کنید");
                return; // Stop execution if the title is missing
            }

            // Check if Book Author is empty
            if (string.IsNullOrWhiteSpace(txtBookAuthor.Text))
            {
                MessageBox.Show("لطفاً نام نویسنده را وارد کنید");
                return; // Stop execution if the author is missing
            }

            try
            {
                if (bookId == 0)
                {
                    // Attempt to parse the selected value in cbBookCategory
                    if (!int.TryParse(cbBookCategory.SelectedValue?.ToString(), out int selectedCategoryId))
                    {
                        MessageBox.Show("لطفا یک دسته بندی انتخاب کنید");
                        return; // Stop execution if category is not selected or not a valid number
                    }

                    // Create a new LibraryBook instance and set its properties
                    var newBook = new DataLayer.tblBook
                    {
                        Title = txtBookTitle.Text,
                        Author = txtBookAuthor.Text,
                        Image = bookImage.ImageLocation,
                        PublishYear = numPublishYear.Value.ToString(),
                    };
                    db.BookRepository.Insert(newBook);
                }
                else
                {
                    var book = db.BookRepository.GetById(bookId);
                    book.Title = txtBookTitle.Text;
                    book.Author = txtBookAuthor.Text;
                    book.PublishYear = numPublishYear.Value.ToString();
                    book.Image = bookImage.ImageLocation;
                    db.BookRepository.Update(book);

                }
                db.BookRepository.Save();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                // Handle exceptions, e.g., display an error message
                MessageBox.Show("خطا در ذخیره کتاب: " + ex.Message);
            }
        }



        private void frmNewBook_Load(object sender, EventArgs e)
        {
            if (bookId == 0)
            {
                this.Text = "افزودن کتاب";
                btnSave.Text = "افزودن";
            }
            else
            {
                this.Text = "ویرایش کتاب";
                btnSave.Text = "ویرایش";
                var book = db.BookRepository.GetById(bookId);
                txtBookTitle.Text = book.Title;
                txtBookAuthor.Text = book.Author;
                numPublishYear.Value = int.Parse(book.PublishYear);
                bookImage.ImageLocation = book.Image;
            }

            cbBookCategory.DataSource = db.BookCategoryRepository.Get();
            cbBookCategory.DisplayMember = "CategoryTitle";
            cbBookCategory.ValueMember = "CategoryId";
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                bookImage.ImageLocation = ofd.FileName;
            }
        }
    }
}
