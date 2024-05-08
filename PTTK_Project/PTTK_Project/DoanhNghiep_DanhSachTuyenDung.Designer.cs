namespace PTTK_Project
{
    partial class DoanhNghiep_DanhSachTuyenDung
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
            this.dgv_danhSachDangTuyen = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_maPhieu = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hinhThuc = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_xemUngVien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhSachDangTuyen)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách Đăng ký tuyển dụng";
            // 
            // dgv_danhSachDangTuyen
            // 
            this.dgv_danhSachDangTuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhSachDangTuyen.Location = new System.Drawing.Point(12, 92);
            this.dgv_danhSachDangTuyen.Name = "dgv_danhSachDangTuyen";
            this.dgv_danhSachDangTuyen.RowHeadersWidth = 62;
            this.dgv_danhSachDangTuyen.RowTemplate.Height = 28;
            this.dgv_danhSachDangTuyen.Size = new System.Drawing.Size(524, 407);
            this.dgv_danhSachDangTuyen.TabIndex = 1;
            this.dgv_danhSachDangTuyen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhSachDangTuyen_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(625, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phiếu Đăng tuyển";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Phiếu";
            // 
            // txt_maPhieu
            // 
            this.txt_maPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maPhieu.Location = new System.Drawing.Point(118, 34);
            this.txt_maPhieu.Name = "txt_maPhieu";
            this.txt_maPhieu.Size = new System.Drawing.Size(150, 30);
            this.txt_maPhieu.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_maPhieu);
            this.panel1.Location = new System.Drawing.Point(546, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 100);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_hinhThuc);
            this.panel2.Location = new System.Drawing.Point(546, 245);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 100);
            this.panel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hình thức";
            // 
            // txt_hinhThuc
            // 
            this.txt_hinhThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hinhThuc.Location = new System.Drawing.Point(118, 34);
            this.txt_hinhThuc.Name = "txt_hinhThuc";
            this.txt_hinhThuc.Size = new System.Drawing.Size(150, 30);
            this.txt_hinhThuc.TabIndex = 4;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(757, 388);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(142, 62);
            this.btn_back.TabIndex = 7;
            this.btn_back.Text = "Trở lại";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_xemUngVien
            // 
            this.btn_xemUngVien.Location = new System.Drawing.Point(546, 388);
            this.btn_xemUngVien.Name = "btn_xemUngVien";
            this.btn_xemUngVien.Size = new System.Drawing.Size(142, 62);
            this.btn_xemUngVien.TabIndex = 9;
            this.btn_xemUngVien.Text = "Xem Danh sách ứng viên";
            this.btn_xemUngVien.UseVisualStyleBackColor = true;
            this.btn_xemUngVien.Click += new System.EventHandler(this.btn_xemUngVien_Click);
            // 
            // DoanhNghiep_DanhSachTuyenDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 634);
            this.Controls.Add(this.btn_xemUngVien);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_danhSachDangTuyen);
            this.Controls.Add(this.label1);
            this.Name = "DoanhNghiep_DanhSachTuyenDung";
            this.Text = "DoanhNghiep_DanhSachTuyenDung";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhSachDangTuyen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_danhSachDangTuyen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_maPhieu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_hinhThuc;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_xemUngVien;
    }
}