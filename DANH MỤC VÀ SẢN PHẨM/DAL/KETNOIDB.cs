using System.Configuration;
using System.Data.SqlClient;

namespace DANH_MỤC_VÀ_SẢN_PHẨM.DAL
{
    public class KETNOIDB
    {
        public static SqlConnection TaoKetNoi()
        {
            string strConn = ConfigurationManager.ConnectionStrings["ChuoiKetNoi"].ConnectionString;
            return new SqlConnection(strConn);
        }
    }
}