namespace PTTK_Project
{
    partial class DoanhNghiep_TongHop
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
            this.btn_dangKyTuyenDung = new System.Windows.Forms.Button();
            this.btn_xemDsDangTuyen = new System.Windows.Forms.Button();
            this.btn_xemHoaDon = new System.Windows.Forms.Button();
            this.btn_dangXuat = new System.Windows.Forms.Button();
            this.btn_xemDsUngVien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách chức năng cho Doanh nghiệp";
            // 
            // btn_dangKyTuyenDung
            // 
            this.btn_dangKyTuyenDung.Location = new System.Drawing.Point(191, 131);
            this.btn_dangKyTuyenDung.Name = "btn_dangKyTuyenDung";
            this.btn_dangKyTuyenDung.Size = new System.Drawing.Size(205, 68);
            this.btn_dangKyTuyenDung.TabIndex = 1;
            this.btn_dangKyTuyenDung.Text = "Đăng ký tuyển dụng";
            this.btn_dangKyTuyenDung.UseVisualStyleBackColor = true;
            this.btn_dangKyTuyenDung.Click += new System.EventHandler(this.btn_dangKyTuyenDung_Click);
            // 
            // btn_xemDsDangTuyen
            // 
            this.btn_xemDsDangTuyen.Location = new System.Drawing.Point(191, 266);
            this.btn_xemDsDangTuyen.Name = "btn_xemDsDangTuyen";
            this.btn_xemDsDangTuyen.Size = new System.Drawing.Size(205, 68);
            this.btn_xemDsDangTuyen.TabIndex = 2;
            this.btn_xemDsDangTuyen.Text = "Xem danh sách tuyển dụng";
            this.btn_xemDsDangTuyen.UseVisualStyleBackColor = true;
            this.btn_xemDsDangTuyen.Click += new System.EventHandler(this.btn_xemDsDangTuyen_Click);
            // 
            // btn_xemHoaDon
            // 
            this.btn_xemHoaDon.Location = new System.Drawing.Point(505, 131);
            this.btn_xemHoaDon.Name = "btn_xemHoaDon";
            this.btn_xemHoaDon.Size = new System.Drawing.Size(205, 68);
            this.btn_xemHoaDon.TabIndex = 3;
            this.btn_xemHoaDon.Text = "Xem hóa đơn";
            this.btn_xemHoaDon.UseVisualStyleBackColor = true;
            this.btn_xemHoaDon.Click += new System.EventHandler(this.btn_xemHoaDon_Click);
            // 
            // btn_dangXuat
            // 
            this.btn_dangXuat.Location = new System.Drawing.Point(714, 379);
            this.btn_dangXuat.Name = "btn_dangXuat";
            this.btn_dangXuat.Size = new System.Drawing.Size(139, 46);
            this.btn_dangXuat.TabIndex = 4;
            this.btn_dangXuat.Text = "Đăng xuất";
            this.btn_dangXuat.UseVisualStyleBackColor = true;
            this.btn_dangXuat.Click += new System.EventHandler(this.btn_dangXuat_Click);
            // 
            // btn_xemDsUngVien
            // 
            this.btn_xemDsUngVien.Location = new System.Drawing.Point(505, 266);
            this.btn_xemDsUngVien.Name = "btn_xemDsUngVien";
            this.btn_xemDsUngVien.Size = new System.Drawing.Size(205, 68);
            this.btn_xemDsUngVien.TabIndex = 5;
            this.btn_xemDsUngVien.Text = "Xem danh sách ứng tuyển";
            this.btn_xemDsUngVien.UseVisualStyleBackColor = true;
            this.btn_xemDsUngVien.Click += new System.EventHandler(this.btn_xemDsUngVien_Click);
            // 
            // DoanhNghiep_TongHop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 437);
            this.Controls.Add(this.btn_xemDsUngVien);
            this.Controls.Add(this.btn_dangXuat);
            this.Controls.Add(this.btn_xemHoaDon);
            this.Controls.Add(this.btn_xemDsDangTuyen);
            this.Controls.Add(this.btn_dangKyTuyenDung);
            this.Controls.Add(this.label1);
            this.Name = "DoanhNghiep_TongHop";
            this.Text = "DoanhNghiep_TongHop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_dangKyTuyenDung;
        private System.Windows.Forms.Button btn_xemDsDangTuyen;
        private System.Windows.Forms.Button btn_xemHoaDon;
        private System.Windows.Forms.Button btn_dangXuat;
        private System.Windows.Forms.Button btn_xemDsUngVien;
    }
}