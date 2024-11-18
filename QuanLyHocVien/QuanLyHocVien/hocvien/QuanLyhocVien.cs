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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyHocVien.hocvien
{
    public partial class QuanLyhocVien : Form
    {
        HocVien hocVien;
        public QuanLyhocVien()
        {
            InitializeComponent();
            hocVien = new HocVien();
        }
        private void QuanLyhocVien_Load(object sender, EventArgs e)
        {
            gridDSHV.DataSource = hocVien.getHocVien();
            gridDSHV.Columns["hocvien_id"].HeaderText = "Mã học viên";
            gridDSHV.Columns["ho_ten"].HeaderText = "Họ và tên";
            gridDSHV.Columns["ngay_sinh"].HeaderText = "Ngày sinh";
            gridDSHV.Columns["gioi_tinh"].HeaderText = "Giới tính";
            gridDSHV.Columns["so_dien_thoai"].HeaderText = "SĐT";
            gridDSHV.Columns["dia_chi"].HeaderText = "Địa chỉ";
            gridDSHV.Columns["ngay_dang_ky"].HeaderText = "Ngày tiếp nhận";
            gridDSHV.Columns["email"].HeaderText = "Email";
            gridDSHV.Columns["trinh_do"].HeaderText = "Trình độ";
            setState(false);
        }
        private void setState(bool state)
        {
            btnThemHocVien.Enabled = state;
            btnSuaHV.Enabled = state;
            btnXoaHV.Enabled = state;
            txtMaHV.Enabled = !state;
        }
        private void clearText()
        {
            txtMaHV.Clear();
            txtHoTen.Clear();
            dateNgaySinh.Value = DateTime.Now;
            cboGioiTinh.SelectedIndex = 0;
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            dateNgayTiepNhan.Value = DateTime.Now;
            cboLoaiHV.SelectedIndex = 0;
        }
        private void gridDSHV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gridDSHV.Rows[e.RowIndex];
                txtMaHV.Text = row.Cells[0].Value.ToString();
                //txtMaHV.Enabled = false;
                txtHoTen.Text = row.Cells[1].Value.ToString();
                dateNgaySinh.Text = row.Cells[2].Value.ToString();
                cboGioiTinh.Text = row.Cells[3].Value.ToString().Trim();
                txtDiaChi.Text = row.Cells[4].Value.ToString();
                txtSDT.Text = row.Cells[5].Value.ToString();
                txtEmail.Text = row.Cells[6].Value.ToString();
                cboLoaiHV.Text = row.Cells[8].Value.ToString();
                dateNgayTiepNhan.Text = row.Cells[7].Value.ToString().Trim();
                setState(true);
            }
        }

        private void btnThemHocVien_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtMaHV.Text);
            string hoten = txtHoTen.Text;
            string ngaysinh = dateNgaySinh.Text;
            string gioitinh = cboGioiTinh.Text;
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            string email = txtEmail.Text;
            string ngaydangki = dateNgayTiepNhan.Text;
            string trinhdo = cboLoaiHV.Text;
            hocVien.CreateHocVien(ma, hoten, ngaysinh, gioitinh, diachi, sdt, email, ngaydangki, trinhdo);
            gridDSHV.DataSource = hocVien.getHocVien();
            setState(false);
            clearText();
        }

        private void btnSuaHV_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtMaHV.Text);
            string hoten = txtHoTen.Text;
            string ngaysinh = dateNgaySinh.Text;
            string gioitinh = cboGioiTinh.Text;
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            string email = txtEmail.Text;
            string ngaydangki = dateNgayTiepNhan.Text;
            string trinhdo = cboLoaiHV.Text;
            hocVien.UpdateHocVien(ma, hoten, ngaysinh, gioitinh, diachi, sdt, email, ngaydangki, trinhdo);
            gridDSHV.DataSource = hocVien.getHocVien();
            setState(false);
            clearText();
        }

        private void btnXoaHV_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtMaHV.Text);
            hocVien.DeleteHocVien(ma);
            gridDSHV.DataSource = hocVien.getHocVien();
            setState(false);
            clearText();
        }

        private void btnLuuTT_Click(object sender, EventArgs e)
        {
            if(txtMaHV.Text == "")
            {
                MessageBox.Show("Mã Học Viên trống!!");
                txtMaHV.Focus();
                return;
            }
            if(txtHoTen.Text == "")
            {
                MessageBox.Show("Họ Tên Học Viên trống!!");
                txtHoTen.Focus();
                return;
            }
            setState(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setState(false);
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            var qlhv = new ThongTinHocVien();
            this.Hide();
            qlhv.ShowDialog();
            this.Show();
            QuanLyhocVien_Load(sender, e);
        }
    }
}
