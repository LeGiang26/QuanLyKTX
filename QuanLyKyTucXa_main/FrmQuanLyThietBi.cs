using QuanLy_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;

namespace QuanLyKyTucXa_main
{
    public delegate void SendMessage(String value);
    public partial class FrmQuanLyThietBi : Form
    {
        public FrmQuanLyThietBi()
        {
            InitializeComponent();
        }

        QuanLy_BLL.BLL_ThietBi bll = new QuanLy_BLL.BLL_ThietBi();
        QuanLy_BLL.BLL_Phong bllPhong = new QuanLy_BLL.BLL_Phong();

        //  public string maphongnhan = "";

        private void FrmQuanLyThietBi_Load(object sender, EventArgs e)
        {
            dgvThietbi.DataSource = bll.GetAllThietBi();
            LoadPhongData();
            //txtMaphong.Text = maphongnhan;
            // dgvThietbi.DataSource = bll.GetThietBiTheoPhong(txtMaphong.Text);
        }

        private void LoadPhongData()
        {
            var phongList = bllPhong.GetAllPhong();
            cbMaphong.DataSource = phongList;
            cbMaphong.ValueMember = "maphong";
            cbMaphong.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThietBi tb = new ThietBi(
                cbMaphong.Text,
                txtTentb.Text,
                (int)numericUpDownSoluong.Value,
                txtTinhtrang.Text
            );

            string error;
            if (!bll.InsertThietBi(tb, out error))
            {
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Thêm thiết bị thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnLamMoi_Click(sender, e);
        }

        private void dgvThietbi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            if (vitri >= 0)
            {
                cbMaphong.Text = dgvThietbi.Rows[vitri].Cells[0].Value.ToString();
                txtTentb.Text = dgvThietbi.Rows[vitri].Cells[1].Value.ToString();
                numericUpDownSoluong.Value = Decimal.Parse(dgvThietbi.Rows[vitri].Cells[2].Value.ToString());
                txtTinhtrang.Text = dgvThietbi.Rows[vitri].Cells[3].Value.ToString();
            }
        }

        private void ClearBox()
        {
            cbMaphong.SelectedIndex = -1;
            txtTentb.Clear();
            numericUpDownSoluong.Value = 0;
            txtTinhtrang.Clear();
        }

        private void btnCapnhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbMaphong.Text) || string.IsNullOrEmpty(txtTentb.Text))
            {
                MessageBox.Show("Vui lòng chọn thiết bị cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ThietBi tb = new ThietBi(
                cbMaphong.Text.Trim(),
                txtTentb.Text,
                (int)numericUpDownSoluong.Value,
                txtTinhtrang.Text
            );

            string error;
            if (!bll.UpdateThietBi(tb, out error))
            {
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Cập nhật thiết bị thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnLamMoi_Click(sender, e);
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cbMaphong.Text == "" || txtTentb.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                bll.DeleteThietBi(cbMaphong.Text, txtTentb.Text);
                btnLamMoi_Click(sender, e);
            }
            else if (dlr == DialogResult.No)
                return;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            FrmQuanLyThietBi_Load(sender, e);
            ClearBox();
        }

        //Kéo giao diện
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
