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
    public class DanhSachDangKy_DL: DataProvider
    {  
        // Tải Danh sách lên để chờ duyệt
        public List<SinhVienDangKy> LayDSSinhVienDangKy()
        {
            string masvdky, tensv, gioitinh, ngaysinh, quequan, khoa, lop, loaiuutien;
            List<SinhVienDangKy> sinhVienDangKys = new List<SinhVienDangKy>();
            string sql = "SELECT * FROM SinhVienDangKy";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    masvdky = reader[0].ToString();
                    tensv = reader[1].ToString();
                    gioitinh = reader[2].ToString();
                    ngaysinh = reader[3].ToString();
                    quequan = reader[4].ToString();
                    khoa = reader[5].ToString();
                    lop = reader[6].ToString();
                    loaiuutien = reader[7].ToString();

                    SinhVienDangKy sinhVienDangKy = new SinhVienDangKy(masvdky, tensv, gioitinh, ngaysinh, quequan, khoa, lop, loaiuutien);
                    sinhVienDangKys.Add(sinhVienDangKy);
                }
                reader.Close();
                return sinhVienDangKys;
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

        // Tải danh sách sinh viên đăng đã được duyệt rồi
        public List<SinhVien> LayDSSinhVien()
        {
            string masv, tensv, gioitinh, ngaysinh, quequan, khoa, lop, loaiuutien, maphong;
            List<SinhVien> sinhViens = new List<SinhVien>();
            string sql = "SELECT * FROM SinhVien";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    masv = reader[0].ToString();
                    tensv = reader[1].ToString();
                    gioitinh = reader[2].ToString();
                    ngaysinh = reader[3].ToString();
                    quequan = reader[4].ToString();
                    khoa = reader[5].ToString();
                    lop = reader[6].ToString();
                    loaiuutien = reader[7].ToString();
                    maphong = reader[8].ToString();

                    SinhVien sinhVien = new SinhVien(masv, tensv, gioitinh, ngaysinh, quequan, khoa, lop, loaiuutien, maphong);
                    sinhViens.Add(sinhVien);
                }
                reader.Close();
                return sinhViens;
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

        private List<Phong> LayDSPhongTheoDieuKien(string sql)
        {
            List<Phong> dsPhong = new List<Phong>();
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    string maphong = reader["maphong"].ToString();
                    string tenphong = reader["tenphong"].ToString();
                    string sosv = reader["sosv"].ToString();
                    string sosvtoida = reader["sosvtoida"].ToString();
                    string tinhtrang = reader["tinhtrang"].ToString();
                    string loaiphong = reader["loaiphong"].ToString();
                    string xeploai = reader["xeploai"].ToString();
                    string day = reader["day"].ToString();
                    string chisocu = reader["chisocu"].ToString();

                    Phong phong = new Phong(maphong, tenphong, sosv, sosvtoida, tinhtrang, loaiphong, xeploai, day, chisocu);
                    dsPhong.Add(phong);
                }
                reader.Close();
                return dsPhong;
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

        // Lấy Danh sách phòng của Nam
        public List<Phong> LayDSPhongTrongNam()
        {
            List<Phong> dsPhongNam = new List<Phong>();
            string sql = "SELECT * FROM Phong WHERE loaiphong = N'Nam' AND sosv < sosvtoida";
            return LayDSPhongTheoDieuKien(sql);
        }

        // Lấy Danh sách phòng của Nữ
        public List<Phong> LayDSPhongTrongNu()
        {
            List<Phong> dsPhongNu = new List<Phong>();
            string sql = "SELECT * FROM Phong WHERE loaiphong = N'Nữ' AND sosv < sosvtoida";
            return LayDSPhongTheoDieuKien(sql);
        }

        public bool ThemSinhVien(SinhVien sv)
        {
            string sql = @"INSERT INTO SinhVien (masv, tensv, gioitinh, ngaysinh, quequan, khoa, lop, loaiuutien, maphong) 
                  VALUES (@masv, @tensv, @gioitinh, @ngaysinh, @quequan, @khoa, @lop, @loaiuutien, @maphong)";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@masv", sv.masv);
                cmd.Parameters.AddWithValue("@tensv", sv.tensv);
                cmd.Parameters.AddWithValue("@gioitinh", sv.gioitinh);
                cmd.Parameters.AddWithValue("@ngaysinh", sv.ngaysinh);
                cmd.Parameters.AddWithValue("@quequan", sv.quequan);
                cmd.Parameters.AddWithValue("@khoa", sv.khoa);
                cmd.Parameters.AddWithValue("@lop", sv.lop);
                cmd.Parameters.AddWithValue("@loaiuutien", sv.loaiuutien);
                cmd.Parameters.AddWithValue("@maphong", sv.maphong);
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

        public bool XoaSinhVienDangKy(string masv)
        {
            string sql = "DELETE FROM SinhVienDangKy WHERE masvdky = @masv";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@masv", masv);
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

        public bool CapNhatSoSVPhong(string maPhong)
        {
            string sql = "UPDATE Phong SET sosv = sosv + 1 WHERE maphong = @maphong";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@maphong", maPhong);
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

        public bool CapNhatSinhVienDangKy(SinhVienDangKy sv)
        {
            string sql = @"UPDATE SinhVienDangKy 
                   SET tensv = @tensv, 
                       gioitinh = @gioitinh, 
                       ngaysinh = @ngaysinh, 
                       quequan = @quequan, 
                       khoa = @khoa, 
                       lop = @lop, 
                       loaiuutien = @loaiuutien 
                   WHERE masvdky = @masvdky";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@masvdky", sv.masvdky);
                cmd.Parameters.AddWithValue("@tensv", sv.tensv);
                cmd.Parameters.AddWithValue("@gioitinh", sv.gioitinh);
                cmd.Parameters.AddWithValue("@ngaysinh", sv.ngaysinh);
                cmd.Parameters.AddWithValue("@quequan", sv.quequan);
                cmd.Parameters.AddWithValue("@khoa", sv.khoa);
                cmd.Parameters.AddWithValue("@lop", sv.lop);
                cmd.Parameters.AddWithValue("@loaiuutien", sv.loaiuutien);
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
    }
}

