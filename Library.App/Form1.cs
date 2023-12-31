﻿using Library.DataLayer;
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
        public int loggedInUserId;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmRegisterOrLogin frmRegisterOrLogin = new frmRegisterOrLogin();
            if (frmRegisterOrLogin.ShowDialog() == DialogResult.OK)
            {
                loggedInUserId = frmRegisterOrLogin.loggedInUserId;
                this.Show();
            }
            else
            {
                Application.Exit();
            }
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

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            frmRegisterOrLogin frmRegisterOrLogin = new frmRegisterOrLogin();
            frmRegisterOrLogin.loggedInUserId = loggedInUserId;
            frmRegisterOrLogin.isLogin = true;
            frmRegisterOrLogin.ShowDialog();
        }
    }
}
