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
            this.dtpNgaythanhtoan = new System.Windows.Forms.DateTimePicker();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.tenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvNhanvien = new System.Windows.Forms.DataGridView();
            this.txtMaluong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpThang = new System.Windows.Forms.DateTimePicker();
            this.txtTongluong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTinhluong = new System.Windows.Forms.Button();
            this.txtThuongphat = new System.Windows.Forms.TextBox();
            this.dgvLuongnhanvien = new System.Windows.Forms.DataGridView();
            this.maluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongcoban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phucap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thuongphat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaythanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLuongcoban = new System.Windows.Forms.TextBox();
            this.txtPhucap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTennv = new System.Windows.Forms.TextBox();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuongnhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgaythanhtoan
            // 
            this.dtpNgaythanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaythanhtoan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaythanhtoan.Location = new System.Drawing.Point(617, 127);
            this.dtpNgaythanhtoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaythanhtoan.Name = "dtpNgaythanhtoan";
            this.dtpNgaythanhtoan.Size = new System.Drawing.Size(160, 24);
            this.dtpNgaythanhtoan.TabIndex = 68;
            this.dtpNgaythanhtoan.Value = new System.DateTime(2025, 4, 17, 14, 32, 54, 0);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(227, 347);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(160, 46);
            this.btnXoa.TabIndex = 67;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(30, 347);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(160, 46);
            this.btnSua.TabIndex = 66;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // tenNhanVien
            // 
            this.tenNhanVien.DataPropertyName = "tennv";
            this.tenNhanVien.HeaderText = "Tên nhân viên";
            this.tenNhanVien.MinimumWidth = 8;
            this.tenNhanVien.Name = "tenNhanVien";
            this.tenNhanVien.Width = 130;
            // 
            // maNhanVien
            // 
            this.maNhanVien.DataPropertyName = "manv";
            this.maNhanVien.HeaderText = "Mã nhân viên";
            this.maNhanVien.MinimumWidth = 8;
            this.maNhanVien.Name = "maNhanVien";
            this.maNhanVien.Width = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(480, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 18);
            this.label8.TabIndex = 69;
            this.label8.Text = "Ngày thanh toán";
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
            this.dgvNhanvien.Location = new System.Drawing.Point(877, 32);
            this.dgvNhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNhanvien.Name = "dgvNhanvien";
            this.dgvNhanvien.RowHeadersWidth = 62;
            this.dgvNhanvien.RowTemplate.Height = 28;
            this.dgvNhanvien.Size = new System.Drawing.Size(356, 219);
            this.dgvNhanvien.TabIndex = 65;
            // 
            // txtMaluong
            // 
            this.txtMaluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaluong.Location = new System.Drawing.Point(166, 26);
            this.txtMaluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaluong.Name = "txtMaluong";
            this.txtMaluong.Size = new System.Drawing.Size(160, 24);
            this.txtMaluong.TabIndex = 63;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(45, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 18);
            this.label11.TabIndex = 64;
            this.label11.Text = "Mã lương";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(45, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 18);
            this.label10.TabIndex = 62;
            this.label10.Text = "Tháng";
            // 
            // dtpThang
            // 
            this.dtpThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThang.Location = new System.Drawing.Point(166, 175);
            this.dtpThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpThang.Name = "dtpThang";
            this.dtpThang.Size = new System.Drawing.Size(160, 24);
            this.dtpThang.TabIndex = 61;
            this.dtpThang.Value = new System.DateTime(2025, 4, 17, 14, 32, 54, 0);
            // 
            // txtTongluong
            // 
            this.txtTongluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongluong.Location = new System.Drawing.Point(617, 184);
            this.txtTongluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongluong.Name = "txtTongluong";
            this.txtTongluong.Size = new System.Drawing.Size(160, 24);
            this.txtTongluong.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(496, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 18);
            this.label7.TabIndex = 59;
            this.label7.Text = "Tổng lương";
            // 
            // btnTinhluong
            // 
            this.btnTinhluong.Location = new System.Drawing.Point(617, 227);
            this.btnTinhluong.Name = "btnTinhluong";
            this.btnTinhluong.Size = new System.Drawing.Size(160, 46);
            this.btnTinhluong.TabIndex = 58;
            this.btnTinhluong.Text = "Tính lương";
            this.btnTinhluong.UseVisualStyleBackColor = true;
            // 
            // txtThuongphat
            // 
            this.txtThuongphat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThuongphat.Location = new System.Drawing.Point(617, 76);
            this.txtThuongphat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThuongphat.Name = "txtThuongphat";
            this.txtThuongphat.Size = new System.Drawing.Size(160, 24);
            this.txtThuongphat.TabIndex = 57;
            // 
            // dgvLuongnhanvien
            // 
            this.dgvLuongnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuongnhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maluong,
            this.manv,
            this.tennv,
            this.thang,
            this.luongcoban,
            this.phucap,
            this.thuongphat,
            this.ngaythanhtoan,
            this.tongluong});
            this.dgvLuongnhanvien.Location = new System.Drawing.Point(30, 409);
            this.dgvLuongnhanvien.Name = "dgvLuongnhanvien";
            this.dgvLuongnhanvien.RowHeadersWidth = 51;
            this.dgvLuongnhanvien.RowTemplate.Height = 24;
            this.dgvLuongnhanvien.Size = new System.Drawing.Size(809, 252);
            this.dgvLuongnhanvien.TabIndex = 47;
            // 
            // maluong
            // 
            this.maluong.DataPropertyName = "maluong";
            this.maluong.HeaderText = "Mã Lương";
            this.maluong.MinimumWidth = 6;
            this.maluong.Name = "maluong";
            this.maluong.Width = 125;
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
            // thang
            // 
            this.thang.DataPropertyName = "thang";
            this.thang.HeaderText = "Tháng";
            this.thang.MinimumWidth = 6;
            this.thang.Name = "thang";
            this.thang.Width = 125;
            // 
            // luongcoban
            // 
            this.luongcoban.DataPropertyName = "luongcoban";
            this.luongcoban.HeaderText = "Luong Cơ Bản";
            this.luongcoban.MinimumWidth = 6;
            this.luongcoban.Name = "luongcoban";
            this.luongcoban.Width = 125;
            // 
            // phucap
            // 
            this.phucap.DataPropertyName = "phucap";
            this.phucap.HeaderText = "Phụ Cấp";
            this.phucap.MinimumWidth = 6;
            this.phucap.Name = "phucap";
            this.phucap.Width = 125;
            // 
            // thuongphat
            // 
            this.thuongphat.DataPropertyName = "thuongphat";
            this.thuongphat.HeaderText = "Thưởng Phạt";
            this.thuongphat.MinimumWidth = 6;
            this.thuongphat.Name = "thuongphat";
            this.thuongphat.Width = 125;
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
            // txtLuongcoban
            // 
            this.txtLuongcoban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuongcoban.Location = new System.Drawing.Point(166, 227);
            this.txtLuongcoban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLuongcoban.Name = "txtLuongcoban";
            this.txtLuongcoban.Size = new System.Drawing.Size(160, 24);
            this.txtLuongcoban.TabIndex = 52;
            // 
            // txtPhucap
            // 
            this.txtPhucap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhucap.Location = new System.Drawing.Point(617, 32);
            this.txtPhucap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhucap.Name = "txtPhucap";
            this.txtPhucap.Size = new System.Drawing.Size(160, 24);
            this.txtPhucap.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(496, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 56;
            this.label4.Text = "Thưởng phạt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(496, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 55;
            this.label5.Text = "Phụ cấp";
            // 
            // txtTennv
            // 
            this.txtTennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTennv.Location = new System.Drawing.Point(166, 124);
            this.txtTennv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTennv.Name = "txtTennv";
            this.txtTennv.Size = new System.Drawing.Size(160, 24);
            this.txtTennv.TabIndex = 51;
            // 
            // txtManv
            // 
            this.txtManv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManv.Location = new System.Drawing.Point(166, 80);
            this.txtManv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(160, 24);
            this.txtManv.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 18);
            this.label6.TabIndex = 50;
            this.label6.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 49;
            this.label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 53;
            this.label3.Text = "Lương cơ bản";
            // 
            // FrmThanhToanLuongNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 687);
            this.Controls.Add(this.dtpNgaythanhtoan);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvNhanvien);
            this.Controls.Add(this.txtMaluong);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpThang);
            this.Controls.Add(this.txtTongluong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnTinhluong);
            this.Controls.Add(this.txtThuongphat);
            this.Controls.Add(this.dgvLuongnhanvien);
            this.Controls.Add(this.txtLuongcoban);
            this.Controls.Add(this.txtPhucap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTennv);
            this.Controls.Add(this.txtManv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "FrmThanhToanLuongNhanVien";
            this.Text = "ThanhToanLuongNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuongnhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgaythanhtoan;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvNhanvien;
        private System.Windows.Forms.TextBox txtMaluong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpThang;
        private System.Windows.Forms.TextBox txtTongluong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTinhluong;
        private System.Windows.Forms.TextBox txtThuongphat;
        private System.Windows.Forms.DataGridView dgvLuongnhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongcoban;
        private System.Windows.Forms.DataGridViewTextBoxColumn phucap;
        private System.Windows.Forms.DataGridViewTextBoxColumn thuongphat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaythanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongluong;
        private System.Windows.Forms.TextBox txtLuongcoban;
        private System.Windows.Forms.TextBox txtPhucap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTennv;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}