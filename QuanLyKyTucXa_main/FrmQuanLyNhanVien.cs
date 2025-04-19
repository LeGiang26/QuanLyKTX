using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using QuanLy_BLL;
using TransferObject;

namespace QuanLyKyTucXa_main
{
    public partial class FrmQuanLyNhanVien : Form
    {
        private QuanLyNhanVien_BL quanLyNhanVien_BL;
        public FrmQuanLyNhanVien()
        {
            InitializeComponent();
            quanLyNhanVien_BL = new QuanLyNhanVien_BL();
        }
        private void FrmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanvien.DataSource = quanLyNhanVien_BL.LayDanhSachNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu nhập
                if (string.IsNullOrEmpty(txtManv.Text))
                    throw new Exception("Mã NV không được trống");
                if (string.IsNullOrEmpty(txtTennv.Text))
                    throw new Exception("Tên NV không được trống");
                // Thêm các điều kiện kiểm tra khác...

                // Tạo đối tượng nhân viên
                NhanVien nv = new NhanVien(
                    txtManv.Text,
                    txtTennv.Text,
                    cbGioitinh.Text,
                    dtpNgaysinh.Value.ToString("yyyy-MM-dd"),
                    txtDiachi.Text,
                    txtSodienthoai.Text
                );

                // Gọi BLL để thêm
                bool result = quanLyNhanVien_BL.ThemNhanVien(nv);

                if (result)
                {
                    MessageBox.Show("Thêm thành công!");
                    // Cập nhật lại DataGridView
                    dgvNhanvien.DataSource = quanLyNhanVien_BL.LayDanhSachNhanVien();

                    // Xóa trắng các ô nhập
                    ClearControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtManv.Text))
                    throw new Exception("Vui lòng chọn nhân viên cần sửa!");

                // Tạo đối tượng nhân viên
                NhanVien nv = new NhanVien(
                    txtManv.Text,
                    txtTennv.Text,
                    cbGioitinh.Text,
                    dtpNgaysinh.Value.ToString("yyyy-MM-dd"),
                    txtDiachi.Text,
                    txtSodienthoai.Text
                );

                // Gọi BLL để sửa
                bool result = quanLyNhanVien_BL.SuaNhanVien(nv);

                if (result)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    dgvNhanvien.DataSource = quanLyNhanVien_BL.LayDanhSachNhanVien();
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
                if (string.IsNullOrEmpty(txtManv.Text))
                    throw new Exception("Vui lòng chọn nhân viên cần xóa!");

                // Xác nhận xóa
                DialogResult confirm = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa nhân viên này?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo
                );

                if (confirm != DialogResult.Yes) return;

                // Gọi BLL để xóa
                bool result = quanLyNhanVien_BL.XoaNhanVien(txtManv.Text);

                if (result)
                {
                    MessageBox.Show("Xóa thành công!");
                    dgvNhanvien.DataSource = quanLyNhanVien_BL.LayDanhSachNhanVien();
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
                bool timTheoMa = rbTktheoma.Checked;

                if (string.IsNullOrEmpty(keyword))
                {
                    // Nếu ô tìm kiếm trống, load lại toàn bộ danh sách
                    dgvNhanvien.DataSource = quanLyNhanVien_BL.LayDanhSachNhanVien();
                    return;
                }

                // Gọi BLL để tìm kiếm
                List<NhanVien> ketQua = quanLyNhanVien_BL.TimKiemNhanVien(keyword, timTheoMa);

                // Hiển thị kết quả lên DataGridView
                dgvNhanvien.DataSource = ketQua;

                if (ketQua.Count == 0)
                    MessageBox.Show("Không tìm thấy nhân viên phù hợp!");
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
                txtManv.Text = row.Cells["manv"].Value.ToString();
                txtTennv.Text = row.Cells["tennv"].Value.ToString();
                cbGioitinh.Text = row.Cells["gioitinh"].Value.ToString();
                dtpNgaysinh.Value = DateTime.Parse(row.Cells["ngaysinh"].Value.ToString());
                txtDiachi.Text = row.Cells["diachi"].Value.ToString();
                txtSodienthoai.Text = row.Cells["sodienthoai"].Value.ToString();
            }
        }
        // Phương thức xóa trắng control
        private void ClearControls()
        {
            txtManv.Clear();
            txtTennv.Clear();
            cbGioitinh.SelectedIndex = -1;
            dtpNgaysinh.Value = DateTime.Now;
            txtDiachi.Clear();
            txtSodienthoai.Clear();
        }
    }
}
