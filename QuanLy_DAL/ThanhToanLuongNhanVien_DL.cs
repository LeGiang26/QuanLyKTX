using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using System.Data.SqlClient;
using System.Data;

namespace QuanLy_DAL
{
    public class ThanhToanLuongNhanVien_DL: DataProvider
    {
        public List<NhanVien> LayDanhSachNhanVien()
        {
            string manv, tennv, gioitinh;
            List<NhanVien> nhanViens = new List<NhanVien>();
            string sql = "SELECT * FROM NhanVien";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    manv = reader[0].ToString();
                    tennv = reader[1].ToString();
                    gioitinh = reader[2].ToString();

                    NhanVien nhanVien = new NhanVien(manv, tennv, "", "", "", "");
                    nhanViens.Add(nhanVien);
                }
                reader.Close();
                return nhanViens;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }

        public List<LuongNhanVien> LayDanhLuongNhanVien()
        {
            string mahoadon, manv, tennv, luongcoban, hesoluong, phucap, khautru, songaycong, ngaythanhtoan, tongluong;
            List<LuongNhanVien> luongNhanViens = new List<LuongNhanVien>();
            string sql = "SELECT * FROM LuongNhanVien";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    mahoadon = reader[0].ToString();
                    manv = reader[1].ToString();
                    tennv = reader[2].ToString();
                    luongcoban = reader[3].ToString();
                    hesoluong = reader[4].ToString();
                    phucap = reader[5].ToString();
                    khautru = reader[6].ToString();
                    songaycong = reader[7].ToString();
                    ngaythanhtoan = reader[8].ToString();
                    tongluong = reader[9].ToString();

                    LuongNhanVien luongNhanVien = new LuongNhanVien(mahoadon, manv, tennv, luongcoban, hesoluong, phucap, khautru, songaycong, ngaythanhtoan, tongluong);
                    luongNhanViens.Add(luongNhanVien);
                }
                reader.Close();
                return luongNhanViens;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }
        public void ThemHoacCapNhatLuong(LuongNhanVien luongNV)
        {
            string sql = @"INSERT INTO LuongNhanVien (manv, tennv, luongcoban, hesoluong, phucap, khautru, songaycong, ngaythanhtoan, tongluong, trangthai)
               VALUES (@manv, @tennv, @luongcoban, @hesoluong, @phucap, @khautru, @songaycong, @ngaythanhtoan, @tongluong)";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@manv", luongNV.manv);
                cmd.Parameters.AddWithValue("@tennv", luongNV.tennv);
                cmd.Parameters.AddWithValue("@luongcoban", decimal.Parse(luongNV.luongcoban));
                cmd.Parameters.AddWithValue("@hesoluong", decimal.Parse(luongNV.hesoluong));
                cmd.Parameters.AddWithValue("@phucap", decimal.Parse(luongNV.phucap));
                cmd.Parameters.AddWithValue("@khautru", decimal.Parse(luongNV.khautru));
                cmd.Parameters.AddWithValue("@songaycong", int.Parse(luongNV.songaycong));
                cmd.Parameters.AddWithValue("@ngaythanhtoan", DateTime.Parse(luongNV.ngaythanhtoan));
                cmd.Parameters.AddWithValue("@tongluong", decimal.Parse(luongNV.tongluong));
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }

        public void CapNhatLuongNhanVien(LuongNhanVien luongNV)
        {
            string sql = @"UPDATE LuongNhanVien 
                   SET manv = @manv, tennv = @tennv, luongcoban = @luongcoban, 
                       hesoluong = @hesoluong, phucap = @phucap, khautru = @khautru, 
                       songaycong = @songaycong, ngaythanhtoan = @ngaythanhtoan, 
                       tongluong = @tongluong
                   WHERE mahoadon = @mahoadon";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@mahoadon", luongNV.mahoadon);
                cmd.Parameters.AddWithValue("@manv", luongNV.manv);
                cmd.Parameters.AddWithValue("@tennv", luongNV.tennv);
                cmd.Parameters.AddWithValue("@luongcoban", decimal.Parse(luongNV.luongcoban));
                cmd.Parameters.AddWithValue("@hesoluong", decimal.Parse(luongNV.hesoluong));
                cmd.Parameters.AddWithValue("@phucap", decimal.Parse(luongNV.phucap));
                cmd.Parameters.AddWithValue("@khautru", decimal.Parse(luongNV.khautru));
                cmd.Parameters.AddWithValue("@songaycong", int.Parse(luongNV.songaycong));
                cmd.Parameters.AddWithValue("@ngaythanhtoan", DateTime.Parse(luongNV.ngaythanhtoan));
                cmd.Parameters.AddWithValue("@tongluong", decimal.Parse(luongNV.tongluong));
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }

        public void XoaLuongNhanVien(string maHoaDon)
        {
            string sql = "DELETE FROM LuongNhanVien WHERE mahoadon = @mahoadon";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@mahoadon", maHoaDon);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }
    }
}
