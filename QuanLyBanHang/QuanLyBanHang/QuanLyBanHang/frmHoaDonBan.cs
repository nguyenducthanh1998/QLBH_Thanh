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
    public partial class frmHoaDonBan : Form
    {
        public frmHoaDonBan()
        {
            InitializeComponent();
        }
        public string MaHDB { get; set; } = "";
        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            HienThiDanhSachHDB();   
        }
        private void HienThiDanhSachHDB()
        {
            Admin adm = new Admin();

            //Lấy danh sách
            DataTable dtHDB = adm.LayThongTinHoaDonBan();

            //Hiển thị lên gridview
            gridHDB.DataSource = null;
            gridHDB.DataSource = dtHDB;
        }
        private void HienThiChiTietHDB()
        {
            //HienThiDanhSachKhoa();
            //Admin adm = new Admin();

            //DataTable dtHDB = adm.LayChiTietTheoMaHoaDonBan(MaHDB);

            //if (dtHDB.Rows.Count > 0)
            //{
            //txtMaHang.Text = MaHDB;
            //txtTenHDB.Text = "" + dtHDB.Rows[0]["TenHoaDon"];
            //txtSoLuongHDB.Text = "" + dtHDB.Rows[0]["SoLuong"];
            //txtGiaBanHDB.Text = "" + dtHDB.Rows[0]["GiaBan"];
            ////dtpNgayBanHDB.Text = "" + dtHDB.Rows[0]["NgayBan"];
            //txtMoTaHDB.Text = "" + dtHDB.Rows[0]["MoTa"];
            //txtMaKH.Text = "" + dtHDB.Rows[0]["MaKhachHang"];
            //txtMaHang.Text = "" + dtHDB.Rows[0]["MaHang"];

            //DateTime dtNgayBan = DateTime.Now;

            //DateTime.TryParse("" + dtHDB.Rows[0]["NgayBan"], out dtNgayBan);
            //dtpNgayBanHDB.Value = dtNgayBan;


            //}

            
        }

        private void gridHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = gridHDB.Rows[e.RowIndex];
            txtMaHDB.Text = Convert.ToString(row.Cells["colMaHDB"].Value);
            txtTenHDB.Text = Convert.ToString(row.Cells["colTenHDB"].Value);
            txtSoLuongHDB.Text = Convert.ToString(row.Cells["colSoLuongHDB"].Value);
            txtGiaBanHDB.Text = Convert.ToString(row.Cells["colGiaBanHDB"].Value);
            dtpNgayBanHDB.Value = Convert.ToDateTime(row.Cells["colNgayBanHDB"].Value);

            txtMoTaHDB.Text = Convert.ToString(row.Cells["colMoTaHDB"].Value);
            txtMaKH.Text = Convert.ToString(row.Cells["colMaKH"].Value);
            txtMaHang.Text = Convert.ToString(row.Cells["colMaHang"].Value);
            if (gridHDB.Rows[e.RowIndex] == null)
            {
                MessageBox.Show("Phai chon hang co gia tri","Thong bao", MessageBoxButtons.OK);
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            HoaDonBan objHDB = new HoaDonBan();

            //Gán giá trị từ giao diện cho các thuộc tính
            objHDB.MaHoaDonBan = txtMaHDB.Text;
            objHDB.TenHoaDonBan = txtTenHDB.Text;
            objHDB.SoLuong = Convert.ToInt32(txtSoLuongHDB.Text);
            objHDB.GiaBan = Convert.ToDecimal(txtGiaBanHDB.Text);
            objHDB.NgayBan = dtpNgayBanHDB.Value;
            objHDB.MoTa = txtMoTaHDB.Text;
            objHDB.MaKH = txtMaKH.Text;
            objHDB.MaHang = txtMaHang.Text;

            bool ketQua = DataProvider.ADM.ThemMoiHDBH(objHDB);
            
            if (ketQua)
            {
                MessageBox.Show("Thêm mới hóa đơn thành công");
                HienThiDanhSachHDB();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HoaDonBan1 objHDB = new HoaDonBan1 ();

            //Gán giá trị từ giao diện cho các thuộc tính
            
            objHDB.TenHoaDonBan = txtTenHDB.Text;

            objHDB.NgayBan = dtpNgayBanHDB.Value;
            objHDB.MoTa = txtMoTaHDB.Text;
            objHDB.MaKH = txtMaKH.Text;

            HoaDonBanChiTiet1 objHDBCT = new HoaDonBanChiTiet1();

            objHDBCT.SoLuong = Convert.ToInt32(txtSoLuongHDB.Text);
            objHDBCT.GiaBan = Convert.ToDecimal(txtGiaBanHDB.Text);
            objHDBCT.MaHang = txtMaHang.Text;

            bool ketQua = DataProvider.ADM.CapNhatHDBH(objHDB);
            bool ketQua1 = DataProvider.ADM.CapNhatHDBHCT(objHDBCT);

            if (ketQua && ketQua1)
            {
                MessageBox.Show("Sửa hóa đơn thành công");
                HienThiDanhSachHDB();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaHang.Text = "";
            txtTenHDB.Text = "";
            txtMaHDB.Text = "";
            txtGiaBanHDB.Text = "";
            txtMoTaHDB.Text = "";
            txtSoLuongHDB.Text = "";
            txtMaKH.Text = "";
            txtMaHDB.Focus();
        }
    }
}
