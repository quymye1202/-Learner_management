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
    public partial class QuanLyDiem : Form
    {
        Diem diem;
        public QuanLyDiem()
        {
            InitializeComponent();
            diem = new Diem();
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

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            QuanLyDiem_Load(sender, e);
        }

        private void QuanLyDiem_Load(object sender, EventArgs e)
        {
            gridLop.DataSource = diem.getDiem();
            gridLop.Columns[0].HeaderText = "Mã Lớp";
            gridLop.Columns[0].Width = 50;
            gridLop.Columns[1].HeaderText = "Tên Lớp";
        }

        private void gridLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gridLop.Rows[e.RowIndex];
                int malh = int.Parse(row.Cells[0].Value.ToString());
                gridDSHV.DataSource = diem.ThongTinDiem(malh);
                gridDSHV.Columns[0].HeaderText = "Mã Học Viên";
                gridDSHV.Columns[1].HeaderText = "Họ Tên";
                gridDSHV.Columns[2].HeaderText = "Ngày Sinh";
                gridDSHV.Columns[3].HeaderText = "Điểm Nghe";
                gridDSHV.Columns[4].HeaderText = "Điểm Đọc";
                gridDSHV.Columns[5].HeaderText = "Điểm Viết";
                gridDSHV.Columns[6].HeaderText = "Điểm Nói";
                int dem = int.Parse(gridDSHV.RowCount.ToString());
                lblTongCong.Text = $"Tổng cộng: {dem} học viên";
                string malop = row.Cells[0].Value.ToString();
                string tenlop = row.Cells[1].Value.ToString();
                lblTenLop.Text = tenlop;
                lblMaLop.Text = malop;
            }
        }

        private void gridDSHV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = gridDSHV.Rows[e.RowIndex];
                string maHV = row.Cells[0].Value.ToString();
                string hoTen = row.Cells[1].Value.ToString();
                string ngaySinh = row.Cells[2].Value.ToString();
                string diemNghe = row.Cells[3].Value.ToString();
                string diemDoc = row.Cells[4].Value.ToString();
                string diemViet = row.Cells[5].Value.ToString();
                string diemNoi = row.Cells[6].Value.ToString();
                
                lblMaHV.Text = maHV;
                lblTenHV.Text = hoTen;
                numDiemDoc.Text = diemDoc;
                numDiemNghe.Text = diemNghe;
                numDiemNoi.Text = diemNoi;
                numDiemViet.Text = diemViet;
            }
        }
    }
}
