using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace QuanLy_DAL
{
    public class KyLuat_DL: DataProvider
    {
        public DataTable SelectKyLuat()
        {
            string sql = "SELECT * FROM KyLuat";
            return GetTable(sql);
        }

        public void InsertKyLuat(string masv, string kyluat, DateTime ngaykl, float tienphat)
        {
            string sql = $"INSERT INTO KyLuat (masv, kyluat, ngaykyluat, tienphat) VALUES ('{masv}', N'{kyluat}', '{ngaykl:yyyy-MM-dd}', {tienphat})";
            ExecNonQuery(sql);
        }

        public void UpdateKyLuat(string makyluat, string masv, string kyluat, DateTime ngaykl, float tienphat)
        {
            string sql = $"UPDATE KyLuat SET masv='{masv}', kyluat=N'{kyluat}', ngaykyluat='{ngaykl:yyyy-MM-dd}', tienphat={tienphat} WHERE makyluat='{makyluat}'";
            ExecNonQuery(sql);
        }

        public void DeleteKyLuat(string makl)
        {
            string sql = $"DELETE FROM KyLuat WHERE makyluat='{makl}'";
            ExecNonQuery(sql);
        }

        public DataTable SearchKyLuat(string keyword, string field)
        {
            string sql = $"SELECT * FROM KyLuat WHERE {field} LIKE N'%{keyword}%'";
            return GetTable(sql);
        }

        public bool ExistsKyLuat(string makyluat)
        {
            string sql = $"SELECT COUNT(*) FROM KyLuat WHERE makyluat='{makyluat}'";
            DataTable dt = GetTable(sql);
            return Convert.ToInt32(dt.Rows[0][0]) > 0;
        }
    }
}

