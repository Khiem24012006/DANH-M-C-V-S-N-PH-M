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
        DanhMucDAL dmDAL = new DanhMucDAL();
        DanhMucBLL dmBLL = new DanhMucBLL();
        DanhMucDTO dmDTO=new DanhMucDTO();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            dgvDanhMuc.DataSource= dmDAL.LoadFormDM();
            UpdateTongSanPham();


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dmDTO.MaDM = txtMaDM.Text.Trim();
            dmDTO.TenDM = txtTenDM.Text.Trim();
            string thongbao = dmBLL.ThemDanhMuc(dmDTO);
            
            if(thongbao== "Thêm danh mục thành công!")
            {
                MessageBox.Show(thongbao);
                dgvDanhMuc.DataSource = dmDAL.LoadFormDM();
                UpdateTongSanPham();
            }
            else
            {
                MessageBox.Show(thongbao);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
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
                    dgvDanhMuc.DataSource = dmDAL.LoadFormDM();
                    UpdateTongSanPham();
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
                dgvDanhMuc.DataSource = dmDAL.LoadFormDM();
                UpdateTongSanPham();
            }
            else
            {
                MessageBox.Show(thongbao);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvDanhMuc.DataSource = dmDAL.TimKiemDanhMuc(txtTimKiem.Text.Trim());
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhMuc.Rows[e.RowIndex];
                txtMaDM.Text = row.Cells["MaDM"].Value.ToString();
                txtTenDM.Text = row.Cells["TenDM"].Value.ToString();
                txtMaDM.Enabled = false; // Vô hiệu hóa TextBox MaDM khi chọn một danh mục từ DataGridView
            }
        }
          
        public void UpdateTongSanPham()
        {
           
            int tongSanPham = dgvDanhMuc.Rows.Count;
            lblTongSanPham.Text = tongSanPham.ToString();
        }

    }
}
