using System;
using System.Data;
using System.Data.SqlClient;
using QuanLy_DAL;
using TransferObject;

namespace QuanLy_BLL
{
    public class Phong_BL
    {
        private Phong_DL dal = new Phong_DL();

        public Phong_BL()
        {
            dal = new Phong_DL();
        }

        public DataTable GetAllPhong()
        {
            return dal.GetAllPhong();
        }

        public DataTable GetMaPhong()
        {
            return dal.GetMaPhong();
        }

        public DataTable GetPhongTrong()
        {
            return dal.GetPhongTrong();
        }

        public DataTable GetSoSinhVien(string maphong)
        {
            return dal.GetSoSinhVien(maphong);
        }

        public DataTable GetSinhVienTrongPhong(string maphong)
        {
            return dal.GetSinhVienTrongPhong(maphong);
        }

        public DataTable SearchPhong(string keyword, string field)
        {
            return dal.SearchPhong(field, keyword);
        }

        public bool InsertPhong(string maphong, string tenphong, string sosvtoida, string loaiphong, string xeploai, string maday)
        {
            try
            {
                Phong phong = new Phong(maphong, tenphong, 0, int.Parse(sosvtoida), "Thiếu", loaiphong, xeploai, maday);
                string msg;
                return InsertPhong(phong, out msg);
            }
            catch
            {
                return false;
            }
        }

        public bool InsertPhong(Phong phong, out string message)
        {
            try
            {
                dal.InsertPhong(phong);
                message = "Đã thêm phòng thành công.";
                return true;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("PRIMARY KEY"))
                    message = "Mã phòng không được trùng.";
                else
                    message = ex.Message;
                return false;
            }
        }

        public bool UpdatePhong(string maphong, string tenphong, int sosvhientai, int sosvtoida, string loaiphong, string xeploai, string maday)
        {
            Phong phong = new Phong(maphong, tenphong, 0, sosvtoida, "Thiếu", loaiphong, xeploai, maday);
            string msg;
            return UpdatePhong(phong, out msg);
        }

        public bool UpdatePhong(Phong phong, out string message)
        {
            try
            {
                dal.UpdatePhong(phong);
                message = "Cập nhật phòng thành công.";
                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public bool DeletePhong(string maphong)
        {
            string msg;
            return DeletePhong(maphong, out msg);
        }

        public bool DeletePhong(string maphong, out string message)
        {
            try
            {
                dal.DeletePhong(maphong);
                message = "Xóa phòng thành công.";
                return true;
            }
            catch
            {
                message = "Không tìm thấy mã phòng để xóa.";
                return false;
            }
        }
    }

}
