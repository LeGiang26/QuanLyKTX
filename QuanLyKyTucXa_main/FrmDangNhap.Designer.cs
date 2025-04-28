namespace QuanLyKyTucXa_main
{
    partial class FrmDangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtTaikhoan = new System.Windows.Forms.TextBox();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.cbQuyen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDangky = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu";
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatkhau.Location = new System.Drawing.Point(104, 279);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(306, 27);
            this.txtMatkhau.TabIndex = 3;
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaikhoan.Location = new System.Drawing.Point(100, 202);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(306, 27);
            this.txtTaikhoan.TabIndex = 4;
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangnhap.Location = new System.Drawing.Point(104, 339);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(306, 45);
            this.btnDangnhap.TabIndex = 5;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = true;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // cbQuyen
            // 
            this.cbQuyen.FormattingEnabled = true;
            this.cbQuyen.Location = new System.Drawing.Point(100, 130);
            this.cbQuyen.Name = "cbQuyen";
            this.cbQuyen.Size = new System.Drawing.Size(306, 24);
            this.cbQuyen.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quyền";
            // 
            // btnDangky
            // 
            this.btnDangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangky.Location = new System.Drawing.Point(249, 402);
            this.btnDangky.Name = "btnDangky";
            this.btnDangky.Size = new System.Drawing.Size(157, 43);
            this.btnDangky.TabIndex = 9;
            this.btnDangky.Text = "Đăng ký";
            this.btnDangky.UseVisualStyleBackColor = true;
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 467);
            this.Controls.Add(this.btnDangky);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbQuyen);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.txtTaikhoan);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDangNhap";
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtTaikhoan;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.ComboBox cbQuyen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDangky;
    }
}

