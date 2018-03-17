namespace QLHopDong
{
    partial class FormTui
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
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtLoaiTui = new System.Windows.Forms.TextBox();
            this.txtMaTui = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.pnlData = new System.Windows.Forms.Panel();
            this.dgvTui = new System.Windows.Forms.DataGridView();
            this.MaTui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiTui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTui)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(284, 101);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(126, 46);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(148, 101);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(126, 46);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(12, 101);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(126, 46);
            this.btnThem.TabIndex = 9;
            this.btnThem.Tag = "Add";
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtLoaiTui
            // 
            this.txtLoaiTui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLoaiTui.Location = new System.Drawing.Point(12, 47);
            this.txtLoaiTui.Name = "txtLoaiTui";
            this.txtLoaiTui.Size = new System.Drawing.Size(228, 26);
            this.txtLoaiTui.TabIndex = 5;
            // 
            // txtMaTui
            // 
            this.txtMaTui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaTui.Location = new System.Drawing.Point(12, 14);
            this.txtMaTui.Name = "txtMaTui";
            this.txtMaTui.Size = new System.Drawing.Size(228, 26);
            this.txtMaTui.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại túi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Túi";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(456, 101);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(126, 46);
            this.btnCapNhat.TabIndex = 11;
            this.btnCapNhat.Tag = "Edit";
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Visible = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.txtLoaiTui);
            this.pnlData.Controls.Add(this.txtMaTui);
            this.pnlData.Enabled = false;
            this.pnlData.Location = new System.Drawing.Point(126, 12);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(259, 83);
            this.pnlData.TabIndex = 12;
            // 
            // dgvTui
            // 
            this.dgvTui.AllowUserToAddRows = false;
            this.dgvTui.AllowUserToDeleteRows = false;
            this.dgvTui.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTui.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvTui.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTui.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTui,
            this.LoaiTui});
            this.dgvTui.Location = new System.Drawing.Point(12, 157);
            this.dgvTui.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTui.MultiSelect = false;
            this.dgvTui.Name = "dgvTui";
            this.dgvTui.ReadOnly = true;
            this.dgvTui.RowHeadersVisible = false;
            this.dgvTui.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTui.Size = new System.Drawing.Size(570, 208);
            this.dgvTui.TabIndex = 16;
            // 
            // MaTui
            // 
            this.MaTui.DataPropertyName = "Ma";
            this.MaTui.HeaderText = "Mã túi";
            this.MaTui.Name = "MaTui";
            this.MaTui.ReadOnly = true;
            // 
            // LoaiTui
            // 
            this.LoaiTui.DataPropertyName = "Loai";
            this.LoaiTui.HeaderText = "Loại túi";
            this.LoaiTui.Name = "LoaiTui";
            this.LoaiTui.ReadOnly = true;
            // 
            // FormTui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 379);
            this.Controls.Add(this.dgvTui);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlData);
            this.Name = "FormTui";
            this.Text = "FormTui";
            this.Load += new System.EventHandler(this.FormTui_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTui)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtLoaiTui;
        private System.Windows.Forms.TextBox txtMaTui;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridView dgvTui;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTui;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiTui;
    }
}