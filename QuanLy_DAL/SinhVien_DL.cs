using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace QuanLy_DAL
{
    public class SinhVien_DL : DataProvider
    {
        public DataTable SelectMaSinhVien()
        {
            string sql = "select masv from SinhVien";
            DataTable dt = new DataTable();
            return GetTable(sql);
        }
    }

}
