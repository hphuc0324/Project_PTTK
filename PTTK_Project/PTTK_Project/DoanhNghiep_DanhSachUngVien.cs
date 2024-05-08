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


namespace PTTK_Project
{
    public partial class DoanhNghiep_DanhSachUngVien : Form
    {
        private string MaDoiTac = "";

        public DoanhNghiep_DanhSachUngVien(string maDoiTac ="1222")
        {
            InitializeComponent();

            this.MaDoiTac = maDoiTac;
            LoadMaDangTuyen();
        }

      

        private void btn_xemUngvien_Click(object sender, EventArgs e)
        {

        }

        private void LoadMaDangTuyen()
        {
            DataTable dt = THONGTINDANGTUYEN_BUS.XemDanhSachDangTuyen(this.MaDoiTac);

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                cbx_maDangTuyen.Items.Add(dr["MaDangTuyen"].ToString());
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            DoanhNghiep_TongHop form = new DoanhNghiep_TongHop(this.MaDoiTac);

            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
