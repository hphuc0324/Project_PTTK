using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class HOADON_BUS
    {
        public static HOADON_DTO TimHoaDon(string maPhieu)
        {
            if(maPhieu == "")
            {
                return null;
            }

            return HOADON_DAL.TimHoaDon(maPhieu);
        }

        public static bool KiemTraThanhToan(string maHoaDon)
        {
            if(maHoaDon == "")
            {
                return false;
            }

            return HOADON_DAL.KiemTraThanhToan(maHoaDon);
        }

        public static int ThanhToan(string maHoaDon, ref string message)
        {
            if(maHoaDon == "")
            {
                message = "Vui lòng nhập mã hóa đơn";
                return 0;
            }

            if (KiemTraThanhToan(maHoaDon))
            {
                message = "Hóa đơn đã được thanh toán trước đó!";
                return 0;
            }

            int res = HOADON_DAL.ThanhToan(maHoaDon);

            if(res == 0)
            {
                message = "Xảy ra lỗi trong quá trình thanh toán! Xin vui lòng thử lại sau";
            }
            else
            {
                message = "Thanh toán thành công!";
            }

            return res;
        }
    }
}
