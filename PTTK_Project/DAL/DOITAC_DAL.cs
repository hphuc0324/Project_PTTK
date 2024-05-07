using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DOITAC_DAL : DataProvider
    {
        public static int TaoDoiTac(DOITAC_DTO doiTac)
        {
            string query = "EXEC sp_themDoiTac @maSoThue , @matKhau , @diaChi , @email , @tenCongTy , @nguoiDaiDien";
            object[] parameters = new object[] {doiTac.MaSoThue, doiTac.MatKhau, doiTac.DiaChi, doiTac.Email, doiTac.TenCongTy, doiTac.TenNguoiDaiDien};

            int res = Instance.ExecuteStoreProcedure(query, parameters);

            return res;
        }
    }
}
