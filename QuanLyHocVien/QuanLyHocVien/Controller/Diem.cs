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
    internal class Diem
    {
        KetNoi kn;
        public Diem()
        {
            kn = new KetNoi();
        }
        public DataTable getDiem()
        {
            string sql = "SELECT lophoc_id, ten_lop FROM lophoc";
            return kn.GetData(sql);
        }
        public DataTable TimKiemLopHoc(string searchString)
        {
            string sql = $"SELECT lophoc_id, ten_lop FROM lophoc {searchString}";
            return kn.GetData(sql);
        }
        public DataTable ThongTinDiem(int malop)
        {
            string sql = $"SELECT hocvien.hocvien_id, ho_ten, ngay_sinh, diem_nghe, diem_doc, diem_viet, " +
                $"diem_noi FROM bangdiem, hocvien WHERE bangdiem.lophoc_id = {malop} " +
                $"and bangdiem.hocvien_id = hocvien.hocvien_id";
            return kn.GetData(sql);
        }
        public void UpdateHocVien(int mahv, decimal diemnghe, decimal diemdoc,decimal diemnoi,decimal diemviet)
        {
            string sql = "UPDATE bangdiem SET diem_nghe=@diemnghe, diem_doc=@diemdoc, diem_viet=@diemviet, diem_noi=@diemnoi WHERE hocvien_id=@mahv";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@mahv", mahv),
                new SqlParameter("@diemnghe", diemnghe),
                new SqlParameter("@diemnoi", diemnoi),
                new SqlParameter("@diemdoc", diemdoc),
                new SqlParameter("@diemviet", diemviet)
            };
            if (kn.CreateUpdateDelete(sql, sp))
            {
                MessageBox.Show("Cập nhật điểm thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật điểm thất bại");
            }
        }
    }
}
