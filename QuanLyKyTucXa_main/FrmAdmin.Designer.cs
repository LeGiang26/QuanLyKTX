namespace QuanLyKyTucXa_main
{
    partial class FrmAdmin
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
            this.btnThanhtoanluong = new System.Windows.Forms.Button();
            this.btnQuanLyNhanVien = new System.Windows.Forms.Button();
            this.btnQuanLyDay = new System.Windows.Forms.Button();
            this.btnDanhSachPhong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThanhtoanluong
            // 
            this.btnThanhtoanluong.Location = new System.Drawing.Point(529, 346);
            this.btnThanhtoanluong.Name = "btnThanhtoanluong";
            this.btnThanhtoanluong.Size = new System.Drawing.Size(157, 71);
            this.btnThanhtoanluong.TabIndex = 9;
            this.btnThanhtoanluong.Text = "Thanh toán lương nhân viên";
            this.btnThanhtoanluong.UseVisualStyleBackColor = true;
            // 
            // btnQuanLyNhanVien
            // 
            this.btnQuanLyNhanVien.Location = new System.Drawing.Point(177, 346);
            this.btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            this.btnQuanLyNhanVien.Size = new System.Drawing.Size(157, 71);
            this.btnQuanLyNhanVien.TabIndex = 8;
            this.btnQuanLyNhanVien.Text = "Quản Lý Nhân Viên";
            this.btnQuanLyNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnQuanLyDay
            // 
            this.btnQuanLyDay.Location = new System.Drawing.Point(334, 244);
            this.btnQuanLyDay.Name = "btnQuanLyDay";
            this.btnQuanLyDay.Size = new System.Drawing.Size(157, 71);
            this.btnQuanLyDay.TabIndex = 7;
            this.btnQuanLyDay.Text = "Quản lý dãy";
            this.btnQuanLyDay.UseVisualStyleBackColor = true;
            // 
            // btnDanhSachPhong
            // 
            this.btnDanhSachPhong.Location = new System.Drawing.Point(542, 96);
            this.btnDanhSachPhong.Name = "btnDanhSachPhong";
            this.btnDanhSachPhong.Size = new System.Drawing.Size(157, 71);
            this.btnDanhSachPhong.TabIndex = 6;
            this.btnDanhSachPhong.Text = "Danh Sách Phòng";
            this.btnDanhSachPhong.UseVisualStyleBackColor = true;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 512);
            this.Controls.Add(this.btnThanhtoanluong);
            this.Controls.Add(this.btnQuanLyNhanVien);
            this.Controls.Add(this.btnQuanLyDay);
            this.Controls.Add(this.btnDanhSachPhong);
            this.Name = "FrmAdmin";
            this.Text = "FrmAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThanhtoanluong;
        private System.Windows.Forms.Button btnQuanLyNhanVien;
        private System.Windows.Forms.Button btnQuanLyDay;
        private System.Windows.Forms.Button btnDanhSachPhong;
    }
}