using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DANH_MỤC_VÀ_SẢN_PHẨM.DAL
{
    public class  SanPhamDAL
    {
        public DataTable LoadFormSP()
        {
           using (SqlConnection conn = KETNOIDB.TaoKetNoi())
            {
                conn.Open();
                string sql = "select* from SanPham";
                using (SqlDataAdapter da= new SqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    
                    return dt;
                }
            }
        }

        
    }
}
