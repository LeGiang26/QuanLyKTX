namespace QuanLyKyTucXa_main
{
    partial class FrmQuanLyKyLuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyKyLuat));
            this.txtTienphat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.rbKyluat = new System.Windows.Forms.RadioButton();
            this.rbMasv = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbMasv = new System.Windows.Forms.ComboBox();
            this.btnCapnhap = new System.Windows.Forms.Button();
            this.dgvKyluat = new System.Windows.Forms.DataGridView();
            this.dtpNgaykyluat = new System.Windows.Forms.DateTimePicker();
            this.txtKyluat = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kyluat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaykyluat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienphat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKyluat)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTienphat
            // 
            this.txtTienphat.Location = new System.Drawing.Point(121, 256);
            this.txtTienphat.Margin = new System.Windows.Forms.Padding(2);
            this.txtTienphat.Name = "txtTienphat";
            this.txtTienphat.Size = new System.Drawing.Size(103, 20);
            this.txtTienphat.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 263);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Tiền phạt";
            // 
            // btnLammoi
            // 
            this.btnLammoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLammoi.FlatAppearance.BorderSize = 0;
            this.btnLammoi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLammoi.Location = new System.Drawing.Point(700, 386);
            this.btnLammoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnLammoi.Size = new System.Drawing.Size(60, 60);
            this.btnLammoi.TabIndex = 28;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(603, 386);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnXoa.Size = new System.Drawing.Size(60, 60);
            this.btnXoa.TabIndex = 27;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(409, 387);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnThem.Size = new System.Drawing.Size(60, 60);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // rbKyluat
            // 
            this.rbKyluat.AutoSize = true;
            this.rbKyluat.Location = new System.Drawing.Point(102, 18);
            this.rbKyluat.Margin = new System.Windows.Forms.Padding(2);
            this.rbKyluat.Name = "rbKyluat";
            this.rbKyluat.Size = new System.Drawing.Size(57, 17);
            this.rbKyluat.TabIndex = 1;
            this.rbKyluat.TabStop = true;
            this.rbKyluat.Text = "Kỷ luật";
            this.rbKyluat.UseVisualStyleBackColor = true;
            this.rbKyluat.CheckedChanged += new System.EventHandler(this.rbKyluat_CheckedChanged);
            // 
            // rbMasv
            // 
            this.rbMasv.AutoSize = true;
            this.rbMasv.Location = new System.Drawing.Point(13, 18);
            this.rbMasv.Margin = new System.Windows.Forms.Padding(2);
            this.rbMasv.Name = "rbMasv";
            this.rbMasv.Size = new System.Drawing.Size(85, 17);
            this.rbMasv.TabIndex = 0;
            this.rbMasv.TabStop = true;
            this.rbMasv.Text = "Mã sinh viên";
            this.rbMasv.UseVisualStyleBackColor = true;
            this.rbMasv.CheckedChanged += new System.EventHandler(this.rbMasv_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Controls.Add(this.txtTimkiem);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.rbKyluat);
            this.groupBox1.Controls.Add(this.rbMasv);
            this.groupBox1.Location = new System.Drawing.Point(45, 305);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(180, 141);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimkiem.FlatAppearance.BorderSize = 0;
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.Location = new System.Drawing.Point(13, 87);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnTimkiem.Size = new System.Drawing.Size(130, 37);
            this.btnTimkiem.TabIndex = 34;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.Location = new System.Drawing.Point(13, 60);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(130, 21);
            this.txtTimkiem.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Nhập thông tin tìm kiếm:";
            // 
            // cbMasv
            // 
            this.cbMasv.FormattingEnabled = true;
            this.cbMasv.Location = new System.Drawing.Point(121, 93);
            this.cbMasv.Margin = new System.Windows.Forms.Padding(2);
            this.cbMasv.Name = "cbMasv";
            this.cbMasv.Size = new System.Drawing.Size(103, 21);
            this.cbMasv.TabIndex = 20;
            // 
            // btnCapnhap
            // 
            this.btnCapnhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapnhap.FlatAppearance.BorderSize = 0;
            this.btnCapnhap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCapnhap.Location = new System.Drawing.Point(506, 387);
            this.btnCapnhap.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapnhap.Name = "btnCapnhap";
            this.btnCapnhap.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnCapnhap.Size = new System.Drawing.Size(63, 60);
            this.btnCapnhap.TabIndex = 26;
            this.btnCapnhap.Text = "Cập nhập";
            this.btnCapnhap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCapnhap.UseVisualStyleBackColor = true;
            this.btnCapnhap.Click += new System.EventHandler(this.btnCapnhap_Click);
            // 
            // dgvKyluat
            // 
            this.dgvKyluat.AllowUserToAddRows = false;
            this.dgvKyluat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKyluat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKyluat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.masv,
            this.kyluat,
            this.ngaykyluat,
            this.tienphat});
            this.dgvKyluat.Location = new System.Drawing.Point(240, 38);
            this.dgvKyluat.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKyluat.Name = "dgvKyluat";
            this.dgvKyluat.RowHeadersWidth = 62;
            this.dgvKyluat.RowTemplate.Height = 28;
            this.dgvKyluat.Size = new System.Drawing.Size(520, 324);
            this.dgvKyluat.TabIndex = 30;
            this.dgvKyluat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKyluat_CellClick);
            // 
            // dtpNgaykyluat
            // 
            this.dtpNgaykyluat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaykyluat.Location = new System.Drawing.Point(121, 202);
            this.dtpNgaykyluat.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaykyluat.Name = "dtpNgaykyluat";
            this.dtpNgaykyluat.Size = new System.Drawing.Size(103, 20);
            this.dtpNgaykyluat.TabIndex = 22;
            // 
            // txtKyluat
            // 
            this.txtKyluat.Location = new System.Drawing.Point(121, 148);
            this.txtKyluat.Margin = new System.Windows.Forms.Padding(2);
            this.txtKyluat.Name = "txtKyluat";
            this.txtKyluat.Size = new System.Drawing.Size(103, 20);
            this.txtKyluat.TabIndex = 21;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(121, 39);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(103, 20);
            this.txtId.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Kỷ luật";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ngày kỷ luật";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mã sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID";
            // 
            // id
            // 
            this.id.DataPropertyName = "makyluat";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 80;
            // 
            // masv
            // 
            this.masv.DataPropertyName = "masv";
            this.masv.HeaderText = "Mã sinh viên";
            this.masv.MinimumWidth = 8;
            this.masv.Name = "masv";
            this.masv.Width = 90;
            // 
            // kyluat
            // 
            this.kyluat.DataPropertyName = "kyluatnoidung";
            this.kyluat.HeaderText = "Kỷ luật";
            this.kyluat.MinimumWidth = 8;
            this.kyluat.Name = "kyluat";
            this.kyluat.Width = 110;
            // 
            // ngaykyluat
            // 
            this.ngaykyluat.DataPropertyName = "ngaykyluat";
            this.ngaykyluat.HeaderText = "Ngày kỷ luật";
            this.ngaykyluat.MinimumWidth = 8;
            this.ngaykyluat.Name = "ngaykyluat";
            // 
            // tienphat
            // 
            this.tienphat.DataPropertyName = "tienphat";
            this.tienphat.HeaderText = "Tiền phạt";
            this.tienphat.MinimumWidth = 8;
            this.tienphat.Name = "tienphat";
            // 
            // FrmQuanLyKyLuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.txtTienphat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbMasv);
            this.Controls.Add(this.btnCapnhap);
            this.Controls.Add(this.dgvKyluat);
            this.Controls.Add(this.dtpNgaykyluat);
            this.Controls.Add(this.txtKyluat);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmQuanLyKyLuat";
            this.Text = "FrmQuanLyKyLuat";
            this.Load += new System.EventHandler(this.FrmQuanLyKyLuat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKyluat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTienphat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.RadioButton rbKyluat;
        private System.Windows.Forms.RadioButton rbMasv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMasv;
        private System.Windows.Forms.Button btnCapnhap;
        private System.Windows.Forms.DataGridView dgvKyluat;
        private System.Windows.Forms.DateTimePicker dtpNgaykyluat;
        private System.Windows.Forms.TextBox txtKyluat;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn masv;
        private System.Windows.Forms.DataGridViewTextBoxColumn kyluat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaykyluat;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienphat;
    }
}