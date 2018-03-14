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
        private SqlDataAdapter _adapter;

        public DbHandler()
        {
            _adapter = new SqlDataAdapter();

        }

        public DataTable GetData(string query)
        {
            return null;
        }
    }
}
