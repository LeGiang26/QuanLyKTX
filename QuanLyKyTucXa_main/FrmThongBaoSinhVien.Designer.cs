namespace QuanLyKyTucXa_main
{
    partial class FrmThongBaoSinhVien
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
            this.btnGuimail = new System.Windows.Forms.Button();
            this.txtNoidungThongbao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGuimail
            // 
            this.btnGuimail.Location = new System.Drawing.Point(742, 373);
            this.btnGuimail.Name = "btnGuimail";
            this.btnGuimail.Size = new System.Drawing.Size(120, 40);
            this.btnGuimail.TabIndex = 2;
            this.btnGuimail.Text = "Gửi mail";
            this.btnGuimail.UseVisualStyleBackColor = true;
            this.btnGuimail.Click += new System.EventHandler(this.btnGuimail_Click);
            // 
            // txtNoidungThongbao
            // 
            this.txtNoidungThongbao.AllowDrop = true;
            this.txtNoidungThongbao.Location = new System.Drawing.Point(23, 36);
            this.txtNoidungThongbao.Multiline = true;
            this.txtNoidungThongbao.Name = "txtNoidungThongbao";
            this.txtNoidungThongbao.Size = new System.Drawing.Size(839, 314);
            this.txtNoidungThongbao.TabIndex = 3;
            // 
            // FrmThongBaoSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 447);
            this.Controls.Add(this.txtNoidungThongbao);
            this.Controls.Add(this.btnGuimail);
            this.Name = "FrmThongBaoSinhVien";
            this.Text = "FrmThongBaoSinhVien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuimail;
        private System.Windows.Forms.TextBox txtNoidungThongbao;
    }
}