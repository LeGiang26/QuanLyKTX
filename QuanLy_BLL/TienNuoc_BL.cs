using System;
using System.Data;
using TransferObject;
using QuanLy_DAL;

namespace QuanLy_BLL
{
    public class TienNuoc_BL
    {
        private TienNuoc_DL dal = new TienNuoc_DL();

        public DataTable SelectTienNuoc()
        {
            return dal.SelectTienNuoc();
        }


        public DataTable SelectSoKhoi(string mahoadon)
        {
            return dal.SelectSoKhoi(mahoadon);
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

        public void InsertTienNuoc(TienNuoc tn)
        {
            dal.InsertTienNuoc(tn);
        }

        public void UpdateTienNuoc(TienNuoc tn)
        {
            dal.UpdateTienNuoc(tn);
        }

        public void DeleteTienNuoc(string mahoadon)
        {
            dal.DeleteTienNuoc(mahoadon);
        }

        public DataTable SearchTienNuoc(string chuoi, string truong)
        {
            return dal.SearchTienNuoc(chuoi, truong);
        }

    }
}
