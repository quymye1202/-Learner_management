using QuanLyHocVien.Controller;
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

namespace QuanLyHocVien.giangvien
{
    public partial class QuanLyGiangVien : Form
    {
        GiangVien giangVien;
        public QuanLyGiangVien()
        {
            InitializeComponent();
            giangVien = new GiangVien();
        }
        private void ThongTinGiangVien_Load(object sender, EventArgs e)
        {
            gridDSGV.DataSource = giangVien.getGiangVien();
            gridDSGV.Columns[0].HeaderText = "Mã GV";
            gridDSGV.Columns[1].HeaderText = "Họ Tên";
            gridDSGV.Columns[2].HeaderText = "Chuyên Môn";
            gridDSGV.Columns[3].HeaderText = "Số Diện Thoại";
            gridDSGV.Columns[4].HeaderText = "Email";
            setState(false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtMaGV.Text);
            string hoten = txtHoTen.Text;
            string chuyenmon = txtChuyenMon.Text;
            string sdt = txtSDT.Text;
            string email = txtEmail.Text;
            giangVien.CreateGiangVien(ma, hoten,chuyenmon, sdt, email);
            gridDSGV.DataSource = giangVien.getGiangVien();
            setState(false);
            clearText();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtMaGV.Text);
            string hoten = txtHoTen.Text;
            string chuyenmon = txtChuyenMon.Text;
            string sdt = txtSDT.Text;
            string email = txtEmail.Text;
            giangVien.UpdateGiangVien(ma, hoten, chuyenmon, sdt, email);
            gridDSGV.DataSource = giangVien.getGiangVien();
            setState(false);
            clearText();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtMaGV.Text);
            giangVien.DeleteGiangVien(ma);
            gridDSGV.DataSource = giangVien.getGiangVien();
            setState(false);
            clearText();
        }

        private void gridDSGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gridDSGV.Rows[e.RowIndex];
                txtMaGV.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                txtChuyenMon.Text = row.Cells[2].Value.ToString();
                txtSDT.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
                setState(true);
            }
        }
        private void setState(bool state)
        {
            btnThem.Enabled = state;
            btnSua.Enabled = state;
            btnXoa.Enabled = state;
            txtMaGV.Enabled = !state;
        }
        private void clearText()
        {
            txtMaGV.Clear();
            txtHoTen.Clear();
            txtChuyenMon.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
        }
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            var qlhv = new ThongTinGiangVien();
            this.Hide();
            qlhv.ShowDialog();
            this.Show();
            ThongTinGiangVien_Load(sender, e);
        }

        private void btnLuuTT_Click(object sender, EventArgs e)
        {
            if (txtMaGV.Text == "")
            {
                MessageBox.Show("Mã Giảng Viên trống!!");
                txtMaGV.Focus();
                return;
            }
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Họ Tên Giảng Viên trống!!");
                txtHoTen.Focus();
                return;
            }
            setState(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setState(false);
            clearText();
        }
    }
}
