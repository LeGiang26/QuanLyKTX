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
    public partial class FrmChuyenPhong: Form
    {

        private DanhSachDangKy_BL danhSachDangKy_BL = new DanhSachDangKy_BL();

        public FrmChuyenPhong()
        {
            InitializeComponent();
            danhSachDangKy_BL = new DanhSachDangKy_BL();
        }


        // Thêm phương thức để thiết lập thông tin sinh viên
        public void SetThongTinSinhVien(
            string masv, string tensv, string gioitinh, string ngaysinh,
            string quequan, string email, string khoa, string lop,
            string loaiuutien, string maphong)
        {
            // Điền dữ liệu vào các control
            txtMasv.Text = masv;
            txtTensv.Text = tensv;
            cbGioitinh.Text = gioitinh;
            dtpNgaysinh.Text = ngaysinh;
            txtQuequan.Text = quequan;
            txtEmail.Text = email;
            cbKhoa.Text = khoa;
            txtLop.Text = lop;
            cbLoaiuutien.Text = loaiuutien;
            txtMaphong.Text = maphong;

            LoadPhongTrong();
        }

        private void LoadPhongTrong()
        {
            try
            {
                var phongTrong = danhSachDangKy_BL.LayPhongTrong();
                cbMaphong.DataSource = phongTrong;
                cbMaphong.DisplayMember = "maphong";
                cbMaphong.ValueMember = "maphong";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải phòng: " + ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
