using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class PHIEUDANGTUYEN_DAL : DataProvider
    {
        public static PHIEUDANGTUYEN_DTO TimPhieuDangTuyenTheoMa(string maDangTuyen)
        {
            string query = $"SELECT * FROM PHIEUDANGTUYEN WHERE MaTTDangTuyen='{maDangTuyen}'";

            DataTable dt = Instance.ExecuteQuery(query);

            if(dt == null)
            {
                return null;
            }
            DataRow dr = dt.Rows[0];

            PHIEUDANGTUYEN_DTO phieuDangTuyen = new PHIEUDANGTUYEN_DTO(dr["MaPhieu"].ToString(), dr["HinhThuc"].ToString(), dr["MaNVDuyet"].ToString(), dr["MaTTDangTuyen"].ToString());
       

            return phieuDangTuyen;
        }

        public static DataTable TimPhieuDangTuyenTheoDoanhNghiep(string maDoiTac)
        {
            string query = $"SELECT * FROM PHIEUDANGTUYEN WHERE MaTTDangTuyen IN(SELECT MaDangTuyen FROM THONGTINDANGTUYEN WHERE MaDoiTac='{maDoiTac}')";

            DataTable dt = Instance.ExecuteQuery(query);

            return dt;
        }
    }
}
