using System;
using System.Data;
using TransferObject;
using QuanLy_DAL;

namespace QuanLy_BLL
{
    public class ThietBi_BL
    {
        private ThietBi_DL dal = new ThietBi_DL();

        public DataTable GetAllThietBi()
        {
            return dal.GetAllThietBi();
        }

        public DataTable SelectThietBi(string maphong)
        {
            return dal.GetThietBiTheoPhong(maphong);
        }

        public bool InsertThietBi(ThietBi tb, out string error)
        {
            error = "";

            if (string.IsNullOrEmpty(tb.Tenthietbi) || tb.Soluong <= 0)
            {
                error = "Tên thiết bị không hợp lệ hoặc số lượng <= 0";
                return false;
            }

            return dal.InsertThietBi(tb);
        }

        public bool UpdateThietBi(ThietBi tb, out string error)
        {
            error = "";

            if (string.IsNullOrEmpty(tb.Maphong) || string.IsNullOrEmpty(tb.Tenthietbi))
            {
                error = "Thiếu mã phòng hoặc tên thiết bị";
                return false;
            }

            return dal.UpdateThietBi(tb);
        }

        public bool DeleteThietBi(string maphong, string tentb)
        {
            return dal.DeleteThietBi(maphong, tentb);
        }
    }
}
