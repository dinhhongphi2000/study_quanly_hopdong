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
    public partial class FormHangHoa : Form
    {
        //Lưu danh sách hàng hóa
        private DataTable _hangHoaTable = null;
        //Object thao tác với database
        private HangHoaHandler _databaseHandler = null;
        //_thaoTac cho biết được người dùng đang thao tac sửa hay thêm
        //1 - Thao tác thêm
        //2 - Thao tác sửa
        //0 - Không rõ
        private int _thaoTac = 0;

        public FormHangHoa()
        {
            InitializeComponent();
            //khởi tạo đối tượng xử lý các thao tác thêm, xóa, sửa tới database
            _databaseHandler = new HangHoaHandler();
            //Lấy danh sách hàng hóa từ database
            _hangHoaTable = _databaseHandler.LayDuLieu();
        }

        private void FormHangHoa_Load(object sender, EventArgs e)
        {
            dgvHangHoa.DataSource = _hangHoaTable;
            ChoPhepChinhSua(false);
            //mặc định hiển thị dữ liệu của row số 0 lên textbox
            HienThiDuLieu(0);
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
            dgvHangHoa.Enabled = false;
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
            dgvHangHoa.Enabled = true;
            //Hiển thị lại dữ liệu được chọn
            var rowSelected = dgvHangHoa.CurrentCell;
            HienThiDuLieu(rowSelected.RowIndex);
        }

        /// <summary>
        /// Xóa dữ liệu trên textbox để nhập mới
        /// </summary>
        private void ClearInputData()
        {
            txtMaHangHoa.Clear();
            txtTenHangHoa.Clear();
            txtDonVi.Clear();
            
        }

        /// <summary>
        /// Hiển thị dữ liệu từ row được chọn lên textbox
        /// </summary>
        /// <param name="rowIndex">Vị trí của row cần hiển thị</param>
        private void HienThiDuLieu(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= _hangHoaTable.Rows.Count)
                return;
            //Lấy dữ liệu tại vị trí rowIndex
            var rowSelected = _hangHoaTable.Rows[rowIndex];
            //Hiển thị dữ liệu lên textbox nếu rowIndex valid
            if (rowSelected != null)
            {
                txtMaHangHoa.Text = rowSelected["Ma"].ToString();
                txtTenHangHoa.Text = rowSelected["Ten"].ToString();
                txtDonVi.Text = rowSelected["DonVi"].ToString();
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
        /// Xử lý sự kiện thêm hàng hóa mới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            //Xác định chức năng của nút btnThem 
            if (btnThem.Tag.ToString() == "Add")
            {
                //Chức năng của btnThem lúc này là Thêm Hàng hóa (Add)
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
        /// Kiểm tra thao tác của người dùng và thực hiện cập nhật dữ liệu xuống database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (_thaoTac == 1)
            {
                //đang thực hiện thao tác thêm
                //tạo một record mới để lưu thông tin hàng hóa
                DataRow row = _hangHoaTable.NewRow();
                row["Ma"] = txtMaHangHoa.Text;
                row["Ten"] = txtTenHangHoa.Text;
                row["DonVi"] = txtDonVi.Text;

                //thông báo cho database lưu khách hàng mới
                try
                {
                    _hangHoaTable.Rows.Add(row);
                    _databaseHandler.UpdateDuLieu(_hangHoaTable);
                    MessageBox.Show("Đã thêm hàng hóa thành công", "Thành công", MessageBoxButtons.OK);
                    //Cập nhật thành công, hủy thao tác thêm
                    int rowCount = _hangHoaTable.Rows.Count;
                    dgvHangHoa.Rows[rowCount - 1].Selected = true;
                    HuyThaoTac();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thất bại", MessageBoxButtons.OK);
                    //Thêm hàng hóa mới không thành công
                    //Đưa table trở về trạng thái ban đầu
                    _hangHoaTable.RejectChanges();
                }
            }
            else if (_thaoTac == 2)
            {
                //đang thực hiện thao tác sửa
                var rowEditingIndex = dgvHangHoa.CurrentRow.Index;
                var row = _hangHoaTable.Rows[rowEditingIndex];
                row["Ma"] = txtMaHangHoa.Text;
                row["Ten"] = txtTenHangHoa.Text;
                row["DonVi"] = txtDonVi.Text;
                
                try
                {
                    //cập nhật dữ liệu xuống database
                    _databaseHandler.UpdateDuLieu(_hangHoaTable);
                    //kết thúc thao tác sửa
                    HuyThaoTac();
                    MessageBox.Show("Cập nhật thành công", "Thành công", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thất bại", MessageBoxButtons.OK);
                    //Có lỗi xảy ra đưa dữ liệu về trạng thái cũ
                    _hangHoaTable.RejectChanges();
                }
            }
        }

        /// <summary>
        /// Xử lý sự kiện xóa một hàng hóa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            var rowSelected = dgvHangHoa.CurrentRow;
            //kiểm tra hàng hóa cần xóa đã được chọn hay chưa
            if (rowSelected.Index >= 0)
            {
                //xác thực việc xóa
                string message = String.Format("Bạn có thực sự muốn xóa hàng hóa có mã số {0}",
                                                _hangHoaTable.Rows[rowSelected.Index]["Ma"]);
                DialogResult result = MessageBox.Show(message, "Xác thực hành vi", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        //đã có thông tin hang hóa cần xóa
                        //thay đổi trạng thái của row đó là deleted
                        _hangHoaTable.Rows[rowSelected.Index].Delete();
                        //thông báo cho database tiến hành xóa hàng đã chọn
                        _databaseHandler.UpdateDuLieu(_hangHoaTable);
                        MessageBox.Show("Đã xóa khách hàng thành công", "Thành công", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        //Có lỗi xảy ra khi tiến hành xóa hàng hóa
                        MessageBox.Show(ex.Message, "Thất bại", MessageBoxButtons.OK);
                        //phục hồi lại thông tin hàng hóa không xóa được
                        _hangHoaTable.RejectChanges();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng hóa cần xóa", "Cảnh báo", MessageBoxButtons.OK);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //bắt đầu cho phép chỉnh sửa
            BatDauThaoTac(2);
        }
    }
}
