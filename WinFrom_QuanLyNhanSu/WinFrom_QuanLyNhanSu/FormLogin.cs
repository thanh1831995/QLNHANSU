using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFrom_QuanLyNhanSu
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        public bool checkObject()
        {
            if (string.IsNullOrWhiteSpace(txtUsename.Text))
            {
                MessageBox.Show("bạn chưa nhập tên người dùng", "cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsename.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("bạn chưa nhập password", "cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }
            return true;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (checkObject())
            {
                if (txtUsename.Text.Equals("admin") && txtPassword.Text.Equals("tmp"))
                {
                    this.Hide();
                }
                else
                {
                    lblMessage.Visible = true;
                    lblMessage.Text = "bạn đã nhập sai tên tài khoản hoặc password";
                }
            }
        }
    }
}
