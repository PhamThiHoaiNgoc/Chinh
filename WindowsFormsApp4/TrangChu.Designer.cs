﻿namespace BTN
{
    partial class TrangChu
    {
        private System.ComponentModel.IContainer components = null;

      
        // Dọn dẹp tài nguyên được sử dụng
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Phương thức khởi tạo giao diện
        private void InitializeComponent()
        {
            this.labelTieude = new System.Windows.Forms.Label();
            this.btnQLKH = new System.Windows.Forms.Button();
            this.btnQLDU = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnCTUD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTieude
            // 
            this.labelTieude.AutoSize = true;
            this.labelTieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTieude.Location = new System.Drawing.Point(43, 31);
            this.labelTieude.Name = "labelTieude";
            this.labelTieude.Size = new System.Drawing.Size(199, 20);
            this.labelTieude.TabIndex = 0;
            this.labelTieude.Text = "CHÀO MỪNG QUẢN LÝ";
            // 
            // btnQLKH
            // 
            this.btnQLKH.Location = new System.Drawing.Point(64, 92);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Size = new System.Drawing.Size(95, 61);
            this.btnQLKH.TabIndex = 1;
            this.btnQLKH.Text = "QL Khách Hàng";
            this.btnQLKH.UseVisualStyleBackColor = true;
            this.btnQLKH.Click += new System.EventHandler(this.btnQLKH_Click);
            // 
            // btnQLDU
            // 
            this.btnQLDU.Location = new System.Drawing.Point(226, 92);
            this.btnQLDU.Name = "btnQLDU";
            this.btnQLDU.Size = new System.Drawing.Size(95, 61);
            this.btnQLDU.TabIndex = 2;
            this.btnQLDU.Text = "QL Đồ Uống";
            this.btnQLDU.UseVisualStyleBackColor = true;
            this.btnQLDU.Click += new System.EventHandler(this.btnQLDU_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(381, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 61);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(64, 210);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 61);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(226, 210);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 61);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnCTUD
            // 
            this.btnCTUD.Location = new System.Drawing.Point(381, 210);
            this.btnCTUD.Name = "btnCTUD";
            this.btnCTUD.Size = new System.Drawing.Size(95, 61);
            this.btnCTUD.TabIndex = 6;
            this.btnCTUD.Text = "QL Chương Trình Ưu Đãi";
            this.btnCTUD.UseVisualStyleBackColor = true;
            this.btnCTUD.Click += new System.EventHandler(this.btnCTUD_Click);
            // 
            // TrangChu
            // 
            this.ClientSize = new System.Drawing.Size(567, 357);
            this.Controls.Add(this.btnCTUD);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnQLDU);
            this.Controls.Add(this.btnQLKH);
            this.Controls.Add(this.labelTieude);
            this.Name = "TrangChu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label Tieude;
        private System.Windows.Forms.Button btQLKH;
        private System.Windows.Forms.Button btQLDU;
        private System.Windows.Forms.Button btQLHD;
        private System.Windows.Forms.Button btQLCT;
        private System.Windows.Forms.Button btTK;
        private System.Windows.Forms.Label labelTieude;
        private System.Windows.Forms.Button btnQLKH;
        private System.Windows.Forms.Button btnQLDU;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnCTUD;
    }
}
