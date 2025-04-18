using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using QuanLy_DAL;

namespace QuanLy_BLL
{
    public class DanhSachDangKy_BL
    {
        private DanhSachDangKy_DL danhSachDangKyDL;
       
        public DanhSachDangKy_BL()
        {
            danhSachDangKyDL = new DanhSachDangKy_DL();
        }

        public List<SinhVienDangKy> LayDSSinhVienDangKy()
        {
            try
            {
                return danhSachDangKyDL.LayDSSinhVienDangKy();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<SinhVien> LayDSSinhVien()
        {
            try
            {
                return danhSachDangKyDL.LayDSSinhVien();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public List<Phong> LayDSPhongTrongNam()
        {
            try
            {
                return danhSachDangKyDL.LayDSPhongTrongNam();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<Phong> LayDSPhongTrongNu()
        {
            try
            {
                return danhSachDangKyDL.LayDSPhongTrongNu();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool ThemSinhVien(SinhVien sv)
        {
            try
            {
                return danhSachDangKyDL.ThemSinhVien(sv);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool XoaSinhVienDangKy(string masv)
        {
            try
            {
                return danhSachDangKyDL.XoaSinhVienDangKy(masv);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }


        public bool CapNhatSoSVPhong(string maPhong)
        {
            try
            {
                return danhSachDangKyDL.CapNhatSoSVPhong(maPhong);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool CapNhatSinhVienDangKy(SinhVienDangKy sv)
        {
            try
            {
                return danhSachDangKyDL.CapNhatSinhVienDangKy(sv);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
