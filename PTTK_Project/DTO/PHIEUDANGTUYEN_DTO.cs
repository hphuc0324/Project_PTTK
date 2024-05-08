using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PHIEUDANGTUYEN_DTO
    {
        public string MaPhieu { get; set; }
        public string HinhThuc { get; set; }
        public string MaTTDangTuyen { get; set; }
        public string MaNVDuyet { get; set; }

        public PHIEUDANGTUYEN_DTO(string maPhieu, string hinhThuc, string maNVDuyet, string maTTDangTuyen)
        {
            this.MaPhieu = maPhieu;
            this.HinhThuc = hinhThuc;
            this.MaTTDangTuyen = maTTDangTuyen;
            this.MaNVDuyet = maNVDuyet;
        }
    }
}
