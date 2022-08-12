using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        frmLogin login = new frmLogin();
        private void frmMain_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            Login login = new Login();
            DataTable dtLogin = login.TaiKhoanDangNhap();
            string userName = "" + dtLogin.Rows[0]["TaiKhoan"];

            lblThongTinNguoiDung.Text = "Xin chào, " + userName;
            lblDateTime.Text = dt.ToString();

            
        }

        private void ribThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát?","Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //this.Close();
                //login.thoat();
                Application.Exit();
            }
        }

        private void ribDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //this.Hide();
                //login.ShowDialog();
                Application.Exit();
            }
        }

        private void lblDateTime_Click(object sender, EventArgs e)
        {

        }

        private void ribbtnKH_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKH = new frmKhachHang();

            frmKH.ShowDialog();


        }

        private void ribbtnHoaDonBan_Click(object sender, EventArgs e)
        {
            frmHoaDonBan frmHDB = new frmHoaDonBan();
            frmHDB.ShowDialog();
        }

        private void ribbtnHoaDonMua_Click(object sender, EventArgs e)
        {
            frmHoaDonMua frmHDM = new frmHoaDonMua();
            frmHDM.ShowDialog();
        }

        private void ribbon1_Click(object sender, EventArgs e)
        {

        }

        private void ribbtnKhoHang_Click(object sender, EventArgs e)
        {
            frmHangHoa frmHH = new frmHangHoa();

            frmHH.ShowDialog();
        }

        private void ribbtnNhapHang_Click(object sender, EventArgs e)
        {
            frmAddHangHoa addHH = new frmAddHangHoa();
            addHH.ShowDialog();
        }
    }
}
