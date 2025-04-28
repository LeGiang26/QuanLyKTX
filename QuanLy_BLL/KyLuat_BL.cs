using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLy_DAL;
using TransferObject;

namespace QuanLy_BLL
{
    public class KyLuat_BL
    {
        private KyLuat_DL dal = new KyLuat_DL();

        public DataTable SelectKyLuat()
        {
            return dal.SelectKyLuat();
        }

        public bool InsertKyLuat(string masv, string kyluat, DateTime ngaykl, float tienphat)
        {
            try
            {
                dal.InsertKyLuat(masv, kyluat, ngaykl, tienphat);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateKyLuat(string makyluat, string masv, string kyluat, DateTime ngaykl, float tienphat)
        {
            if (!dal.ExistsKyLuat(makyluat))
                return false;

            try
            {
                dal.UpdateKyLuat(makyluat, masv, kyluat, ngaykl, tienphat);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteKyLuat(string makyluat)
        {
            if (!dal.ExistsKyLuat(makyluat))
                return false;

            try
            {
                dal.DeleteKyLuat(makyluat);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable SearchKyLuat(string keyword, string field)
        {
            return dal.SearchKyLuat(keyword, field);
        }
    }
}