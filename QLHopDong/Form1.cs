using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLHopDong.Model;

namespace QLHopDong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KhachHangHandler handler = new KhachHangHandler();
            
            DataTable table = handler.LayDuLieu();

        }
    }
}
