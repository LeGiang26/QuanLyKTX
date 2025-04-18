using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class QuanLyNguoiDung
    {
        public string manguoidung { get; set; }
        public string manv { get; set; }
        public string tendangnhap { get; set; }

        public string matkhau { get; set; }
        public string quyen { get; set; }


        public QuanLyNguoiDung(string maNguoiDung, string maNV, 
            string tenDangNhap, string matKhau, string Quyen)
        {
            this.manguoidung = maNguoiDung;
            this.manv = maNV;
            this.tendangnhap = tenDangNhap;
            this.matkhau = matKhau;
            this.quyen = Quyen;
        }
    }
}
