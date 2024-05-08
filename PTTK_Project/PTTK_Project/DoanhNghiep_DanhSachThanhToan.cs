using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace PTTK_Project
{
    public partial class DoanhNghiep_DanhSachThanhToan : Form
    {
        private string MaDoiTac = "";
        private string message = "";

        public DoanhNghiep_DanhSachThanhToan(string maDoiTac ="1222")
        {
            InitializeComponent();
            this.MaDoiTac = maDoiTac;

            LoadPhieuDangTuyen();
        }

        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
            int res = HOADON_BUS.ThanhToan(txt_maHoaDon.Text, ref message);

            MessageBox.Show(message);

            if(res == 1)
            {
                LoadHoaDon();
            }
        }

        private void LoadHoaDon()
        {
            HOADON_DTO hoadon = HOADON_BUS.TimHoaDon(cbx_maPhieu.Text);

            txt_maHoaDon.Text = hoadon.MaHoaDon;
            txt_soTien.Text = hoadon.TongTien.ToString();
            txt_tinhTrang.Text = hoadon.TinhTrang;
        }

        private void LoadPhieuDangTuyen()
        {
            DataTable dt = PHIEUDANGTUYEN_BUS.TimPhieuDangTuyenTheoDoanhNghiep(this.MaDoiTac);

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                cbx_maPhieu.Items.Add(dr["MaPhieu"].ToString());
            }
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            LoadHoaDon();
        }

    }
}
