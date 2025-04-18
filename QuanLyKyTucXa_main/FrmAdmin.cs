using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKyTucXa_main
{
    public partial class FrmAdmin: Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void btnDangKyPhong_Click(object sender, EventArgs e)
        {
            FrmDangKyPhong frmDangKyPhong = new FrmDangKyPhong();
            frmDangKyPhong.ShowDialog();
        }

        private void btnDanhSachPhong_Click(object sender, EventArgs e)
        {
            DanhSachDangKy danhSachDangKy = new DanhSachDangKy();
            danhSachDangKy.ShowDialog();
        }

        private void btnQuanLyDay_Click(object sender, EventArgs e)
        {
            FrmQuanLyDay quanLyDay = new FrmQuanLyDay();
            quanLyDay.ShowDialog();
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            FrmQuanLyNhanVien quanLyNhanVien = new FrmQuanLyNhanVien();
            quanLyNhanVien.ShowDialog();
        }

        private void btnThanhtoanluong_Click(object sender, EventArgs e)
        {
            FrmThanhToanLuongNhanVien thanhToanLuongNhanVien = new FrmThanhToanLuongNhanVien();
            thanhToanLuongNhanVien.ShowDialog();
        }

    }
}
