using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHopDong.Model
{
    public class TuiHandler : DbHandler
    {
        public TuiHandler() : base("SELECT * FROM [Package]")
        {
        }
    }
}
