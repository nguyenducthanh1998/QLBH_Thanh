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
    public partial class frmHangHoa : Form
    {
        public frmHangHoa()
        {
            InitializeComponent();
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            HienThiDanhSachHH();
        }
        private void HienThiDanhSachHH()
        {
            Admin adm = new Admin();

            //Lấy danh sách
            DataTable dtHH = adm.LayThongTinHangHoa();

            //Hiển thị lên gridview
            gridKhoHang.DataSource = null;
            gridKhoHang.DataSource = dtHH;
        }
    }
}
