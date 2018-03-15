using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHopDong.Model
{
    public class DbHandler : DatabaseConnection
    {
        private readonly SqlDataAdapter _adapter;

        public DbHandler(string selectCommand)
        {
            _adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(selectCommand, _connection);
            _adapter.SelectCommand = cmd;
            SqlCommandBuilder builder = new SqlCommandBuilder(_adapter);
        }

        /// <summary>
        /// Lấy thông tin khách hàng
        /// </summary>
        /// <returns></returns>
        public DataTable LayDuLieu()
        {
            DataTable table = new DataTable();
            //Thực thi lệnh dưới database để lấy dữ liệu
            try
            {
                OpenConnection();
                _adapter.Fill(table);
                CloseConnection();
                return table;
            }
            catch (SqlException)
            {
                return null;
            }
        }

        public virtual void UpdateDuLieu(DataTable table)
        {
            //Thực thi lệnh dưới database để thêm khách hàng
            OpenConnection();
            _adapter.Update(table);
            CloseConnection();
        }
    }
}
