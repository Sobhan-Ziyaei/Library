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
    public partial class frmRegisterUser : Form
    {
        UnitOfWork db = new UnitOfWork();
        public frmRegisterUser()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtNewUser.Text == null)
            {
                MessageBox.Show("لطفاً یک نام کاربری تعیین کنید");
            }
            if (txtNewPassword.Text == null)
            {
                MessageBox.Show("لطفاً رمز عبور تعیین کنید");
            }
            else
            {
                db.UserRepository.Insert(new DataLayer.tblUser
                {
                    Name = txtNewUser.Text,
                    Password = txtNewPassword.Text
                });
                db.UserRepository.Save();
                DialogResult = DialogResult.OK;
            }

        }
    }
}
