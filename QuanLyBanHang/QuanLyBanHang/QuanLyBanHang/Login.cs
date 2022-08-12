using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang
{
    public class Login
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }

        public DataTable TaiKhoanDangNhap()
        {
           
            string strSQL = "select * from QLTK";

            return DataProvider.LayDanhSach(strSQL);
        }
    }
}
