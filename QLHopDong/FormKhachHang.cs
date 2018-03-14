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
        private DataTable khachHangTable = null;
        //Object thao tác với database
        private KhachHangHandler _databaseHandler = null;

        public FormKhachHang()
        {
            InitializeComponent();
            _databaseHandler = new KhachHangHandler();
            khachHangTable = _databaseHandler.LayDuLieu();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = khachHangTable;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataRow row = khachHangTable.NewRow();
        }
    }
}
