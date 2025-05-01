using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class ThietBi
    {
        public string Maphong { get; set; }
        public string Tenthietbi { get; set; }
        public int Soluong { get; set; }
        public string Tinhtrang { get; set; }

        public ThietBi() { }

        public ThietBi(string maphong, string tenthietbi, int soluong, string tinhtrang)
        {
            this.Maphong = maphong;
            this.Tenthietbi = tenthietbi;
            this.Soluong = soluong;
            this.Tinhtrang = tinhtrang;
        }
    }
}
