using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang
{
    public class KhachHangBusiness
    {
        public DataTable LayDanhSach()
        {
            string strSQL = "Select MaLoai, TenLoai from LoaiKhachHang";
            return DataProvider.LayDanhSach(strSQL);
        }
    }
}
