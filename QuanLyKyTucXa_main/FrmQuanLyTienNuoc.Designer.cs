namespace QuanLyKyTucXa_main
{
    partial class FrmQuanLyTienNuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyTienNuoc));
            this.cbMaphong = new System.Windows.Forms.ComboBox();
            this.btnThanhtoan = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.rbTktheoma = new System.Windows.Forms.RadioButton();
            this.rbTktheott = new System.Windows.Forms.RadioButton();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCapnhap = new System.Windows.Forms.Button();
            this.cbTrangthai = new System.Windows.Forms.ComboBox();
            this.dtpNgaylap = new System.Windows.Forms.DateTimePicker();
            this.txtTiennuoc = new System.Windows.Forms.TextBox();
            this.txtChisomoi = new System.Windows.Forms.TextBox();
            this.txtMahoadon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXuatPDF = new System.Windows.Forms.Button();
            this.dgvTiennuoc = new System.Windows.Forms.DataGridView();
            this.mahoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chisocu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chisomoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sokhoitieuthu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiennuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMaphong
            // 
            this.cbMaphong.FormattingEnabled = true;
            this.cbMaphong.Location = new System.Drawing.Point(157, 68);
            this.cbMaphong.Name = "cbMaphong";
            this.cbMaphong.Size = new System.Drawing.Size(110, 21);
            this.cbMaphong.TabIndex = 25;
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhtoan.Enabled = false;
            this.btnThanhtoan.Location = new System.Drawing.Point(585, 232);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnThanhtoan.Size = new System.Drawing.Size(164, 39);
            this.btnThanhtoan.TabIndex = 36;
            this.btnThanhtoan.Text = "  Thanh toán";
            this.btnThanhtoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThanhtoan.UseVisualStyleBackColor = true;
            this.btnThanhtoan.Click += new System.EventHandler(this.btnThanhtoan_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.FlatAppearance.BorderSize = 0;
            this.btnLammoi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLammoi.Location = new System.Drawing.Point(477, 148);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnLammoi.Size = new System.Drawing.Size(60, 60);
            this.btnLammoi.TabIndex = 33;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(335, 148);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnXoa.Size = new System.Drawing.Size(60, 60);
            this.btnXoa.TabIndex = 32;
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
            this.btnThem.Location = new System.Drawing.Point(51, 148);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnThem.Size = new System.Drawing.Size(60, 60);
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // rbTktheoma
            // 
            this.rbTktheoma.AutoSize = true;
            this.rbTktheoma.Location = new System.Drawing.Point(19, 19);
            this.rbTktheoma.Name = "rbTktheoma";
            this.rbTktheoma.Size = new System.Drawing.Size(141, 17);
            this.rbTktheoma.TabIndex = 0;
            this.rbTktheoma.TabStop = true;
            this.rbTktheoma.Text = "Tìm kiếm theo mã phòng";
            this.rbTktheoma.UseVisualStyleBackColor = true;
            //            this.rbTktheoma.CheckedChanged += new System.EventHandler(this.rbTktheoma_CheckedChanged);
            // 
            // rbTktheott
            // 
            this.rbTktheott.AutoSize = true;
            this.rbTktheott.Location = new System.Drawing.Point(19, 42);
            this.rbTktheott.Name = "rbTktheott";
            this.rbTktheott.Size = new System.Drawing.Size(138, 17);
            this.rbTktheott.TabIndex = 1;
            this.rbTktheott.TabStop = true;
            this.rbTktheott.Text = "Tìm kiếm theo trạng thái";
            this.rbTktheott.UseVisualStyleBackColor = true;
            //           this.rbTktheott.CheckedChanged += new System.EventHandler(this.rbTktheott_CheckedChanged);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimkiem.FlatAppearance.BorderSize = 0;
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.Location = new System.Drawing.Point(18, 118);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnTimkiem.Size = new System.Drawing.Size(137, 37);
            this.btnTimkiem.TabIndex = 2;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTimkiem);
            this.groupBox1.Controls.Add(this.rbTktheoma);
            this.groupBox1.Controls.Add(this.rbTktheott);
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Location = new System.Drawing.Point(589, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 166);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo";
            // 
            // btnCapnhap
            // 
            this.btnCapnhap.FlatAppearance.BorderSize = 0;
            this.btnCapnhap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCapnhap.Location = new System.Drawing.Point(189, 148);
            this.btnCapnhap.Name = "btnCapnhap";
            this.btnCapnhap.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnCapnhap.Size = new System.Drawing.Size(64, 60);
            this.btnCapnhap.TabIndex = 31;
            this.btnCapnhap.Text = "Cập nhập";
            this.btnCapnhap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCapnhap.UseVisualStyleBackColor = true;
            this.btnCapnhap.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // cbTrangthai
            // 
            this.cbTrangthai.FormattingEnabled = true;
            this.cbTrangthai.Items.AddRange(new object[] {
            "Đã thanh toán",
            "Chưa thanh toán"});
            this.cbTrangthai.Location = new System.Drawing.Point(428, 111);
            this.cbTrangthai.Name = "cbTrangthai";
            this.cbTrangthai.Size = new System.Drawing.Size(110, 21);
            this.cbTrangthai.TabIndex = 29;
            // 
            // dtpNgaylap
            // 
            this.dtpNgaylap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaylap.Location = new System.Drawing.Point(157, 111);
            this.dtpNgaylap.Name = "dtpNgaylap";
            this.dtpNgaylap.Size = new System.Drawing.Size(110, 20);
            this.dtpNgaylap.TabIndex = 26;
            // 
            // txtTiennuoc
            // 
            this.txtTiennuoc.Enabled = false;
            this.txtTiennuoc.Location = new System.Drawing.Point(428, 68);
            this.txtTiennuoc.Name = "txtTiennuoc";
            this.txtTiennuoc.Size = new System.Drawing.Size(110, 20);
            this.txtTiennuoc.TabIndex = 28;
            this.txtTiennuoc.Text = "22.000đ / khối";
            // 
            // txtChisomoi
            // 
            this.txtChisomoi.Location = new System.Drawing.Point(428, 25);
            this.txtChisomoi.Name = "txtChisomoi";
            this.txtChisomoi.Size = new System.Drawing.Size(110, 20);
            this.txtChisomoi.TabIndex = 27;
            // 
            // txtMahoadon
            // 
            this.txtMahoadon.Enabled = false;
            this.txtMahoadon.Location = new System.Drawing.Point(157, 25);
            this.txtMahoadon.Name = "txtMahoadon";
            this.txtMahoadon.Size = new System.Drawing.Size(110, 20);
            this.txtMahoadon.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Trạng thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Ngày lập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Tiền nước";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Chỉ số mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Mã phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Mã hóa đơn";
            // 
            // btnXuatPDF
            // 
            this.btnXuatPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuatPDF.Location = new System.Drawing.Point(585, 310);
            this.btnXuatPDF.Name = "btnXuatPDF";
            this.btnXuatPDF.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnXuatPDF.Size = new System.Drawing.Size(164, 39);
            this.btnXuatPDF.TabIndex = 44;
            this.btnXuatPDF.Text = "  Xuất hóa đơn";
            this.btnXuatPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXuatPDF.UseVisualStyleBackColor = true;
            this.btnXuatPDF.Click += new System.EventHandler(this.btnXuatPDF_Click);
            // 
            // dgvTiennuoc
            // 
            this.dgvTiennuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTiennuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiennuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahoadon,
            this.maphong,
            this.ngaylap,
            this.chisocu,
            this.chisomoi,
            this.sokhoitieuthu,
            this.tongtien,
            this.trangthai});
            this.dgvTiennuoc.Location = new System.Drawing.Point(50, 232);
            this.dgvTiennuoc.Name = "dgvTiennuoc";
            this.dgvTiennuoc.Size = new System.Drawing.Size(487, 200);
            this.dgvTiennuoc.TabIndex = 45;
            this.dgvTiennuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTiennuoc_CellClick);
            // 
            // mahoadon
            // 
            this.mahoadon.DataPropertyName = "mahoadon";
            this.mahoadon.HeaderText = "Mã hóa đơn";
            this.mahoadon.Name = "mahoadon";
            this.mahoadon.Width = 80;
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "maphong";
            this.maphong.HeaderText = "Mã phòng";
            this.maphong.Name = "maphong";
            // 
            // ngaylap
            // 
            this.ngaylap.DataPropertyName = "ngaylap";
            this.ngaylap.HeaderText = "Ngày lập";
            this.ngaylap.Name = "ngaylap";
            // 
            // chisocu
            // 
            this.chisocu.DataPropertyName = "chisocu";
            this.chisocu.HeaderText = "Chỉ số cũ";
            this.chisocu.Name = "chisocu";
            // 
            // chisomoi
            // 
            this.chisomoi.DataPropertyName = "chisomoi";
            this.chisomoi.HeaderText = "Chỉ số mới";
            this.chisomoi.Name = "chisomoi";
            // 
            // sokhoitieuthu
            // 
            this.sokhoitieuthu.DataPropertyName = "sokhoitieuthu";
            this.sokhoitieuthu.HeaderText = "Lượng nước tiêu thụ";
            this.sokhoitieuthu.Name = "sokhoitieuthu";
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "tongtien";
            this.tongtien.HeaderText = "Tổng tiền";
            this.tongtien.Name = "tongtien";
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.Name = "trangthai";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Nhập thông tin tìm kiếm:";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.Location = new System.Drawing.Point(18, 91);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(137, 21);
            this.txtTimkiem.TabIndex = 6;
            // 
            // FrmQuanLyTienNuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTiennuoc);
            this.Controls.Add(this.btnXuatPDF);
            this.Controls.Add(this.cbMaphong);
            this.Controls.Add(this.btnThanhtoan);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCapnhap);
            this.Controls.Add(this.cbTrangthai);
            this.Controls.Add(this.dtpNgaylap);
            this.Controls.Add(this.txtTiennuoc);
            this.Controls.Add(this.txtChisomoi);
            this.Controls.Add(this.txtMahoadon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmQuanLyTienNuoc";
            this.Text = "FrmQuanLyTienNuoc";
            this.Load += new System.EventHandler(this.FrmQuanLyTienNuoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiennuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMaphong;
        private System.Windows.Forms.Button btnThanhtoan;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.RadioButton rbTktheoma;
        private System.Windows.Forms.RadioButton rbTktheott;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCapnhap;
        private System.Windows.Forms.ComboBox cbTrangthai;
        private System.Windows.Forms.DateTimePicker dtpNgaylap;
        private System.Windows.Forms.TextBox txtTiennuoc;
        private System.Windows.Forms.TextBox txtChisomoi;
        private System.Windows.Forms.TextBox txtMahoadon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXuatPDF;
        private System.Windows.Forms.DataGridView dgvTiennuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap;
        private System.Windows.Forms.DataGridViewTextBoxColumn chisocu;
        private System.Windows.Forms.DataGridViewTextBoxColumn chisomoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sokhoitieuthu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTimkiem;
    }
}