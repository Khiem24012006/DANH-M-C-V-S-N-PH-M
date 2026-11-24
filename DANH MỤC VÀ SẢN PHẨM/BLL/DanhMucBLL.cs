using DANH_MỤC_VÀ_SẢN_PHẨM.DAL;
using DANH_MỤC_VÀ_SẢN_PHẨM.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;  
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DANH_MỤC_VÀ_SẢN_PHẨM.BLL
{
    public class DanhMucBLL
    {
        DanhMucDAL dmDAL = new DanhMucDAL();
        // Các phương thức xử lý nghiệp vụ liên quan đến danh mục
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
            if (!Regex.IsMatch(dm.MaDM, @"^DM\d{2}$"))
            {
                return "Mã danh mục phải theo định dạng DM + 2 chữ số (ví dụ: DM01).";
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

        public DataTable LoadFormDM(out string errorMessage)
        {
            errorMessage = null;
            try
            {
                return dmDAL.LoadFormDM();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 53 || ex.Number == 4060)
                    errorMessage = "Không thể kết nối đến máy chủ SQL Server (Mr-khieem)!";
                else
                    errorMessage = "Lỗi cơ sở dữ liệu khi tải danh mục: " + ex.Message;
                return new DataTable();
            }
            catch (Exception ex)
            {
                errorMessage = "Lỗi hệ thống: " + ex.Message;
                return new DataTable();
            }
        }

        public DataTable TimKiemDanhMuc(string tuKhoa, out string errorMessage)
        {
            errorMessage = null;
            try
            {
                if (string.IsNullOrWhiteSpace(tuKhoa))
                    return dmDAL.LoadFormDM();

                return dmDAL.TimKiemDanhMuc(tuKhoa.Trim());
            }
            catch (SqlException ex)
            {
                if (ex.Number == 53 || ex.Number == 4060)
                    errorMessage = "Không thể kết nối đến máy chủ SQL Server (Mr-khieem)!";
                else
                    errorMessage = "Lỗi cơ sở dữ liệu khi tìm kiếm: " + ex.Message;
                return new DataTable();
            }
            catch (Exception ex)
            {
                errorMessage = "Lỗi hệ thống: " + ex.Message;
                return new DataTable();
            }
        }
    }
    
}
