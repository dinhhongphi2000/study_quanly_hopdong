using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHopDong.Model
{
    public class ChiTietHDHandler : DbHandler
    {
        public ChiTietHDHandler() : base("SELECT * FROM ContractDetail")
        {
        }

        /// <summary>
        /// Tạo một table mẫu để lưu trữ dữ liệu với các column như bảng thật
        /// </summary>
        /// <returns></returns>
        public DataTable TaoBangMau()
        {
            base.SetSelectCommand(@"SELECT TOP 0 * FROM ContractDetail");
            DataTable table = base.LayDuLieu();
            base.SetSelectCommand(@"SELECT * FROM ContractDetail");
            return table;
        }

        /// <summary>
        /// Lấy chi tiết hợp đồng theo số hợp đồng
        /// </summary>
        /// <param name="soHD"></param>
        /// <returns></returns>
        public DataTable LayDuLieuTheoSoHD(string soHD)
        {
            base.SetSelectCommand(@"SELECT * FROM ContractDetail WHERE SoHD = '" + soHD + "'");
            DataTable table = base.LayDuLieu();
            base.SetSelectCommand(@"SELECT * FROM ContractDetail");
            return table;
        }
    }
}
