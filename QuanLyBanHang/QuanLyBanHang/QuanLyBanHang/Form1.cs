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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        frmLogin flogin = new frmLogin();
        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            Login login = new Login();
            DataTable dtLogin = login.TaiKhoanDangNhap();
            string userName = "" + dtLogin.Rows[0]["TaiKhoan"];

            lblThongTinNguoiDung.Text = "Xin chào, "+ userName;
            lblDateTime.Text = dt.ToString();
            groupBox1.Hide();
        }

        private void txtDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            flogin.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình!!", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                flogin.Show();
            }
        }

        private void tsmDanhSachHoaDonBan_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Danh sách hóa đơn bán";
            groupBox1.Show();
            HienThiDanhSachHoaDonBan();
        }

        private void HienThiDanhSachHoaDonBan()
        {
            //khai báo đối tượng
            Admin adm = new Admin();

            //Lấy danh sách
            DataTable dtSinhVien = adm.LayThongTinHoaDonBan();

            //Hiển thị lên gridview
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dtSinhVien;
        }
        private void tsmDanhSachHoaDonMua_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Danh sách hóa đơn mua";
            groupBox1.Show();
            HienThiDanhSachHoaDonMua();
        }
        private void HienThiDanhSachHoaDonMua()
        {
            //khai báo đối tượng
            Admin adm = new Admin();

            //Lấy danh sách
            DataTable dtSinhVien = adm.LayThongTinHoaDonMua();

            //Hiển thị lên gridview
            dataGridView1.Show();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dtSinhVien;
        }

        private void tsmKhoHang_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Danh sách hàng trong kho";
            groupBox1.Show();
            HienThiDanhSachHangHoa();
        }
        private void HienThiDanhSachHangHoa()
        {
            //khai báo đối tượng
            Admin adm = new Admin();

            //Lấy danh sách
            DataTable dtSinhVien = adm.LayThongTinHangHoa();

            //Hiển thị lên gridview
            dataGridView1.Show();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dtSinhVien;
        }

        private void tsmKhachHang_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Thông tin khách hàng";
            groupBox1.Show();
            HienThiDanhSachKhachHang();
        }
        private void HienThiDanhSachKhachHang()
        {
            //khai báo đối tượng
            Admin adm = new Admin();

            //Lấy danh sách
            DataTable dtSinhVien = adm.LayThongTinKhachHang();

            //Hiển thị lên gridview
            dataGridView1.Show();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dtSinhVien;
        }
    }
}
