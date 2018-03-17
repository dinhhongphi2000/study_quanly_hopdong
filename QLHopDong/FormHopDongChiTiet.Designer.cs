namespace QLHopDong
{
    partial class FormHopDongChiTiet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbKhachHang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayHD = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPPThanhToan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayHetHanHopDong = new System.Windows.Forms.DateTimePicker();
            this.dtpThoiHanGiaoHang = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvChiTietHD = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.labelThueSuat = new System.Windows.Forms.Label();
            this.txtThueSuat = new System.Windows.Forms.TextBox();
            this.pnlData = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.TenHang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiBanh = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.LoaiTui = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHD)).BeginInit();
            this.pnlData.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSoHD
            // 
            this.txtSoHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoHD.Location = new System.Drawing.Point(140, 2);
            this.txtSoHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(83, 26);
            this.txtSoHD.TabIndex = 3;
            this.txtSoHD.Leave += new System.EventHandler(this.txtSoHD_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(12, 39);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Số hợp đồng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Khách hàng";
            // 
            // cbbKhachHang
            // 
            this.cbbKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbKhachHang.FormattingEnabled = true;
            this.cbbKhachHang.Location = new System.Drawing.Point(140, 82);
            this.cbbKhachHang.Name = "cbbKhachHang";
            this.cbbKhachHang.Size = new System.Drawing.Size(201, 28);
            this.cbbKhachHang.TabIndex = 4;
            this.cbbKhachHang.Enter += new System.EventHandler(this.comboBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(402, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thời gian hợp đồng từ";
            // 
            // dtpNgayHD
            // 
            this.dtpNgayHD.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayHD.Location = new System.Drawing.Point(404, 34);
            this.dtpNgayHD.Name = "dtpNgayHD";
            this.dtpNgayHD.Size = new System.Drawing.Size(200, 26);
            this.dtpNgayHD.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phương thức thanh toán";
            // 
            // txtPPThanhToan
            // 
            this.txtPPThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPPThanhToan.Location = new System.Drawing.Point(11, 148);
            this.txtPPThanhToan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPPThanhToan.Multiline = true;
            this.txtPPThanhToan.Name = "txtPPThanhToan";
            this.txtPPThanhToan.Size = new System.Drawing.Size(327, 96);
            this.txtPPThanhToan.TabIndex = 3;
            this.txtPPThanhToan.TextChanged += new System.EventHandler(this.txtPPThanhToan_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(402, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thời gian giao hàng chậm nhất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(402, 190);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hiệu lực hợp đồng đến";
            // 
            // dtpNgayHetHanHopDong
            // 
            this.dtpNgayHetHanHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayHetHanHopDong.Location = new System.Drawing.Point(404, 104);
            this.dtpNgayHetHanHopDong.Name = "dtpNgayHetHanHopDong";
            this.dtpNgayHetHanHopDong.Size = new System.Drawing.Size(200, 26);
            this.dtpNgayHetHanHopDong.TabIndex = 5;
            // 
            // dtpThoiHanGiaoHang
            // 
            this.dtpThoiHanGiaoHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpThoiHanGiaoHang.Location = new System.Drawing.Point(404, 176);
            this.dtpThoiHanGiaoHang.Name = "dtpThoiHanGiaoHang";
            this.dtpThoiHanGiaoHang.Size = new System.Drawing.Size(200, 26);
            this.dtpThoiHanGiaoHang.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(13, 322);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Chi tiết hợp đồng";
            // 
            // dgvChiTietHD
            // 
            this.dgvChiTietHD.AllowUserToDeleteRows = false;
            this.dgvChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenHang,
            this.DonViTinh,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien,
            this.LoaiBanh,
            this.LoaiTui});
            this.dgvChiTietHD.Location = new System.Drawing.Point(17, 348);
            this.dgvChiTietHD.Name = "dgvChiTietHD";
            this.dgvChiTietHD.Size = new System.Drawing.Size(610, 179);
            this.dgvChiTietHD.TabIndex = 6;
            this.dgvChiTietHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietHD_CellClick);
            this.dgvChiTietHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietHD_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(242, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "NỘI DUNG HỢP ĐỒNG";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(450, 536);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(177, 46);
            this.btnCapNhat.TabIndex = 15;
            this.btnCapNhat.Tag = "Edit";
            this.btnCapNhat.Text = "Cập nhật hợp đồng";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(16, 536);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(126, 46);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa hàng hóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // labelThueSuat
            // 
            this.labelThueSuat.AutoSize = true;
            this.labelThueSuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelThueSuat.Location = new System.Drawing.Point(12, 80);
            this.labelThueSuat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelThueSuat.Name = "labelThueSuat";
            this.labelThueSuat.Size = new System.Drawing.Size(83, 20);
            this.labelThueSuat.TabIndex = 2;
            this.labelThueSuat.Text = "Thuế Suất";
            // 
            // txtThueSuat
            // 
            this.txtThueSuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtThueSuat.Location = new System.Drawing.Point(140, 42);
            this.txtThueSuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtThueSuat.Name = "txtThueSuat";
            this.txtThueSuat.Size = new System.Drawing.Size(83, 26);
            this.txtThueSuat.TabIndex = 3;
            this.txtThueSuat.Leave += new System.EventHandler(this.txtThueSuat_Leave);
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.label8);
            this.pnlData.Controls.Add(this.txtTongTien);
            this.pnlData.Controls.Add(this.lblTongTien);
            this.pnlData.Controls.Add(this.dtpThoiHanGiaoHang);
            this.pnlData.Controls.Add(this.txtSoHD);
            this.pnlData.Controls.Add(this.txtThueSuat);
            this.pnlData.Controls.Add(this.txtPPThanhToan);
            this.pnlData.Controls.Add(this.cbbKhachHang);
            this.pnlData.Controls.Add(this.dtpNgayHetHanHopDong);
            this.pnlData.Controls.Add(this.dtpNgayHD);
            this.pnlData.Location = new System.Drawing.Point(2, 36);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(625, 283);
            this.pnlData.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(475, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "(đã bao gồm thuế suất)";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongTien.Location = new System.Drawing.Point(404, 252);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(200, 26);
            this.txtTongTien.TabIndex = 18;
            this.txtTongTien.Text = "0";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongTien.Location = new System.Drawing.Point(400, 227);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(75, 20);
            this.lblTongTien.TabIndex = 17;
            this.lblTongTien.Text = "Tổng tiền";
            // 
            // TenHang
            // 
            this.TenHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenHang.DataPropertyName = "MaProduct";
            this.TenHang.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.TenHang.HeaderText = "Tên hàng";
            this.TenHang.MinimumWidth = 150;
            this.TenHang.Name = "TenHang";
            this.TenHang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenHang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TenHang.Width = 150;
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonVi";
            this.DonViTinh.HeaderText = "DonViTinh";
            this.DonViTinh.Name = "DonViTinh";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle7.Format = "N2";
            this.DonGia.DefaultCellStyle = dataGridViewCellStyle7;
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            // 
            // ThanhTien
            // 
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.ThanhTien.DefaultCellStyle = dataGridViewCellStyle8;
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // LoaiBanh
            // 
            this.LoaiBanh.DataPropertyName = "MaWeight";
            this.LoaiBanh.HeaderText = "Loại Bành";
            this.LoaiBanh.Name = "LoaiBanh";
            this.LoaiBanh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LoaiBanh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // LoaiTui
            // 
            this.LoaiTui.DataPropertyName = "MaPackage";
            this.LoaiTui.HeaderText = "Loại Túi";
            this.LoaiTui.Name = "LoaiTui";
            this.LoaiTui.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LoaiTui.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormHopDongChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 589);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvChiTietHD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelThueSuat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pnlData);
            this.Name = "FormHopDongChiTiet";
            this.Text = "FormHopDong";
            this.Load += new System.EventHandler(this.FormHopDongChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHD)).EndInit();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPPThanhToan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayHetHanHopDong;
        private System.Windows.Forms.DateTimePicker dtpThoiHanGiaoHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvChiTietHD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label labelThueSuat;
        private System.Windows.Forms.TextBox txtThueSuat;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewComboBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewComboBoxColumn LoaiBanh;
        private System.Windows.Forms.DataGridViewComboBoxColumn LoaiTui;
    }
}