using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHopDong
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKhachHang form = new FormKhachHang();
            form.MdiParent = this;
            form.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void quảnLýTúiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTui form = new FormTui();
            form.MdiParent = this;
            form.Show();
        }

        private void quảnLýBànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBanh form = new FormBanh();
            form.MdiParent = this;
            form.Show();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHangHoa form = new FormHangHoa();
            form.MdiParent = this;
            form.Show();
        }

        private void quảnLýHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHopDong form = new FormHopDong();
            form.MdiParent = this;
            form.Show();
        }
    }
}
