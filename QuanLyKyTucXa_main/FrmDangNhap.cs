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
using QuanLy_BLL;
using System.Data.SqlClient;
using System.Security.Principal;

namespace QuanLyKyTucXa_main
{
    public partial class FrmDangNhap : Form
    {
        private DangNhap_BL dangnhapBL;
        public FrmDangNhap()
        {
            InitializeComponent();
            dangnhapBL = new DangNhap_BL();
            LoadQuyen();
        }
        private void LoadQuyen()
        {
            cbQuyen.Items.Add("Admin");
            cbQuyen.Items.Add("User");
            cbQuyen.SelectedIndex = 0;
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTaikhoan.Text.Trim();
            string matKhau = txtMatkhau.Text.Trim();
            string quyen = cbQuyen.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(quyen))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NguoiDung nguoiDung = dangnhapBL.KiemTraDangNhap(tenDangNhap, matKhau, quyen);

            if (nguoiDung != null)
            {
                this.Hide();
                if (quyen == "Admin")
                {
                    FrmAdmin frmAdmin = new FrmAdmin();
                    frmAdmin.ShowDialog();
                }
                else
                {
                    //FrmUser frmUser = new FrmUser();
                    //frmUser.ShowDialog();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
