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

namespace QuanLyHocVien.hocvien
{
    public partial class QuanLyKhoaHoccs : Form
    {
        KhoaHoc khoaHoc;
        public QuanLyKhoaHoccs()
        {
            InitializeComponent();
            khoaHoc = new KhoaHoc();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            setState(false);
        }

        private void QuanLyKhoaHoccs_Load(object sender, EventArgs e)
        {
            gridKH.DataSource = khoaHoc.getKhoaHoc();
            gridKH.Columns[0].HeaderText = "Mã Khóa Học";
            gridKH.Columns[1].HeaderText = "Tên Khóa Học";
            gridKH.Columns[2].HeaderText = "Mô Tả";
            gridKH.Columns[3].HeaderText = "Trình Độ";
            gridKH.Columns[4].HeaderText = "Học Phí";
            gridKH.Columns[5].HeaderText = "Ngày Bắt Đầu";
            gridKH.Columns[6].HeaderText = "Ngày Kết Thúc";
            setState(false);
        }
        private void setState(bool state)
        {
            btnThemKhoaHoc.Enabled = state;
            btnSuaKH.Enabled = state;
            btnXoaKH.Enabled = state;
            txtMaKH.Enabled = !state;
        }
        private void clearText()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtmota.Clear();
            numHocPhi.Value = 0;
            dateBatDau.Value = DateTime.Now;
            dateKetThuc.Value = DateTime.Now;
        }
        private void btnThemKhoaHoc_Click(object sender, EventArgs e)
        {
            int makh = int.Parse(txtMaKH.Text);
            string tenkh = txtTenKH.Text;
            string mota = txtmota.Text;
            string trinhdo = cbtrinhdo.Text;
            decimal hocphi = decimal.Parse(numHocPhi.Value.ToString());
            DateTime ngaybd = dateBatDau.Value;
            DateTime ngaykt = dateKetThuc.Value;
            khoaHoc.CreateKhoaHoc(makh, tenkh, mota, trinhdo, hocphi, ngaybd, ngaykt);
            QuanLyKhoaHoccs_Load(sender, e);
            setState(false);
            clearText();
        }

        private void gridKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gridKH.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtTenKH.Text= row.Cells[1].Value.ToString();
                txtmota.Text = row.Cells[2].Value.ToString();
                cbtrinhdo.Text = row.Cells[3].Value.ToString();
                numHocPhi.Value = Convert.ToInt32(row.Cells[4].Value);
                dateBatDau.Text = row.Cells[5].Value.ToString();
                dateKetThuc.Text = row.Cells[6].Value.ToString();
                setState(true);
            }
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            int makh = int.Parse(txtMaKH.Text);
            string tenkh = txtTenKH.Text;
            string mota = txtmota.Text;
            string trinhdo = cbtrinhdo.Text;
            decimal hocphi = decimal.Parse(numHocPhi.Value.ToString());
            DateTime ngaybd = dateBatDau.Value;
            DateTime ngaykt = dateKetThuc.Value;
            khoaHoc.UpdateKhoaHoc(makh, tenkh, mota, trinhdo, hocphi, ngaybd, ngaykt);
            QuanLyKhoaHoccs_Load(sender, e);
            setState(false);
            clearText();
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            int makh = int.Parse(txtMaKH.Text);
            khoaHoc.DeleteKhoaHoc(makh);
            QuanLyKhoaHoccs_Load(sender, e);
            setState(false);
            clearText();
        }

        private void btnLuuTT_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Mã Khóa Học trống!!");
                txtMaKH.Focus();
                return;
            }
            setState(true);
        }
    }
}
