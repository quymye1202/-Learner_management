using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocVien.Controller
{
    internal class GiangVien
    {
        KetNoi kn;
        public GiangVien()
        {
            kn = new KetNoi();
        }
        public DataTable getGiangVien()
        {
            string sql = "SELECT * FROM giangvien";
            return kn.GetData(sql);
        }
        public void CreateGiangVien(int magv, string hoten, string chuyenmon, string sdt, 
            string email)
        {
            string sql = "INSERT INTO giangvien (giangvien_id, ho_ten, chuyen_mon, so_dien_thoai, email) " +
                "VALUES (@magv, @hoten, @chuyenmon, @sdt, @email)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@magv", magv),
                new SqlParameter("@hoten", hoten),
                new SqlParameter("@chuyenmon", chuyenmon),
                new SqlParameter("@sdt", sdt),
                new SqlParameter("@email", email)
            };
            if (kn.CreateUpdateDelete(sql, sp))
            {
                MessageBox.Show("Thêm giảng viên thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
        public void UpdateGiangVien(int magv, string hoten, string chuyenmon, string sdt,
            string email)
        {
            string sql = "UPDATE giangvien SET ho_ten=@hoten, chuyen_mon=@chuyenmon, " +
                "so_dien_thoai=@sdt, email=@email WHERE giangvien_id=@magv";
            SqlParameter[] sp = new SqlParameter[]
            {
                 new SqlParameter("@magv", magv),
                new SqlParameter("@hoten", hoten),
                new SqlParameter("@chuyenmon", chuyenmon),
                new SqlParameter("@sdt", sdt),
                new SqlParameter("@email", email)
            };
            if (kn.CreateUpdateDelete(sql, sp))
            {
                MessageBox.Show("Sửa giảng viên thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }
        public void DeleteGiangVien(int magv)
        {
            string sql = "DELETE FROM giangvien WHERE giangvien_id=@magv";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@magv", magv),
            };
            if (kn.CreateUpdateDelete(sql, sp))
            {
                MessageBox.Show("Xóa giảng viên thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
        public DataTable searchTimKiem(string searchString)
        {
            string sql = $"SELECT * FROM giangvien WHERE {searchString}";
            return kn.GetData(sql);
        }
    }
}
