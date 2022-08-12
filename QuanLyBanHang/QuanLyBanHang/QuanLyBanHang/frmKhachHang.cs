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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void txtGiaBanHDB_TextChanged(object sender, EventArgs e)
        {

        }
        private void HienThiDanhSachKH()
        {
            Admin adm = new Admin();

            //Lấy danh sách
            DataTable dtKH = adm.LayThongTinKhachHang();

            //Hiển thị lên gridview
            gridKH.DataSource = null;
            gridKH.DataSource = dtKH;
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            HienThiDanhSachKH();
            HienThiLoaiKH();
        }

        private void HienThiLoaiKH()
        {
            //Khai báo đối tượng
            KhachHangBusiness khbus = new KhachHangBusiness();
            //Lấy danh sách
            DataTable dtLoaiKH = khbus.LayDanhSach();
            DataRow root = dtLoaiKH.NewRow();
            root[0] = "";
            root[1] = "---Chọn Loại KH---";
            dtLoaiKH.Rows.InsertAt(root, 0);
            cboLoaiKH.DisplayMember = "Maloai";
            cboLoaiKH.ValueMember = "MaLoai";
            cboLoaiKH.DataSource = dtLoaiKH;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtEmail.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            txtMaKH.Enabled = true;
            txtMaKH.Focus();

        }

        private void gridKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = gridKH.Rows[e.RowIndex];
            txtMaKH.Text = Convert.ToString(row.Cells["colMaKH"].Value);
            txtTenKH.Text = Convert.ToString(row.Cells["colTenKH"].Value);
            txtEmail.Text = Convert.ToString(row.Cells["colEmail"].Value);
            txtDienThoai.Text = Convert.ToString(row.Cells["colDienThoai"].Value);

            txtDiaChi.Text = Convert.ToString(row.Cells["colDiaChi"].Value);
            cboLoaiKH.Text = Convert.ToString(row.Cells["colLoaiKH"].Value);
            txtMaKH.Enabled = false;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            KhachHang objKH = new KhachHang();

            //Gán giá trị từ giao diện cho các thuộc tính
            objKH.MaKH = txtMaKH.Text;
            objKH.TenKH = txtTenKH.Text;
            objKH.Email = txtEmail.Text;
            objKH.DienThoai = txtDienThoai.Text;
            objKH.DiaChi = txtDiaChi.Text;
            objKH.LoaiKhachHang = cboLoaiKH.Text;

            bool ketQua = DataProvider.ADM.ThemMoiKH(objKH);

            if (ketQua)
            {
                MessageBox.Show("Thêm mới khách hàng thành công");
                HienThiDanhSachKH();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KhachHang objKH = new KhachHang();

            //Gán giá trị từ giao diện cho các thuộc tính
            objKH.MaKH = txtMaKH.Text;
            objKH.TenKH = txtTenKH.Text;

            objKH.Email = txtEmail.Text;
            objKH.DienThoai = txtDienThoai.Text;
            objKH.DiaChi = txtDiaChi.Text;
            objKH.LoaiKhachHang = cboLoaiKH.Text;

            bool ketQua = DataProvider.ADM.CapNhatKH(objKH);

            if (ketQua )
            {
                MessageBox.Show("Sửa thông tin khách hàng thành công");
                HienThiDanhSachKH();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắn chắn muốn xóa khách hàng này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)//True
            {
                //Khai báo biến
                string maKH = "";

                //Lấy mã sv người dùng chọn trên gridview
                maKH = "" + gridKH.CurrentRow.Cells[0].Value;

                bool kq = DataProvider.ADM.XoaKH(maKH);

                if (kq)
                {
                    //Reload lại danh sách
                    HienThiDanhSachKH();
                }
            }
        }
    }
}
