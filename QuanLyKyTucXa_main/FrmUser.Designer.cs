namespace QuanLyKyTucXa_main
{
    partial class FrmUser
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
            this.btnDangkyphong = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDangkyphong
            // 
            this.btnDangkyphong.Location = new System.Drawing.Point(123, 85);
            this.btnDangkyphong.Name = "btnDangkyphong";
            this.btnDangkyphong.Size = new System.Drawing.Size(171, 60);
            this.btnDangkyphong.TabIndex = 0;
            this.btnDangkyphong.Text = "Đăng Ký Phòng";
            this.btnDangkyphong.UseVisualStyleBackColor = true;
            this.btnDangkyphong.Click += new System.EventHandler(this.btnDangkyphong_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "Yêu cầu sửa chửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 487);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDangkyphong);
            this.Name = "FrmUser";
            this.Text = "FrmUser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDangkyphong;
        private System.Windows.Forms.Button button2;
    }
}