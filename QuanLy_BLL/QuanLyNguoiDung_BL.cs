//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using TransferObject;
//using QuanLy_DAL;
//using System.Data.SqlClient;

//namespace QuanLy_BLL
//{
//    public class QuanLyNguoiDung_BL
//    {
//        private QuanLyNguoiDung_DL quanLyNguoiDung_DL;
//        public QuanLyNguoiDung_BL()
//        {
//            quanLyNguoiDung_DL = new QuanLyNguoiDung_DL();
//        }
//        public List<QuanLyNguoidung> LayDanhSachNguoiDung()
//        {
//            try
//            {
//                return quanLyNguoiDung_DL.LayDanhSachNguoiDung();

//            }
//            catch (SqlException ex)
//            {
//                throw ex;
//            }
//        }
//    }
//}
