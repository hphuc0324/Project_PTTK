using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTK_Project
{
    public partial class DoanhNghiep_TongHop : Form
    {
        private string MaDoiTac = "";
        public DoanhNghiep_TongHop(string maDoiTac ="1222")
        {
            InitializeComponent();

            this.MaDoiTac = maDoiTac;
        }

        private void btn_dangKyTuyenDung_Click(object sender, EventArgs e)
        {
            DoanhNghiep_DangTuyenDung form = new DoanhNghiep_DangTuyenDung();

            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btn_xemHoaDon_Click(object sender, EventArgs e)
        {
            DoanhNghiep_DanhSachThanhToan form = new DoanhNghiep_DanhSachThanhToan(this.MaDoiTac);

            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btn_xemDsDangTuyen_Click(object sender, EventArgs e)
        {
            DoanhNghiep_DanhSachTuyenDung form = new DoanhNghiep_DanhSachTuyenDung(this.MaDoiTac);
            
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btn_xemDsUngVien_Click(object sender, EventArgs e)
        {
            DoanhNghiep_DanhSachUngVien form = new DoanhNghiep_DanhSachUngVien(this.MaDoiTac);

            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btn_dangXuat_Click(object sender, EventArgs e)
        {
            //Ve trang dang nhap
        }
    }
}
