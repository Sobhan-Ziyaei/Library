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
        UnitOfWork db = new UnitOfWork();
        public frmNewBookCategory()
        {
            InitializeComponent();
        }

        private void frmNewBookCategory_Load(object sender, EventArgs e)
        {
            dgCategory.AutoGenerateColumns = false;
            dgCategory.DataSource = db.BookCategoryRepository.Get();
        }
    }
}
