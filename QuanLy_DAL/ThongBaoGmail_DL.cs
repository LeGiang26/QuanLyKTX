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
    public class ThongBaoGmail_DL: DataProvider
    {
        public List<string> LayDanhSachEmail()
        {
            List<string> emails = new List<string>();
            string sql = "SELECT email FROM SinhVien";

            Connect();
            try
            {
                using (SqlDataReader dr = MyExecuteReader(sql, CommandType.Text))
                {
                    while (dr.Read())
                    {
                        emails.Add(dr["email"].ToString());
                    }
                }
            }
            finally
            {
                DisConnect();
            }
            return emails;
        }
    }
}
