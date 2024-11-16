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
    public partial class ThongTinHocVien : Form
    {
        HocVien hocVien;
        KhoaHoc khoaHoc;
        int phanquyen;
        public ThongTinHocVien()
        {
            InitializeComponent();
            hocVien = new HocVien();
            khoaHoc = new KhoaHoc();
        }
        public ThongTinHocVien(int phanquyen)
        {
            InitializeComponent();
            hocVien = new HocVien();
            khoaHoc = new KhoaHoc();
            this.phanquyen = phanquyen;
        }

        private void ThongTinHocVien_Load(object sender, EventArgs e)
        {
            cbbLoaiHV.DataSource = hocVien.getTrinhDo();
            cbbLoaiHV.DisplayMember = "trinh_do";
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
            lblTongCong.Text = $"Tổng cộng: <{gridDSHV.RowCount}> học viên";
            if(phanquyen == 1)
            {
                btnCapNhat.Enabled = false;
            }
        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            gridDSHV.DataSource = hocVien.getHocVien();
            lblTongCong.Text = $"Tổng cộng: <{gridDSHV.RowCount}> học viên";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchString = "1=1";
            if(cbMaHV.Checked)
            {
                searchString += $" and hocvien_id = {txtMaHV.Text}";
            }
            if(cbTenHV.Checked)
            {
                searchString += $" and ho_ten like N'%{txtTenHV.Text}%'";
            }
            if(cbGT.Checked)
            {
                searchString += $" and gioi_tinh = N'{cboGioiTinh.Text}'";
            }
            if (cbNgayTN.Checked)
            {
                searchString += $" and (ngay_dang_ky BETWEEN '{dateTuNgay.Value}' AND '{dateDenNgay.Value}')";
            }
            gridDSHV.DataSource = hocVien.searchTimKiem(searchString);
            lblTongCong.Text = $"Tổng cộng: <{gridDSHV.RowCount}> học viên";
        }

        private void cbbLoaiHV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchString = $" trinh_do = N'{cbbLoaiHV.Text}'";
            gridDSHV.DataSource = hocVien.searchTimKiem(searchString);
            lblTongCong.Text = $"Tổng cộng: <{gridDSHV.RowCount}> học viên";
        }

        private void cbMaHV_CheckedChanged(object sender, EventArgs e)
        {
            if(cbMaHV.Checked)
            {
                txtMaHV.Enabled = true;
            }
            else
            {
                txtMaHV.Enabled = false;
            }
        }

        private void cbTenHV_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTenHV.Checked)
            {
                txtTenHV.Enabled = true;
            }
            else
            {
                txtTenHV.Enabled = false;
            }
        }

        private void cbGT_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGT.Checked)
            {
                cboGioiTinh.Enabled = true;
            }
            else
            {
                cboGioiTinh.Enabled = false;
            }
        }

        private void cbNgayTN_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNgayTN.Checked)
            {
                dateTuNgay.Enabled = true;
                dateDenNgay.Enabled = true;
            }
            else
            {
                dateTuNgay.Enabled = false;
                dateDenNgay.Enabled = false;
            }
        }
        private void clearText()
        {
            txtMaHV.Clear();
            txtTenHV.Clear();
            dateTuNgay.Value = DateTime.Now;
            dateDenNgay.Value = DateTime.Now;
        }
        private void btnDatLai_Click(object sender, EventArgs e)
        {
            cbMaHV.Checked = false;
            cbTenHV.Checked = false;
            cbGT.Checked = false;
            cbNgayTN.Checked = false;
            clearText();
            ThongTinHocVien_Load(sender, e);
        }

        private void btnThemHocVien_Click(object sender, EventArgs e)
        {
            var qlhv = new QuanLyhocVien();
            this.Hide();
            qlhv.ShowDialog();
            this.Show();
            ThongTinHocVien_Load(sender, e);
        }
    }
}
