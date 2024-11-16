using QuanLyHocVien.hocvien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocVien
{
    public partial class Main : Form
    {
        int phanquyen;
        public Main()
        {
            InitializeComponent();
        }
        public Main(int phanquyen)
        {
            InitializeComponent();
            this.phanquyen = phanquyen;
        }
        private void menuhocvien_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            if(phanquyen == 1)
            {
                quảnLýHọcViênToolStripMenuItem.Enabled = false;
            }
        }

        private void thôngTinHọcViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var qlhv = new ThongTinHocVien(phanquyen);
            this.Hide();
            qlhv.ShowDialog();
            this.Show();
        }
    }
}
