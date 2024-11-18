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

namespace QuanLyHocVien.lophoc
{
    
    public partial class QuanLyLopHoc : Form
    {
        GiangVien gv=new GiangVien();
        Lophoc lh = new Lophoc();
        KhoaHoc kh = new KhoaHoc();
        int phanquyen;
        public QuanLyLopHoc(int phanquyen)
        {
            InitializeComponent();
            this.phanquyen = phanquyen;
        }
        public QuanLyLopHoc()
        {
            InitializeComponent();
            
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchString = "1=1";
            if (chkMaLop.Checked)
            {
                searchString += $" and lophoc_id = {txtMaLop.Text}";
            }
            if (chkTenLop.Checked)
            {
                searchString += $" and ten_lop = N'{txtenlop.Text}'";
            }
            if (chkKhoa.Checked)
            {
                searchString += $" and ten_khoa_hoc = N'{cboKhoa.Text}'";
            }
            if (chkTinhTrang.Checked)
            {
                if (rdDong.Checked)
                {
                    searchString += $" and tinhtrang = N'Mở'";
                }
                else
                {
                    searchString += $" and tinhtrang = N'Đóng'";
                }
                
            }
            if (chkKhoangTG.Checked)
            {
                string tuNgay = dateTuNgay.Value.Date.ToString("yyyy-MM-dd");
                string denNgay = dateDenNgay.Value.Date.ToString("yyyy-MM-dd");

     
                searchString += $" AND ((ngay_bat_dau BETWEEN '{tuNgay}' AND '{denNgay}') OR (ngay_ket_thuc BETWEEN '{tuNgay}' AND '{denNgay}') OR (ngay_bat_dau <= '{denNgay}' AND ngay_ket_thuc >= '{tuNgay}'))";
            }


            gridLop.DataSource = lh.searchTimKiem(searchString);
            
            if (gridLop.RowCount == 0)
            {
                MessageBox.Show("Không có dữ liệu cần tìm");
            }
            lblTongCong.Text = $"Tổng cộng: <{gridLop.RowCount}> lớp học";
        }
        public void load_form()
        {
            gridLop.DataSource = lh.getLophoc1();
            gridLop.Columns["lophoc_id"].HeaderText = "Mã lớp học";
            gridLop.Columns["ten_khoa_hoc"].HeaderText = "Khóa học";
            gridLop.Columns["ho_ten"].HeaderText = "Giang viên";
            gridLop.Columns["ten_lop"].HeaderText = "Tên lớp";
            gridLop.Columns["ngay_bat_dau"].HeaderText = "Ngày bắt đầu";
            gridLop.Columns["ngay_ket_thuc"].HeaderText = "Ngày kết thúc";
            gridLop.Columns["tinhtrang"].HeaderText = "Tình trạng";

            lblTongCong.Text = $"Tổng cộng: <{gridLop.RowCount}> lớp học";
        }
        private void QuanLyLopHoc_Load(object sender, EventArgs e)
        {
            cbkhoahoc.DataSource =kh.getKhoaHoc();
            cbkhoahoc.DisplayMember = "ten_khoa_hoc";
            cboKhoa.DataSource = kh.getKhoaHoc();
            cboKhoa.DisplayMember = "ten_khoa_hoc";
            cbtinhtrang.DataSource = lh.gettinhtrang();
            cbtinhtrang.DisplayMember = "tinhtrang";



           load_form();
        }

        private void gridLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void gridLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gridLop.Rows[e.RowIndex];
                txmalop.Text = row.Cells[0].Value.ToString();
                cbkhoahoc.Text = row.Cells[3].Value.ToString();
                txgiangvien.Text = row.Cells[2].Value.ToString();
                txtenlop.Text = row.Cells[1].Value.ToString().Trim();
                dtngaybd.Text = row.Cells[4].Value.ToString();
                dtngaykt.Text = row.Cells[5].Value.ToString();
                cbtinhtrang.Text = row.Cells[6].Value.ToString();

            }
        }

        private void btnThemLopHoc_Click(object sender, EventArgs e)
        {
            string malop=txmalop.Text;
            string tenlop=txtenlop.Text;
            string khoahoc=cbkhoahoc.Text;
            string tinhtrang = cbtinhtrang.Text;
            string tengiangvien=txgiangvien.Text;
            DateTime ngaybatday = dtngaybd.Value;
            DateTime ngayketthuc=dtngaykt.Value;
            lh.CreateLopHoc(malop, tengiangvien, khoahoc, tenlop, ngaybatday, ngayketthuc, tinhtrang);
            load_form();
        }

        private void bntSuaHV_Click(object sender, EventArgs e)
        {
            string malop = txmalop.Text;
            string tenlop = txtenlop.Text;
            string khoahoc = cbkhoahoc.Text;
            string tinhtrang = cbtinhtrang.Text;
            string tengiangvien = txgiangvien.Text;
            DateTime ngaybatday = dtngaybd.Value;
            DateTime ngayketthuc = dtngaykt.Value;
            lh.UpdateLopHoc(malop, tengiangvien, khoahoc, tenlop, ngaybatday, ngayketthuc, tinhtrang);
            load_form();
        }

        private void btnXoaHV_Click(object sender, EventArgs e)
        {
            int malop = int.Parse(txmalop.Text);    
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp học này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                lh.DeleteLopHoc(malop);  
                load_form();             
            }
            else
            {
                MessageBox.Show("Hành động xóa lớp học đã bị hủy.");
            }
        }

       

        private void chkMaLop_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMaLop.Checked)
            {
                txtMaLop.Enabled = true;
            }
            else
            {
                txtMaLop.Enabled = false;
            }
        }

        private void chkTenLop_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTenLop.Checked)
            {
                txtTenLop.Enabled = true;
            }
            else
            {
                txtTenLop.Enabled = false;
            }
        }

        private void chkKhoa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKhoa.Checked)
            {
                cboKhoa.Enabled = true;
            }
            else
            {
                cboKhoa.Enabled = false;
            }
        }

        private void chkKhoangTG_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKhoangTG.Checked)
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
            txtMaLop.Clear();
            txtTenLop.Clear();
            cbkhoahoc.Text = "";
            dateTuNgay.Value = DateTime.Now;
            dateDenNgay.Value = DateTime.Now;
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            gridLop.DataSource = lh.getLophoc1();

        }

        private void chkTinhTrang_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTinhTrang.Checked)
            {
                rdDong.Enabled = true;
                rdMo.Enabled = true;
            }
            else
            {
                rdMo.Enabled = false;
                rdDong.Enabled = false;
            }
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            chkMaLop.Checked = false;
            chkTenLop.Checked = false;
            chkKhoa.Checked = false;
            chkKhoangTG.Checked = false;
            clearText();
        }
    }
}
