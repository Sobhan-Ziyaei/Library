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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBookCategory_Click(object sender, EventArgs e)
        {

            frmBookCategory frm = new frmBookCategory();
            frm.ShowDialog();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            frmBook frmBook = new frmBook();
            frmBook.ShowDialog();
        }
    }
}
