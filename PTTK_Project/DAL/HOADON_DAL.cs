using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class HOADON_DAL : DataProvider
    {
        public static HOADON_DTO TimHoaDon(string maPhieu)
        {
            string query = $"SELECT * FROM HOADON WHERE MaPhieuDangTuyen='{maPhieu}'";

            DataTable dt = Instance.ExecuteQuery(query);

            if (dt == null)
            {
                return null;
            }

            DataRow dr = dt.Rows[0];

            HOADON_DTO hoadon = new HOADON_DTO(dr["MaHoaDon"].ToString(), Int32.Parse(dr["TongTien"].ToString()),  dr["MaPhieuDangTuyen"].ToString(), dr["TinhTrang"].ToString());


            return hoadon;
        }

        public static int ThanhToan(string maHoaDon)
        {
            string query = "EXEC sp_thanhToan @maHoaDon";
            object[] parameters = new object[] { maHoaDon };

            int res = Instance.ExecuteStoreProcedure(query, parameters);

            return res;
        }

        public static bool KiemTraThanhToan(string maHoaDon)
        {
            string query = "EXEC sp_kiemTraThanhToan @maHoaDon";
            object[] parameters = new object[] { maHoaDon };

            int res = Instance.ExecuteStoreProcedure(query, parameters);

            return (res == 1);
        }
    }
}
