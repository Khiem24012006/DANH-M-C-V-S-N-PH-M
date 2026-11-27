using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DANH_MỤC_VÀ_SẢN_PHẨM.DTO
{
    internal class SanPhamDTO
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string MaDM_Sach { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }
        public string Mota { get; set; }
        public string HinhAnh { get; set; }
    }
}
