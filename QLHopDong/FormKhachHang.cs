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
    public partial class FormKhachHang : Form
    {
        //Lưu danh sách khách hàng
        private DataTable _khachHangTable = null;
        //Object thao tác với database
        private KhachHangHandler _databaseHandler = null;
        //_thaoTac cho biết được người dùng đang thao tac sửa hay thêm
        //1 - Thao tác thêm
        //2 - Thao tác sửa
        //0 - Không rõ
        private int _thaoTac = 0;

        public FormKhachHang()
        {
            InitializeComponent();
            //khởi tạo đối tượng xử lý các thao tác thêm, xóa, sửa tới database
            _databaseHandler = new KhachHangHandler();
            //Lấy danh sách khách hàng từ database
            _khachHangTable = _databaseHandler.LayDuLieu();
        }

        /// <summary>
        /// Hiển thị dữ liệu từ row được chọn lên textbox
        /// </summary>
        /// <param name="rowIndex">Vị trí của row cần hiển thị</param>
        private void HienThiDuLieu(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= _khachHangTable.Rows.Count)
                return;
            //Lấy dữ liệu tại vị trí rowIndex
            var rowSelected = _khachHangTable.Rows[rowIndex];
            //Hiển thị dữ liệu lên textbox nếu rowIndex valid
            if (rowSelected != null)
            {
                txtMa.Text = rowSelected["Ma"].ToString();
                txtTenKhachHang.Text = rowSelected["TenKhachHang"].ToString();
                txtDiaChi.Text = rowSelected["DiaChi"].ToString();
                txtMaSoThue.Text = rowSelected["MaSoThue"].ToString();
                txtTel.Text = rowSelected["Tel"].ToString();
                txtFax.Text = rowSelected["Fax"].ToString();
                txtEmail.Text = rowSelected["Email"].ToString();
                txtSoTaiKhoan.Text = rowSelected["TaiKhoan"].ToString();
                txtNguoiDaiDien.Text = rowSelected["DaiDien"].ToString();
                txtChucVu.Text = rowSelected["ChucVuDaiDien"].ToString();
            }
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = _khachHangTable;
            ChoPhepChinhSua(false);
            //mặc định hiển thị dữ liệu của row số 0 lên textbox
            HienThiDuLieu(0);
        }

        /// <summary>
        /// Xử lý sự kiện thêm khách hàng mới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            //Xác định chức năng của nút btnThem 
            if (btnThem.Tag.ToString() == "Add")
            {
                //Chức năng của btnThem lúc này là Thêm khách hàng (Add)
                //bắt đầu thao tác thêm
                BatDauThaoTac(1);
            }
            else
            {
                //Chức năng của btnThem lúc này là hủy (Cancel) theo tác thêm, sửa
                //btnThem.Tag == "Cancel"
                HuyThaoTac();
            }
        }

        /// <summary>
        /// Bắt đầu thao tác chỉnh sửa hoặc thêm dữ liệu
        /// </summary>
        /// <param name="thaotac"></param>
        private void BatDauThaoTac(int thaotac)
        {
            _thaoTac = thaotac;
            btnThem.Tag = "Cancel";
            btnThem.Text = "Cancel";
            btnCapNhat.Visible = true;
            btnXoa.Visible = false;
            pnlData.Enabled = true;
            btnSua.Visible = false;
            dgvKhachHang.Enabled = false;
            //nếu là thao tác thêm
            if (thaotac == 1)
            {

                //xóa dữ liệu trên textbox để nhập mới
                ClearInputData();
            }
        }

        //Hủy bỏ thao tác người dùng đang làm và hiển thị lại các chức năng khác
        private void HuyThaoTac()
        {
            _thaoTac = 0;
            btnThem.Tag = "Add";
            btnThem.Text = "Thêm";
            btnXoa.Visible = true;
            btnSua.Visible = true;
            pnlData.Enabled = false;
            btnCapNhat.Visible = false;
            dgvKhachHang.Enabled = true;
            //Hiển thị lại dữ liệu được chọn
            var rowSelected = dgvKhachHang.CurrentCell;
            HienThiDuLieu(rowSelected.RowIndex);
        }

        /// <summary>
        /// Xóa dữ liệu trên textbox để nhập mới
        /// </summary>
        private void ClearInputData()
        {
            txtMa.Clear();
            txtTenKhachHang.Clear();
            txtDiaChi.Clear();
            txtChucVu.Clear();
            txtEmail.Clear();
            txtFax.Clear();
            txtMaSoThue.Clear();
            txtNguoiDaiDien.Clear();
            txtSoTaiKhoan.Clear();
            txtTel.Clear();
        }

        /// <summary>
        /// Xử lý sự kiện xóa một khách hàng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            var rowSelected = dgvKhachHang.CurrentRow;
            //kiểm tra khách hàng cần xóa đã được chọn hay chưa
            if (rowSelected.Index >= 0)
            {
                //xác thực việc xóa
                string message = String.Format("Bạn có thực sự muốn xóa khách hàng có mã số {0}", 
                                                _khachHangTable.Rows[rowSelected.Index]["Ma"]);
                DialogResult result = MessageBox.Show(message, "Xác thực hành vi", MessageBoxButtons.OKCancel);
                if(result == DialogResult.OK)
                {
                    try
                    {
                        //đã có thông tin khách hàng cần xóa
                        //thay đổi trạng thái của row đó là deleted
                        _khachHangTable.Rows[rowSelected.Index].Delete();
                        //thông báo cho database tiến hành xóa hàng đã chọn
                        _databaseHandler.UpdateDuLieu(_khachHangTable);
                        MessageBox.Show("Đã xóa khách hàng thành công", "Thành công", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        //Có lỗi xảy ra khi tiến hành xóa khách hàng
                        MessageBox.Show(ex.Message, "Thất bại", MessageBoxButtons.OK);
                        //phục hồi lại thông tin khách hàng không xóa được
                        _khachHangTable.RejectChanges();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa", "Cảnh báo", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Hiển thị dữ liệu của row được double click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowSelected = dgvKhachHang.CurrentRow;
            //kiểm tra người dùng đã chọn row chưa
            if (rowSelected.Index >= 0)
            {
                //Đã có row được chọn
                //hiển thị dữ liệu của row đó lên textbox
                HienThiDuLieu(rowSelected.Index);
            }
        }

        /// <summary>
        /// Disable hoặc enable textbox
        /// </summary>
        /// <param name="allow"></param>
        private void ChoPhepChinhSua(bool allow = true)
        {
            if (allow)
            {
                pnlData.Enabled = true;
            }
            else
            {
                pnlData.Enabled = false;
            }
        }

        /// <summary>
        /// Kiểm tra thao tác của người dùng và thực hiện cập nhật dữ liệu xuống database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (_thaoTac == 1)
            {
                //đang thực hiện thao tác thêm
                //tạo một record mới để lưu thông tin khách hàng
                DataRow row = _khachHangTable.NewRow();
                row["Ma"] = txtMa.Text;
                row["TenKhachHang"] = txtTenKhachHang.Text;
                row["DiaChi"] = txtDiaChi.Text;
                row["MaSoThue"] = txtMaSoThue.Text;
                row["Tel"] = txtTel.Text;
                row["Fax"] = txtFax.Text;
                row["Email"] = txtEmail.Text;
                row["TaiKhoan"] = txtSoTaiKhoan.Text;
                row["DaiDien"] = txtNguoiDaiDien.Text;
                row["ChucVuDaiDien"] = txtChucVu.Text;

                //thông báo cho database lưu khách hàng mới
                try
                {
                    _khachHangTable.Rows.Add(row);
                    _databaseHandler.UpdateDuLieu(_khachHangTable);
                    MessageBox.Show("Đã thêm khách hàng thành công", "Thành công", MessageBoxButtons.OK);
                    //Cập nhật thành công, hủy thao tác thêm
                    int rowCount = _khachHangTable.Rows.Count;
                    dgvKhachHang.Rows[rowCount - 1].Selected = true;
                    HuyThaoTac();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thất bại", MessageBoxButtons.OK);
                    //Thêm khách hàng mới không thành công
                    //Đưa table trở về trạng thái ban đầu
                    _khachHangTable.RejectChanges();
                }
            }
            else if (_thaoTac == 2)
            {
                //đang thực hiện thao tác sửa
                var rowEditingIndex = dgvKhachHang.CurrentRow.Index;
                var row = _khachHangTable.Rows[rowEditingIndex];
                row["Ma"] = txtMa.Text;
                row["TenKhachHang"] = txtTenKhachHang.Text;
                row["DiaChi"] = txtDiaChi.Text;
                row["MaSoThue"] = txtMaSoThue.Text;
                row["Tel"] = txtTel.Text;
                row["Fax"] = txtFax.Text;
                row["Email"] = txtEmail.Text;
                row["TaiKhoan"] = txtSoTaiKhoan.Text;
                row["DaiDien"] = txtNguoiDaiDien.Text;
                row["ChucVuDaiDien"] = txtChucVu.Text;
                try
                {
                    //cập nhật dữ liệu xuống database
                    _databaseHandler.UpdateDuLieu(_khachHangTable);
                    //kết thúc thao tác sửa
                    HuyThaoTac();
                    MessageBox.Show("Cập nhật thành công", "Thành công", MessageBoxButtons.OK);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thất bại", MessageBoxButtons.OK);
                    //Có lỗi xảy ra đưa dữ liệu về trạng thái cũ
                    _khachHangTable.RejectChanges();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //bắt đầu cho phép chỉnh sửa
            BatDauThaoTac(2);
        }
    }
}
