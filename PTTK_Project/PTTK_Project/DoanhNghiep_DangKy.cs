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
    public partial class DoanhNghiep_DangKy : Form
    {
        private string message = "";
        public DoanhNghiep_DangKy()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_dangKy_Click(object sender, EventArgs e)
        {
            string maSoThue = txt_MaSoThue.Text;
            string matKhau = txt_matKhau.Text;
            string diaChi = txt_diaChi.Text;
            string email = txt_Email.Text;
            string tenCongTy = txt_tenCongTy.Text;
            string nguoiDaiDien = txt_nguoiDaiDien.Text;

            try
            {
                DOITAC_DTO doitac = new DOITAC_DTO(maSoThue, matKhau, diaChi, email, tenCongTy, nguoiDaiDien);
                int result = DOITAC_BUS.TaoDoiTac(doitac, ref message);


                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
