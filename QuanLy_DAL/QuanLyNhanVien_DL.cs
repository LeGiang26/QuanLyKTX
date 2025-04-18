using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace QuanLy_DAL
{
    public class QuanLyNhanVien_DL: DataProvider
    {
        public List<NhanVien> LayDanhSachNhanVien()
        {
            string manv, tennv, gioitinh, diachi, ngaysinh, sodienthoai;
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
                    diachi = reader[3].ToString();
                    ngaysinh = reader[4].ToString();
                    sodienthoai = reader[5].ToString();

                    NhanVien nhanVien = new NhanVien(manv, tennv, gioitinh, diachi, ngaysinh, sodienthoai);
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

        public bool ThemNhanVien(NhanVien nv)
        {
            string sql = "INSERT INTO NhanVien VALUES(@manv, @tennv, @gioitinh, @ngaysinh, @diachi, @sodienthoai)";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@manv", nv.manv);
                cmd.Parameters.AddWithValue("@tennv", nv.tennv);
                cmd.Parameters.AddWithValue("@gioitinh", nv.gioitinh);
                cmd.Parameters.AddWithValue("@ngaysinh", DateTime.Parse(nv.ngaysinh));
                cmd.Parameters.AddWithValue("@diachi", nv.diachi);
                cmd.Parameters.AddWithValue("@sodienthoai", nv.sodienthoai);
                cmd.ExecuteNonQuery();
                return true;
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
        public bool SuaNhanVien(NhanVien nv)
        {
            string sql = @"UPDATE NhanVien 
                  SET tennv = @tennv, 
                      gioitinh = @gioitinh, 
                      ngaysinh = @ngaysinh, 
                      diachi = @diachi, 
                      sodienthoai = @sodienthoai 
                  WHERE manv = @manv";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@manv", nv.manv);
                cmd.Parameters.AddWithValue("@tennv", nv.tennv);
                cmd.Parameters.AddWithValue("@gioitinh", nv.gioitinh);
                cmd.Parameters.AddWithValue("@ngaysinh", DateTime.Parse(nv.ngaysinh));
                cmd.Parameters.AddWithValue("@diachi", nv.diachi);
                cmd.Parameters.AddWithValue("@sodienthoai", nv.sodienthoai);
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
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

        public bool XoaNhanVien(string manv)
        {
            string sql = "DELETE FROM NhanVien WHERE manv = @manv";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@manv", manv);
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (SqlException ex)
            {
                // Xử lý ràng buộc khóa ngoại
                if (ex.Number == 547)
                    throw new Exception("Không thể xóa nhân viên đang có thông tin liên quan!");
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }
        public List<NhanVien> TimKiemNhanVien(string keyword, bool timTheoMa)
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            string sql;
            if (timTheoMa)
                sql = "SELECT * FROM NhanVien WHERE manv LIKE @keyword";
            else
                sql = "SELECT * FROM NhanVien WHERE tennv LIKE @keyword";

            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    NhanVien nv = new NhanVien(
                        reader["manv"].ToString(),
                        reader["tennv"].ToString(),
                        reader["gioitinh"].ToString(),
                        reader["ngaysinh"].ToString(),
                        reader["diachi"].ToString(),
                        reader["sodienthoai"].ToString()
                    );
                    nhanViens.Add(nv);
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

    }
}
