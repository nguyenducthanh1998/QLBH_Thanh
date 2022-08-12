using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang
{
    public class XuatXu
    {
        public DataTable LayDanhSachXuatXu()
        {
            string strSQL = "select MaQuocGia, TenQuocGia from QuocGia";
            return DataProvider.LayDanhSach(strSQL);
        }
    }
}
