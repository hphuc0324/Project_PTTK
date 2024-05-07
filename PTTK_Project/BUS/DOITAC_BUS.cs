using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class DOITAC_BUS
    {
        public static int TaoDoiTac(DOITAC_DTO doiTac, ref string message)
        {
            if(doiTac.MaSoThue.Length > 10 || doiTac.MaSoThue.Length < 4)
            {
                message = "Mã số thuế có độ dài từ 4-10 ký tự!";
                return 0;
            }

            if(doiTac.MatKhau.Length > 50 || doiTac.MatKhau.Length < 3)
            {
                message = "Mật khẩu phải có độ dài từ 3-50 ký tự";
                return 0;
            }

            if(doiTac.Email.Length == 0 || doiTac.DiaChi.Length == 0 || doiTac.TenNguoiDaiDien.Length == 0 || doiTac.TenCongTy.Length == 0)
            {
                message = "Thiếu thông tin!"; 
                return 0;
            }

            int res = DOITAC_DAL.TaoDoiTac(doiTac);

            if(res == 0)
            {
                message = "Đăng ký doanh nghiệp thất bại! Vui lòng thử lại"; ;
                return 0;
            }

            message = "Đăng ký doanh nghiệp thành công";
            return 1;
        }
    }
}
