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
    public class SinhVien_BL
    {
        private SinhVien_DL dal = new SinhVien_DL();

        public SinhVien_BL()
        {
            dal = new SinhVien_DL();
        }

        public DataTable SelectMaSinhVien()
        {
            return dal.SelectMaSinhVien();
        }

    }
}
