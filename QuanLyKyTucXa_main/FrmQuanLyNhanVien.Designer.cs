namespace QuanLyKyTucXa_main
{
    partial class FrmQuanLyNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyNhanVien));
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvNhanvien = new System.Windows.Forms.DataGridView();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTktheoma = new System.Windows.Forms.RadioButton();
            this.rbTktheoten = new System.Windows.Forms.RadioButton();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(37, 34);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnThem.Size = new System.Drawing.Size(88, 74);
            this.btnThem.TabIndex = 27;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvNhanvien
            // 
            this.dgvNhanvien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.tennv,
            this.gioitinh,
            this.ngaysinh,
            this.diachi,
            this.sodienthoai,
            this.Column1,
            this.Column2});
            this.dgvNhanvien.Location = new System.Drawing.Point(12, 244);
            this.dgvNhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNhanvien.Name = "dgvNhanvien";
            this.dgvNhanvien.RowHeadersWidth = 62;
            this.dgvNhanvien.RowTemplate.Height = 28;
            this.dgvNhanvien.Size = new System.Drawing.Size(961, 257);
            this.dgvNhanvien.TabIndex = 32;
            this.dgvNhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanvien_CellClick_1);
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Mã nhân viên";
            this.manv.MinimumWidth = 8;
            this.manv.Name = "manv";
            this.manv.Width = 80;
            // 
            // tennv
            // 
            this.tennv.DataPropertyName = "tennv";
            this.tennv.HeaderText = "Tên nhân viên";
            this.tennv.MinimumWidth = 8;
            this.tennv.Name = "tennv";
            this.tennv.Width = 130;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 8;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Width = 90;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 8;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 125;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.MinimumWidth = 8;
            this.diachi.Name = "diachi";
            this.diachi.Width = 125;
            // 
            // sodienthoai
            // 
            this.sodienthoai.DataPropertyName = "sodienthoai";
            this.sodienthoai.HeaderText = "Số điện thoại";
            this.sodienthoai.MinimumWidth = 8;
            this.sodienthoai.Name = "sodienthoai";
            this.sodienthoai.Width = 130;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Xóa";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Sửa";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbTktheoma);
            this.groupBox1.Controls.Add(this.rbTktheoten);
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTimkiem);
            this.groupBox1.Location = new System.Drawing.Point(754, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(219, 229);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // rbTktheoma
            // 
            this.rbTktheoma.AutoSize = true;
            this.rbTktheoma.Location = new System.Drawing.Point(25, 22);
            this.rbTktheoma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbTktheoma.Name = "rbTktheoma";
            this.rbTktheoma.Size = new System.Drawing.Size(134, 20);
            this.rbTktheoma.TabIndex = 0;
            this.rbTktheoma.TabStop = true;
            this.rbTktheoma.Text = "Tìm kiếm theo mã";
            this.rbTktheoma.UseVisualStyleBackColor = true;
            // 
            // rbTktheoten
            // 
            this.rbTktheoten.AutoSize = true;
            this.rbTktheoten.Location = new System.Drawing.Point(25, 49);
            this.rbTktheoten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbTktheoten.Name = "rbTktheoten";
            this.rbTktheoten.Size = new System.Drawing.Size(133, 20);
            this.rbTktheoten.TabIndex = 1;
            this.rbTktheoten.TabStop = true;
            this.rbTktheoten.Text = "Tìm kiếm theo tên";
            this.rbTktheoten.UseVisualStyleBackColor = true;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimkiem.FlatAppearance.BorderSize = 0;
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.Location = new System.Drawing.Point(25, 156);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnTimkiem.Size = new System.Drawing.Size(156, 48);
            this.btnTimkiem.TabIndex = 3;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nhập thông tin tìm kiếm:";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.Location = new System.Drawing.Point(25, 114);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(156, 24);
            this.txtTimkiem.TabIndex = 2;
            // 
            // FrmQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1000, 694);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvNhanvien);
            this.Name = "FrmQuanLyNhanVien";
            this.Text = "FrmQuanLyNhanVien";
            this.Load += new System.EventHandler(this.FrmQuanLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvNhanvien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTktheoma;
        private System.Windows.Forms.RadioButton rbTktheoten;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodienthoai;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
    }
}