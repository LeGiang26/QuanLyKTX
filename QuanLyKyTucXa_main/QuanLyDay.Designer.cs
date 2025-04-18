namespace QuanLyKyTucXa_main
{
    partial class FrmQuanLyDay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyDay));
            this.cbQuanly = new System.Windows.Forms.ComboBox();
            this.txtTenday = new System.Windows.Forms.TextBox();
            this.txtTrangthai = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quanly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDay = new System.Windows.Forms.DataGridView();
            this.txtMaday = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDay)).BeginInit();
            this.SuspendLayout();
            // 
            // cbQuanly
            // 
            this.cbQuanly.FormattingEnabled = true;
            this.cbQuanly.Location = new System.Drawing.Point(174, 219);
            this.cbQuanly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbQuanly.Name = "cbQuanly";
            this.cbQuanly.Size = new System.Drawing.Size(163, 24);
            this.cbQuanly.TabIndex = 23;
            // 
            // txtTenday
            // 
            this.txtTenday.Location = new System.Drawing.Point(174, 153);
            this.txtTenday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenday.Name = "txtTenday";
            this.txtTenday.Size = new System.Drawing.Size(163, 22);
            this.txtTenday.TabIndex = 22;
            // 
            // txtTrangthai
            // 
            this.txtTrangthai.Location = new System.Drawing.Point(174, 287);
            this.txtTrangthai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTrangthai.Name = "txtTrangthai";
            this.txtTrangthai.Size = new System.Drawing.Size(163, 22);
            this.txtTrangthai.TabIndex = 24;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(485, 390);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnThem.Size = new System.Drawing.Size(80, 74);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Quản lý";
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.MinimumWidth = 8;
            this.trangthai.Name = "trangthai";
            this.trangthai.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Tên dãy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Mã dãy";
            // 
            // quanly
            // 
            this.quanly.DataPropertyName = "quanly";
            this.quanly.HeaderText = "Quản lý";
            this.quanly.MinimumWidth = 8;
            this.quanly.Name = "quanly";
            this.quanly.Width = 125;
            // 
            // tenday
            // 
            this.tenday.DataPropertyName = "tenday";
            this.tenday.HeaderText = "Tên dãy";
            this.tenday.MinimumWidth = 8;
            this.tenday.Name = "tenday";
            this.tenday.Width = 125;
            // 
            // maday
            // 
            this.maday.DataPropertyName = "maday";
            this.maday.HeaderText = "Mã dãy";
            this.maday.MinimumWidth = 8;
            this.maday.Name = "maday";
            this.maday.Width = 125;
            // 
            // dgvDay
            // 
            this.dgvDay.AllowUserToAddRows = false;
            this.dgvDay.AllowUserToDeleteRows = false;
            this.dgvDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maday,
            this.tenday,
            this.quanly,
            this.trangthai});
            this.dgvDay.Location = new System.Drawing.Point(382, 86);
            this.dgvDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDay.Name = "dgvDay";
            this.dgvDay.RowHeadersWidth = 62;
            this.dgvDay.RowTemplate.Height = 28;
            this.dgvDay.Size = new System.Drawing.Size(587, 279);
            this.dgvDay.TabIndex = 29;
            this.dgvDay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDay_CellClick);
            // 
            // txtMaday
            // 
            this.txtMaday.Location = new System.Drawing.Point(174, 86);
            this.txtMaday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaday.Name = "txtMaday";
            this.txtMaday.Size = new System.Drawing.Size(163, 22);
            this.txtMaday.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Trạng thái";
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(615, 390);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnSua.Size = new System.Drawing.Size(80, 74);
            this.btnSua.TabIndex = 34;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(743, 390);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnXoa.Size = new System.Drawing.Size(80, 74);
            this.btnXoa.TabIndex = 35;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // FrmQuanLyDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 550);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.cbQuanly);
            this.Controls.Add(this.txtTenday);
            this.Controls.Add(this.txtTrangthai);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDay);
            this.Controls.Add(this.txtMaday);
            this.Controls.Add(this.label4);
            this.Name = "FrmQuanLyDay";
            this.Text = "QuanLyDay";
            this.Load += new System.EventHandler(this.FrmQuanLyDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbQuanly;
        private System.Windows.Forms.TextBox txtTenday;
        private System.Windows.Forms.TextBox txtTrangthai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn quanly;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenday;
        private System.Windows.Forms.DataGridViewTextBoxColumn maday;
        private System.Windows.Forms.DataGridView dgvDay;
        private System.Windows.Forms.TextBox txtMaday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
    }
}