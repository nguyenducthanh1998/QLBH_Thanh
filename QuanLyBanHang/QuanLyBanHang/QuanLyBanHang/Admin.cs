using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace QuanLyBanHang
{
    public class Admin
    {
        #region Lấy thông tin từ db
        public DataTable LayThongTinKhachHang()
        {
            string strSQL = "Select * from KhachHang";
            return DataProvider.LayDanhSach(strSQL);
        }
        public DataTable LayThongTinHoaDonBan()
        {
            string strSQL = "select HoaDonBan.MaHoaDon, HoaDonBan.TenHoaDon, HoaDonBanChiTiet.MaHang, HoaDonBanChiTiet.SoLuong, HoaDonBanChiTiet.GiaBan, HoaDonBan.NgayBan, HoaDonBan.MoTa, HoaDonBan.MaKhachHang from HoaDonBan left outer join HoaDonBanChiTiet on HoaDonBan.MaHoaDon = HoaDonBanChiTiet.MaHoaDon";
            return DataProvider.LayDanhSach(strSQL);
        }

        public DataTable LayThongTinHoaDonMua()
        {
            string strSQL = "select HoaDonMua.MaHoaDon, HoaDonMua.TenHoaDon, HoaDonMuaChiTiet.SoLuong, HoaDonMuaChiTiet.GiaMua, HoaDonMua.NgayMua, HoaDonMua.MoTa, HoaDonMuaChiTiet.MaHang from HoaDonMua left outer  join HoaDonMuaChiTiet on HoaDonMua.MaHoaDon = HoaDonMuaChiTiet.MaHoaDon";
            return DataProvider.LayDanhSach(strSQL);
        }
        public DataTable LayThongTinHangHoa()
        {
            string strSQL = "select * from HangHoa";
            return DataProvider.LayDanhSach(strSQL);
        }
        #endregion Lấy thông tin từ db
        #region Xử lý khách hàng
        public DataTable LayChiTietTheoMa(string maKH)
        {
            string strSQL = "Select * from KhachHang where MaKH = '" + maKH + "'";
            return DataProvider.LayDanhSach(strSQL);
        }
        public bool ThemMoiKH(KhachHang objKH)
        {
            string strInsert = "Insert into KhachHang(MaKhachHang, TenKhachHang, DienThoai,Email,DiaChi,LoaiKhachHang) values(@MaKhachHang, @TenKhachHang, @DienThoai,@Email,@DiaChi,@LoaiKhachHang)";

            SqlParameter[] pars = new SqlParameter[6];
            pars[0] = new SqlParameter("@MaKhachHang", SqlDbType.VarChar, 10);
            pars[0].Value = objKH.MaKH;

            pars[1] = new SqlParameter("@TenKhachHang", SqlDbType.NVarChar, 30);
            pars[1].Value = objKH.TenKH;

            pars[2] = new SqlParameter("@DienThoai", SqlDbType.VarChar, 20);
            pars[2].Value = objKH.DienThoai;

            pars[3] = new SqlParameter("@Email", SqlDbType.VarChar, 50);
            pars[3].Value = objKH.Email;

            pars[4] = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 50);
            pars[4].Value = objKH.DiaChi;

            pars[5] = new SqlParameter("@LoaiKhachHang", SqlDbType.VarChar, 10);
            pars[5].Value = objKH.LoaiKhachHang;

            return DataProvider.ThucHien(strInsert, pars);
        }

        public bool CapNhatKH(KhachHang objKH)
        {
            string strUpdate = "Update KhachHang set TenKhachHang = @TenKhachHang, DienThoai = @DienThoai, Email = @Email, DiaChi = @DiaChi, LoaiKhachHang = @LoaiKhachHang where MaKhachHang = @MaKhachHang";

            SqlParameter[] pars = new SqlParameter[6];

            pars[0] = new SqlParameter("@TenKhachHang", SqlDbType.NVarChar, 30);
            pars[0].Value = objKH.TenKH;

            pars[1] = new SqlParameter("@DienThoai", SqlDbType.VarChar, 20);
            pars[1].Value = objKH.DienThoai;

            pars[2] = new SqlParameter("@Email", SqlDbType.VarChar, 50);
            pars[2].Value = objKH.Email;

            pars[3] = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 50);
            pars[3].Value = objKH.DiaChi;

            pars[4] = new SqlParameter("@LoaiKhachHang", SqlDbType.VarChar, 10);
            pars[4].Value = objKH.LoaiKhachHang;

            pars[5] = new SqlParameter("@MaKhachHang", SqlDbType.VarChar, 10);
            pars[5].Value = objKH.MaKH;

            return DataProvider.ThucHien(strUpdate, pars);
        }
        public bool XoaKH(string maKH)
        {
            string strDelete = "Delete from KhachHang where MaKhachHang = @MaKH";

            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@MaKH", SqlDbType.VarChar, 10);
            pars[0].Value = maKH;

            return DataProvider.ThucHien(strDelete, pars);
        }
        #endregion
        #region Xử lý hóa đơn bán
        public DataTable LayChiTietTheoMaHoaDonBan(string maHDBH)
        {
            string strSQL = "Select * from HoaDonBan, HoaDonBanChiTiet where HoaDonBan.MaHoaDon = '" + maHDBH + "' and HoaDonBanChiTiet.MaHoaDon = '" + maHDBH + "'";
            return DataProvider.LayDanhSach(strSQL);
        }
        public bool ThemMoiHDBH(HoaDonBan objHDBH)
        {
            string strInsert = "Insert into HoaDonBan(MaHoaDon, TenHoaDon, MoTa,NgayBan,MaKhachHang) values(@MaHoaDon, @TenHoaDon, @MoTa,@NgayBan,@MaKhachHang)" +
                "Insert into HoaDonBanChiTiet(MaHoaDon, MaHang, SoLuong, GiaBan) values (@MaHoaDon, @MaHang, @SoLuong, @GiaBan)";

            SqlParameter[] pars = new SqlParameter[8];
            pars[0] = new SqlParameter("@MaHoaDon", SqlDbType.VarChar, 10);
            pars[0].Value = objHDBH.MaHoaDonBan;

            pars[1] = new SqlParameter("@TenHoaDon", SqlDbType.NVarChar, 50);
            pars[1].Value = objHDBH.TenHoaDonBan;

            pars[2] = new SqlParameter("@SoLuong", SqlDbType.Int, 20);
            pars[2].Value = objHDBH.SoLuong;

            pars[3] = new SqlParameter("@GiaBan", SqlDbType.Decimal, 50);
            pars[3].Value = objHDBH.GiaBan;

            pars[4] = new SqlParameter("@NgayBan", SqlDbType.Date, 50);
            pars[4].Value = objHDBH.NgayBan;

            pars[5] = new SqlParameter("@MoTa", SqlDbType.NVarChar, 200);
            pars[5].Value = objHDBH.MoTa;

            pars[6] = new SqlParameter("@MaKhachHang", SqlDbType.VarChar, 10);
            pars[6].Value = objHDBH.MaKH;

            pars[7] = new SqlParameter("@MaHang", SqlDbType.VarChar, 10);
            pars[7].Value = objHDBH.MaHang;

            return DataProvider.ThucHien(strInsert, pars);
        }

        public bool CapNhatHDBH(HoaDonBan1 objHDBH)
        {
            string strUpdate = "Update HoaDonBan set TenHoaDon = @TenHoaDon, MoTa = @MoTa, NgayBan = @NgayBan, MaKhachHang = @MaKhachHang where MaHoaDon = @MaHoaDon";
            

            SqlParameter[] pars = new SqlParameter[5];

            pars[0] = new SqlParameter("@TenHoaDon", SqlDbType.NVarChar, 50);
            pars[0].Value = objHDBH.TenHoaDonBan;

            pars[1] = new SqlParameter("@MoTa", SqlDbType.NVarChar, 200);
            pars[1].Value = objHDBH.MoTa;

            pars[2] = new SqlParameter("@NgayBan", SqlDbType.Date, 50);
            pars[2].Value = objHDBH.NgayBan;

            pars[3] = new SqlParameter("@MaKhachHang", SqlDbType.VarChar, 10);
            pars[3].Value = objHDBH.MaKH;

            pars[4] = new SqlParameter("@MaHoaDon", SqlDbType.VarChar, 10);
            pars[4].Value = objHDBH.MaHoaDonBan;

            return DataProvider.ThucHien(strUpdate, pars);
        }

        public bool CapNhatHDBHCT(HoaDonBanChiTiet1 objHDBHCT)
        {
            string strUpdate = "Update HoaDonBanChiTiet set MaHang = @MaHang, SoLuong = @SoLuong, GiaBan = @GiaBan where MaHoaDon = @MaHoaDon";

            SqlParameter[] pars = new SqlParameter[4];

            pars[0] = new SqlParameter("@MaHang", SqlDbType.VarChar, 10);
            pars[0].Value = objHDBHCT.MaHang;

            pars[1] = new SqlParameter("@SoLuong", SqlDbType.Int, 20);
            pars[1].Value = objHDBHCT.SoLuong;

            pars[2] = new SqlParameter("@GiaBan", SqlDbType.Decimal, 50);
            pars[2].Value = objHDBHCT.GiaBan;

            pars[3] = new SqlParameter("@MaHoaDon", SqlDbType.VarChar, 10);
            pars[3].Value = objHDBHCT.MaHoaDonBan;

            return DataProvider.ThucHien(strUpdate, pars);
        }
        public bool XoaHDBH(string maHDBH)
        {
            string strDelete = "Delete from HoaDonBan, HoaDonBanChiTiet where MaHoaDon = @MaHoaDon";

            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@MaHoaDon", SqlDbType.VarChar, 10);
            pars[0].Value = maHDBH;

            return DataProvider.ThucHien(strDelete);
        }
        #endregion
        #region Xử lý hóa đơn mua
        public DataTable LayChiTietTheoMaHoaDonMua(string maHDMH)
        {
            string strSQL = "Select * from HoaDonMua, HoaDonMuaChiTiet where HoaDonMua.MaHoaDon = '" + maHDMH + "' and HoaDonMuaChiTiet.MaHoaDon = '" + maHDMH + "'";
            return DataProvider.LayDanhSach(strSQL);
        }
        public bool ThemMoiHDMH(HoaDonMua objHDMH)
        {
            string strInsert = "Insert into HoaDonMua(MaHoaDon, TenHoaDon, MoTa,NgayMua) values(@MaHoaDon, @TenHoaDon, @MoTa,@NgayMua)" +
                "Insert into HoaDonMuaChiTiet(MaHoaDon, MaHang, SoLuong, GiaMua) values (@MaHoaDon, @MaHang, @SoLuong, @GiaMua)";

            SqlParameter[] pars = new SqlParameter[7];
            pars[0] = new SqlParameter("@MaHoaDon", SqlDbType.VarChar, 10);
            pars[0].Value = objHDMH.MaHoaDonMua;

            pars[1] = new SqlParameter("@TenHoaDon", SqlDbType.NVarChar, 50);
            pars[1].Value = objHDMH.TenHoaDonMua;

            pars[2] = new SqlParameter("@SoLuong", SqlDbType.Int, 20);
            pars[2].Value = objHDMH.SoLuong;

            pars[3] = new SqlParameter("@GiaMua", SqlDbType.Decimal, 50);
            pars[3].Value = objHDMH.GiaMua;

            pars[4] = new SqlParameter("@NgayMua", SqlDbType.Date, 50);
            pars[4].Value = objHDMH.NgayMua;

            pars[5] = new SqlParameter("@MoTa", SqlDbType.NVarChar, 200);
            pars[5].Value = objHDMH.MoTa;

            pars[6] = new SqlParameter("@MaHang", SqlDbType.VarChar, 10);
            pars[6].Value = objHDMH.MaHang;

            return DataProvider.ThucHien(strInsert, pars);
        }

        public bool CapNhatHDMH(HoaDonMua objHDMH)
        {
            string strUpdate = "Update HoaDonMua set TenHoaDon = @TenHoaDon, MoTa = @MoTa, NgayMua = @NgayMua where MaHoaDon = @MaHoaDon" +
                "Update hdmct set MaHang = @MaHang, SoLuong = @SoLuong, GiaMua = @GiaMua from HoaDonMuaChiTiet hdmct inner join HoaDonMua hdm on hdm.MaHoaDon = hdmct.MaHoaDon";

            SqlParameter[] pars = new SqlParameter[7];

            pars[0] = new SqlParameter("@TenHoaDon", SqlDbType.NVarChar, 50);
            pars[0].Value = objHDMH.TenHoaDonMua;

            pars[1] = new SqlParameter("@SoLuong", SqlDbType.Int, 20);
            pars[1].Value = objHDMH.SoLuong;

            pars[2] = new SqlParameter("@GiaMua", SqlDbType.Decimal, 50);
            pars[2].Value = objHDMH.GiaMua;

            pars[3] = new SqlParameter("@NgayMua", SqlDbType.Date, 50);
            pars[3].Value = objHDMH.NgayMua;

            pars[4] = new SqlParameter("@MoTa", SqlDbType.NVarChar, 200);
            pars[4].Value = objHDMH.MoTa;

            pars[5] = new SqlParameter("@MaHang", SqlDbType.VarChar, 10);
            pars[5].Value = objHDMH.MaHang;

            pars[6] = new SqlParameter("@MaHoaDon", SqlDbType.VarChar, 10);
            pars[6].Value = objHDMH.MaHoaDonMua;

            return DataProvider.ThucHien(strUpdate, pars);
        }
        public bool XoaHDMH(string maHDMH)
        {
            string strDelete = "Delete from HoaDonMuaChiTiet where HoaDonMuaChiTiet.MaHoaDon = @MaHoaDon"+ "Delete from HoaDonMua where HoaDonMua.MaHoaDon = @MaHoaDon";

            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@MaHoaDon", SqlDbType.VarChar, 10);
            pars[0].Value = maHDMH;

            return DataProvider.ThucHien(strDelete);
        }

        #endregion
        #region Xử lý hàng hóa
        public DataTable LayChiTietTheoMaHang(string maHH)
        {
            string strSQL = "Select * from HangHoa where MaHang = '" + maHH + "'";
            return DataProvider.LayDanhSach(strSQL);
        }
        public bool ThemMoiHH(HangHoa objHH)
        {
            string strInsert = "Insert into HangHoa(MaHang, TenHang, MoTa,XuatXuID) values(@MaHang, @TenHang, @MoTa,@XuatXuID)";

            SqlParameter[] pars = new SqlParameter[4];
            pars[0] = new SqlParameter("@MaHang", SqlDbType.VarChar, 10);
            pars[0].Value = objHH.MaHang;

            pars[1] = new SqlParameter("@TenHang", SqlDbType.NVarChar, 50);
            pars[1].Value = objHH.TenHang;

            pars[2] = new SqlParameter("@MoTa", SqlDbType.NVarChar, 200);
            pars[2].Value = objHH.MoTa;

            pars[3] = new SqlParameter("@XuatXuID", SqlDbType.VarChar, 10);
            pars[3].Value = objHH.XuatXuID;

            return DataProvider.ThucHien(strInsert, pars);
        }

        public bool CapNhatHH(HangHoa objHH)
        {
            string strUpdate = "Update HangHoa set TenHang = @TenHang, MoTa = @MoTa, XuatXuID = @XuatXuID where MaHang = @MaHang";

            SqlParameter[] pars = new SqlParameter[4];
            pars[0] = new SqlParameter("@MaHang", SqlDbType.VarChar, 10);
            pars[0].Value = objHH.MaHang;

            pars[1] = new SqlParameter("@TenHang", SqlDbType.NVarChar, 50);
            pars[1].Value = objHH.TenHang;

            pars[2] = new SqlParameter("@MoTa", SqlDbType.NVarChar, 200);
            pars[2].Value = objHH.MoTa;

            pars[3] = new SqlParameter("@XuatXuID", SqlDbType.VarChar, 10);
            pars[3].Value = objHH.XuatXuID;

            return DataProvider.ThucHien(strUpdate, pars);
        }
        public bool XoaHH(string maHH)
        {
            string strDelete = "Delete from HangHoa where MaHang = @MaHang";

            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@MaHang", SqlDbType.VarChar, 10);
            pars[0].Value = maHH;

            return DataProvider.ThucHien(strDelete);
        }
        #endregion
    }
}
