using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DANH_MỤC_VÀ_SẢN_PHẨM;
using DANH_MỤC_VÀ_SẢN_PHẨM.DTO;


namespace DANH_MỤC_VÀ_SẢN_PHẨM.DAL
{
    public class DanhMucDAL
    {

        public DataTable LoadFormDM()
        {
            using (SqlDataAdapter da = new SqlDataAdapter())
                
            {
                string sql = "SELECT MaDM, TenDM FROM DanhMuc";
                DataTable dt = new DataTable();
                da.SelectCommand = new SqlCommand(sql, KETNOIDB.TaoKetNoi());
                da.Fill(dt);
                return dt;
            }
        }

        public bool ThemDanhMuc(DanhMucDTO dm)
        {
            using (SqlConnection conn = KETNOIDB.TaoKetNoi())
            {
                conn.Open(); 
                string sql = "INSERT INTO DanhMuc (MaDM, TenDM) VALUES (@MaDM, @TenDM)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MaDM", SqlDbType.VarChar, 10).Value = dm.MaDM;
                    cmd.Parameters.Add("@TenDM", SqlDbType.NVarChar, 100).Value = dm.TenDM; // Dùng NVarChar để lưu tiếng Việt có dấu

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public bool XoaDanhMuc(string maDM)
        {
            using (SqlConnection conn = KETNOIDB.TaoKetNoi())
            {
                conn.Open();
                string sql = "DELETE FROM DanhMuc WHERE MaDM = @MaDM";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MaDM", SqlDbType.VarChar, 10).Value = maDM;
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool SuaDanhMuc(DanhMucDTO dm)
        {
            using (SqlConnection conn = KETNOIDB.TaoKetNoi())
            {
                conn.Open();
                string sql = "UPDATE DanhMuc SET TenDM = @TenDM WHERE MaDM = @MaDM";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MaDM", SqlDbType.VarChar, 10).Value = dm.MaDM;
                    cmd.Parameters.Add("@TenDM", SqlDbType.NVarChar, 100).Value = dm.TenDM;
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        
        public DataTable TimKiemDanhMuc(string tuKhoa)
        {
            using (SqlDataAdapter da = new SqlDataAdapter())
            {
                string sql = "SELECT MaDM, TenDM FROM DanhMuc WHERE MaDM LIKE @TuKhoa OR TenDM LIKE @TuKhoa";
                DataTable dt = new DataTable();
                da.SelectCommand = new SqlCommand(sql, KETNOIDB.TaoKetNoi());
                da.SelectCommand.Parameters.Add("@TuKhoa", SqlDbType.NVarChar, 100).Value = "%" + tuKhoa + "%";
                da.Fill(dt);
                return dt;
            }
        }

        
    }
}
