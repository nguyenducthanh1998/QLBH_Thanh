using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang
{
    public class DataProvider
    {
        private const string _ConnectString = "Server=DESKTOP-V7THFBG\\THANHND; Database = QLBH_ProjectCuoiKhoa; Integrated Security = True;";

        public static string ConnectString
        {
            get { return _ConnectString; }
        }

        public static Admin _ADM = null;

        public static Admin ADM
        {
            get
            {
                if(_ADM == null)
                {
                    _ADM = new Admin();
                }
                return _ADM;
            }
            
        }

        public static DataTable LayDanhSach(string strSQL, SqlParameter[] pars = null)
        {
            //Khai báo 1 database
            DataTable dt = new DataTable();
            SqlConnection conn = null;
            try
            {
                //Tạo 1 đối tượng kết nối
                conn = new SqlConnection(ConnectString);
                //Mở kết nối
                conn.Open();
                //Tạo công việc
                SqlCommand comm = new SqlCommand();
                //Thực hiện trên kết nối nào
                comm.Connection = conn;
                //Kiểu công việc
                comm.CommandType = CommandType.Text;
                //Công việc
                comm.CommandText = strSQL;
                if (pars != null && pars.Length > 0)//Nếu có tham số
                {
                    comm.Parameters.AddRange(pars);
                }
                //Khai báo 1 đối tượng để chứa kết quả lấy được từ truy vấn
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                //Đổ dữ liệu vào
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //Đóng kết nối
                conn.Close();
            }
            return dt;
        }

        public static bool ThucHien(string strSQL, SqlParameter[] pars = null)
        {
            //Khai báo 1 biến chứa kết quả thực hiện
            bool ketQua = false;
            SqlConnection conn = null;
            try
            {
                //Tạo 1 đối tượng kết nối
                conn = new SqlConnection(ConnectString);
                //Mở kết nối
                conn.Open();
                //Tạo công việc
                SqlCommand comm = new SqlCommand();
                //Thực hiện trên kết nối nào
                comm.Connection = conn;
                //Kiểu công việc
                comm.CommandType = CommandType.Text;
                //Công việc
                comm.CommandText = strSQL;
                if (pars != null && pars.Length > 0)//Nếu có tham số
                {
                    comm.Parameters.AddRange(pars);
                }
                //Thực hiện công việc
                ketQua = comm.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //Đóng kết nối
                conn.Close();
            }
            return ketQua;
        }


        



    }
}
