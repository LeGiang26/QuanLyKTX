using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLy_BLL;
using TransferObject;

namespace QuanLyKyTucXa_main
{
    public partial class DanhSachDangKy: Form
    {
        private DanhSachDangKy_BL danhSachDangKy_BL;
        public DanhSachDangKy()
        {
            InitializeComponent();
            danhSachDangKy_BL = new DanhSachDangKy_BL();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSVChoDuyet.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin từ các control
            string masvdky = txtMasv.Text;
            string tensv = txtTensv.Text;
            string gioitinh = cbGioitinh.SelectedItem?.ToString();
            string ngaysinh = dtpNgaysinh.Value.ToString("yyyy-MM-dd");
            string quequan = txtQuequan.Text;
            string khoa = cbKhoa.SelectedItem?.ToString();
            string lop = txtLop.Text;
            string loaiuutien = cbLoaiuutien.SelectedItem?.ToString();

            // Kiểm tra dữ liệu hợp lệ
            if (string.IsNullOrEmpty(masvdky) ||
                string.IsNullOrEmpty(tensv) ||
                string.IsNullOrEmpty(gioitinh) ||
                string.IsNullOrEmpty(khoa) ||
                string.IsNullOrEmpty(lop) ||
                string.IsNullOrEmpty(loaiuutien))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo đối tượng SinhVienDangKy
            SinhVienDangKy sv = new SinhVienDangKy(masvdky, tensv, gioitinh, ngaysinh, quequan, khoa, lop, loaiuutien);

            try
            {
                bool result = danhSachDangKy_BL.CapNhatSinhVienDangKy(sv);
                if (result)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Load lại dữ liệu
                    dgvSVChoDuyet.DataSource = danhSachDangKy_BL.LayDSSinhVienDangKy();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra giới tính và phòng được chọn
            string gioiTinh = cbGioitinh.SelectedItem?.ToString();
            string maPhongNam = cbMaphongNam.SelectedValue?.ToString();
            string maPhongNu = cbMaphongNu.SelectedValue?.ToString();
            string maPhong = "";

            if (gioiTinh == "Nam")
            {
                if (maPhongNam == "----" || string.IsNullOrEmpty(maPhongNam))
                {
                    MessageBox.Show("Vui lòng chọn phòng Nam cho sinh viên Nam.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                maPhong = maPhongNam;
            }
            else if (gioiTinh == "Nữ")
            {
                if (maPhongNu == "----" || string.IsNullOrEmpty(maPhongNu))
                {
                    MessageBox.Show("Vui lòng chọn phòng Nữ cho sinh viên Nữ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                maPhong = maPhongNu;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn giới tính cho sinh viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy thông tin từ các control
            string masv = txtMasv.Text;
            string tensv = txtTensv.Text;
            string ngaysinh = dtpNgaysinh.Value.ToString("yyyy-MM-dd");
            string quequan = txtQuequan.Text;
            string khoa = cbKhoa.Text.ToString();
            string lop = txtLop.Text;
            string loaiuutien = cbLoaiuutien.SelectedItem?.ToString();

            // Tạo đối tượng SinhVien
            SinhVien sv = new SinhVien(masv, tensv, gioiTinh, ngaysinh, quequan, khoa, lop, loaiuutien, maPhong);

            try
            {
                // Thêm sinh viên vào bảng SinhVien
                bool themSV = danhSachDangKy_BL.ThemSinhVien(sv);
                if (themSV)
                {
                    // Xóa sinh viên khỏi bảng đăng ký
                    danhSachDangKy_BL.XoaSinhVienDangKy(masv);

                    // Cập nhật số lượng sinh viên trong phòng
                    danhSachDangKy_BL.CapNhatSoSVPhong(maPhong);

                    // Thông báo thành công
                    MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Load lại dữ liệu
                    dgvSVChoDuyet.DataSource = danhSachDangKy_BL.LayDSSinhVienDangKy();
                    dgvSVDaDuyet.DataSource = danhSachDangKy_BL.LayDSSinhVien();
                    LoadPhongTrongVaoComboBox();
                }
                else
                {
                    MessageBox.Show("Thêm sinh viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void DanhSachDangKy_Load(object sender, EventArgs e)
        {
            dgvSVChoDuyet.DataSource = danhSachDangKy_BL.LayDSSinhVienDangKy();
            dgvSVDaDuyet.DataSource = danhSachDangKy_BL.LayDSSinhVien();

            // Load combobox phòng trống
            LoadPhongTrongVaoComboBox();
        }

        private void LoadPhongTrongVaoComboBox()
        {
            // Lấy danh sách phòng trống
            var phongNam = danhSachDangKy_BL.LayDSPhongTrongNam();
            var phongNu = danhSachDangKy_BL.LayDSPhongTrongNu();
            
            // Thêm lựa chọn trống vào đầu danh sách phòng Nam
            phongNam.Insert(0, new Phong("----", "", "", "", "", "", "", "", ""));

            // Thêm lựa chọn trống vào đầu danh sách phòng Nữ
            phongNu.Insert(0, new Phong("----", "", "", "", "", "", "", "", ""));

            // Gán DataSource cho combobox
            cbMaphongNam.DataSource = phongNam;
            cbMaphongNam.DisplayMember = "maphong";
            cbMaphongNam.ValueMember = "maphong";

            cbMaphongNu.DataSource = phongNu;
            cbMaphongNu.DisplayMember = "maphong";
            cbMaphongNu.ValueMember = "maphong";
        }

        private void dgvSVChoDuyet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSVChoDuyet.Rows[e.RowIndex];
                txtMasv.Text = row.Cells["dgvtbcMaSV"].Value.ToString();
                txtTensv.Text = row.Cells["dgvtbcTenSV"].Value.ToString();
                cbGioitinh.Text = row.Cells["dgvtbcGioiTinh"].Value.ToString();
                dtpNgaysinh.Value = DateTime.Parse(row.Cells["dgvtbcNgaySinh"].Value.ToString());
                txtQuequan.Text = row.Cells["dgvtbcQueQuan"].Value.ToString();
                cbKhoa.Text = row.Cells["dgvtbcKhoa"].Value.ToString();
                txtLop.Text = row.Cells["dgvtbcLop"].Value.ToString();
                cbLoaiuutien.Text = row.Cells["dgvtbcLoaiUuTien"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSVChoDuyet.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã sinh viên từ dòng được chọn
            string masv = dgvSVChoDuyet.CurrentRow.Cells["dgvtbcMaSV"].Value.ToString();

            try
            {
                bool result = danhSachDangKy_BL.XoaSinhVienDangKy(masv);
                if (result)
                {
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Load lại dữ liệu
                    dgvSVChoDuyet.DataSource = danhSachDangKy_BL.LayDSSinhVienDangKy();
                }
                else
                {
                    MessageBox.Show("Xóa sinh viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
