using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace PTTK_Project
{
    public partial class DoanhNghiep_DangKy : Form
    {
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
            try
            {
                DataProvider.Instance.OpenConnect();
                MessageBox.Show("Connected");

                DataProvider.Instance.CloseConnect();
                MessageBox.Show("Disconnected");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
