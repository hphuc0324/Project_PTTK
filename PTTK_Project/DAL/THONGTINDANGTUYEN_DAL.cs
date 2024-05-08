using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class THONGTINDANGTUYEN_DAL : DataProvider
    {
        public static int TaoThongTinDangTuyen(THONGTINDANGTUYEN_DTO dangTuyen)
        {
            string query = "EXEC sp_themDangTuyen @soLuong , @viTri , @thoiGianBatDau , @thoiGianKetThuc , @yeuCau , @hinhThuc , @maDoiTac";
            object[] parameters = new object[] { dangTuyen.SoLuongTuyenDung, dangTuyen.ViTriTuyenDung, dangTuyen.ThoiGianBatDau, dangTuyen.ThoiGianKetThuc, dangTuyen.YeuCauUngVien, dangTuyen.HinhThuc, dangTuyen.MaDoiTac };

            int res = Instance.ExecuteStoreProcedure(query, parameters);

            return res;
        }
    }
}
