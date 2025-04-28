using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using TransferObject;

namespace QuanLy_DAL
{
    public class TienDien_DL : DataProvider
    {
        public DataTable SelectTienDien()
        {
            string sql = "SELECT * FROM TienDien";
            return GetTable(sql);
        }


        public DataTable SelectSoDien(string mahoadon)
        {
            string sql = "SELECT sodientieuthu FROM TienDien WHERE mahoadon = '" + mahoadon + "'";
            return GetTable(sql);
        }

        public DataTable SelectChiSoMoiGanNhat(string maphong)
        {
            string sql = $@"
            SELECT TOP 1 chisomoi
            FROM TienDien
            WHERE maphong = '{maphong}'
            ORDER BY ngaylap DESC, mahoadon DESC";
            return GetTable(sql);
        }

        public DataTable SelectHoaDonKeTiep(string maphong, DateTime ngaylap)
        {
            string sql = $@"
            SELECT TOP 1 * 
            FROM TienDien 
            WHERE maphong = '{maphong}' AND ngaylap > '{ngaylap:yyyy-MM-dd}'
            ORDER BY ngaylap ASC";
            return GetTable(sql);
        }

        public DataTable SelectChiSoCu(string map)
        {
            string sql = "SELECT chisocu FROM TienDien WHERE maphong = '" + map + "'";
            return GetTable(sql);
        }

        public void UpdateTrangThai(string mahd, string trangthai)
        {
            string sql = "UPDATE TienDien SET trangthai = N'" + trangthai + "' WHERE mahoadon = '" + mahd + "'";
            ExecNonQuery(sql);
        }

        public void InsertTienDien(TienDien td)
        {
            string sql = $"INSERT INTO TienDien (maphong, ngaylap, chisocu, chisomoi, sodientieuthu, tongtien, trangthai) " +
                         $"VALUES ('{td.Maphong}', '{td.Ngaylap:yyyy-MM-dd}', {td.Chisocu}, {td.Chisomoi}, {td.Sodientieuthu}, {td.Tongtien}, N'{td.Trangthai}')";
            ExecNonQuery(sql);
        }


        public void UpdateTienDien(TienDien td)
        {
            string sql = $"UPDATE TienDien SET " +
                         $"maphong='{td.Maphong}', " +
                         $"ngaylap='{td.Ngaylap:yyyy-MM-dd}', " +
                         $"chisocu={td.Chisocu}, " +
                         $"chisomoi={td.Chisomoi}, " +
                         $"sodientieuthu={td.Sodientieuthu}, " +
                         $"tongtien={td.Tongtien}, " +
                         $"trangthai=N'{td.Trangthai}' " +
                         $"WHERE mahoadon={td.Mahoadon}";
            ExecNonQuery(sql);
        }


        public void DeleteTienDien(string mahoadon)
        {
            string sql = "DELETE FROM TienDien WHERE mahoadon='" + mahoadon + "'";
            ExecNonQuery(sql);
        }

        public DataTable SearchTienDien(string chuoi, string truong)
        {
            string sql = $"SELECT * FROM TienDien WHERE {truong} LIKE N'%{chuoi}%'";
            return GetTable(sql);
        }

    }
}
