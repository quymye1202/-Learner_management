using QuanLyHocVien.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocVien.giangvien
{
    public partial class DiemTheoLop : Form
    {
        Diem diem;
        public DiemTheoLop()
        {
            InitializeComponent();
            diem = new Diem();
        }

        private void DiemTheoLop_Load(object sender, EventArgs e)
        {
            gridLop.DataSource = diem.getDiem();
            gridLop.Columns[0].HeaderText = "Mã Lớp";
            gridLop.Columns[0].Width = 50;
            gridLop.Columns[1].HeaderText = "Tên Lớp";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchString = "WHERE 1=1 ";
            string malh = txtMaLop.Text;

            searchString += $"and khoahoc_id = {malh}";
            gridLop.DataSource = diem.TimKiemLopHoc(searchString);
            gridLop.Columns[0].HeaderText = "Mã Lớp";
            gridLop.Columns[1].HeaderText = "Tên Lớp";
        }

        private void gridLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gridLop.Rows[e.RowIndex];
                int malh = int.Parse(row.Cells[0].Value.ToString());
                gridThongKe.DataSource = diem.ThongTinDiem(malh);
                gridThongKe.Columns[0].HeaderText = "Mã Học Viên";
                gridThongKe.Columns[1].HeaderText = "Họ Tên";
                gridThongKe.Columns[2].HeaderText = "Ngày Sinh";
                gridThongKe.Columns[3].HeaderText = "Điểm Nghe";
                gridThongKe.Columns[4].HeaderText = "Điểm Đọc";
                gridThongKe.Columns[5].HeaderText = "Điểm Viết";
                gridThongKe.Columns[6].HeaderText = "Điểm Nói";
                int dem = int.Parse(gridThongKe.RowCount.ToString());
                lblTongCong.Text = $"Tổng cộng: {dem} học viên";
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DiemTheoLop_Load(sender, e);
        }
    }
}
