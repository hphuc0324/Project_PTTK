using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace PTTK_Project
{
    public partial class DoanhNghiep_DangTuyenDung : Form
    {
        private string message = "";
        private string MaDoiTac = "";
        public DoanhNghiep_DangTuyenDung(string MaDoiTac="1222")
        {
            InitializeComponent();
            this.MaDoiTac = MaDoiTac;
        }

        private void btn_dangKy_Click(object sender, EventArgs e)
        {
            string viTri = txt_viTri.Text;
            int soLuong = Int32.Parse(txt_soLuong.Text);
            DateTime ngayBatDau = DateTime.Parse(dtp_ngayBatDau.Text);
            DateTime ngayKetThuc = DateTime.Parse(dtp_ngayKetThuc.Text);
            string yeuCau = txt_yeuCau.Text;
            string hinhThuc = cbx_hinhThuc.Text;

            THONGTINDANGTUYEN_DTO dangTuyen = new THONGTINDANGTUYEN_DTO(soLuong, viTri, ngayBatDau, ngayKetThuc, yeuCau, hinhThuc, this.MaDoiTac);
            try
            {
                THONGTINDANGTUYEN_BUS.TaoDangTuyen(dangTuyen, ref message);

                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            DoanhNghiep_TongHop form = new DoanhNghiep_TongHop();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
