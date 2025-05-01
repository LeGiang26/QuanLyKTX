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
    public partial class FrmMenuUser : Form
    {
        private Button currentButton;
        private Form activeForm = null;
        public FrmMenuUser()
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
//an muc con
        private void customizeDesign()
        {
            panelTaikhoanSubmenu.Visible = false;

        }
        private void openChildForm(Form childForm, Size size, Point point)
        {
            if (activeForm != null)
                activeForm.Close();
            //panelControl.Visible = false;
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            lblTitle.Text = childForm.Text;
            lblTitle.Size = size;
            lblTitle.Location = point;
            btnClose.Visible = true;
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
            
        }

//danhmuc
        private void btnDanhmuc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, 0, 150, 136);
            showSubMenu(panelDanhmucSubmenu);
        }
        private void btnDangKyPhong_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmDangKyPhong(), new Size(192, 26), new Point(325, 15));
        }
        private void btnYeuCauSua_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmYeucausuachua(), new Size(192, 26), new Point(325, 15));
            
        }

//TaiKhoan
        private void btnTaikhoan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, 89, 120, 187);
            showSubMenu(panelTaikhoanSubmenu);
        }
        private void btnDoimatkhau_Click(object sender, EventArgs e)
        {
            // FrmDoiMatKhau frmDoiMk = new FrmDoiMatKhau();
            //frmDoiMk.id = this.idNguoiDung;
            //frmDoiMk.Show();

        }

        //dangxuat
        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn tạm FrmMainMenu đi trước
            FrmDangNhap dangNhap = new FrmDangNhap();
            dangNhap.ShowDialog(); // Chờ đăng nhập xong
            this.Close(); // Đóng hẳn FrmMainMenu sau
        }

        private void FrmMenuUser_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
