using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKyTucXa_main
{
    partial class FrmQuanLyPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyPhong));
            this.panelChucNang = new System.Windows.Forms.Panel();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnCapnhap = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.sosvtoida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xeploai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTktheoma = new System.Windows.Forms.RadioButton();
            this.rbTkTheoMaday = new System.Windows.Forms.RadioButton();
            this.rbTktheoten = new System.Windows.Forms.RadioButton();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.sosv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbXeploai = new System.Windows.Forms.ComboBox();
            this.cbLoaiphong = new System.Windows.Forms.ComboBox();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.txtSosvtoida = new System.Windows.Forms.TextBox();
            this.txtTinhtrang = new System.Windows.Forms.TextBox();
            this.txtSosvhientai = new System.Windows.Forms.TextBox();
            this.txtTenphong = new System.Windows.Forms.TextBox();
            this.txtMaphong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnToggleChatBot = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnThem = new System.Windows.Forms.Button();
            this.chatBotControl1 = new QuanLyKyTucXa_main.ChatBotControl();
            this.panelChucNang.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChucNang
            // 
            this.panelChucNang.Controls.Add(this.btnCapnhat);
            this.panelChucNang.Controls.Add(this.btnThem);
            this.panelChucNang.Controls.Add(this.btnCapnhap);
            this.panelChucNang.Controls.Add(this.btnXoa);
            this.panelChucNang.Location = new System.Drawing.Point(31, 207);
            this.panelChucNang.Name = "panelChucNang";
            this.panelChucNang.Size = new System.Drawing.Size(500, 60);
            this.panelChucNang.TabIndex = 46;
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.FlatAppearance.BorderSize = 0;
            this.btnCapnhat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCapnhat.Location = new System.Drawing.Point(394, 0);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnCapnhat.Size = new System.Drawing.Size(60, 60);
            this.btnCapnhat.TabIndex = 40;
            this.btnCapnhat.Text = "Làm mới";
            this.btnCapnhat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnCapnhap
            // 
            this.btnCapnhap.FlatAppearance.BorderSize = 0;
            this.btnCapnhap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCapnhap.Location = new System.Drawing.Point(154, 0);
            this.btnCapnhap.Name = "btnCapnhap";
            this.btnCapnhap.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnCapnhap.Size = new System.Drawing.Size(62, 60);
            this.btnCapnhap.TabIndex = 38;
            this.btnCapnhap.Text = "Cập nhập";
            this.btnCapnhap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCapnhap.UseVisualStyleBackColor = true;
            this.btnCapnhap.Click += new System.EventHandler(this.btnCapnhap_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(274, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnXoa.Size = new System.Drawing.Size(60, 60);
            this.btnXoa.TabIndex = 39;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // sosvtoida
            // 
            this.sosvtoida.DataPropertyName = "sosvtoida";
            this.sosvtoida.HeaderText = "Số sinh viên tối đa";
            this.sosvtoida.MinimumWidth = 8;
            this.sosvtoida.Name = "sosvtoida";
            // 
            // tinhtrang
            // 
            this.tinhtrang.DataPropertyName = "tinhtrang";
            this.tinhtrang.HeaderText = "Tình trạng";
            this.tinhtrang.MinimumWidth = 8;
            this.tinhtrang.Name = "tinhtrang";
            this.tinhtrang.Width = 150;
            // 
            // loaiphong
            // 
            this.loaiphong.DataPropertyName = "loaiphong";
            this.loaiphong.HeaderText = "Loại phòng";
            this.loaiphong.MinimumWidth = 8;
            this.loaiphong.Name = "loaiphong";
            // 
            // xeploai
            // 
            this.xeploai.DataPropertyName = "xeploai";
            this.xeploai.HeaderText = "Xếp loại";
            this.xeploai.MinimumWidth = 8;
            this.xeploai.Name = "xeploai";
            // 
            // day
            // 
            this.day.DataPropertyName = "day";
            this.day.HeaderText = "Dãy";
            this.day.MinimumWidth = 8;
            this.day.Name = "day";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbTktheoma);
            this.groupBox1.Controls.Add(this.rbTkTheoMaday);
            this.groupBox1.Controls.Add(this.rbTktheoten);
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTimkiem);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox1.Location = new System.Drawing.Point(593, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 179);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm phòng";
            // 
            // rbTktheoma
            // 
            this.rbTktheoma.AutoSize = true;
            this.rbTktheoma.Location = new System.Drawing.Point(11, 14);
            this.rbTktheoma.Name = "rbTktheoma";
            this.rbTktheoma.Size = new System.Drawing.Size(121, 19);
            this.rbTktheoma.TabIndex = 0;
            this.rbTktheoma.TabStop = true;
            this.rbTktheoma.Text = "Tìm kiếm theo mã";
            this.rbTktheoma.UseVisualStyleBackColor = true;
            // 
            // rbTkTheoMaday
            // 
            this.rbTkTheoMaday.AutoSize = true;
            this.rbTkTheoMaday.Location = new System.Drawing.Point(12, 60);
            this.rbTkTheoMaday.Name = "rbTkTheoMaday";
            this.rbTkTheoMaday.Size = new System.Drawing.Size(143, 19);
            this.rbTkTheoMaday.TabIndex = 1;
            this.rbTkTheoMaday.TabStop = true;
            this.rbTkTheoMaday.Text = "Tìm kiếm theo mã dãy";
            this.rbTkTheoMaday.UseVisualStyleBackColor = true;
            // 
            // rbTktheoten
            // 
            this.rbTktheoten.AutoSize = true;
            this.rbTktheoten.Location = new System.Drawing.Point(12, 37);
            this.rbTktheoten.Name = "rbTktheoten";
            this.rbTktheoten.Size = new System.Drawing.Size(121, 19);
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
            this.btnTimkiem.Location = new System.Drawing.Point(11, 131);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnTimkiem.Size = new System.Drawing.Size(130, 37);
            this.btnTimkiem.TabIndex = 3;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Nhập thông tin tìm kiếm:";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.Location = new System.Drawing.Point(11, 104);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(130, 21);
            this.txtTimkiem.TabIndex = 2;
            // 
            // sosv
            // 
            this.sosv.DataPropertyName = "sosv";
            this.sosv.HeaderText = "Số sinh viên hiện tại";
            this.sosv.MinimumWidth = 8;
            this.sosv.Name = "sosv";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(600, 250);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(138, 17);
            this.checkBox1.TabIndex = 43;
            this.checkBox1.Text = "Danh sách phòng trống";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tenphong
            // 
            this.tenphong.DataPropertyName = "tenphong";
            this.tenphong.HeaderText = "Tên phòng";
            this.tenphong.MinimumWidth = 8;
            this.tenphong.Name = "tenphong";
            // 
            // dgvPhong
            // 
            this.dgvPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphong,
            this.tenphong,
            this.sosv,
            this.sosvtoida,
            this.tinhtrang,
            this.loaiphong,
            this.xeploai,
            this.day});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhong.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPhong.EnableHeadersVisualStyles = false;
            this.dgvPhong.Location = new System.Drawing.Point(31, 280);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersVisible = false;
            this.dgvPhong.RowHeadersWidth = 62;
            this.dgvPhong.RowTemplate.Height = 28;
            this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhong.Size = new System.Drawing.Size(720, 163);
            this.dgvPhong.TabIndex = 42;
            this.dgvPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellClick);
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "maphong";
            this.maphong.HeaderText = "Mã phòng";
            this.maphong.MinimumWidth = 8;
            this.maphong.Name = "maphong";
            // 
            // cbXeploai
            // 
            this.cbXeploai.FormattingEnabled = true;
            this.cbXeploai.Items.AddRange(new object[] {
            "Vip",
            "Thường"});
            this.cbXeploai.Location = new System.Drawing.Point(424, 111);
            this.cbXeploai.Name = "cbXeploai";
            this.cbXeploai.Size = new System.Drawing.Size(129, 21);
            this.cbXeploai.TabIndex = 35;
            // 
            // cbLoaiphong
            // 
            this.cbLoaiphong.FormattingEnabled = true;
            this.cbLoaiphong.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbLoaiphong.Location = new System.Drawing.Point(424, 66);
            this.cbLoaiphong.Name = "cbLoaiphong";
            this.cbLoaiphong.Size = new System.Drawing.Size(129, 21);
            this.cbLoaiphong.TabIndex = 34;
            // 
            // cbDay
            // 
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Location = new System.Drawing.Point(424, 158);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(129, 21);
            this.cbDay.TabIndex = 36;
            // 
            // txtSosvtoida
            // 
            this.txtSosvtoida.Location = new System.Drawing.Point(151, 156);
            this.txtSosvtoida.Name = "txtSosvtoida";
            this.txtSosvtoida.Size = new System.Drawing.Size(129, 20);
            this.txtSosvtoida.TabIndex = 32;
            // 
            // txtTinhtrang
            // 
            this.txtTinhtrang.Enabled = false;
            this.txtTinhtrang.Location = new System.Drawing.Point(424, 24);
            this.txtTinhtrang.Name = "txtTinhtrang";
            this.txtTinhtrang.Size = new System.Drawing.Size(129, 20);
            this.txtTinhtrang.TabIndex = 33;
            // 
            // txtSosvhientai
            // 
            this.txtSosvhientai.Enabled = false;
            this.txtSosvhientai.Location = new System.Drawing.Point(151, 112);
            this.txtSosvhientai.Name = "txtSosvhientai";
            this.txtSosvhientai.Size = new System.Drawing.Size(129, 20);
            this.txtSosvhientai.TabIndex = 31;
            // 
            // txtTenphong
            // 
            this.txtTenphong.Location = new System.Drawing.Point(151, 68);
            this.txtTenphong.Name = "txtTenphong";
            this.txtTenphong.Size = new System.Drawing.Size(129, 20);
            this.txtTenphong.TabIndex = 30;
            // 
            // txtMaphong
            // 
            this.txtMaphong.Location = new System.Drawing.Point(151, 24);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Size = new System.Drawing.Size(129, 20);
            this.txtMaphong.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(343, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Dãy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(343, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Xếp loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(343, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tình trạng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(343, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Loại phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Số sinh viên tối đa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Số sinh viên hiện tại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tên phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã phòng";
            // 
            // btnToggleChatBot
            // 
            this.btnToggleChatBot.BackColor = System.Drawing.SystemColors.Control;
            this.btnToggleChatBot.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnToggleChatBot.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnToggleChatBot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToggleChatBot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnToggleChatBot.FillColor = System.Drawing.Color.Transparent;
            this.btnToggleChatBot.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnToggleChatBot.ForeColor = System.Drawing.SystemColors.Control;
            this.btnToggleChatBot.Image = global::QuanLyKyTucXa_main.Properties.Resources.chat_box;
            this.btnToggleChatBot.ImageSize = new System.Drawing.Size(50, 50);
            this.btnToggleChatBot.Location = new System.Drawing.Point(699, 481);
            this.btnToggleChatBot.Name = "btnToggleChatBot";
            this.btnToggleChatBot.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnToggleChatBot.Size = new System.Drawing.Size(52, 50);
            this.btnToggleChatBot.TabIndex = 50;
            this.btnToggleChatBot.Click += new System.EventHandler(this.btnToggleChatBot_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(34, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnThem.Size = new System.Drawing.Size(60, 60);
            this.btnThem.TabIndex = 37;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // chatBotControl1
            // 
            this.chatBotControl1.BackColor = System.Drawing.Color.White;
            this.chatBotControl1.Location = new System.Drawing.Point(515, 185);
            this.chatBotControl1.Name = "chatBotControl1";
            this.chatBotControl1.Size = new System.Drawing.Size(240, 293);
            this.chatBotControl1.TabIndex = 51;
            // 
            // FrmQuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 543);
            this.Controls.Add(this.chatBotControl1);
            this.Controls.Add(this.btnToggleChatBot);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.cbXeploai);
            this.Controls.Add(this.cbLoaiphong);
            this.Controls.Add(this.cbDay);
            this.Controls.Add(this.txtSosvtoida);
            this.Controls.Add(this.txtTinhtrang);
            this.Controls.Add(this.txtSosvhientai);
            this.Controls.Add(this.txtTenphong);
            this.Controls.Add(this.txtMaphong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelChucNang);
            this.Name = "FrmQuanLyPhong";
            this.Text = "FrmQuanLyPhong";
            this.Load += new System.EventHandler(this.FrmQuanLyPhong_Load);
            this.panelChucNang.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn sosvtoida;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn xeploai;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTktheoma;
        private System.Windows.Forms.RadioButton rbTkTheoMaday;
        private System.Windows.Forms.RadioButton rbTktheoten;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn sosv;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenphong;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.ComboBox cbXeploai;
        private System.Windows.Forms.ComboBox cbLoaiphong;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.TextBox txtSosvtoida;
        private System.Windows.Forms.TextBox txtTinhtrang;
        private System.Windows.Forms.TextBox txtSosvhientai;
        private System.Windows.Forms.TextBox txtTenphong;
        private System.Windows.Forms.TextBox txtMaphong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Panel panelChucNang;
        private Guna.UI2.WinForms.Guna2CircleButton btnToggleChatBot;
        private ChatBotControl chatBotControl1;
        // private ChatBotControl chatBotControl1;
    }
}