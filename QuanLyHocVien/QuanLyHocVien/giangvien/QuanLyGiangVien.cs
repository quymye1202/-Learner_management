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

        private void QuanLyGiangVien_Load(object sender, EventArgs e)
        {
            cboChuyenMon.DataSource = giangVien.getGiangVien();
            cboChuyenMon.DisplayMember = "chuyen_mon";

            gridGV.DataSource = giangVien.getGiangVien();
            gridGV.Columns[0].HeaderText = "Mã GV";
            gridGV.Columns[1].HeaderText = "Họ Tên";
            gridGV.Columns[2].HeaderText = "Chuyên Môn";
            gridGV.Columns[3].HeaderText = "Số Diện Thoại";
            gridGV.Columns[4].HeaderText = "Email";
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            gridGV.DataSource = giangVien.getGiangVien();
        }

        private void chkMaGV_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMaGV.Checked)
            {
                txtMaGV.Enabled = true;
            }
            else
            {
                txtMaGV.Enabled = false;
            }
        }

        private void chkTenGV_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTenGV.Checked)
            {
                txtTenGV.Enabled = true;
            }
            else
            {
                txtTenGV.Enabled = false;
            }
        }

        private void chkChuyenMon_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChuyenMon.Checked)
            {
                cboChuyenMon.Enabled = true;
            }
            else
            {
                cboChuyenMon.Enabled = false;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchString = "1=1";
            if (chkMaGV.Checked)
            {
                searchString += $" and giangvien_id = {txtMaGV.Text}";
            }
            if (chkTenGV.Checked)
            {
                searchString += $" and ho_ten like N'%{txtTenGV.Text}%'";
            }
            if (chkChuyenMon.Checked)
            {
                searchString += $" and chuyen_mon = N'{cboChuyenMon.Text}'";
            }
            gridGV.DataSource = giangVien.searchTimKiem(searchString);
            if(gridGV.RowCount == 0)
            {
                MessageBox.Show("Không có dữ liệu cần tìm");
            }
        }
        private void clearText()
        {
            txtMaGV.Clear();
            txtTenGV.Clear();
            cboChuyenMon.Text = "";
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            chkMaGV.Checked = false;
            chkTenGV.Checked = false;
            chkChuyenMon.Checked = false;
            clearText();
            QuanLyGiangVien_Load(sender, e);
        }

        private void btnThemGV_Click(object sender, EventArgs e)
        {
            var qlhv = new ThongTinGiangVien();
            this.Hide();
            qlhv.ShowDialog();
            this.Show();
            QuanLyGiangVien_Load(sender, e);
        }
    }
}
