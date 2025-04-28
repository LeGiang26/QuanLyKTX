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
    public partial class FrmMainMenu : Form
    {
        private Button currentButton;
        private Form activeForm = null;
        public FrmMainMenu()
        {
            InitializeComponent();
            customizeDesign();
        }

//đổi màu nút
        private void ActivateButton(object btnSender, int r, int g, int b)
        {
            if (btnSender != null && currentButton != (Button)btnSender)
            {
                DisableButton();
                Color color = Color.FromArgb(r, g, b);
                currentButton = (Button)btnSender;
                currentButton.BackColor = color;
                currentButton.ForeColor = Color.White;
                currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelSidebar.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = SystemColors.ButtonFace;
                    previousBtn.ForeColor = SystemColors.ControlText;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

 //ẩn hiện panel
        private void openChildForm(Form childForm)
            //, Size size, Point point)
        {
            //if (activeForm != null)
            //    activeForm.Close();
            ////panelControl.Visible = false;
            //activeForm = childForm;
            //childForm.TopLevel = false;
            //childForm.FormBorderStyle = FormBorderStyle.None;
            //childForm.Dock = DockStyle.Fill;
            //panelMain.Controls.Add(childForm);
            //panelMain.Tag = childForm;
            //childForm.BringToFront();
            //childForm.Show();
            ////thay doi title
            //lblTitle.Text = childForm.Text;
            //lblTitle.Size = size;
            //lblTitle.Location = point;
            //btnClose.Visible = true;
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill; // ✅ Đặt lại Dock Fill như ban đầu

            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();

            lblTitle.Text = childForm.Text;
            btnClose.Visible = true;
        }

        private void customizeDesign()
        {
            panelTaikhoanSubmenu.Visible = false;
            panelDanhmucSubmenu.Visible = false;
            panelPhongSubmenu.Visible = false;
            panelBaocaoSubmenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panelTaikhoanSubmenu.Visible == true)
            {
                panelTaikhoanSubmenu.Visible = false;
            }
            if (panelDanhmucSubmenu.Visible == true)
            {
                panelDanhmucSubmenu.Visible = false;
            }
            if (panelPhongSubmenu.Visible == true)
            {
                panelPhongSubmenu.Visible = false;
            }
            if (panelBaocaoSubmenu.Visible == true)
            {
                panelBaocaoSubmenu.Visible = false;
            }
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }


//taikhoan
        private void btnTaikhoan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, 89, 120, 187);
            showSubMenu(panelTaikhoanSubmenu);
        }

//danhmuc
        private void btnDanhmuc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, 0, 150, 136);
            showSubMenu(panelDanhmucSubmenu);
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLyNhanVien());
                //, new Size(192, 26), new Point(325, 15));
            //hideSubmenu();
        }

        private void btnLuongNV_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmThanhToanLuongNhanVien());
            //, new Size(192, 26), new Point(325, 15));
        }

        private void btnKyluat_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLyKyLuat());
            //, new Size(156, 26), new Point(325, 15));
            //hideSubmenu();
        }

        private void btnDanhSachDangKy_Click(object sender, EventArgs e)
        {
            openChildForm(new DanhSachDangKy());
            //hideSubmenu();
        }
 //QLSV
        private void btnSinhvien_Click(object sender, EventArgs e)
        {

            ActivateButton(sender, 255, 152, 0);
            openChildForm(new FrmQuanLySinhVien());
        }
//QLPhong
        private void btnPhong_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, 199, 220, 91);
            showSubMenu(panelPhongSubmenu);
        }

        private void btnDanhsachday_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLyDay());
            //hideSubmenu();
        }

        private void btnDanhsachphong_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLyPhong());
            ////hideSubmenu();
        }

        private void btnTienDien_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLyTienDien());
            ////hideSubmenu();
        }

        private void btnTienNuoc_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLyTienNuoc());
            ////hideSubmenu();
        }
        private void btnThietBi_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLyThietBi());
            ////hideSubmenu();

        }
 //BaoCao
        private void btnBaocao_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, 3, 150, 243);
            showSubMenu(panelBaocaoSubmenu);
        }

        private void btnBaoCaoTienDien_Click(object sender, EventArgs e)
        {
            openChildForm(new ThongKeTienDien());
            //hideSubmenu();
        }
//dangxxuat
        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn tạm FrmMainMenu đi trước
            FrmDangNhap dangNhap = new FrmDangNhap();
            dangNhap.ShowDialog(); // Chờ đăng nhập xong
            this.Close(); // Đóng hẳn FrmMainMenu sau
        }
    }
}
