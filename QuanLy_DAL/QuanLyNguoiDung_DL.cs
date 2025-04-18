//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using TransferObject;
//using System.Data.SqlClient;
//using System.Data;

//namespace QuanLy_DAL
//{
//    public class QuanLyNguoiDung_DL:DataProvider
//    {
//        // Tải Danh sách lên
//        public List<QuanLyNguoidung> LayDanhSachNguoiDung()
//        {
//            string manguoidung, manv, tendangnhap, matkhau, quyen;
//            List<QuanLyNguoidung> qlNguoiDungs = new List<QuanLyNguoidung>();
//            string sql = "SELECT * FROM NguoiDung";
//            try
//            {
//                Connect();
//                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
//                while (reader.Read())
//                {
//                    manguoidung = reader[0].ToString();
//                    manv = reader[1].ToString();
//                    tendangnhap = reader[2].ToString();
//                    matkhau = reader[3].ToString();
//                    quyen = reader[4].ToString();

//                    QuanLyNguoidung qlNguoiDung = new QuanLyNguoidung(manguoidung, manv, tendangnhap, matkhau, quyen);
//                    qlNguoiDungs.Add(qlNguoiDung);
//                }
//                reader.Close();
//                return qlNguoiDungs;
//            }
//            catch (SqlException ex)
//            {
//                throw ex;
//            }
//            finally
//            {
//                DisConnect();
//            }
//        }
//    }
//}
