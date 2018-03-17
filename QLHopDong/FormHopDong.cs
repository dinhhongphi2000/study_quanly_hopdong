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
    public partial class FormHopDong : Form
    {
        //Lưu danh sách túi
        private DataTable _hopdongTable = null;
        //Object thao tác với database
        private HopDongHandler _databaseHandler = null;
        //_thaoTac cho biết được người dùng đang thao tac sửa hay thêm
        //1 - Thao tác thêm
        //2 - Thao tác sửa
        //0 - Không rõ
        private int _thaoTac = 0;

        public FormHopDong()
        {
            InitializeComponent();
            //khởi tạo đối tượng thực hiện các thao tác thêm, xóa, sửa vào database
            _databaseHandler = new HopDongHandler();
            //lấy danh sách túi từ database
            _hopdongTable = _databaseHandler.LayDuLieuVoiTongTien();
        }

        private void FormHopDong_Load(object sender, EventArgs e)
        {
            //hiển thị danh sách hợp đồng 
            dgvHopDong.DataSource = _hopdongTable;
        }

        /// <summary>
        /// Xử lý sự kiện thêm hợp đồng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            //Hiển thị form để thêm hợp đồng
            FormHopDongChiTiet form = new FormHopDongChiTiet(1);
            form.DataAdded += () =>
            {
                //lấy danh sách túi từ database
                _hopdongTable = _databaseHandler.LayDuLieuVoiTongTien();
                //hiển thị danh sách hợp đồng 
                dgvHopDong.DataSource = _hopdongTable;
            };

            form.ShowDialog();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            //Xác định hợp đồng cần được hiển thị chi tiết
            int index = dgvHopDong.CurrentRow.Index;
            if(index >= 0)
            {
                //gọi form để hiển thị dữ liệu hợp đồng được chọn
                FormHopDongChiTiet form = new FormHopDongChiTiet(3,_hopdongTable.Rows[index]["SoHD"].ToString());
                form.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Xác nhận lại việc xóa
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
                return;

            //Tiến hành xóa hợp đồng và chi tiết hợp đồng
            //Xác định hợp đồng cần được hiển thị chi tiết
            int index = dgvHopDong.CurrentRow.Index;
            if (index >= 0)
            {
                try
                {
                    _databaseHandler.DeleteHopDong(_hopdongTable.Rows[index]["SoHD"].ToString());
                    _hopdongTable.Rows.RemoveAt(index);
                    MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"Lỗi",MessageBoxButtons.OK);
                }
                
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Xác định hợp đồng cần được hiển thị chi tiết
            int index = dgvHopDong.CurrentRow.Index;
            if (index >= 0)
            {
                //gọi form để hiển thị dữ liệu hợp đồng được chọn
                FormHopDongChiTiet form = new FormHopDongChiTiet(2, _hopdongTable.Rows[index]["SoHD"].ToString());
                form.DataEdited += () =>
                {
                    //lấy danh sách túi từ database
                    _hopdongTable = _databaseHandler.LayDuLieuVoiTongTien();
                    //hiển thị danh sách hợp đồng 
                    dgvHopDong.DataSource = _hopdongTable;
                };

                form.ShowDialog();
            }
        }
    }
}
