using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TransferObject;

namespace QuanLy_DAL
{
    public class Phong_DL : DataProvider
    {
        public DataTable GetAllPhong()
        {
            string sql = "SELECT * FROM Phong";
            return GetTable(sql);
        }

        public DataTable GetMaPhong()
        {
            string sql = "SELECT maphong FROM Phong";
            return GetTable(sql);
        }

        public DataTable GetPhongTrong()
        {
            string sql = "SELECT * FROM Phong WHERE tinhtrang = N'Thiếu'";
            return GetTable(sql);
        }

        public DataTable GetSoSinhVien(string maphong)
        {
            string sql = $"SELECT COUNT(*) FROM SinhVien WHERE maphong = '{maphong}'";
            return GetTable(sql);
        }

        public DataTable GetSinhVienTrongPhong(string maphong)
        {
            string sql = $"SELECT * FROM SinhVien WHERE maphong = '{maphong}'";
            return GetTable(sql);
        }

        public DataTable SearchPhong(string truong, string chuoi)
        {
            string sql = $"SELECT * FROM Phong WHERE {truong} LIKE N'%{chuoi}%'";
            return GetTable(sql);
        }

        public void InsertPhong(Phong phong)
        {
            string sql = $"INSERT INTO Phong VALUES('{phong.Maphong}', N'{phong.Tenphong}', {phong.Sosv}, {phong.Sosvtoida}, N'{phong.Tinhtrang}', N'{phong.Loaiphong}', N'{phong.Xeploai}', '{phong.Maday}')";
            ExecNonQuery(sql);
        }

        public void UpdatePhong(Phong phong)
        {
            string tt = phong.Sosv < phong.Sosvtoida ? "Thiếu" : "Đủ";
            string sql = $"UPDATE Phong SET tenphong = N'{phong.Tenphong}', sosvtoida = {phong.Sosvtoida}, tinhtrang = N'{tt}', loaiphong = N'{phong.Loaiphong}', xeploai = N'{phong.Xeploai}', day = '{phong.Maday}' WHERE maphong = '{phong.Maphong}'";
            ExecNonQuery(sql);
        }

        public void DeletePhong(string maphong)
        { 
            string sql = $"DELETE FROM Phong WHERE maphong = '{maphong}'";
            ExecNonQuery(sql);
        }
    }
}
