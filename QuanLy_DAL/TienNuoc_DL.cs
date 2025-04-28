using System;
using System.Data;
using System.Data.SqlClient;
using TransferObject;

namespace QuanLy_DAL
{
    public class TienNuoc_DL : DataProvider
    {
        public DataTable SelectTienNuoc()
        {
            string sql = "SELECT * FROM TienNuoc";
            return GetTable(sql);
        }

        public DataTable SelectSoKhoi(string mahoadon)
        {
            string sql = "SELECT sokhoitieuthu FROM TienNuoc WHERE mahoadon = '" + mahoadon + "'";
            return GetTable(sql);
        }

        public DataTable SelectChiSoMoiGanNhat(string maphong)
        {
            string sql = $@"
                SELECT TOP 1 chisomoi 
                FROM TienNuoc 
                WHERE maphong = '{maphong}' 
                ORDER BY ngaylap DESC, mahoadon DESC";
            return GetTable(sql);
        }

        public DataTable SelectHoaDonKeTiep(string maphong, DateTime ngaylap)
        {
            string sql = $@"
                SELECT TOP 1 * 
                FROM TienNuoc 
                WHERE maphong = '{maphong}' AND ngaylap > '{ngaylap:yyyy-MM-dd}' 
                ORDER BY ngaylap ASC";
            return GetTable(sql);
        }

        public DataTable SelectChiSoCu(string map)
        {
            string sql = "SELECT chisocu FROM TienNuoc WHERE maphong = '" + map + "'";
            return GetTable(sql);
        }

        public void UpdateTrangThai(string mahd, string trangthai)
        {
            string sql = "UPDATE TienNuoc SET trangthai = N'" + trangthai + "' WHERE mahoadon = '" + mahd + "'";
            ExecNonQuery(sql);
        }

        public void InsertTienNuoc(TienNuoc tn)
        {
            string sql = $@"
                INSERT INTO TienNuoc (maphong, ngaylap, chisocu, chisomoi, sokhoitieuthu, tongtien, trangthai)
                VALUES ('{tn.Maphong}', '{tn.Ngaylap:yyyy-MM-dd}', {tn.Chisocu}, {tn.Chisomoi}, {tn.Sokhoitieuthu}, {tn.Tongtien}, N'{tn.Trangthai}')";
            ExecNonQuery(sql);
        }

        public void UpdateTienNuoc(TienNuoc tn)
        {
            string sql = $@"
                UPDATE TienNuoc 
                SET maphong='{tn.Maphong}', 
                    ngaylap='{tn.Ngaylap:yyyy-MM-dd}', 
                    chisocu={tn.Chisocu}, 
                    chisomoi={tn.Chisomoi},
                    sokhoitieuthu={tn.Sokhoitieuthu},
                    tongtien={tn.Tongtien},
                    trangthai=N'{tn.Trangthai}'
                WHERE mahoadon={tn.Mahoadon}";
            ExecNonQuery(sql);
        }

        public void DeleteTienNuoc(string mahoadon)
        {
            string sql = "DELETE FROM TienNuoc WHERE mahoadon='" + mahoadon + "'";
            ExecNonQuery(sql);
        }

        public DataTable SearchTienNuoc(string chuoi, string truong)
        {
            string sql = $"SELECT * FROM TienNuoc WHERE {truong} LIKE N'%{chuoi}%'";
            return GetTable(sql);
        }
    }
}
