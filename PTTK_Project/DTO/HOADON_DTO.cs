using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HOADON_DTO
    {
        public string MaHoaDon { get; set; }
        public string TinhTrang { get; set; }
        public int TongTien { get; set; }
        public string MaPhieuDangTuyen { get; set; }

        public HOADON_DTO(string maHoaDon, int tongTien, string maPhieu, string tinhTrang="Chua thanh toan")
        {
            this.MaHoaDon = maHoaDon;
            this.TongTien = tongTien;
            this.MaPhieuDangTuyen = maPhieu;
            this.TinhTrang = tinhTrang;
        }
    }
}
