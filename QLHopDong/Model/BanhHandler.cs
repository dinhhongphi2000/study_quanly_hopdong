using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHopDong.Model
{
    public class BanhHandler : DbHandler
    {
        public BanhHandler() : base("SELECT * FROM [Weight]")
        {
        }
    }
}
