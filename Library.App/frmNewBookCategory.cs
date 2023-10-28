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
    public partial class frmNewBookCategory : Form
    {
        public int categoryId = 0;
        UnitOfWork db = new UnitOfWork();
        public frmNewBookCategory()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewCategory.Text))
            {
                MessageBox.Show("لطفا عنوانی برای دسته‌بندی انتخاب کنید", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                if (categoryId == 0)
                {
                    db.CategoryRepository.Insert(new DataLayer.tblCategory
                    {
                        
                        Title = txtNewCategory.Text,
                    });
                    MessageBox.Show($"آیا از اضافه کردن {txtNewCategory.Text} مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo);

                }
                else
                {
                    var category = db.CategoryRepository.GetById(categoryId);
                    category.Title = txtNewCategory.Text;
                    db.CategoryRepository.Update(category);
                    MessageBox.Show($"آیا از ویرایش کردن {txtNewCategory.Text} مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo);

                }
                db.BookCategoryRepository.Save();
                DialogResult = DialogResult.Yes;

            }
        }


        private void frmNewBookCategory_Load(object sender, EventArgs e)
        {
            if (categoryId == 0)
            {
                this.Text = "افزودن دسته‌بندی";
                btnSave.Text = "افزودن";
            }
            else
            {
                this.Text = "ویرایش دسته‌بندی";
                btnSave.Text = "ویرایش";
                var category = db.CategoryRepository.GetById(categoryId);
                txtNewCategory.Text = category.Title;

            }
        }
    }
}
