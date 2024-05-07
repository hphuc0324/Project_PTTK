using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DOITAC_DTO
    {
        public string MaSoThue { get; set; }
        public string MatKhau { get; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string TenCongTy { get; set; }
        public string TenNguoiDaiDien { get; set; }
        public string TiemNang { get; set; }
            
        public DOITAC_DTO(string maSoThue, string matKhau, string diaChi, string email, string tenCongty, string tenNguoiDaiDien)
        {
            this.MaSoThue = maSoThue;
            this.MatKhau = matKhau;
            this.DiaChi = diaChi;
            this.Email = email;
            this.TenCongTy = tenCongty;
            this.TenNguoiDaiDien = tenNguoiDaiDien;
        }
    }
}
