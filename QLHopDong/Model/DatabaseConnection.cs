using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHopDong.Model
{
    /// <summary>
    /// Quản lý kết nối tới database
    /// </summary>
    public class DatabaseConnection : IDisposable
    {
        protected SqlConnection _connection = null;
        private static string _connectionString = "";

        public DatabaseConnection()
        {
            //Khởi tạo đối tượng chứa thông tin kết nối database
            if (_connection == null)
                _connection = new SqlConnection(_connectionString);
        }

        /// <summary>
        /// Đóng kết nối và hủy đối tượng không sử dụng
        /// </summary>
        public void Dispose()
        {
            CloseConnection();
            _connection.Dispose();
        }

        /// <summary>
        /// Mở kết nối tới database để truy vấn dữ liệu
        /// </summary>
        public void OpenConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        /// <summary>
        /// Đóng kết nối nếu không còn object nào sử dụng
        /// </summary>
        public void CloseConnection()
        {
            if(_connection.State != System.Data.ConnectionState.Closed)
            {
                _connection.Close();
            }
        }

        /// <summary>
        /// Lấy kết nối database
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetConnection()
        {
            return _connection;
        }

    }
}
