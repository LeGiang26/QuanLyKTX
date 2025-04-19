using QuanLy_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;

namespace QuanLyKyTucXa_main
{
    public partial class FrmThanhToanLuongNhanVien : Form
    {
        private ThanhToanLuongNhanVien_BL thanhToanLuongNhanVien_BL;
        public FrmThanhToanLuongNhanVien()
        {
            InitializeComponent();
            thanhToanLuongNhanVien_BL = new ThanhToanLuongNhanVien_BL();
        }

        private void FrmThanhToanLuongNhanVien_Load(object sender, EventArgs e)
        {
            dgvLuongnhanvien.DataSource = thanhToanLuongNhanVien_BL.LayDanhSachLuongNhanVien();
            dgvNhanvien.DataSource = thanhToanLuongNhanVien_BL.LayDanhSachNhanVien();
        }


        private void btnTinhluong_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(txtManv.Text)) throw new Exception("Mã NV không được trống");
                decimal luongCoBan = decimal.Parse(txtLuongcoban.Text);
                decimal heSoLuong = decimal.Parse(txtHesoluong.Text);
                decimal phuCap = decimal.Parse(txtPhucap.Text);
                decimal khauTru = decimal.Parse(txtKhautru.Text);
                int soNgayCong = int.Parse(txtSongaycong.Text);

                // Tính tổng lương (ví dụ: công thức cơ bản)
                decimal tongLuong = (luongCoBan * heSoLuong + phuCap - khauTru) * (soNgayCong / 26m);

                // Cập nhật các TextBox (KHÔNG gán ngày hiện tại)
                txtTongluong.Text = tongLuong.ToString("N0");


                // Tạo đối tượng lưu vào CSDL với ngày từ DateTimePicker
                LuongNhanVien luongNV = new LuongNhanVien(
                    txtMahoadon.Text,
                    txtManv.Text,
                    txtTennv.Text,
                    txtLuongcoban.Text,
                    txtHesoluong.Text,
                    txtPhucap.Text,
                    txtKhautru.Text,
                    txtSongaycong.Text,
                    dtpNgaythanhtoan.Value.ToString("yyyy-MM-dd"), // Sử dụng giá trị từ DateTimePicker
                    tongLuong.ToString()

                );

                // Gọi phương thức BL để thêm/cập nhật dữ liệu
                thanhToanLuongNhanVien_BL.ThemHoacCapNhatLuong(luongNV);

                // Làm mới DataGridView
                dgvLuongnhanvien.DataSource = thanhToanLuongNhanVien_BL.LayDanhSachLuongNhanVien();
                MessageBox.Show("Tính lương và lưu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanvien.Rows[e.RowIndex];
                txtManv.Text = row.Cells["maNhanVien"].Value.ToString();
                txtTennv.Text = row.Cells["tenNhanVien"].Value.ToString();
            }
        }

        private void dgvLuongnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLuongnhanvien.Rows[e.RowIndex];
                txtMahoadon.Text = row.Cells["mahoadon"].Value.ToString();
                txtManv.Text = row.Cells["manv"].Value.ToString();
                txtTennv.Text = row.Cells["tennv"].Value.ToString();
                txtLuongcoban.Text = row.Cells["luongcoban"].Value.ToString();
                txtHesoluong.Text = row.Cells["hesoluong"].Value.ToString();
                txtPhucap.Text = row.Cells["phucap"].Value.ToString();
                txtKhautru.Text = row.Cells["khautru"].Value.ToString();
                txtSongaycong.Text = row.Cells["songaycong"].Value.ToString();
                dtpNgaythanhtoan.Value = DateTime.Parse(row.Cells["ngaythanhtoan"].Value.ToString());
                txtTongluong.Text = row.Cells["tongluong"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMahoadon.Text))
                    throw new Exception("Vui lòng chọn hóa đơn cần sửa");

                // Tạo đối tượng cập nhật
                LuongNhanVien luongNV = new LuongNhanVien(
                    txtMahoadon.Text,
                    txtManv.Text,
                    txtTennv.Text,
                    txtLuongcoban.Text,
                    txtHesoluong.Text,
                    txtPhucap.Text,
                    txtKhautru.Text,
                    txtSongaycong.Text,
                    dtpNgaythanhtoan.Value.ToString("yyyy-MM-dd"),
                    txtTongluong.Text
                );

                // Gọi phương thức cập nhật
                thanhToanLuongNhanVien_BL.CapNhatLuongNhanVien(luongNV);

                // Làm mới DataGridView
                dgvLuongnhanvien.DataSource = thanhToanLuongNhanVien_BL.LayDanhSachLuongNhanVien();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMahoadon.Text))
                    throw new Exception("Vui lòng chọn hóa đơn cần xóa");

                // Gọi phương thức xóa
                thanhToanLuongNhanVien_BL.XoaLuongNhanVien(txtMahoadon.Text);

                // Làm mới DataGridView
                dgvLuongnhanvien.DataSource = thanhToanLuongNhanVien_BL.LayDanhSachLuongNhanVien();
                MessageBox.Show("Xóa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}

