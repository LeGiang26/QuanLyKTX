using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Phong
    {
        public string maphong { get; set; }
        public string tenphong { get; set; }
        public int sosv { get; set; }
        public int sosvtoida { get; set; }
        public string tinhtrang { get; set; }
        public string loaiphong { get; set; }
        public string xeploai { get; set; }
        public string day { get; set; }
        public string chisocu { get; set; }

        public  Phong (string maPhong, string tenPhong, int soSV, int soSVToiDa, 
            string tinhTrang, string loaiPhong, string xepLoai, string Day, string chiSoCu)
        {
            this.maphong=maPhong;
            this.tenphong=tenPhong;
            this.sosv = soSV;
            this.sosvtoida =soSVToiDa;
            this.tinhtrang = tinhTrang;
            this.loaiphong = loaiPhong;
            this.xeploai = xepLoai;
            this.day = Day;
            this.chisocu = chiSoCu;
        }
    }
}
