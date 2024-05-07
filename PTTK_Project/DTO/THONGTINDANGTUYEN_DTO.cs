using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class THONGTINDANGTUYEN_DTO
    {
        public string MaDangTuyen { get; set; }
        public int SoLuongTuyenDung { get; set; }
        public string ViTriTuyenDung { get; set; }
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
        public string YeuCauUngVien { get; set; }
        public string TrangThai { get; set; }
        public string HinhThuc { get; set; }
        public string MaDoiTac { get; set; }
        
        public THONGTINDANGTUYEN_DTO(string maDangTuyen, int soLuong, string viTri, DateTime batDau, DateTime ketThuc, string yeuCau, string hinhThuc, string maDoiTac)
        {
            this.MaDangTuyen = maDangTuyen;
            this.SoLuongTuyenDung = soLuong;
            this.ViTriTuyenDung= viTri;
            this.ThoiGianBatDau = batDau;
            this.ThoiGianKetThuc = ketThuc;
            this.YeuCauUngVien = yeuCau;
            this.TrangThai = "Cho Duyet";
            this.HinhThuc = hinhThuc;
            this.MaDoiTac = maDoiTac;
        }
    }
}
