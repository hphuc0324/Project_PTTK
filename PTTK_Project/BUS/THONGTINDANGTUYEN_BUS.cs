using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class THONGTINDANGTUYEN_BUS
    {
        public static int TaoDangTuyen(THONGTINDANGTUYEN_DTO dangTuyen, ref string message)
        {
            if(dangTuyen.SoLuongTuyenDung <= 0 || dangTuyen.YeuCauUngVien == "" || dangTuyen.MaDoiTac == "" )
            {
                message = "Thiếu thông tin";
                return 0;
            }

            if(dangTuyen.ThoiGianBatDau >= dangTuyen.ThoiGianKetThuc)
            {
                message = "Thời gian đăng tuyển không hợp lệ";
                return 0;
            }

            int res = THONGTINDANGTUYEN_DAL.TaoThongTinDangTuyen(dangTuyen);

            if (res == 0)
            {
                message = "Lỗi xảy ra khi tạo thông tin đăng tuyển! Vui lòng thử lại";
            }
            else
            {
                message = "Đăng ký đăng tuyển thành công";
            }
            return res;
        }
    }
}
