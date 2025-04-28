namespace QuanLyKyTucXa_main
{
    partial class FrmQuanLyNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyNguoiDung));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTendangnhap = new System.Windows.Forms.RadioButton();
            this.rbManv = new System.Windows.Forms.RadioButton();
            this.dgvNguoidung = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendangnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbQuyen = new System.Windows.Forms.ComboBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtTendangnhap = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoidung)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTimkiem);
            this.groupBox1.Controls.Add(this.rbTendangnhap);
            this.groupBox1.Controls.Add(this.rbManv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 295);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(279, 118);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo";
            // 
            // rbTendangnhap
            // 
            this.rbTendangnhap.AutoSize = true;
            this.rbTendangnhap.Location = new System.Drawing.Point(140, 22);
            this.rbTendangnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbTendangnhap.Name = "rbTendangnhap";
            this.rbTendangnhap.Size = new System.Drawing.Size(126, 22);
            this.rbTendangnhap.TabIndex = 1;
            this.rbTendangnhap.TabStop = true;
            this.rbTendangnhap.Text = "Tên đăng nhập";
            this.rbTendangnhap.UseVisualStyleBackColor = true;
            // 
            // rbManv
            // 
            this.rbManv.AutoSize = true;
            this.rbManv.Location = new System.Drawing.Point(7, 22);
            this.rbManv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbManv.Name = "rbManv";
            this.rbManv.Size = new System.Drawing.Size(116, 22);
            this.rbManv.TabIndex = 0;
            this.rbManv.TabStop = true;
            this.rbManv.Text = "Mã nhân viên";
            this.rbManv.UseVisualStyleBackColor = true;
            // 
            // dgvNguoidung
            // 
            this.dgvNguoidung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNguoidung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguoidung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tendangnhap,
            this.matkhau,
            this.quyen});
            this.dgvNguoidung.Location = new System.Drawing.Point(379, 31);
            this.dgvNguoidung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNguoidung.Name = "dgvNguoidung";
            this.dgvNguoidung.RowHeadersWidth = 62;
            this.dgvNguoidung.RowTemplate.Height = 28;
            this.dgvNguoidung.Size = new System.Drawing.Size(613, 382);
            this.dgvNguoidung.TabIndex = 34;
            this.dgvNguoidung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNguoidung_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "manguoidung";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 60;
            // 
            // tendangnhap
            // 
            this.tendangnhap.DataPropertyName = "tendangnhap";
            this.tendangnhap.HeaderText = "Tên đăng nhập";
            this.tendangnhap.MinimumWidth = 8;
            this.tendangnhap.Name = "tendangnhap";
            this.tendangnhap.Width = 125;
            // 
            // matkhau
            // 
            this.matkhau.DataPropertyName = "matkhau";
            this.matkhau.HeaderText = "Mật khẩu";
            this.matkhau.MinimumWidth = 8;
            this.matkhau.Name = "matkhau";
            this.matkhau.Width = 130;
            // 
            // quyen
            // 
            this.quyen.DataPropertyName = "quyen";
            this.quyen.HeaderText = "Quyền";
            this.quyen.MinimumWidth = 8;
            this.quyen.Name = "quyen";
            this.quyen.Width = 60;
            // 
            // cbQuyen
            // 
            this.cbQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuyen.FormattingEnabled = true;
            this.cbQuyen.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cbQuyen.Location = new System.Drawing.Point(158, 205);
            this.cbQuyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbQuyen.Name = "cbQuyen";
            this.cbQuyen.Size = new System.Drawing.Size(160, 26);
            this.cbQuyen.TabIndex = 27;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimkiem.FlatAppearance.BorderSize = 0;
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTimkiem.Location = new System.Drawing.Point(32, 422);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnTimkiem.Size = new System.Drawing.Size(279, 39);
            this.btnTimkiem.TabIndex = 33;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(780, 434);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnXoa.Size = new System.Drawing.Size(84, 78);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(648, 434);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnSua.Size = new System.Drawing.Size(84, 78);
            this.btnSua.TabIndex = 30;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(516, 434);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnThem.Size = new System.Drawing.Size(84, 78);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(158, 35);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(160, 24);
            this.txtId.TabIndex = 23;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatkhau.Location = new System.Drawing.Point(158, 146);
            this.txtMatkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(160, 24);
            this.txtMatkhau.TabIndex = 26;
            // 
            // txtTendangnhap
            // 
            this.txtTendangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTendangnhap.Location = new System.Drawing.Point(158, 87);
            this.txtTendangnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTendangnhap.Name = "txtTendangnhap";
            this.txtTendangnhap.Size = new System.Drawing.Size(160, 24);
            this.txtTendangnhap.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 18);
            this.label8.TabIndex = 35;
            this.label8.Text = "Quyền";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(36, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 18);
            this.label12.TabIndex = 39;
            this.label12.Text = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 18);
            this.label9.TabIndex = 36;
            this.label9.Text = "Mật khẩu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 18);
            this.label10.TabIndex = 37;
            this.label10.Text = "Tên đăng nhập";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.Location = new System.Drawing.Point(0, 69);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(279, 24);
            this.txtTimkiem.TabIndex = 27;
            // 
            // FrmQuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 555);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvNguoidung);
            this.Controls.Add(this.cbQuyen);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.txtTendangnhap);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Name = "FrmQuanLyNguoiDung";
            this.Text = "FrmQuanLyNguoiDung";
            this.Load += new System.EventHandler(this.FrmQuanLyNguoiDung_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoidung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTendangnhap;
        private System.Windows.Forms.RadioButton rbManv;
        private System.Windows.Forms.DataGridView dgvNguoidung;
        private System.Windows.Forms.ComboBox cbQuyen;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtTendangnhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendangnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn matkhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn quyen;
        private System.Windows.Forms.TextBox txtTimkiem;
    }
}