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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachDangKy));
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dgvSVDaDuyet = new System.Windows.Forms.DataGridView();
            this.masvdky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quequan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiuutien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbLoaiuutien = new System.Windows.Forms.ComboBox();
            this.cbMaphongNu = new System.Windows.Forms.ComboBox();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.cbGioitinh = new System.Windows.Forms.ComboBox();
            this.txtQuequan = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtTensv = new System.Windows.Forms.TextBox();
            this.txtMasv = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbMaphongNam = new System.Windows.Forms.ComboBox();
            this.dgvSVChoDuyet = new System.Windows.Forms.DataGridView();
            this.dgvtbcMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcTenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcQueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcLoaiUuTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSVDaDuyet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSVChoDuyet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.FlatAppearance.BorderSize = 0;
            this.btnCapnhat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCapnhat.Location = new System.Drawing.Point(747, 216);
            this.btnCapnhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnCapnhat.Size = new System.Drawing.Size(80, 74);
            this.btnCapnhat.TabIndex = 40;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCapnhat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(537, 216);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnXoa.Size = new System.Drawing.Size(80, 74);
            this.btnXoa.TabIndex = 38;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(119, 216);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnThem.Size = new System.Drawing.Size(80, 74);
            this.btnThem.TabIndex = 35;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(328, 216);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnSua.Size = new System.Drawing.Size(80, 74);
            this.btnSua.TabIndex = 37;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.khoa,
            this.lop,
            this.loaiuutien,
            this.maphong});
            this.dgvSVDaDuyet.Location = new System.Drawing.Point(13, 556);
            this.dgvSVDaDuyet.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSVDaDuyet.Name = "dgvSVDaDuyet";
            this.dgvSVDaDuyet.RowHeadersWidth = 51;
            this.dgvSVDaDuyet.Size = new System.Drawing.Size(1056, 172);
            this.dgvSVDaDuyet.TabIndex = 41;
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
            // cbLoaiuutien
            // 
            this.cbLoaiuutien.FormattingEnabled = true;
            this.cbLoaiuutien.Items.AddRange(new object[] {
            "Bình thường",
            "Hộ nghèo",
            "Gia đình thương binh liệt sĩ",
            "Du học sinh"});
            this.cbLoaiuutien.Location = new System.Drawing.Point(667, 179);
            this.cbLoaiuutien.Margin = new System.Windows.Forms.Padding(4);
            this.cbLoaiuutien.Name = "cbLoaiuutien";
            this.cbLoaiuutien.Size = new System.Drawing.Size(160, 24);
            this.cbLoaiuutien.TabIndex = 34;
            // 
            // cbMaphongNu
            // 
            this.cbMaphongNu.FormattingEnabled = true;
            this.cbMaphongNu.Location = new System.Drawing.Point(667, 103);
            this.cbMaphongNu.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaphongNu.Name = "cbMaphongNu";
            this.cbMaphongNu.Size = new System.Drawing.Size(160, 24);
            this.cbMaphongNu.TabIndex = 33;
            // 
            // cbKhoa
            // 
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Items.AddRange(new object[] {
            "K10",
            "K11",
            "K12",
            "K13"});
            this.cbKhoa.Location = new System.Drawing.Point(667, 25);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(160, 24);
            this.cbKhoa.TabIndex = 31;
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaysinh.Location = new System.Drawing.Point(243, 139);
            this.dtpNgaysinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(159, 22);
            this.dtpNgaysinh.TabIndex = 29;
            // 
            // cbGioitinh
            // 
            this.cbGioitinh.FormattingEnabled = true;
            this.cbGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioitinh.Location = new System.Drawing.Point(243, 97);
            this.cbGioitinh.Margin = new System.Windows.Forms.Padding(4);
            this.cbGioitinh.Name = "cbGioitinh";
            this.cbGioitinh.Size = new System.Drawing.Size(159, 24);
            this.cbGioitinh.TabIndex = 28;
            // 
            // txtQuequan
            // 
            this.txtQuequan.Location = new System.Drawing.Point(243, 179);
            this.txtQuequan.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuequan.Name = "txtQuequan";
            this.txtQuequan.Size = new System.Drawing.Size(159, 22);
            this.txtQuequan.TabIndex = 30;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(667, 65);
            this.txtLop.Margin = new System.Windows.Forms.Padding(4);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(160, 22);
            this.txtLop.TabIndex = 32;
            // 
            // txtTensv
            // 
            this.txtTensv.Location = new System.Drawing.Point(243, 57);
            this.txtTensv.Margin = new System.Windows.Forms.Padding(4);
            this.txtTensv.Name = "txtTensv";
            this.txtTensv.Size = new System.Drawing.Size(159, 22);
            this.txtTensv.TabIndex = 27;
            // 
            // txtMasv
            // 
            this.txtMasv.Location = new System.Drawing.Point(243, 17);
            this.txtMasv.Margin = new System.Windows.Forms.Padding(4);
            this.txtMasv.Name = "txtMasv";
            this.txtMasv.Size = new System.Drawing.Size(159, 22);
            this.txtMasv.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(529, 183);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 18);
            this.label9.TabIndex = 48;
            this.label9.Text = "Loại ưu tiên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(529, 108);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 18);
            this.label8.TabIndex = 47;
            this.label8.Text = "Mã phòng Nữ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(529, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 18);
            this.label7.TabIndex = 46;
            this.label7.Text = "Lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(529, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 45;
            this.label6.Text = "Khóa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 183);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 44;
            this.label5.Text = "Quê quán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 43;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 39;
            this.label2.Text = "Tên sv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "Mã sv";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(529, 142);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 18);
            this.label10.TabIndex = 49;
            this.label10.Text = "Mã phòng Nam";
            // 
            // cbMaphongNam
            // 
            this.cbMaphongNam.FormattingEnabled = true;
            this.cbMaphongNam.Location = new System.Drawing.Point(667, 139);
            this.cbMaphongNam.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaphongNam.Name = "cbMaphongNam";
            this.cbMaphongNam.Size = new System.Drawing.Size(160, 24);
            this.cbMaphongNam.TabIndex = 50;
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
            this.dgvtbcKhoa,
            this.dgvtbcLop,
            this.dgvtbcLoaiUuTien});
            this.dgvSVChoDuyet.Location = new System.Drawing.Point(13, 328);
            this.dgvSVChoDuyet.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSVChoDuyet.Name = "dgvSVChoDuyet";
            this.dgvSVChoDuyet.RowHeadersWidth = 51;
            this.dgvSVChoDuyet.Size = new System.Drawing.Size(1056, 177);
            this.dgvSVChoDuyet.TabIndex = 51;
            this.dgvSVChoDuyet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSVChoDuyet_CellClick);
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
            this.label11.Location = new System.Drawing.Point(12, 308);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(243, 16);
            this.label11.TabIndex = 52;
            this.label11.Text = "Danh sách Sinh Viên Đăng ký chờ duyệt";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 536);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(237, 16);
            this.label12.TabIndex = 53;
            this.label12.Text = "Danh sách Sinh Viên Đăng ký đã duyệt";
            // 
            // DanhSachDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 784);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvSVChoDuyet);
            this.Controls.Add(this.cbMaphongNam);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dgvSVDaDuyet);
            this.Controls.Add(this.cbLoaiuutien);
            this.Controls.Add(this.cbMaphongNu);
            this.Controls.Add(this.cbKhoa);
            this.Controls.Add(this.dtpNgaysinh);
            this.Controls.Add(this.cbGioitinh);
            this.Controls.Add(this.txtQuequan);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.txtTensv);
            this.Controls.Add(this.txtMasv);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DanhSachDangKy";
            this.Text = "DanhSachDangKy";
            this.Load += new System.EventHandler(this.DanhSachDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSVDaDuyet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSVChoDuyet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dgvSVDaDuyet;
        private System.Windows.Forms.ComboBox cbLoaiuutien;
        private System.Windows.Forms.ComboBox cbMaphongNu;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.ComboBox cbGioitinh;
        private System.Windows.Forms.TextBox txtQuequan;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtTensv;
        private System.Windows.Forms.TextBox txtMasv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbMaphongNam;
        private System.Windows.Forms.DataGridView dgvSVChoDuyet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn masvdky;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensv;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn quequan;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiuutien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcTenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcQueQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcLoaiUuTien;
    }
}