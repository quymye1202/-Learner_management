using QuanLyHocVien.giangvien;
using QuanLyHocVien.hocvien;
using QuanLyHocVien.lophoc;
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
        string user;
        public Main(int phanquyen,string user)
        {
            InitializeComponent();
            this.phanquyen = phanquyen;
            this.user = user;
        }
        private void menuhocvien_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            if(phanquyen == 1)
            {
                quảnLýHọcViênToolStripMenuItem.Enabled = false;
                quảnLýGiảngViênToolStripMenuItem.Enabled = false;
                khóaHọcToolStripMenuItem.Enabled = false;
                xếpLớpToolStripMenuItem.Enabled=false;
                quảnLýLớpHọcToolStripMenuItem.Enabled = false;
            }
            lbuser.Text = "Xin chào: " + user;
        }


        private void thôngTinHọcViênToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var form = new ThongTinHocVien(phanquyen);
            form.ShowDialog();
            this.Show();
        }

        private void quảnLýHọcViênToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var form = new QuanLyhocVien();   
            form.ShowDialog();
            this.Show();
        }

        private void quảnLýToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var form = new ThongTinGiangVien(phanquyen);
            form.ShowDialog();
            this.Show();
        }

        private void quảnLýGiảngViênToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var form = new QuanLyGiangVien();
            form.ShowDialog();
            this.Show();
        }

        private void xếpLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new xeplop(phanquyen);
            form.ShowDialog();
            this.Show();
        }

        private void khóaHọcToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var form = new QuanLyKhoaHoccs();
            form.ShowDialog();
            this.Show();
        }

        private void xêpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new QuanLyDiem();
            form.ShowDialog();
            this.Show();
        }

        private void điểmTheoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new DiemTheoLop();
            form.ShowDialog();
            this.Show();
        }

        private void quảnLýLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new QuanLyLopHoc(phanquyen);
            form.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
