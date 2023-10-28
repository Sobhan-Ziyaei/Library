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
    public partial class frmBookCategory : Form
    {
        UnitOfWork db = new UnitOfWork();
        public frmBookCategory()
        {
            InitializeComponent();
        }

        private void frmNewBookCategory_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnNewCatergory_Click(object sender, EventArgs e)
        {
            frmNewBookCategory frmNewBookCategory = new frmNewBookCategory();
            if (frmNewBookCategory.ShowDialog() == DialogResult.Yes)
            {
                BindGrid();
            }
        }

        //This method is for refreshing grid
        public void BindGrid()
        {
            dgCategory.AutoGenerateColumns = false;
            dgCategory.DataSource = null;
            var categories = db.BookCategoryRepository.Get();
            dgCategory.DataSource = db.BookCategoryRepository.Get();
            dgCategory.Refresh();



        }

        private void btnRefreshCategory_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgCategory.CurrentRow != null)
            {
                int categoryId = int.Parse(dgCategory.CurrentRow.Cells[0].Value.ToString());
                var category = db.CategoryRepository.GetById(categoryId);

                if (category != null)
                {
                    // Check if there are related books
                    //bool hasRelatedBooks = category.LibraryBooks.Any();

                    //if (hasRelatedBooks)
                    //{
                    //    MessageBox.Show("این دسته‌بندی دارای کتاب‌های مرتبط است. نمی‌توانید آن را حذف کنید.");
                    //}
                    //else
                    //{
                    //    if (MessageBox.Show($"آیا از حذف دسته بندی {category.Title} مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    //    {
                    //        db.BookCategoryRepository.Delete(category);
                    //        db.BookCategoryRepository.Save();
                    //        BindGrid();
                    //    }
                    //}
                }
            }
            else
            {
                MessageBox.Show("لطفاً یک سطر را انتخاب کنید");
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            int categoryId = int.Parse(dgCategory.CurrentRow.Cells[0].Value.ToString());
            frmNewBookCategory frmNewBookCategory = new frmNewBookCategory();
            frmNewBookCategory.categoryId = categoryId;
            if (frmNewBookCategory.ShowDialog() == DialogResult.Yes)
            {
                BindGrid();
            }
        }

        private void txtCategoryFilter_TextChanged(object sender, EventArgs e)
        {
            dgCategory.DataSource = db.CategoryRepository.Get(x => x.Title.Contains(txtCategoryFilter.Text));
        }


    }
}
