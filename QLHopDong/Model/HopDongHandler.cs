using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHopDong.Model
{
    public class HopDongHandler : DbHandler
    {
        public HopDongHandler() : 
            base(@"SELECT * FROM CONTRACT")
        {
        }

        public DataTable LayDuLieuVoiTongTien()
        {
            base.SetSelectCommand(@"SELECT hd.SoHD, hd.NgayHD, hd.NgayHetHanHD, hd.ThoiHanGiaoHang, hd.MaKH, hd.ThueSuat, hd.PTThanhToan,
		            kh.TenKhachHang, SUM(hdd.SoLuong * hdd.DonGia) * hd.ThueSuat/100 + SUM(hdd.SoLuong * hdd.DonGia) as Tong
                FROM [Contract] as hd
                LEFT JOIN [ContractDetail] as hdd ON hd.SoHD = hdd.SoHD
                LEFT JOIN [Customer] as kh ON hd.MaKH = kh.Ma
                GROUP BY hd.SoHD, hd.NgayHD, hd.NgayHetHanHD, hd.ThoiHanGiaoHang, hd.MaKH, hd.ThueSuat, hd.PTThanhToan,
		            kh.TenKhachHang");
            return base.LayDuLieu();
        }

        /// <summary>
        /// Tạo một table mẫu để lưu trữ dữ liệu với các column như bảng thật
        /// </summary>
        /// <returns></returns>
        public DataTable TaoBangMau()
        {
            base.SetSelectCommand(@"SELECT TOP 0 * FROM Contract");
            DataTable table = base.LayDuLieu();
            base.SetSelectCommand(@"SELECT * FROM Contract");
            return table;
        }

        public DataRow LayDuLieuVoiTongTienBangSoHD(string soHD)
        {
            base.SetSelectCommand(@"SELECT hd.SoHD, hd.NgayHD, hd.NgayHetHanHD, hd.ThoiHanGiaoHang, hd.MaKH, hd.ThueSuat, hd.PTThanhToan,
		            kh.TenKhachHang, SUM(hdd.SoLuong * hdd.DonGia) * hd.ThueSuat/100 + SUM(hdd.SoLuong * hdd.DonGia) as Tong
                FROM [Contract] as hd
                LEFT JOIN [ContractDetail] as hdd ON hd.SoHD = hdd.SoHD
                LEFT JOIN [Customer] as kh ON hd.MaKH = kh.Ma" +
                " WHERE hd.SoHD = '" + soHD + "' " +
                @"GROUP BY hd.SoHD, hd.NgayHD, hd.NgayHetHanHD, hd.ThoiHanGiaoHang, hd.MaKH, hd.ThueSuat, hd.PTThanhToan,
		            kh.TenKhachHang");
            DataTable table = base.LayDuLieu();
            //set default command
            base.SetSelectCommand(@"SELECT * FROM CONTRACT");
            if (table != null && table.Rows.Count > 0)
                return table.Rows[0];
            else
                return null;
        }

        /// <summary>
        /// Lấy thông tin hợp đồng bằng số hợp đồng
        /// </summary>
        /// <param name="soHD"></param>
        /// <returns></returns>
        public DataTable LayHopDongBangSoHD(string soHD)
        {
            base.SetSelectCommand("SELECT * FROM Contract WHERE SoHD='" + soHD + "'");
            DataTable table = base.LayDuLieu();
            //set default command
            base.SetSelectCommand(@"SELECT * FROM CONTRACT");
            return table;
        }

        public void DeleteHopDong(string soHD)
        {
            OpenConnection();
            string command = String.Format("DELETE FROM ContractDetail WHERE SoHD = '{0}'; ", soHD);
            command += String.Format("DELETE FROM Contract WHERE SoHD = '{0}'", soHD);
            SqlCommand commandSql = new SqlCommand(command, _connection);
            commandSql.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
