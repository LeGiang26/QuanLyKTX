using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TransferObject;

namespace QuanLy_DAL
{
    public class ThietBi_DL : DataProvider
    {
        public DataTable GetAllThietBi()
        {
            string sql = "SELECT * FROM ThietBi";
            return GetTable(sql);
        }

        public DataTable GetThietBiTheoPhong(string maphong)
        {
            string sql = "SELECT * FROM ThietBi WHERE maphong = @maphong";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@maphong", maphong);
            return GetTable(cmd);
        }

        public bool InsertThietBi(ThietBi tb)
        {
            string sql = @"INSERT INTO ThietBi (maphong, tenthietbi, soluong, tinhtrang)
                           VALUES (@maphong, @tentb, @soluong, @tinhtrang)";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@maphong", tb.Maphong);
            cmd.Parameters.AddWithValue("@tentb", tb.Tenthietbi);
            cmd.Parameters.AddWithValue("@soluong", tb.Soluong);
            cmd.Parameters.AddWithValue("@tinhtrang", tb.Tinhtrang);
            return ExecNonQuery(cmd);
        }

        public bool UpdateThietBi(ThietBi tb)
        {
            string sql = @"UPDATE ThietBi 
                   SET soluong = @soluong, tinhtrang = @tinhtrang 
                   WHERE maphong = @maphong AND tenthietbi = @tentb";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@maphong", tb.Maphong);
            cmd.Parameters.AddWithValue("@tentb", tb.Tenthietbi);
            cmd.Parameters.AddWithValue("@soluong", tb.Soluong);
            cmd.Parameters.AddWithValue("@tinhtrang", tb.Tinhtrang);
            return ExecNonQuery(cmd);
        }


        public bool DeleteThietBi(string maphong, string tentb)
        {
            string sql = "DELETE FROM ThietBi WHERE maphong = @maphong AND tenthietbi = @tentb";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@maphong", maphong);
            cmd.Parameters.AddWithValue("@tentb", tentb);
            return ExecNonQuery(cmd);
        }
    }
}
