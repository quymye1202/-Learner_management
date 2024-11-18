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
    public partial class xeplop : Form
    {
        HocVien hv = new HocVien();
        Lophoc lh = new Lophoc();
        int phanquyen;
        public xeplop(int phanquyen)
        {
            InitializeComponent();
            this.phanquyen = phanquyen;
        }

        public xeplop()
        {
            InitializeComponent();
        }

        public void form1_load()
        {
            DataTable dt = hv.searchTimKiem2(" lophoc_id IS NULL");
            gridDSHV.DataSource = dt;
    
            gridDSHV.Columns[0].HeaderText = "Mã Học Viên";
            gridDSHV.Columns[1].HeaderText = "Họ Tên";
            gridDSHV.Columns[2].HeaderText = "Ngày Sinh";
            gridDSHV.Columns[3].HeaderText = "Giới tính";
            gridDSHV.Columns[4].HeaderText = "Lớp học";
            int dem = int.Parse(gridDSHV.RowCount.ToString());
            lblTongCongHV.Text = $"Tổng cộng: {dem} học viên";

        }
        private void xeplop_Load(object sender, EventArgs e)
        {
            form1_load();
            cboLop.DataSource =lh.getLophoc1();
            cboLop.DisplayMember = "ten_lop";
        }

        public void load_lop()
        {
            string tenlop = cboLop.Text;
            DataTable dtlophoc = lh.searchTimKiem($"ten_lop = N'{tenlop}'");
            int khoaHocId = Convert.ToInt32(dtlophoc.Rows[0]["lophoc_id"]);
            gridDSHVLop.DataSource = hv.searchTimKiem2($"lophoc_id={khoaHocId}");
            gridDSHVLop.Columns[0].HeaderText = "Mã Học Viên";
            gridDSHVLop.Columns[1].HeaderText = "Họ Tên";
            gridDSHVLop.Columns[2].HeaderText = "Ngày Sinh";
            gridDSHVLop.Columns[3].HeaderText = "Giới tính";
            gridDSHVLop.Columns[4].HeaderText = "Lớp học";
            int dem = int.Parse(gridDSHVLop.RowCount.ToString());
            lblTongCongHVLop.Text = $"Tổng cộng: {dem} học viên";
        }
        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_lop();
        }

        private void btnLuuLop_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnLoaiKhoiLop.Enabled = false;
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLoaiKhoiLop.Enabled = true;
        }
        public string ma="";
        public string ma1 = "";
        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenlop = cboLop.Text;
            DataTable dtlophoc = lh.searchTimKiem($"ten_lop = N'{tenlop}'");
            int khoaHocId = Convert.ToInt32(dtlophoc.Rows[0]["lophoc_id"]);
            hv.UpdateHocVienlop(ma, khoaHocId);
            form1_load();
            load_lop() ;
        }

        private void gridDSHV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridDSHV.Rows[e.RowIndex];
            ma = row.Cells[0].Value.ToString();
        }

        private void btnLoaiKhoiLop_Click(object sender, EventArgs e)
        {
            hv.UpdateHocVienrakhoilop(ma1);
            form1_load();
            load_lop();
        }

        private void gridDSHVLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridDSHVLop.Rows[e.RowIndex];
            ma1 = row.Cells[0].Value.ToString();
        }

        
    }
}
