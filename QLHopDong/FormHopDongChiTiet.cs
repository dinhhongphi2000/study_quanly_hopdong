using QLHopDong.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHopDong
{
    public partial class FormHopDongChiTiet : Form
    {
        //Sự kiện xử lý việc thêm dữ liệu thành công
        public delegate void OnAdded();
        public event OnAdded DataAdded;
        //Sự kiện xử lý việc cập nhật dữ liệu thành công
        public delegate void OnEdited();
        public event OnEdited DataEdited;

        //Object hỗ trợ thao tác cập nhật dữ liệu vào database
        private HopDongHandler _hopDongHandler = null;
        private ChiTietHDHandler _chiTietHDHandler = null;
        //Object lưu trữ thông tin khách hàng
        private DataTable _khachHangTable = null;
        //Object lưu trữ danh sách hàng hóa
        private DataTable _hanghoaTable = null;
        //Object lưu trữ danh sách bành
        private DataTable _banhTable = null;
        //Object lưu trữ thông tin túi
        private DataTable _tuiTable = null;
        //Object lưu trữ thông tin hợp đồng
        private DataTable _hopdongTable = null;
        //Object lưu trữ chi tiết hợp đồng
        private DataTable _chiTietHDTable = null;
        //_thaoTac cho biết được người dùng đang thao tac sửa hay thêm
        //1 - Thao tác thêm
        //2 - Thao tác sửa
        //3 - Xem chi tiết
        //0 - Không rõ
        private int _thaoTac = 0;

        public FormHopDongChiTiet(int thaotac, string soHD = "")
        {
            //Thiết lập thao tác cho form
            _thaoTac = thaotac;
            InitializeComponent();
            //khởi tạo đối tượng thực hiện các thao tác thêm, xóa, sửa vào database
            _hopDongHandler = new HopDongHandler();
            _chiTietHDHandler = new ChiTietHDHandler();
            if (_thaoTac == 1)
            {
                //Khởi tạo table để lưu dữ liệu
                _hopdongTable = _hopDongHandler.TaoBangMau();
                //Khởi tạo một bảng chi tiết hợp đồng để chứa chi tiết hợp đồng
                _chiTietHDTable = _chiTietHDHandler.TaoBangMau();
                //liên kết bảng chi tiết hợp đồng với datagridview, để hiển thị dữ liệu
                dgvChiTietHD.DataSource = _chiTietHDTable;
            }
            else if (_thaoTac == 2)
            {
                //Form đang thực hiện thao tác sửa
                txtSoHD.Enabled = false;
                HienThiDuLieu(soHD);

            }
            else if (_thaoTac == 3)
            {
                //Form đang thực hiện thao tác xem chi tiết
                //disable các control để không cho user chỉnh sửa
                pnlData.Enabled = false;
                btnXoa.Visible = false;
                dgvChiTietHD.AllowUserToAddRows = false;
                btnCapNhat.Visible = false;
                HienThiDuLieu(soHD);
            }
            //bắt sự kiện tính tổng tiền cho Cột Thành tiền
            _chiTietHDTable.RowChanged += _chiTietHDTable_RowChanged;
        }

        /// <summary>
        /// Thực hiện tính lại tổng tiền của hợp đồng sau khi có sự thay đổi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _chiTietHDTable_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            HienThiTongTien(_chiTietHDTable.Rows.IndexOf(e.Row));
        }

        /// <summary>
        /// Hiển thị chi tiết dữ liệu của hợp đồng
        /// </summary>
        private void HienThiDuLieu(string soHD)
        {
            //Lấy và hiển thị thông tin hợp đồng
            _hopdongTable = _hopDongHandler.LayHopDongBangSoHD(soHD);
            if (_hopdongTable.Rows.Count > 0)
            {
                DataRow row = _hopdongTable.Rows[0];
                HienThiDanhSachKhachHang();
                //có dữ liệu tướng ứng với soHD được đưa cho
                txtSoHD.Text = row["SoHD"].ToString();
                txtThueSuat.Text = row["ThueSuat"].ToString();
                txtPPThanhToan.Text = row["PTThanhToan"].ToString();
                dtpNgayHD.Text = row["NgayHD"].ToString();
                dtpNgayHetHanHopDong.Text = row["NgayHetHanHD"].ToString();
                dtpThoiHanGiaoHang.Text = row["ThoiHanGiaoHang"].ToString();
                cbbKhachHang.SelectedValue = row["MaKH"];
            }
            //Hiển thị loại túi
            DataGridViewComboBoxColumn loaitui = (DataGridViewComboBoxColumn)dgvChiTietHD.Columns["LoaiTui"];
            HienThiDanhSachTui(loaitui);
            //Hiener thị loại bành
            DataGridViewComboBoxColumn loaibanh = (DataGridViewComboBoxColumn)dgvChiTietHD.Columns["LoaiBanh"];
            HienThiDanhSachBanh(loaibanh);
            //Hiển thị danh sách hàng hóa
            DataGridViewComboBoxColumn loaihang = (DataGridViewComboBoxColumn)dgvChiTietHD.Columns["TenHang"];
            HienThiDanhSachHangHoa(loaihang);
            //Lấy và hiển thị chi tiết hợp đồng
            _chiTietHDTable = _chiTietHDHandler.LayDuLieuTheoSoHD(soHD);
            dgvChiTietHD.DataSource = _chiTietHDTable;

        }

        /// <summary>
        /// Load thông tin khách hàng để hiển thị nếu chưa có
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_Enter(object sender, EventArgs e)
        {
            //Nếu chưa load dữ liệu khách hàng thì thực hiện lấy dữ liệu
            if (_khachHangTable == null)
            {
                HienThiDanhSachKhachHang();
            }
        }

        private void dgvChiTietHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Nếu header được chọn thì return
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            //Lấy thông tin cell được click
            var cell = dgvChiTietHD.Rows[e.RowIndex].Cells[e.ColumnIndex];
            //Nếu cell được click nằm trong cột loại bành thì ta load dữ liệu bành lên nếu chưa có
            if (cell.OwningColumn.Name == "LoaiBanh")
            {
                DataGridViewComboBoxColumn combobox = (DataGridViewComboBoxColumn)cell.OwningColumn;
                //Nếu chưa có thông tin về bành
                if (_banhTable == null)
                {
                    HienThiDanhSachBanh(combobox);
                }
            }
            //Nếu cell được click nằm trong cột túi thì ta load dữ liệu túi nếu chưa có
            if (cell.OwningColumn.Name == "LoaiTui")
            {
                DataGridViewComboBoxColumn combobox = (DataGridViewComboBoxColumn)cell.OwningColumn;
                //Nếu chưa có thông tin về bành
                if (_tuiTable == null)
                {
                    HienThiDanhSachTui(combobox);
                }
            }
            //Nếu cell được click nằm trong cột tên hàng thì ta load dữ liệu hàng hóa nếu chưa có
            if (cell.OwningColumn.Name == "TenHang")
            {
                DataGridViewComboBoxColumn combobox = (DataGridViewComboBoxColumn)cell.OwningColumn;
                //Nếu chưa có thông tin về bành
                if (_hanghoaTable == null)
                {
                    HienThiDanhSachHangHoa(combobox);
                }

                //Khi một dòng được thêm thì thêm SoHD vào dòng đó
                if (dgvChiTietHD.Columns[e.ColumnIndex].Name == "TenHang")
                {
                    dgvChiTietHD.Rows[e.RowIndex].Cells["SoHD"].Value = txtSoHD.Text;
                }
            }
        }

        private void HienThiDanhSachHangHoa(DataGridViewComboBoxColumn combobox)
        {
            //gọi handler để load dữ liệu từ database
            HangHoaHandler handler = new HangHoaHandler();
            _hanghoaTable = handler.LayDuLieu();
            combobox.DataSource = _hanghoaTable;
            combobox.DisplayMember = "Ten";
            combobox.ValueMember = "Ma";
        }

        private void HienThiDanhSachTui(DataGridViewComboBoxColumn combobox)
        {
            //gọi handler để load dữ liệu từ database
            TuiHandler handler = new TuiHandler();
            _tuiTable = handler.LayDuLieu();
            combobox.DataSource = _tuiTable;
            combobox.DisplayMember = "Loai";
            combobox.ValueMember = "Ma";
        }

        private void HienThiDanhSachBanh(DataGridViewComboBoxColumn combobox)
        {
            //gọi handler để load dữ liệu từ database
            BanhHandler handler = new BanhHandler();
            _banhTable = handler.LayDuLieu();
            combobox.DataSource = _banhTable;
            combobox.DisplayMember = "TrongLuongBanh";
            combobox.ValueMember = "Ma";
        }

        private void HienThiDanhSachKhachHang()
        {
            //khởi tạo đối tượng thao tác với database
            KhachHangHandler handler = new KhachHangHandler();
            //lấy dữ liệu từ database và hiển thị lên combobox
            _khachHangTable = handler.LayDuLieu();
            cbbKhachHang.DataSource = _khachHangTable;
            cbbKhachHang.DisplayMember = "TenKhachHang";
            cbbKhachHang.ValueMember = "Ma";
        }

        private void FormHopDongChiTiet_Load(object sender, EventArgs e)
        {
            //format datagridview
            dgvChiTietHD.Columns["Ma"].Visible = false;
            dgvChiTietHD.Columns["SoHD"].Visible = false;
            //không cần hiển thị tổng tiền khi thao tác thêm vừa load, vì chưa có dữ liệu
            if (_thaoTac == 1)
                return;
            HienThiTongTien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //lấy vị trí hàng hóa cần xóa
            int index = dgvChiTietHD.CurrentRow.Index;
            if (index >= 0)
            {
                //tiến hành xóa row
                _chiTietHDTable.Rows.RemoveAt(index);
                MessageBox.Show("Xóa thành công mặt hàng", "Thành công", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mặt hàng cần xóa", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void txtPPThanhToan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoHD_Leave(object sender, EventArgs e)
        {
            //Khi số hóa đơn trên bảng Contract thay đổi
            //thiết lập lại giá trị SoHD trên bảng ContractDetail
            foreach (DataRow row in _chiTietHDTable.Rows)
            {
                row["SoHD"] = txtSoHD.Text;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (_thaoTac == 1)
            {
                //Thực hiện thêm mới Contract và ContractDetail vào database
                try
                {
                    _hopdongTable.Clear();
                    DataRow row = _hopdongTable.NewRow();
                    row["SoHD"] = txtSoHD.Text;
                    row["NgayHD"] = dtpNgayHD.Text;
                    row["NgayHetHanHD"] = dtpNgayHetHanHopDong.Text;
                    row["ThoiHanGiaoHang"] = dtpThoiHanGiaoHang.Text;
                    row["MaKH"] = cbbKhachHang.SelectedValue;
                    row["ThueSuat"] = txtThueSuat.Text;
                    row["PTThanhToan"] = txtPPThanhToan.Text;
                    _hopdongTable.Rows.Add(row);

                    _hopDongHandler.UpdateDuLieu(_hopdongTable);
                    _chiTietHDHandler.UpdateDuLieu(_chiTietHDTable);
                    //Gọi hàm xử lý việc thêm, sửa dữ liệu thành công
                    if (DataAdded != null)
                    {
                        DataAdded();
                    }

                    this.Close();
                    MessageBox.Show("Đã thêm thành công hợp đồng", "Thành công", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);
                }
            }
            else if (_thaoTac == 2)
            {
                //Thực hiện việc cập nhật lại hợp đồng
                try
                {
                    DataRow row = _hopdongTable.Rows[0];
                    row["SoHD"] = txtSoHD.Text;
                    row["NgayHD"] = dtpNgayHD.Text;
                    row["NgayHetHanHD"] = dtpNgayHetHanHopDong.Text;
                    row["ThoiHanGiaoHang"] = dtpThoiHanGiaoHang.Text;
                    row["MaKH"] = cbbKhachHang.SelectedValue;
                    row["ThueSuat"] = txtThueSuat.Text;
                    row["PTThanhToan"] = txtPPThanhToan.Text;

                    _hopDongHandler.UpdateDuLieu(_hopdongTable);
                    _chiTietHDHandler.UpdateDuLieu(_chiTietHDTable);
                    //Gọi hàm xử lý việc thêm, sửa dữ liệu thành công
                    if (DataEdited != null)
                    {
                        DataEdited();
                    }
                    this.Close();
                    MessageBox.Show("Đã thêm thành công hợp đồng", "Thành công", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);
                }
            }
        }

        private void dgvChiTietHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        /// <summary>
        /// Hiển thị tổng tiên lên datagridview
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="columnIndex"></param>
        private void HienThiTongTien(int rowIndex = -1)
        {
            if (rowIndex == -1)
            {
                
                decimal tongtien = 0;
                //Tính thành tiền của toàn bộ bảng
                for (int i = 0; i < _chiTietHDTable.Rows.Count; i++)
                {
                    DataRow row = _chiTietHDTable.Rows[i];
                    if (row["SoLuong"] != DBNull.Value && row["DonGia"] != DBNull.Value)
                    {
                        decimal thanhtien = decimal.Parse(row["SoLuong"].ToString()) * decimal.Parse(row["DonGia"].ToString());
                        tongtien += thanhtien;
                        dgvChiTietHD.Rows[i].Cells["ThanhTien"].Value = thanhtien;
                    }
                }

                //tổng tiền sau khi áp dụng thuế suất
                if (txtThueSuat.Text == String.Empty)
                    return;
                tongtien += tongtien * ( decimal.Parse(txtThueSuat.Text) / 100);
                txtTongTien.Text = tongtien.ToString("#,##");
            }
            else
            {
                if (txtTongTien.Text == String.Empty)
                    return;
                decimal tongtien = decimal.Parse(txtTongTien.Text);
                //Tính thành tiền của một hàng cụ thể
                DataRow row = _chiTietHDTable.Rows[rowIndex];
                if (row["SoLuong"] != DBNull.Value && row["DonGia"] != DBNull.Value)
                {
                    decimal thanhtien = decimal.Parse(row["SoLuong"].ToString()) * decimal.Parse(row["DonGia"].ToString());
                    tongtien += thanhtien;
                    dgvChiTietHD.Rows[rowIndex].Cells["ThanhTien"].Value = thanhtien;
                    //tổng tiền sau khi áp dụng thuế suất
                    if (txtThueSuat.Text == String.Empty)
                        return;
                    tongtien += thanhtien * (decimal.Parse(txtThueSuat.Text) / 100 );
                    txtTongTien.Text = tongtien.ToString("#,##");
                }
                
            }
        }

        private void txtThueSuat_Leave(object sender, EventArgs e)
        {
            //cập nhật lại tổng tiền khi thuế suất thay đổi
            HienThiTongTien();
        }
    }
}
