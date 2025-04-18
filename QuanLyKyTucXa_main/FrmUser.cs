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
    public partial class FrmUser: Form
    {
        public FrmUser()
        {
            InitializeComponent();
        }

        private void btnDangkyphong_Click(object sender, EventArgs e)
        {
            FrmDangKyPhong frmDangKyPhong = new FrmDangKyPhong();
            frmDangKyPhong.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYeucausuachua frmYeuCauSuaChua = new FrmYeucausuachua();
            frmYeuCauSuaChua.ShowDialog();
        }
    }
}
