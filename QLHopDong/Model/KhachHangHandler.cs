using System;
using System.Data;
using System.Data.SqlClient;

namespace QLHopDong.Model
{
    public class KhachHangHandler : DbHandler
    {
        public KhachHangHandler() : base("Select * from Customer")
        {
        }
    }
}
