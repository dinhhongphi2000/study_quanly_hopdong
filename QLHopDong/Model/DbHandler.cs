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
        /// Thiết lập update command
        /// </summary>
        protected void SetUpdateCommand(string updateCommand)
        {
            _adapter.UpdateCommand = new SqlCommand(updateCommand,_connection);
        }

        /// <summary>
        /// Thiết lập select command
        /// </summary>
        /// <param name="selectCommand"></param>
        protected void SetSelectCommand(string selectCommand)
        {
            _adapter.SelectCommand = new SqlCommand(selectCommand, _connection);
            //re-generate command
            SqlCommandBuilder builder = new SqlCommandBuilder(_adapter);
        }

        /// <summary>
        /// Thiết lập insert command
        /// </summary>
        /// <param name="insertCommand"></param>
        protected void SetInsertCommand(string insertCommand)
        {
            _adapter.InsertCommand = new SqlCommand(insertCommand);
        }

        /// <summary>
        /// Thiết lập delete command
        /// </summary>
        /// <param name="deleteCommand"></param>
        protected void SetDeleteCommand(string deleteCommand)
        {
            _adapter.DeleteCommand = new SqlCommand(deleteCommand,_connection);
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
