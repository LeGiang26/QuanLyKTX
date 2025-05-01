using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TransferObject;

namespace QuanLy_DAL
{
    public class DAL_SinhVien : DataProvider
    {
        public List<string> SelectMaSinhVien()
        {
            List<string> list = new List<string>();
            string sql = "SELECT masv FROM SinhVien";

            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    list.Add(reader["masv"].ToString());
                }
                reader.Close();
                return list;
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

        public List<SinhVien> GetAllSinhVien()
        {
            List<SinhVien> list = new List<SinhVien>();
            string sql = "SELECT * FROM SinhVien";

            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    SinhVien sv = new SinhVien(
                        reader["masv"].ToString(),
                        reader["tensv"].ToString(),
                        reader["gioitinh"].ToString(),
                        reader["ngaysinh"].ToString(),
                        reader["quequan"].ToString(),
                        reader["email"].ToString(),
                        reader["khoa"].ToString(),
                        reader["lop"].ToString(),
                        reader["loaiuutien"].ToString(),
                        reader["maphong"].ToString()
                    );
                    list.Add(sv);
                }
                reader.Close();
                return list;
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
