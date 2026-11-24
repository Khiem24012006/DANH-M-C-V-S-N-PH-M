namespace DANH_MỤC_VÀ_SẢN_PHẨM
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpSanPham = new System.Windows.Forms.TabPage();
            this.tpDanhMuc = new System.Windows.Forms.TabPage();
            this.pnlThongTinHienThi = new System.Windows.Forms.Panel();
            this.palTimKiem = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.pnlThongTinDanhMuc = new System.Windows.Forms.Panel();
            this.pnlThongTinDM = new System.Windows.Forms.Panel();
            this.txtThongtTinDM = new System.Windows.Forms.TextBox();
            this.txtTenDM = new System.Windows.Forms.TextBox();
            this.lblTenDM = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaDM = new System.Windows.Forms.TextBox();
            this.lblMaDM = new System.Windows.Forms.Label();
            this.pnlQuanLyDM = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQuanlyDM = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTongSanPham = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tpDanhMuc.SuspendLayout();
            this.pnlThongTinHienThi.SuspendLayout();
            this.palTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.pnlThongTinDanhMuc.SuspendLayout();
            this.pnlThongTinDM.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlQuanLyDM.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpSanPham);
            this.tabMain.Controls.Add(this.tpDanhMuc);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(996, 559);
            this.tabMain.TabIndex = 0;
            // 
            // tpSanPham
            // 
            this.tpSanPham.Location = new System.Drawing.Point(4, 22);
            this.tpSanPham.Name = "tpSanPham";
            this.tpSanPham.Padding = new System.Windows.Forms.Padding(3);
            this.tpSanPham.Size = new System.Drawing.Size(988, 533);
            this.tpSanPham.TabIndex = 0;
            this.tpSanPham.Text = "Sản Phẩm";
            this.tpSanPham.UseVisualStyleBackColor = true;
            // 
            // tpDanhMuc
            // 
            this.tpDanhMuc.Controls.Add(this.pnlThongTinHienThi);
            this.tpDanhMuc.Controls.Add(this.pnlThongTinDanhMuc);
            this.tpDanhMuc.Controls.Add(this.pnlQuanLyDM);
            this.tpDanhMuc.Location = new System.Drawing.Point(4, 22);
            this.tpDanhMuc.Name = "tpDanhMuc";
            this.tpDanhMuc.Padding = new System.Windows.Forms.Padding(3);
            this.tpDanhMuc.Size = new System.Drawing.Size(988, 533);
            this.tpDanhMuc.TabIndex = 1;
            this.tpDanhMuc.Text = "Danh Mục";
            this.tpDanhMuc.UseVisualStyleBackColor = true;
            // 
            // pnlThongTinHienThi
            // 
            this.pnlThongTinHienThi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlThongTinHienThi.Controls.Add(this.palTimKiem);
            this.pnlThongTinHienThi.Controls.Add(this.dgvDanhMuc);
            this.pnlThongTinHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThongTinHienThi.Location = new System.Drawing.Point(287, 91);
            this.pnlThongTinHienThi.Name = "pnlThongTinHienThi";
            this.pnlThongTinHienThi.Size = new System.Drawing.Size(698, 439);
            this.pnlThongTinHienThi.TabIndex = 4;
            // 
            // palTimKiem
            // 
            this.palTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.palTimKiem.Controls.Add(this.txtTimKiem);
            this.palTimKiem.Controls.Add(this.pictureBox1);
            this.palTimKiem.Location = new System.Drawing.Point(36, 29);
            this.palTimKiem.Name = "palTimKiem";
            this.palTimKiem.Size = new System.Drawing.Size(274, 20);
            this.palTimKiem.TabIndex = 8;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(25, 0);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(247, 15);
            this.txtTimKiem.TabIndex = 6;
            this.txtTimKiem.Text = "Tìm kiếm";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::DANH_MỤC_VÀ_SẢN_PHẨM.Properties.Resources.find;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.AllowUserToAddRows = false;
            this.dgvDanhMuc.AllowUserToDeleteRows = false;
            this.dgvDanhMuc.AllowUserToResizeColumns = false;
            this.dgvDanhMuc.AllowUserToResizeRows = false;
            this.dgvDanhMuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMuc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhMuc.Location = new System.Drawing.Point(0, 79);
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.ReadOnly = true;
            this.dgvDanhMuc.RowHeadersVisible = false;
            this.dgvDanhMuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhMuc.Size = new System.Drawing.Size(696, 358);
            this.dgvDanhMuc.TabIndex = 1;
            this.dgvDanhMuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhMuc_CellClick);
            // 
            // pnlThongTinDanhMuc
            // 
            this.pnlThongTinDanhMuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlThongTinDanhMuc.Controls.Add(this.pnlThongTinDM);
            this.pnlThongTinDanhMuc.Controls.Add(this.txtTenDM);
            this.pnlThongTinDanhMuc.Controls.Add(this.lblTenDM);
            this.pnlThongTinDanhMuc.Controls.Add(this.tableLayoutPanel1);
            this.pnlThongTinDanhMuc.Controls.Add(this.txtMaDM);
            this.pnlThongTinDanhMuc.Controls.Add(this.lblMaDM);
            this.pnlThongTinDanhMuc.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlThongTinDanhMuc.Location = new System.Drawing.Point(3, 91);
            this.pnlThongTinDanhMuc.Name = "pnlThongTinDanhMuc";
            this.pnlThongTinDanhMuc.Size = new System.Drawing.Size(284, 439);
            this.pnlThongTinDanhMuc.TabIndex = 5;
            // 
            // pnlThongTinDM
            // 
            this.pnlThongTinDM.Controls.Add(this.txtThongtTinDM);
            this.pnlThongTinDM.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlThongTinDM.Location = new System.Drawing.Point(0, 0);
            this.pnlThongTinDM.Name = "pnlThongTinDM";
            this.pnlThongTinDM.Size = new System.Drawing.Size(282, 78);
            this.pnlThongTinDM.TabIndex = 9;
            // 
            // txtThongtTinDM
            // 
            this.txtThongtTinDM.BackColor = System.Drawing.Color.Gainsboro;
            this.txtThongtTinDM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThongtTinDM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtThongtTinDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThongtTinDM.Location = new System.Drawing.Point(0, 0);
            this.txtThongtTinDM.Multiline = true;
            this.txtThongtTinDM.Name = "txtThongtTinDM";
            this.txtThongtTinDM.Size = new System.Drawing.Size(282, 78);
            this.txtThongtTinDM.TabIndex = 6;
            this.txtThongtTinDM.Text = "\r\nThông tin danh mục";
            this.txtThongtTinDM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTenDM
            // 
            this.txtTenDM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDM.Location = new System.Drawing.Point(26, 227);
            this.txtTenDM.MaxLength = 100;
            this.txtTenDM.Name = "txtTenDM";
            this.txtTenDM.Size = new System.Drawing.Size(235, 29);
            this.txtTenDM.TabIndex = 3;
            // 
            // lblTenDM
            // 
            this.lblTenDM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenDM.AutoSize = true;
            this.lblTenDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDM.Location = new System.Drawing.Point(23, 204);
            this.lblTenDM.Name = "lblTenDM";
            this.lblTenDM.Size = new System.Drawing.Size(122, 20);
            this.lblTenDM.TabIndex = 2;
            this.lblTenDM.Text = "Tên danh mục";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnLamMoi, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnXoa, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSua, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnThem, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 290);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 115);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Gray;
            this.btnLamMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Image = global::DANH_MỤC_VÀ_SẢN_PHẨM.Properties.Resources.làm_mới;
            this.btnLamMoi.Location = new System.Drawing.Point(128, 60);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(119, 52);
            this.btnLamMoi.TabIndex = 7;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = global::DANH_MỤC_VÀ_SẢN_PHẨM.Properties.Resources.xóa;
            this.btnXoa.Location = new System.Drawing.Point(3, 60);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(119, 52);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Image = global::DANH_MỤC_VÀ_SẢN_PHẨM.Properties.Resources.edit;
            this.btnSua.Location = new System.Drawing.Point(128, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(119, 51);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Lime;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = global::DANH_MỤC_VÀ_SẢN_PHẨM.Properties.Resources.thêm;
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(119, 51);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaDM
            // 
            this.txtMaDM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaDM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDM.Location = new System.Drawing.Point(27, 134);
            this.txtMaDM.Name = "txtMaDM";
            this.txtMaDM.Size = new System.Drawing.Size(237, 29);
            this.txtMaDM.TabIndex = 1;
            // 
            // lblMaDM
            // 
            this.lblMaDM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaDM.AutoSize = true;
            this.lblMaDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDM.Location = new System.Drawing.Point(23, 111);
            this.lblMaDM.Name = "lblMaDM";
            this.lblMaDM.Size = new System.Drawing.Size(116, 20);
            this.lblMaDM.TabIndex = 0;
            this.lblMaDM.Text = "Mã danh mục";
            // 
            // pnlQuanLyDM
            // 
            this.pnlQuanLyDM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuanLyDM.Controls.Add(this.panel2);
            this.pnlQuanLyDM.Controls.Add(this.lblQuanlyDM);
            this.pnlQuanLyDM.Controls.Add(this.panel1);
            this.pnlQuanLyDM.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuanLyDM.Location = new System.Drawing.Point(3, 3);
            this.pnlQuanLyDM.Name = "pnlQuanLyDM";
            this.pnlQuanLyDM.Size = new System.Drawing.Size(982, 88);
            this.pnlQuanLyDM.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(641, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 63);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng số sách";
            // 
            // lblQuanlyDM
            // 
            this.lblQuanlyDM.AutoSize = true;
            this.lblQuanlyDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanlyDM.Location = new System.Drawing.Point(83, 26);
            this.lblQuanlyDM.Name = "lblQuanlyDM";
            this.lblQuanlyDM.Size = new System.Drawing.Size(294, 37);
            this.lblQuanlyDM.TabIndex = 0;
            this.lblQuanlyDM.Text = "Quản lý danh mục";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTongSanPham);
            this.panel1.Location = new System.Drawing.Point(446, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 63);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng danh mục";
            // 
            // lblTongSanPham
            // 
            this.lblTongSanPham.AutoSize = true;
            this.lblTongSanPham.Location = new System.Drawing.Point(47, 30);
            this.lblTongSanPham.Name = "lblTongSanPham";
            this.lblTongSanPham.Size = new System.Drawing.Size(35, 13);
            this.lblTongSanPham.TabIndex = 2;
            this.lblTongSanPham.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 559);
            this.Controls.Add(this.tabMain);
            this.Name = "Form1";
            this.Text = "Danh Mục và sản phẩm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabMain.ResumeLayout(false);
            this.tpDanhMuc.ResumeLayout(false);
            this.pnlThongTinHienThi.ResumeLayout(false);
            this.palTimKiem.ResumeLayout(false);
            this.palTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.pnlThongTinDanhMuc.ResumeLayout(false);
            this.pnlThongTinDanhMuc.PerformLayout();
            this.pnlThongTinDM.ResumeLayout(false);
            this.pnlThongTinDM.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlQuanLyDM.ResumeLayout(false);
            this.pnlQuanLyDM.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tpSanPham;
        private System.Windows.Forms.TabPage tpDanhMuc;
        private System.Windows.Forms.TextBox txtTenDM;
        private System.Windows.Forms.Label lblTenDM;
        private System.Windows.Forms.TextBox txtMaDM;
        private System.Windows.Forms.Label lblMaDM;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvDanhMuc;
        private System.Windows.Forms.Panel pnlThongTinHienThi;
        private System.Windows.Forms.Panel pnlQuanLyDM;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblQuanlyDM;
        private System.Windows.Forms.Panel palTimKiem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlThongTinDanhMuc;
        private System.Windows.Forms.TextBox txtThongtTinDM;
        private System.Windows.Forms.Panel pnlThongTinDM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTongSanPham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}

