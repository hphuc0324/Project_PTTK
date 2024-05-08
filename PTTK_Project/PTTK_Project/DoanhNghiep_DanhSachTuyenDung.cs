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
    public partial class DoanhNghiep_DanhSachTuyenDung : Form
    {
        private string MaDoiTac = "";
        public DoanhNghiep_DanhSachTuyenDung(string maDoiTac="1222")
        {
            InitializeComponent();
            this.MaDoiTac = maDoiTac;

            LoadDangTuyen();
        }

        private void LoadDangTuyen()
        {
            dgv_danhSachDangTuyen.DataSource = THONGTINDANGTUYEN_BUS.XemDanhSachDangTuyen(this.MaDoiTac);
        }

        private void dgv_danhSachDangTuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string maDangTuyen = dgv_danhSachDangTuyen.Rows[e.RowIndex].Cells["MaDangTuyen"].Value.ToString();
            PHIEUDANGTUYEN_DTO phieuDangTuyen = PHIEUDANGTUYEN_BUS.TimPhieuDangTuyenTheoMa(maDangTuyen);
            
            if(phieuDangTuyen == null)
            {
                return;
            }

            txt_maPhieu.Text = phieuDangTuyen.MaPhieu;
            txt_hinhThuc.Text = phieuDangTuyen.HinhThuc;
        }

        private void btn_xemUngVien_Click(object sender, EventArgs e)
        {

        }
    }
}
