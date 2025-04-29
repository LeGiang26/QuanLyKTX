namespace QuanLyKyTucXa_main
{
    partial class DanhSachDangKy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvSVDaDuyet = new System.Windows.Forms.DataGridView();
            this.masvdky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quequan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiuutien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvSVChoDuyet = new System.Windows.Forms.DataGridView();
            this.dgvtbcMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcTenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcQueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcLoaiUuTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnGuiEmail = new System.Windows.Forms.Button();
            this.btnXepphong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSVDaDuyet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSVChoDuyet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSVDaDuyet
            // 
            this.dgvSVDaDuyet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSVDaDuyet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSVDaDuyet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masvdky,
            this.tensv,
            this.gioitinh,
            this.ngaysinh,
            this.quequan,
            this.dgvtbcEmail,
            this.khoa,
            this.lop,
            this.loaiuutien,
            this.maphong,
            this.Column2});
            this.dgvSVDaDuyet.Location = new System.Drawing.Point(13, 428);
            this.dgvSVDaDuyet.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSVDaDuyet.Name = "dgvSVDaDuyet";
            this.dgvSVDaDuyet.RowHeadersWidth = 51;
            this.dgvSVDaDuyet.Size = new System.Drawing.Size(1252, 261);
            this.dgvSVDaDuyet.TabIndex = 41;
            this.dgvSVDaDuyet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSVDaDuyet_CellClick);
            this.dgvSVDaDuyet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSVDaDuyet_CellContentClick);
            // 
            // masvdky
            // 
            this.masvdky.DataPropertyName = "masv";
            this.masvdky.HeaderText = "Mã sinh viên";
            this.masvdky.MinimumWidth = 6;
            this.masvdky.Name = "masvdky";
            this.masvdky.Width = 80;
            // 
            // tensv
            // 
            this.tensv.DataPropertyName = "tensv";
            this.tensv.HeaderText = "Tên sinh viên";
            this.tensv.MinimumWidth = 6;
            this.tensv.Name = "tensv";
            this.tensv.Width = 125;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Width = 80;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 80;
            // 
            // quequan
            // 
            this.quequan.DataPropertyName = "quequan";
            this.quequan.HeaderText = "Quê quán";
            this.quequan.MinimumWidth = 6;
            this.quequan.Name = "quequan";
            this.quequan.Width = 125;
            // 
            // dgvtbcEmail
            // 
            this.dgvtbcEmail.DataPropertyName = "email";
            this.dgvtbcEmail.HeaderText = "Email";
            this.dgvtbcEmail.MinimumWidth = 6;
            this.dgvtbcEmail.Name = "dgvtbcEmail";
            this.dgvtbcEmail.Width = 125;
            // 
            // khoa
            // 
            this.khoa.DataPropertyName = "khoa";
            this.khoa.HeaderText = "Khóa";
            this.khoa.MinimumWidth = 6;
            this.khoa.Name = "khoa";
            this.khoa.Width = 70;
            // 
            // lop
            // 
            this.lop.DataPropertyName = "lop";
            this.lop.HeaderText = "Lớp";
            this.lop.MinimumWidth = 6;
            this.lop.Name = "lop";
            this.lop.Width = 125;
            // 
            // loaiuutien
            // 
            this.loaiuutien.DataPropertyName = "loaiuutien";
            this.loaiuutien.HeaderText = "Loại ưu tiên";
            this.loaiuutien.MinimumWidth = 6;
            this.loaiuutien.Name = "loaiuutien";
            this.loaiuutien.Width = 125;
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "maphong";
            this.maphong.HeaderText = "Mã phòng";
            this.maphong.MinimumWidth = 6;
            this.maphong.Name = "maphong";
            this.maphong.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Chuyển phòng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // dgvSVChoDuyet
            // 
            this.dgvSVChoDuyet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSVChoDuyet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSVChoDuyet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcMaSV,
            this.dgvtbcTenSV,
            this.dgvtbcGioiTinh,
            this.dgvtbcNgaySinh,
            this.dgvtbcQueQuan,
            this.email,
            this.dgvtbcKhoa,
            this.dgvtbcLop,
            this.dgvtbcLoaiUuTien});
            this.dgvSVChoDuyet.Location = new System.Drawing.Point(15, 41);
            this.dgvSVChoDuyet.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSVChoDuyet.Name = "dgvSVChoDuyet";
            this.dgvSVChoDuyet.RowHeadersWidth = 51;
            this.dgvSVChoDuyet.Size = new System.Drawing.Size(1252, 266);
            this.dgvSVChoDuyet.TabIndex = 51;
            // 
            // dgvtbcMaSV
            // 
            this.dgvtbcMaSV.DataPropertyName = "masvdky";
            this.dgvtbcMaSV.HeaderText = "Mã sinh viên";
            this.dgvtbcMaSV.MinimumWidth = 6;
            this.dgvtbcMaSV.Name = "dgvtbcMaSV";
            this.dgvtbcMaSV.Width = 80;
            // 
            // dgvtbcTenSV
            // 
            this.dgvtbcTenSV.DataPropertyName = "tensv";
            this.dgvtbcTenSV.HeaderText = "Tên sinh viên";
            this.dgvtbcTenSV.MinimumWidth = 6;
            this.dgvtbcTenSV.Name = "dgvtbcTenSV";
            this.dgvtbcTenSV.Width = 125;
            // 
            // dgvtbcGioiTinh
            // 
            this.dgvtbcGioiTinh.DataPropertyName = "gioitinh";
            this.dgvtbcGioiTinh.HeaderText = "Giới tính";
            this.dgvtbcGioiTinh.MinimumWidth = 6;
            this.dgvtbcGioiTinh.Name = "dgvtbcGioiTinh";
            this.dgvtbcGioiTinh.Width = 80;
            // 
            // dgvtbcNgaySinh
            // 
            this.dgvtbcNgaySinh.DataPropertyName = "ngaysinh";
            this.dgvtbcNgaySinh.HeaderText = "Ngày sinh";
            this.dgvtbcNgaySinh.MinimumWidth = 6;
            this.dgvtbcNgaySinh.Name = "dgvtbcNgaySinh";
            this.dgvtbcNgaySinh.Width = 80;
            // 
            // dgvtbcQueQuan
            // 
            this.dgvtbcQueQuan.DataPropertyName = "quequan";
            this.dgvtbcQueQuan.HeaderText = "Quê quán";
            this.dgvtbcQueQuan.MinimumWidth = 6;
            this.dgvtbcQueQuan.Name = "dgvtbcQueQuan";
            this.dgvtbcQueQuan.Width = 125;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // dgvtbcKhoa
            // 
            this.dgvtbcKhoa.DataPropertyName = "khoa";
            this.dgvtbcKhoa.HeaderText = "Khóa";
            this.dgvtbcKhoa.MinimumWidth = 6;
            this.dgvtbcKhoa.Name = "dgvtbcKhoa";
            this.dgvtbcKhoa.Width = 70;
            // 
            // dgvtbcLop
            // 
            this.dgvtbcLop.DataPropertyName = "lop";
            this.dgvtbcLop.HeaderText = "Lớp";
            this.dgvtbcLop.MinimumWidth = 6;
            this.dgvtbcLop.Name = "dgvtbcLop";
            this.dgvtbcLop.Width = 125;
            // 
            // dgvtbcLoaiUuTien
            // 
            this.dgvtbcLoaiUuTien.DataPropertyName = "loaiuutien";
            this.dgvtbcLoaiUuTien.HeaderText = "Loại ưu tiên";
            this.dgvtbcLoaiUuTien.MinimumWidth = 6;
            this.dgvtbcLoaiUuTien.Name = "dgvtbcLoaiUuTien";
            this.dgvtbcLoaiUuTien.Width = 125;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(243, 16);
            this.label11.TabIndex = 52;
            this.label11.Text = "Danh sách Sinh Viên Đăng ký chờ duyệt";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 408);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(237, 16);
            this.label12.TabIndex = 53;
            this.label12.Text = "Danh sách Sinh Viên Đăng ký đã duyệt";
            // 
            // btnGuiEmail
            // 
            this.btnGuiEmail.FlatAppearance.BorderSize = 0;
            this.btnGuiEmail.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuiEmail.Location = new System.Drawing.Point(978, 330);
            this.btnGuiEmail.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuiEmail.Name = "btnGuiEmail";
            this.btnGuiEmail.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnGuiEmail.Size = new System.Drawing.Size(80, 57);
            this.btnGuiEmail.TabIndex = 56;
            this.btnGuiEmail.Text = "Gửi email";
            this.btnGuiEmail.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuiEmail.UseVisualStyleBackColor = true;
            this.btnGuiEmail.Click += new System.EventHandler(this.btnGuiEmail_Click);
            // 
            // btnXepphong
            // 
            this.btnXepphong.Location = new System.Drawing.Point(15, 330);
            this.btnXepphong.Name = "btnXepphong";
            this.btnXepphong.Size = new System.Drawing.Size(102, 57);
            this.btnXepphong.TabIndex = 57;
            this.btnXepphong.Text = "Xếp phòng";
            this.btnXepphong.UseVisualStyleBackColor = true;
            this.btnXepphong.Click += new System.EventHandler(this.btnXepphong_Click);
            // 
            // DanhSachDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 873);
            this.Controls.Add(this.btnXepphong);
            this.Controls.Add(this.btnGuiEmail);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvSVChoDuyet);
            this.Controls.Add(this.dgvSVDaDuyet);
            this.Name = "DanhSachDangKy";
            this.Text = "DanhSachDangKy";
            this.Load += new System.EventHandler(this.DanhSachDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSVDaDuyet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSVChoDuyet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSVDaDuyet;
        private System.Windows.Forms.DataGridView dgvSVChoDuyet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcTenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcQueQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcLoaiUuTien;
        private System.Windows.Forms.Button btnGuiEmail;
        private System.Windows.Forms.Button btnXepphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn masvdky;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensv;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn quequan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiuutien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
    }
}