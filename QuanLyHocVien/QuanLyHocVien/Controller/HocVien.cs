using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocVien.Controller
{
    internal class HocVien
    {
        KetNoi kn;
        public HocVien()
        {
           kn  = new KetNoi();
        }
        public DataTable getHocVien()
        {
            string sql = "SELECT * FROM hocvien";
            return kn.GetData(sql);
        }
        public void CreateHocVien(int mahv, string hoten, string ngaysinh, string gioitinh,
            string diachi, string sdt, string email, string ngaydk, string trinhdo)
        {
            string sql = "INSERT INTO hocvien (hocvien_id, ho_ten, ngay_sinh, gioi_tinh, dia_chi, " +
                "so_dien_thoai, email, ngay_dang_ky, trinh_do) VALUES (@mahv, @hoten, @ngaysinh, @gioitinh," +
                "@diachi, @sdt, @email, @ngaydk, @trinhdo)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@mahv", mahv),
                new SqlParameter("@hoten", hoten),
                new SqlParameter("@ngaysinh", ngaysinh),
                new SqlParameter("@gioitinh", gioitinh),
                new SqlParameter("@diachi", diachi),
                new SqlParameter("@sdt", sdt),
                new SqlParameter("@email", email),
                new SqlParameter("@ngaydk", ngaydk),
                new SqlParameter("@trinhdo", trinhdo),
            };
            if(kn.CreateUpdateDelete(sql, sp))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
        public void UpdateHocVien(int mahv, string hoten, string ngaysinh, string gioitinh,
            string diachi, string sdt, string email, string ngaydk, string trinhdo)
        {
            string sql = "UPDATE hocvien SET ho_ten=@hoten, ngay_sinh=@ngaysinh, " +
                "gioi_tinh=@gioitinh, dia_chi=@diachi, so_dien_thoai=@sdt, email=@email, " +
                "ngay_dang_ky=@ngaydk, trinh_do=@trinhdo WHERE hocvien_id=@mahv";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@mahv", mahv),
                new SqlParameter("@hoten", hoten),
                new SqlParameter("@ngaysinh", ngaysinh),
                new SqlParameter("@gioitinh", gioitinh),
                new SqlParameter("@diachi", diachi),
                new SqlParameter("@sdt", sdt),
                new SqlParameter("@email", email),
                new SqlParameter("@ngaydk", ngaydk),
                new SqlParameter("@trinhdo", trinhdo),
            };
            if (kn.CreateUpdateDelete(sql, sp))
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }
        public void DeleteHocVien(int mahv)
        {
            string sql = "DELETE FROM hocvien WHERE hocvien_id=@mahv";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@mahv", mahv),
            };
            if (kn.CreateUpdateDelete(sql, sp))
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
        public DataTable searchTimKiem(string searchString)
        {
            string sql = $"SELECT * FROM hocvien WHERE {searchString}";
            return kn.GetData(sql);
        }
        public DataTable searchTimKiem2(string searchString)
        {
            string sql = $"SELECT hocvien_id,ho_ten,ngay_sinh,gioi_tinh,lophoc_id FROM hocvien WHERE {searchString}";
            return kn.GetData(sql);
        }
        public DataTable getTrinhDo()
        {
            string sql = "SELECT DISTINCT trinh_do FROM hocvien";
            return kn.GetData(sql);
        }
        public void UpdateHocVienlop(string mahv,int malop)
        {
            string sql = "UPDATE hocvien SET lophoc_id=@malop WHERE hocvien_id=@mahv";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@mahv", mahv),
                new SqlParameter("@malop", malop),

            };
            if (kn.CreateUpdateDelete(sql, sp))
            {
                MessageBox.Show("Vào lớp thành công");
            }
            else
            {
                MessageBox.Show("Vào lớp thất bại");
            }
        }
        public void UpdateHocVienrakhoilop(string mahv)
        {
            string sql = "UPDATE hocvien SET lophoc_id=NUlL WHERE hocvien_id=@mahv";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@mahv", mahv),

            };
            if (kn.CreateUpdateDelete(sql, sp))
            {
                MessageBox.Show("Loại khỏi lớp thành công");
            }
            else
            {
                MessageBox.Show("Loại ra khỏi lớp thất bại");
            }
        }
    }
}
