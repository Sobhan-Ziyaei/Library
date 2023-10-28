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
    public partial class frmRegisterOrLogin : Form
    {
        UnitOfWork db = new UnitOfWork();
        public bool isLogin = false;
        public frmRegisterOrLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("نام کاربری را وارد کنید");
            }
            if (string.IsNullOrEmpty(txtUserPassword.Text))
            {
                MessageBox.Show("لطفا کلمه عبور را وارد کنید");
            }
            if (isLogin)
            {
                var loggedInUser = db.UserRepository.Get().First();
                loggedInUser.Name = txtUserName.Text;
                loggedInUser.Password = txtUserPassword.Text;
                db.UserRepository.Update(loggedInUser);
                db.UserRepository.Save();
                Application.Restart();
            }
            else
            {
                if (db.UserRepository.Get(u => u.Name == txtUserName.Text && u.Password == txtUserPassword.Text).Any())
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("نام کاربری یا کلمه عبور اشتباه است");
                }
            }

        }

        private void frmRegisterOrLogin_Load(object sender, EventArgs e)
        {
            if (isLogin == true)
            {
                this.Text = "ویرایش کاربر";
                btnRegister.Hide();
                btnLogin.Text = "ویرایش";
                var loggedInUser = db.UserRepository.Get().First();
                //var loggedInUser = db.UserRepository.Get(x => x.ID == );
                txtUserName.Text = loggedInUser.Name;
                txtUserPassword.Text = loggedInUser.Password;

            }
            else
            {
                this.btnLogin.Text = "ورود";

            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegisterUser frmRegisterUser = new frmRegisterUser();
            frmRegisterUser.ShowDialog();
        }
    }
}
