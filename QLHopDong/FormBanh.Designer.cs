namespace QLHopDong
{
    partial class FormBanh
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaBanh = new System.Windows.Forms.TextBox();
            this.txtTrongLuongBanh = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dgvBanh = new System.Windows.Forms.DataGridView();
            this.MaBanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrongLuongBanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.pnlData = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanh)).BeginInit();
            this.pnlData.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Bành";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Trọng lượng bành";
            // 
            // txtMaBanh
            // 
            this.txtMaBanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaBanh.Location = new System.Drawing.Point(9, 14);
            this.txtMaBanh.Name = "txtMaBanh";
            this.txtMaBanh.Size = new System.Drawing.Size(228, 26);
            this.txtMaBanh.TabIndex = 1;
            // 
            // txtTrongLuongBanh
            // 
            this.txtTrongLuongBanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTrongLuongBanh.Location = new System.Drawing.Point(9, 48);
            this.txtTrongLuongBanh.Name = "txtTrongLuongBanh";
            this.txtTrongLuongBanh.Size = new System.Drawing.Size(228, 26);
            this.txtTrongLuongBanh.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(16, 100);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(126, 46);
            this.btnThem.TabIndex = 2;
            this.btnThem.Tag = "Add";
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(148, 100);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(126, 46);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(280, 100);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(126, 46);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dgvBanh
            // 
            this.dgvBanh.AllowUserToAddRows = false;
            this.dgvBanh.AllowUserToDeleteRows = false;
            this.dgvBanh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBanh.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvBanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBanh,
            this.TrongLuongBanh});
            this.dgvBanh.Location = new System.Drawing.Point(1, 150);
            this.dgvBanh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBanh.MultiSelect = false;
            this.dgvBanh.Name = "dgvBanh";
            this.dgvBanh.ReadOnly = true;
            this.dgvBanh.RowHeadersVisible = false;
            this.dgvBanh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBanh.Size = new System.Drawing.Size(575, 200);
            this.dgvBanh.TabIndex = 11;
            this.dgvBanh.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBanh_CellDoubleClick);
            // 
            // MaBanh
            // 
            this.MaBanh.DataPropertyName = "Ma";
            this.MaBanh.HeaderText = "Mã Bành";
            this.MaBanh.Name = "MaBanh";
            this.MaBanh.ReadOnly = true;
            // 
            // TrongLuongBanh
            // 
            this.TrongLuongBanh.DataPropertyName = "TrongLuongBanh";
            this.TrongLuongBanh.HeaderText = "Trọng lượng bành";
            this.TrongLuongBanh.Name = "TrongLuongBanh";
            this.TrongLuongBanh.ReadOnly = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(439, 100);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(126, 46);
            this.btnCapNhat.TabIndex = 12;
            this.btnCapNhat.Tag = "Edit";
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Visible = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.txtTrongLuongBanh);
            this.pnlData.Controls.Add(this.txtMaBanh);
            this.pnlData.Enabled = false;
            this.pnlData.Location = new System.Drawing.Point(148, 12);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(258, 82);
            this.pnlData.TabIndex = 13;
            // 
            // FormBanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 353);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.dgvBanh);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlData);
            this.Name = "FormBanh";
            this.Text = "FormBanh";
            this.Load += new System.EventHandler(this.FormBanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanh)).EndInit();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaBanh;
        private System.Windows.Forms.TextBox txtTrongLuongBanh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dgvBanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrongLuongBanh;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Panel pnlData;
    }
}