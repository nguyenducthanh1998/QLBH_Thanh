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
    public partial class frmAddHangHoa : Form
    {
        public frmAddHangHoa()
        {
            InitializeComponent();
        }
        private void HienThiDanhSachHDM()
        {
            Admin adm = new Admin();

            //Lấy danh sách
            DataTable dtHDM = adm.LayThongTinHoaDonMua();

            //Hiển thị lên gridview
            gridHDM.DataSource = null;
            gridHDM.DataSource = dtHDM;
        }

        private void frmAddHangHoa_Load(object sender, EventArgs e)
        {
            HienThiDanhSachHDM();
        }

        private void gridHDM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = gridHDM.Rows[e.RowIndex];
            txtMaHDM.Text = Convert.ToString(row.Cells["colMaHDM"].Value);
            txtTenHDM.Text = Convert.ToString(row.Cells["colTenHDM"].Value);
            txtSoLuongHDM.Text = Convert.ToString(row.Cells["colSoLuongHDM"].Value);
            txtGiaMuaHDM.Text = Convert.ToString(row.Cells["colGiaMua"].Value);
            dtpNgayMuaHDM.Value = Convert.ToDateTime(row.Cells["colNgayMua"].Value);

            txtMoTaHDM.Text = Convert.ToString(row.Cells["colMota"].Value);
            txtMaHang.Text = Convert.ToString(row.Cells["colMaHang"].Value);
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            HoaDonMua objHDM = new HoaDonMua();

            //Gán giá trị từ giao diện cho các thuộc tính
            objHDM.MaHoaDonMua = txtMaHDM.Text;
            objHDM.TenHoaDonMua = txtTenHDM.Text;
            objHDM.SoLuong = Convert.ToInt32(txtSoLuongHDM.Text);
            objHDM.GiaMua = Convert.ToInt32(txtGiaMuaHDM.Text);
            objHDM.NgayMua = dtpNgayMuaHDM.Value;
            objHDM.MoTa = txtMoTaHDM.Text;
            objHDM.MaHang = txtMaHang.Text;

            bool ketQua = DataProvider.ADM.ThemMoiHDMH(objHDM);

            if (ketQua)
            {
                MessageBox.Show("Thêm mới hóa đơn thành công");
                HienThiDanhSachHDM();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắn chắn muốn xóa hóa đơn này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)//True
            {
                //Khai báo biến
                string maHDM = "";

                //Lấy mã sv người dùng chọn trên gridview
                maHDM = "" + gridHDM.CurrentRow.Cells[0].Value;

                bool kq = DataProvider.ADM.XoaHDMH(maHDM);

                if (kq)
                {
                    //Reload lại danh sách
                    HienThiDanhSachHDM();
                }
            }
        }
    }
}
