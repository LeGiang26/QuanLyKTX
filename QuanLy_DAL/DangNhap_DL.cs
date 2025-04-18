using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace QuanLy_DAL
{
    public class DangNhap_DL: DataProvider
    {
        public NguoiDung KiemTraDangNhap(string tenDangNhap, string matKhau, string quyen)
        {
            try
            {
                Connect();
                string sql = "SELECT * FROM NguoiDung WHERE tendangnhap=@tendangnhap AND matkhau=@matkhau AND quyen=@quyen";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@tendangnhap", tenDangNhap);
                cmd.Parameters.AddWithValue("@matkhau", matKhau);
                cmd.Parameters.AddWithValue("@quyen", quyen);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new NguoiDung(
                        reader["tendangnhap"].ToString(),
                        reader["matkhau"].ToString(),
                        reader["quyen"].ToString()
                    );
                }
                return null;
            }
            finally
            {
                DisConnect();
            }
        }
    }
}
