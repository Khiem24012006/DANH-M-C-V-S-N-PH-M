using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DANH_MỤC_VÀ_SẢN_PHẨM.DAL;
using DANH_MỤC_VÀ_SẢN_PHẨM.DTO;
using System.Threading;
using System.Runtime.InteropServices;
using DANH_MỤC_VÀ_SẢN_PHẨM.BLL;

namespace DANH_MỤC_VÀ_SẢN_PHẨM
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        
        DanhMucBLL dmBLL = new DanhMucBLL();
        DanhMucDTO dmDTO=new DanhMucDTO();

        SanPhamDTO spDTO = new SanPhamDTO();
        SanPhamBLL spBLL = new SanPhamBLL();

        private void TaiDanhSachDanhMuc()
        {
            DataTable dt = dmBLL.LoadFormDM(out string err);
            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Lỗi tải dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvDanhMuc.DataSource = dt;
            UpdateTongSanPham();
        }
       private void TaiDanhSachSanPham()
        {
             DataTable dt= spBLL.LoadFormSP(out string err);
            if(!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Lỗi tải dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvSach.DataSource = dt;
            UpdateTongSanPham();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TaiDanhSachDanhMuc();
            TaiDanhSachSanPham();
            LoadDanhMucLenComboBox();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dmDTO.MaDM = txtMaDM.Text.Trim();
            dmDTO.TenDM = txtTenDM.Text.Trim();
            string thongbao = dmBLL.ThemDanhMuc(dmDTO);
            
            if(thongbao== "Thêm danh mục thành công!")
            {
                MessageBox.Show(thongbao);
                TaiDanhSachDanhMuc();
                btnLamMoi_Click(null, null);
            }
            else
            {
                MessageBox.Show(thongbao);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)

        {
            //if (string.IsNullOrWhiteSpace(txtMaDM.Text))
            //{
            //    MessageBox.Show("Vui lòng chọn danh mục cần xóa!", "Thông báo",
            //        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            DialogResult xacNhan = MessageBox.Show(
            $"Bạn có chắc chắn muốn xóa danh mục '{txtTenDM.Text.Trim()}' (Mã: {txtMaDM.Text.Trim()}) không?",
            "Xác nhận xóa",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if(xacNhan == DialogResult.Yes)
            {
                string maDM = txtMaDM.Text.Trim();
                string thongbao = dmBLL.XoaDanhMuc(maDM);
                if (thongbao == "Xóa danh mục thành công!")
                {
                    MessageBox.Show(thongbao);
                    TaiDanhSachDanhMuc();
                    btnLamMoi_Click(null, null);
                }
                else
                {
                    MessageBox.Show(thongbao);
                }
            }
    
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaDM.Clear();
            txtTenDM.Clear();
            UpdateTongSanPham();
            txtMaDM.Enabled = true;


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dmDTO.MaDM = txtMaDM.Text.Trim();
            dmDTO.TenDM = txtTenDM.Text.Trim();
            string thongbao = dmBLL.SuaDanhMuc(dmDTO);
            if(thongbao == "Sửa danh mục thành công!")
            {
                MessageBox.Show(thongbao);
                TaiDanhSachDanhMuc();
                btnLamMoi_Click(null, null);
            }
            else
            {
                MessageBox.Show(thongbao);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = dmBLL.TimKiemDanhMuc(txtTimKiem.Text, out string err);
            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Lỗi tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgvDanhMuc.DataSource = dt;
            UpdateTongSanPham();
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvDanhMuc.Rows[e.RowIndex];
            if (row.IsNewRow) return; // Bỏ qua dòng trống cuối bảng

            txtMaDM.Text = row.Cells["MaDM"].Value?.ToString() ?? "";
            txtTenDM.Text = row.Cells["TenDM"].Value?.ToString() ?? "";
            txtMaDM.Enabled = false;
        }
          
        public void UpdateTongSanPham()
        {
           
            int tongSanPham = dgvDanhMuc.Rows.Count;
            lblTongDanhMuc.Text = tongSanPham.ToString();
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0) return;
            DataGridViewRow row = dgvSach.Rows[e.RowIndex];

            
            txtMaSach.Text = row.Cells["MaSP"].Value?.ToString() ?? "";
            txtTenSach.Text = row.Cells["TenSP"].Value?.ToString() ?? "";
            cboDanhMuc.SelectedValue = row.Cells["MaDM"].Value?.ToString() ?? "";
            numGiaBan.Value = Convert.ToDecimal(row.Cells["DonGia"].Value);
            numSoLuong.Value = Convert.ToInt32(row.Cells["SoLuong"].Value);
            txtMoTa.Text = row.Cells["MoTa"].Value?.ToString() ?? "";
            ptbAnhBia.ImageLocation = row.Cells["HinhAnh"].Value?.ToString() ?? "";
        }

        private void LoadDanhMucLenComboBox()
        {
            DataTable dt = dmBLL.LoadFormDM(out string err);
            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Lỗi tải dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cboDanhMuc.DataSource = dt;
            cboDanhMuc.DisplayMember = "TenDM";
            cboDanhMuc.ValueMember = "MaDM";
        }
    }
}
