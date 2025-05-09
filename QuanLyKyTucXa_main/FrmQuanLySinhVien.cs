﻿using QuanLy_BLL;
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
    public partial class FrmQuanLySinhVien : Form
    {
        private QuanLySinhVien_BL quanLySinhVien_BLL;
        public FrmQuanLySinhVien()
        {
            InitializeComponent();
            quanLySinhVien_BLL = new QuanLySinhVien_BL();
        }

        private void FrmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            dgvSinhvien.DataSource = quanLySinhVien_BLL.LayDanhSachSinhVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu nhập
                if (string.IsNullOrEmpty(txtMasv.Text))
                    throw new Exception("Mã SV không được trống");
                if (string.IsNullOrEmpty(txtTensv.Text))
                    throw new Exception("Tên SV không được trống");
                // Thêm các điều kiện kiểm tra khác...

                // Tạo đối tượng nhân viên
                SinhVien sv = new SinhVien(
                    txtMasv.Text,
                    txtTensv.Text,
                    cbGioitinh.Text,
                    dtpNgaysinh.Value.ToString("yyyy-MM-dd"),
                    txtQuequan.Text,
                    cbKhoa.Text,
                    txtLop.Text,
                    cbLoaiuutien.Text,
                    cbMaphong.Text
                );

                // Gọi BLL để thêm
                bool result = quanLySinhVien_BLL.ThemSinhVien(sv);

                if (result)
                {
                    MessageBox.Show("Thêm thành công!");
                    // Cập nhật lại DataGridView
                    dgvSinhvien.DataSource = quanLySinhVien_BLL.LayDanhSachSinhVien();

                    // Xóa trắng các ô nhập
                    ClearControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // Phương thức xóa trắng control
        private void ClearControls()
        {
            txtMasv.Clear();
            txtTensv.Clear();
            cbGioitinh.SelectedIndex = -1;
            dtpNgaysinh.Value = DateTime.Now;
            txtQuequan.Clear();
            cbKhoa.SelectedIndex = -1;
            txtLop.Clear();
            cbLoaiuutien.SelectedIndex = -1;
            cbMaphong.SelectedIndex = -1;

        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMasv.Text))
                    throw new Exception("Vui lòng chọn sinh viên cần sửa!");

                // Tạo đối tượng nhân viên
                SinhVien sv = new SinhVien(
                    txtMasv.Text,
                    txtTensv.Text,
                    cbGioitinh.Text,
                    dtpNgaysinh.Value.ToString("yyyy-MM-dd"),
                    txtQuequan.Text,
                    cbKhoa.Text,
                    txtLop.Text,
                    cbLoaiuutien.Text,
                    cbMaphong.Text
                );

                // Gọi BLL để sửa
                bool result = quanLySinhVien_BLL.CapNhatSinhVien(sv);

                if (result)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    dgvSinhvien.DataSource = quanLySinhVien_BLL.LayDanhSachSinhVien();
                    // Xóa trắng các ô nhập (tùy chọn)
                    ClearControls();
                }
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
                if (string.IsNullOrEmpty(txtMasv.Text))
                    throw new Exception("Vui lòng chọn sinh viên cần xóa!");

                // Xác nhận xóa
                DialogResult confirm = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa sinh viên này?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo
                );

                if (confirm != DialogResult.Yes) return;

                // Gọi BLL để xóa
                bool result = quanLySinhVien_BLL.XoaSinhVien(txtMasv.Text);

                if (result)
                {
                    MessageBox.Show("Xóa thành công!");
                    dgvSinhvien.DataSource = quanLySinhVien_BLL.LayDanhSachSinhVien();
                    ClearControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtTimkiem.Text.Trim();

                if (string.IsNullOrEmpty(keyword))
                {
                    // Nếu ô tìm kiếm trống, load lại toàn bộ danh sách
                    dgvSinhvien.DataSource = quanLySinhVien_BLL.LayDanhSachSinhVien();
                    return;
                }

                // Xác định kiểu tìm kiếm dựa trên RadioButton
                KieuTimKiem kieuTimKiem;
                if (rbTktheoma.Checked)
                    kieuTimKiem = KieuTimKiem.TheoMaSV;
                else if (rbTktheoten.Checked)
                    kieuTimKiem = KieuTimKiem.TheoTenSV;
                else if (rbTkTheoMaphong.Checked)
                    kieuTimKiem = KieuTimKiem.TheoMaPhong;
                else
                    throw new Exception("Vui lòng chọn kiểu tìm kiếm!");

                // Gọi BLL để tìm kiếm
                List<SinhVien> ketQua = quanLySinhVien_BLL.TimKiemSinhVien(keyword, kieuTimKiem);

                // Hiển thị kết quả lên DataGridView
                dgvSinhvien.DataSource = ketQua;

                if (ketQua.Count == 0)
                    MessageBox.Show("Không tìm thấy sinh viên nào!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgvSinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSinhvien.Rows[e.RowIndex];
                txtMasv.Text = row.Cells["masv"].Value.ToString();
                txtTensv.Text = row.Cells["tensv"].Value.ToString();
                cbGioitinh.Text = row.Cells["gioitinh"].Value.ToString();
                dtpNgaysinh.Value = DateTime.Parse(row.Cells["ngaysinh"].Value.ToString());
                txtQuequan.Text = row.Cells["quequan"].Value.ToString();
                cbKhoa.Text = row.Cells["khoa"].Value.ToString();
                txtLop.Text = row.Cells["lop"].Value.ToString();
                cbLoaiuutien.Text = row.Cells["loaiuutien"].Value.ToString();
                cbMaphong.Text = row.Cells["maphong"].Value.ToString();

            }
        }


    }
}
