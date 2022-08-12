using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyBanHang
{
    public partial class frmLogin : Form
    {
        public string UserName =  "";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void ckbHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHienThiMatKhau.Checked)
            {
                txtMatKhau.PasswordChar = (char)0;
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            DataTable dtLogin = login.TaiKhoanDangNhap();
            Form1 f1 = new Form1();
            frmMain fmain = new frmMain();

            try
            {
                string userName = "", passWord = "";
                userName = "" + dtLogin.Rows[0]["TaiKhoan"];
                passWord = "" + dtLogin.Rows[0]["MatKhau"];
                bool kq = txtTenDangNhap.Text == userName && txtMatKhau.Text == passWord;
                if (kq)
                {
                    MessageBox.Show("Bạn đã đăng nhập thành công!!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu", "Thông báo");
                    txtTenDangNhap.Text = "";
                    txtMatKhau.Text = "";
                    txtTenDangNhap.Focus();
                }
                if (kq)
                {
                    this.Hide();
                    fmain.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            thoat();
        }
        public void thoat()
        {
            Application.Exit();
        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
