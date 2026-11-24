using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;  
using DANH_MỤC_VÀ_SẢN_PHẨM.DAL;
using DANH_MỤC_VÀ_SẢN_PHẨM.DTO;
using System.Text.RegularExpressions;

namespace DANH_MỤC_VÀ_SẢN_PHẨM.BLL
{
    public class DanhMucBLL
    {
        DanhMucDAL dmDAL = new DanhMucDAL();
        public string ThemDanhMuc(DanhMucDTO dm)
        {
            if(string.IsNullOrWhiteSpace(dm.MaDM) || string.IsNullOrWhiteSpace(dm.TenDM))
            {
                return "Mã danh mục và tên danh mục không được để trống.";
            }
            if(dm.MaDM.Length > 10)
            {
                return "Mã danh mục không được vượt quá 10 ký tự.";
            }
            if(dm.TenDM.Length > 100)
            {
                return "Tên danh mục không được vượt quá 100 ký tự.";
            }
            if(!Regex.IsMatch(dm.MaDM, @"^DM\d{2}$"))//cú pháp bắt buộc 
            {
                return "Mã danh mục chỉ được chứa ký tự chữ và số, không được chứa ký tự đặc biệt.Cú pháp DM+00N";
            }
            try
            {
                bool ketQua = dmDAL.ThemDanhMuc(dm);
                return ketQua
                    ? "Thêm danh mục thành công!"
                    : "Thêm danh mục thất bại!";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    return $"Mã danh mục '{dm.MaDM}' đã tồn tại, vui lòng nhập mã khác!";

                if (ex.Number == 53 || ex.Number == 4060)
                    return "Không thể kết nối đến máy chủ SQL Server (Mr-khieem)!";

                return "Lỗi cơ sở dữ liệu: " + ex.Message;
            }
            catch (Exception ex)
            {
                return "Lỗi hệ thống: " + ex.Message;
            }


        }


        public string SuaDanhMuc(DanhMucDTO dm)
        {
            if (string.IsNullOrWhiteSpace(dm.MaDM) || string.IsNullOrWhiteSpace(dm.TenDM))
            {
                return "Mã danh mục và tên danh mục không được để trống.";
            }
            if (dm.MaDM.Length > 10)
            {
                return "Mã danh mục không được vượt quá 10 ký tự.";
            }
            if (dm.TenDM.Length > 100)
            {
                return "Tên danh mục không được vượt quá 100 ký tự.";
            }
            
            try
            {
                bool ketQua = dmDAL.SuaDanhMuc(dm);
                return ketQua
                    ? "Sửa danh mục thành công!"
                    : "Sửa danh mục thất bại!";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 53 || ex.Number == 4060)
                    return "Không thể kết nối đến máy chủ SQL Server (Mr-khieem)!";
                return "Lỗi cơ sở dữ liệu: " + ex.Message;
            }
            catch (Exception ex)
            {
                return "Lỗi hệ thống: " + ex.Message;
            }
        }

        public string XoaDanhMuc(string maDM)
        {
            if (string.IsNullOrWhiteSpace(maDM))
            {
                return "Mã danh mục không được để trống.";
            }
            if (maDM.Length > 10)
            {
                return "Mã danh mục không được vượt quá 10 ký tự.";
            }
           
            try
            {
                bool ketQua = dmDAL.XoaDanhMuc(maDM);
                return ketQua
                    ? "Xóa danh mục thành công!"
                    : "Xóa danh mục thất bại!";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // Foreign key violation
                    return $"Không thể xóa danh mục '{maDM}' vì có sản phẩm liên quan.";
                if (ex.Number == 53 || ex.Number == 4060)
                    return "Không thể kết nối đến máy chủ SQL Server (Mr-khieem)!";
                return "Lỗi cơ sở dữ liệu: " + ex.Message;
            }
            catch (Exception ex)
            {
                return "Lỗi hệ thống: " + ex.Message;
            }
        }
    }
    
}
