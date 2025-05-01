using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLy_DAL;
using TransferObject;
using System.Data;

namespace QuanLy_BLL
{
    public class BLL_SinhVien
    {
        private DAL_SinhVien dal = new DAL_SinhVien();

        public BLL_SinhVien()
        {
            dal = new DAL_SinhVien();
        }

        public List<string> SelectMaSinhVien()
        {
            return dal.SelectMaSinhVien();
        }

        public List<SinhVien> GetAllSinhVien()
        {
            return dal.GetAllSinhVien();
        }
    }
}
