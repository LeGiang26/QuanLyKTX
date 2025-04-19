using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_DAL
{
    public class DataProvider
    {
            public SqlConnection cn;

            public DataProvider()
            {
            // Link của chi, mn đổi cái khác nha
            string cnStr = "Data Source=DESKTOP-8862V4F\\LEGIANG2;Initial Catalog=QuanLyKytucXa;Integrated Security=True;TrustServerCertificate=True";

            //string cnStr = "Data Source=LAPTOP-MAMQ0DB1\\LION;Initial Catalog=QuanLyKyTucXa;Integrated Security=True";
            //string cnStr = "Data Source=DESKTOP-8862V4F\\LEGIANG2;Initial Catalog=QuanLyKyTucXa;Integrated Security=True;Trust Server Certificate=True";
            cn = new SqlConnection(cnStr);
            }

            public void Connect()
            {
                try
                {
                    if (cn != null && cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                    }
                }
                catch (SqlException ex)
                {
                    throw ex;
                }

            }
            public void DisConnect()
            {
                try
                {
                    if (cn != null && cn.State == ConnectionState.Open)
                    {
                        cn.Close();
                    }
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }
            public object MyExecuteScalar(string sql, CommandType type)
            {
                try
                {
                    Connect();
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.CommandType = type;

                    return (cmd.ExecuteScalar());
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

            public SqlDataReader MyExecuteReader(string sql, CommandType type)
            {
                try
                {

                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.CommandType = type;

                    return (cmd.ExecuteReader());
                }
                catch (SqlException ex)
                {
                    throw ex;
                }

            }
    }
}
