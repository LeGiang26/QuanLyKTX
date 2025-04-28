using System;
using System.Data;
using TransferObject;
using QuanLy_DAL;

namespace QuanLy_BLL
{
    public class BLL_TienDien
    {
        private TienDien_DL dal = new TienDien_DL();

        public DataTable SelectTienDien()
        {
            return dal.SelectTienDien();
        }


        public DataTable SelectSoDien(string mahoadon)
        {
            return dal.SelectSoDien(mahoadon);
        }

        public DataTable SelectChiSoMoiGanNhat(string maphong)
        {
            return dal.SelectChiSoMoiGanNhat(maphong);
        }

        public DataTable SelectHoaDonKeTiep(string maphong, DateTime ngaylap)
        {
            return dal.SelectHoaDonKeTiep(maphong, ngaylap);
        }

        public DataTable SelectChiSoCu(string maphong)
        {
            return dal.SelectChiSoCu(maphong);
        }


        public void UpdateTrangThai(string mahoadon, string trangthai)
        {
            dal.UpdateTrangThai(mahoadon, trangthai);
        }

        public void InsertTienDien(TienDien td)
        {
            dal.InsertTienDien(td);
        }

        public void UpdateTienDien(TienDien td)
        {
            dal.UpdateTienDien(td);
        }

        public void DeleteTienDien(string mahoadon)
        {
            dal.DeleteTienDien(mahoadon);
        }

        public DataTable SearchTienDien(string keyword, string field)
        {
            return dal.SearchTienDien(keyword, field);
        }
   
    }
}
