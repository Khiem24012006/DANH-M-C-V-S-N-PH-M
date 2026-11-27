using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DANH_MỤC_VÀ_SẢN_PHẨM.DAL;

namespace DANH_MỤC_VÀ_SẢN_PHẨM.BLL
{
    public class SanPhamBLL
    {
        SanPhamDAL spDAL = new SanPhamDAL();

        public DataTable LoadFormSP(out string err)
        {
            err = null;
            try
            {
                return spDAL.LoadFormSP();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 53 || ex.Number == 4060)
                    err = "Không thể kết nối đến máy chủ SQL Server (Mr-khieem)!";
                else
                    err = "Lỗi cơ sở dữ liệu: " + ex.Message;
                return new DataTable(); // Trả về DataTable rỗng trong trường hợp lỗi

            }
            catch (Exception ex)
            {
                err = "Lỗi hệ thống: " + ex.Message;
                return new DataTable(); // Trả về DataTable rỗng trong trường hợp lỗi
            }
        }
    }
}
