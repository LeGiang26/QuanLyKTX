namespace QuanLyKyTucXa_main
{
    partial class FrmThanhToanLuongNhanVien
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
            this.dgvLuongnhanvien = new System.Windows.Forms.DataGridView();
            this.mahoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongcoban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hesoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phucap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khautru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songaycong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaythanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTennv = new System.Windows.Forms.TextBox();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHesoluong = new System.Windows.Forms.TextBox();
            this.txtLuongcoban = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKhautru = new System.Windows.Forms.TextBox();
            this.txtPhucap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTinhluong = new System.Windows.Forms.Button();
            this.txtTongluong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSongaycong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpNgaythanhtoan = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMahoadon = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvNhanvien = new System.Windows.Forms.DataGridView();
            this.maNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuongnhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLuongnhanvien
            // 
            this.dgvLuongnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuongnhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahoadon,
            this.manv,
            this.tennv,
            this.luongcoban,
            this.hesoluong,
            this.phucap,
            this.khautru,
            this.songaycong,
            this.ngaythanhtoan,
            this.tongluong});
            this.dgvLuongnhanvien.Location = new System.Drawing.Point(31, 408);
            this.dgvLuongnhanvien.Name = "dgvLuongnhanvien";
            this.dgvLuongnhanvien.RowHeadersWidth = 51;
            this.dgvLuongnhanvien.RowTemplate.Height = 24;
            this.dgvLuongnhanvien.Size = new System.Drawing.Size(809, 252);
            this.dgvLuongnhanvien.TabIndex = 0;
            this.dgvLuongnhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLuongnhanvien_CellClick);
            // 
            // mahoadon
            // 
            this.mahoadon.DataPropertyName = "mahoadon";
            this.mahoadon.HeaderText = "Mã Hóa Đơn";
            this.mahoadon.MinimumWidth = 6;
            this.mahoadon.Name = "mahoadon";
            this.mahoadon.Width = 125;
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Mã Nhân Viên";
            this.manv.MinimumWidth = 6;
            this.manv.Name = "manv";
            this.manv.Width = 125;
            // 
            // tennv
            // 
            this.tennv.DataPropertyName = "tennv";
            this.tennv.HeaderText = "Tên Nhân Viên";
            this.tennv.MinimumWidth = 6;
            this.tennv.Name = "tennv";
            this.tennv.Width = 125;
            // 
            // luongcoban
            // 
            this.luongcoban.DataPropertyName = "luongcoban";
            this.luongcoban.HeaderText = "Luong Cơ Bản";
            this.luongcoban.MinimumWidth = 6;
            this.luongcoban.Name = "luongcoban";
            this.luongcoban.Width = 125;
            // 
            // hesoluong
            // 
            this.hesoluong.DataPropertyName = "hesoluong";
            this.hesoluong.HeaderText = "Hệ Số Lương";
            this.hesoluong.MinimumWidth = 6;
            this.hesoluong.Name = "hesoluong";
            this.hesoluong.Width = 125;
            // 
            // phucap
            // 
            this.phucap.DataPropertyName = "phucap";
            this.phucap.HeaderText = "Phụ Cấp";
            this.phucap.MinimumWidth = 6;
            this.phucap.Name = "phucap";
            this.phucap.Width = 125;
            // 
            // khautru
            // 
            this.khautru.DataPropertyName = "khautru";
            this.khautru.HeaderText = "Khấu Trừ";
            this.khautru.MinimumWidth = 6;
            this.khautru.Name = "khautru";
            this.khautru.Width = 125;
            // 
            // songaycong
            // 
            this.songaycong.DataPropertyName = "songaycong";
            this.songaycong.HeaderText = "Số Ngày Công";
            this.songaycong.MinimumWidth = 6;
            this.songaycong.Name = "songaycong";
            this.songaycong.Width = 125;
            // 
            // ngaythanhtoan
            // 
            this.ngaythanhtoan.DataPropertyName = "ngaythanhtoan";
            this.ngaythanhtoan.HeaderText = "Ngày Thanh Toán";
            this.ngaythanhtoan.MinimumWidth = 6;
            this.ngaythanhtoan.Name = "ngaythanhtoan";
            this.ngaythanhtoan.Width = 125;
            // 
            // tongluong
            // 
            this.tongluong.DataPropertyName = "tongluong";
            this.tongluong.HeaderText = "Tổng Lương";
            this.tongluong.MinimumWidth = 6;
            this.tongluong.Name = "tongluong";
            this.tongluong.Width = 125;
            // 
            // txtTennv
            // 
            this.txtTennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTennv.Location = new System.Drawing.Point(167, 123);
            this.txtTennv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTennv.Name = "txtTennv";
            this.txtTennv.Size = new System.Drawing.Size(160, 24);
            this.txtTennv.TabIndex = 21;
            // 
            // txtManv
            // 
            this.txtManv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManv.Location = new System.Drawing.Point(167, 79);
            this.txtManv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(160, 24);
            this.txtManv.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã nhân viên";
            // 
            // txtHesoluong
            // 
            this.txtHesoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHesoluong.Location = new System.Drawing.Point(167, 226);
            this.txtHesoluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHesoluong.Name = "txtHesoluong";
            this.txtHesoluong.Size = new System.Drawing.Size(160, 24);
            this.txtHesoluong.TabIndex = 25;
            // 
            // txtLuongcoban
            // 
            this.txtLuongcoban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuongcoban.Location = new System.Drawing.Point(167, 182);
            this.txtLuongcoban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLuongcoban.Name = "txtLuongcoban";
            this.txtLuongcoban.Size = new System.Drawing.Size(160, 24);
            this.txtLuongcoban.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Hệ số lương";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Lương cơ bản";
            // 
            // txtKhautru
            // 
            this.txtKhautru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhautru.Location = new System.Drawing.Point(618, 75);
            this.txtKhautru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKhautru.Name = "txtKhautru";
            this.txtKhautru.Size = new System.Drawing.Size(160, 24);
            this.txtKhautru.TabIndex = 29;
            // 
            // txtPhucap
            // 
            this.txtPhucap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhucap.Location = new System.Drawing.Point(618, 31);
            this.txtPhucap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhucap.Name = "txtPhucap";
            this.txtPhucap.Size = new System.Drawing.Size(160, 24);
            this.txtPhucap.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(497, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Khấu trừ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(497, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Phụ cấp";
            // 
            // btnTinhluong
            // 
            this.btnTinhluong.Location = new System.Drawing.Point(618, 308);
            this.btnTinhluong.Name = "btnTinhluong";
            this.btnTinhluong.Size = new System.Drawing.Size(160, 46);
            this.btnTinhluong.TabIndex = 30;
            this.btnTinhluong.Text = "Tính lương";
            this.btnTinhluong.UseVisualStyleBackColor = true;
            this.btnTinhluong.Click += new System.EventHandler(this.btnTinhluong_Click);
            // 
            // txtTongluong
            // 
            this.txtTongluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongluong.Location = new System.Drawing.Point(618, 265);
            this.txtTongluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongluong.Name = "txtTongluong";
            this.txtTongluong.Size = new System.Drawing.Size(160, 24);
            this.txtTongluong.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(497, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 18);
            this.label7.TabIndex = 32;
            this.label7.Text = "Tổng lương";
            // 
            // txtSongaycong
            // 
            this.txtSongaycong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSongaycong.Location = new System.Drawing.Point(618, 128);
            this.txtSongaycong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSongaycong.Name = "txtSongaycong";
            this.txtSongaycong.Size = new System.Drawing.Size(160, 24);
            this.txtSongaycong.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(497, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 18);
            this.label9.TabIndex = 36;
            this.label9.Text = "Số ngày công";
            // 
            // dtpNgaythanhtoan
            // 
            this.dtpNgaythanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaythanhtoan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaythanhtoan.Location = new System.Drawing.Point(618, 214);
            this.dtpNgaythanhtoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaythanhtoan.Name = "dtpNgaythanhtoan";
            this.dtpNgaythanhtoan.Size = new System.Drawing.Size(160, 24);
            this.dtpNgaythanhtoan.TabIndex = 38;
            this.dtpNgaythanhtoan.Value = new System.DateTime(2025, 4, 17, 14, 32, 54, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(481, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 18);
            this.label10.TabIndex = 39;
            this.label10.Text = "Ngày thanh toán";
            // 
            // txtMahoadon
            // 
            this.txtMahoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMahoadon.Location = new System.Drawing.Point(167, 25);
            this.txtMahoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMahoadon.Name = "txtMahoadon";
            this.txtMahoadon.Size = new System.Drawing.Size(160, 24);
            this.txtMahoadon.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(46, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 18);
            this.label11.TabIndex = 41;
            this.label11.Text = "Mã hóa đơn";
            // 
            // dgvNhanvien
            // 
            this.dgvNhanvien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhanVien,
            this.tenNhanVien});
            this.dgvNhanvien.Location = new System.Drawing.Point(878, 31);
            this.dgvNhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNhanvien.Name = "dgvNhanvien";
            this.dgvNhanvien.RowHeadersWidth = 62;
            this.dgvNhanvien.RowTemplate.Height = 28;
            this.dgvNhanvien.Size = new System.Drawing.Size(356, 219);
            this.dgvNhanvien.TabIndex = 42;
            this.dgvNhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanvien_CellClick);
            // 
            // maNhanVien
            // 
            this.maNhanVien.DataPropertyName = "manv";
            this.maNhanVien.HeaderText = "Mã nhân viên";
            this.maNhanVien.MinimumWidth = 8;
            this.maNhanVien.Name = "maNhanVien";
            this.maNhanVien.Width = 80;
            // 
            // tenNhanVien
            // 
            this.tenNhanVien.DataPropertyName = "tennv";
            this.tenNhanVien.HeaderText = "Tên nhân viên";
            this.tenNhanVien.MinimumWidth = 8;
            this.tenNhanVien.Name = "tenNhanVien";
            this.tenNhanVien.Width = 130;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(31, 346);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(160, 46);
            this.btnSua.TabIndex = 43;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(228, 346);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(160, 46);
            this.btnXoa.TabIndex = 44;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // FrmThanhToanLuongNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 687);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dgvNhanvien);
            this.Controls.Add(this.txtMahoadon);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpNgaythanhtoan);
            this.Controls.Add(this.txtSongaycong);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTongluong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnTinhluong);
            this.Controls.Add(this.txtKhautru);
            this.Controls.Add(this.txtPhucap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHesoluong);
            this.Controls.Add(this.txtLuongcoban);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTennv);
            this.Controls.Add(this.txtManv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLuongnhanvien);
            this.Name = "FrmThanhToanLuongNhanVien";
            this.Text = "ThanhToanLuongNhanVien";
            this.Load += new System.EventHandler(this.FrmThanhToanLuongNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuongnhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLuongnhanvien;
        private System.Windows.Forms.TextBox txtTennv;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHesoluong;
        private System.Windows.Forms.TextBox txtLuongcoban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKhautru;
        private System.Windows.Forms.TextBox txtPhucap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTinhluong;
        private System.Windows.Forms.TextBox txtTongluong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSongaycong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpNgaythanhtoan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMahoadon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvNhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVien;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongcoban;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn phucap;
        private System.Windows.Forms.DataGridViewTextBoxColumn khautru;
        private System.Windows.Forms.DataGridViewTextBoxColumn songaycong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaythanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongluong;
    }
}