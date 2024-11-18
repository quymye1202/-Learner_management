using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocVien.Controller
{
    internal class KhoaHoc
    {
        KetNoi kn;
        public KhoaHoc()
        {
            kn = new KetNoi();
        }
        public DataTable getKhoaHoc()
        {
            string sql = "SELECT * FROM khoahoc";
            return kn.GetData(sql);
        }
        public void CreateKhoaHoc(int makh, string tenkh, string mota, string trinhdo, decimal hocphi, 
            DateTime ngaybd, DateTime ngaykt)
        {
            string sql = "INSERT INTO khoahoc (khoahoc_id, ten_khoa_hoc, mo_ta, trinh_do, hoc_phi, " +
                "ngay_bat_dau, ngay_ket_thuc) VALUES (@makh, @tenkh, @mota, @trinhdo, @hocphi, @ngaybd, " +
                "@ngaykt)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@makh", makh),
                new SqlParameter("@tenkh", tenkh),
                new SqlParameter("@mota", mota),
                new SqlParameter("@trinhdo", trinhdo),
                new SqlParameter("@hocphi", hocphi),
                new SqlParameter("@ngaybd", ngaybd),
                new SqlParameter("@ngaykt", ngaykt),
            };
            if (kn.CreateUpdateDelete(sql, sp))
            {
                MessageBox.Show("Thêm khóa học công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
        public void UpdateKhoaHoc(int makh, string tenkh, string mota, string trinhdo, decimal hocphi,
            DateTime ngaybd, DateTime ngaykt)
        {
            string sql = "UPDATE khoahoc SET ten_khoa_hoc=@tenkh, mo_ta=@mota, trinh_do=@trinhdo, " +
                "hoc_phi=@hocphi, ngay_bat_dau=@ngaybd, ngay_ket_thuc=@ngaykt WHERE khoahoc_id=@makh";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@makh", makh),
                new SqlParameter("@tenkh", tenkh),
                new SqlParameter("@mota", mota),
                new SqlParameter("@trinhdo", trinhdo),
                new SqlParameter("@hocphi", hocphi),
                new SqlParameter("@ngaybd", ngaybd),
                new SqlParameter("@ngaykt", ngaykt),
            };
            if (kn.CreateUpdateDelete(sql, sp))
            {
                MessageBox.Show("Sửa khóa học thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }
        public void DeleteKhoaHoc(int makh)
        {
            string sql = "DELETE FROM khoahoc WHERE khoahoc_id=@makh";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@makh", makh),
            };
            if (kn.CreateUpdateDelete(sql, sp))
            {
                MessageBox.Show("Xóa khóa học thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
            public DataTable searchTimKiem(string searchString)
            {
                string sql = $"SELECT * FROM khoahoc WHERE {searchString}";
                return kn.GetData(sql);
            }
        }
}
