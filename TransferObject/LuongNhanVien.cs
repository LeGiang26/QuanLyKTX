using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class LuongNhanVien
    {
        public string mahoadon {  get; set; }
        public string manv { get; set; }

        public string tennv { get; set; }

        public string luongcoban { get; set; }

        public string hesoluong { get; set; }

        public string phucap { get; set; }

        public string khautru { get; set; }

        public string songaycong { get; set; }

        public string ngaythanhtoan { get; set; }

        public string tongluong { get; set; }


        public LuongNhanVien(string maHD, string maNV, string tenNV, string luongCoBan, string heSoLuong, string phuCap, string khauTru, string soNgayCong, 
            
            string ngayThanhToan, string tongLuong)
        {
            this.mahoadon = maHD;
            this.manv = maNV;
            this.tennv = tenNV;
            this.luongcoban = luongCoBan;
            this.hesoluong = heSoLuong;
            this.phucap = phuCap;
            this.khautru = khauTru;
            this.songaycong = soNgayCong;
            this.ngaythanhtoan = ngayThanhToan;
            this.tongluong = tongLuong;
        }
    }
}
