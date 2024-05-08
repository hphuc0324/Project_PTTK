using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class PHIEUDANGTUYEN_BUS
    {
        public static PHIEUDANGTUYEN_DTO TimPhieuDangTuyenTheoMa(string maDangTuyen)
        {
            if(maDangTuyen == "")
            {
                return null;
            }

            return PHIEUDANGTUYEN_DAL.TimPhieuDangTuyenTheoMa(maDangTuyen);
        }

        public static DataTable TimPhieuDangTuyenTheoDoanhNghiep(string maDoiTac)
        {
            if(maDoiTac == "")
            {
                return null;
            }

            DataTable dt = PHIEUDANGTUYEN_DAL.TimPhieuDangTuyenTheoDoanhNghiep(maDoiTac);

            return dt;
        }
    }
}
