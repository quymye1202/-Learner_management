using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyHocVien.Controller
{
    public class Lophoc
    {
        GiangVien dt= new GiangVien();
        KhoaHoc khoa = new KhoaHoc();
        KetNoi kn;
        public Lophoc()
        {
            kn = new KetNoi();
        }
        public void CreateLopHoc(string malop,string tenGiangVien, string tenKhoaHoc, string tenLop,
    DateTime ngayBD, DateTime ngayKT, string tinhTrang)
        {
            // Kiểm tra nếu tìm thấy giảng viên
            DataTable dtGiangVien = dt.searchTimKiem($"ho_ten = N'{tenGiangVien}'");
            if (dtGiangVien.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy giảng viên với tên: " + tenGiangVien);
                return;
            }
            int giangVienId = Convert.ToInt32(dtGiangVien.Rows[0]["giangvien_id"]);

            // Kiểm tra nếu tìm thấy khóa học
            DataTable dtKhoaHoc = khoa.searchTimKiem($"ten_khoa_hoc = N'{tenKhoaHoc}'");
            if (dtKhoaHoc.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy khóa học với tên: " + tenKhoaHoc);
                return;
            }
            int khoaHocId = Convert.ToInt32(dtKhoaHoc.Rows[0]["khoahoc_id"]);


            // Thêm lớp học vào bảng lophoc
            string sqlInsertLopHoc = @"
                INSERT INTO lophoc (lophoc_id, khoahoc_id, giangvien_id, ten_lop, ngay_bat_dau, ngay_ket_thuc, tinhtrang) 
                VALUES (@lophocid, @khoaHocId, @giangVienId, @tenLop, @ngayBD, @ngayKT, @tinhTrang)";
                        SqlParameter[] sp = new SqlParameter[]
                        {
                new SqlParameter("@lophocid", malop),
                new SqlParameter("@khoaHocId", khoaHocId),
                new SqlParameter("@giangVienId", giangVienId),
                new SqlParameter("@tenLop", tenLop),
                new SqlParameter("@ngayBD", ngayBD),
                new SqlParameter("@ngayKT", ngayKT),
                new SqlParameter("@tinhTrang", tinhTrang)
            };

            if (kn.CreateUpdateDelete(sqlInsertLopHoc, sp))
            {
                MessageBox.Show("Thêm lớp học thành công");
            }
            else
            {
                MessageBox.Show("Thêm lớp học thất bại");
            }
        }
        public void UpdateLopHoc(string malop, string tenGiangVien, string tenKhoaHoc, string tenLop,
    DateTime ngayBD, DateTime ngayKT, string tinhTrang)
        {
            // Kiểm tra nếu tìm thấy giảng viên
            DataTable dtGiangVien = dt.searchTimKiem($"ho_ten = N'{tenGiangVien}'");
            if (dtGiangVien.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy giảng viên với tên: " + tenGiangVien);
                return;
            }
            int giangVienId = Convert.ToInt32(dtGiangVien.Rows[0]["giangvien_id"]);

            // Kiểm tra nếu tìm thấy khóa học
            DataTable dtKhoaHoc = khoa.searchTimKiem($"ten_khoa_hoc = N'{tenKhoaHoc}'");
            if (dtKhoaHoc.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy khóa học với tên: " + tenKhoaHoc);
                return;
            }
            int khoaHocId = Convert.ToInt32(dtKhoaHoc.Rows[0]["khoahoc_id"]);

            // Cập nhật thông tin lớp học trong bảng lophoc
             string sqlUpdateLopHoc = @"
                UPDATE lophoc 
                SET khoahoc_id = @khoaHocId, giangvien_id = @giangVienId, ten_lop = @tenLop, 
                    ngay_bat_dau = @ngayBD, ngay_ket_thuc = @ngayKT, tinhtrang = @tinhTrang
                WHERE lophoc_id = @lophocid";

                        SqlParameter[] sp = new SqlParameter[]
                        {
                    new SqlParameter("@lophocid", malop),
                    new SqlParameter("@khoaHocId", khoaHocId),
                    new SqlParameter("@giangVienId", giangVienId),
                    new SqlParameter("@tenLop", tenLop),
                    new SqlParameter("@ngayBD", ngayBD),
                    new SqlParameter("@ngayKT", ngayKT),
                    new SqlParameter("@tinhTrang", tinhTrang)
            };

            if (kn.CreateUpdateDelete(sqlUpdateLopHoc, sp))
            {
                MessageBox.Show("Cập nhật lớp học thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật lớp học thất bại");
            }
        }

        public DataTable getLophoc1()
        {
            string sql = @"
                           SELECT 
                                lh.lophoc_id AS [lophoc_id],
                                lh.ten_lop AS [ten_lop],
                                gv.ho_ten AS [ho_ten],
                                kh.ten_khoa_hoc AS [ten_khoa_hoc],
                                lh.ngay_bat_dau AS [ngay_bat_dau],
                                lh.ngay_ket_thuc AS [ngay_ket_thuc],
                                lh.tinhtrang AS [tinhtrang]
                            FROM lophoc lh
                            LEFT JOIN giangvien gv ON lh.giangvien_id = gv.giangvien_id
                            LEFT JOIN khoahoc kh ON lh.khoahoc_id = kh.khoahoc_id";
            return kn.GetData(sql);
        }
        public void DeleteLopHoc(int malop)
        {
            string sqlDeleteLopHoc = "DELETE FROM lophoc WHERE lophoc_id = @lophocid";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@lophocid", malop)
            };

            if (kn.CreateUpdateDelete(sqlDeleteLopHoc, sp))
            {
                MessageBox.Show("Xóa lớp học thành công");
            }
            else
            {
                MessageBox.Show("Xóa lớp học thất bại");
            }
        }

        public DataTable getLophoc()
        {
            string sql = "SELECT * FROM lophoc";
            return kn.GetData(sql);
        }
        public DataTable searchTimKiem(string searchString)
        {
           string sql = $@"
                           SELECT 
                                lh.lophoc_id AS [lophoc_id],
                                lh.ten_lop AS [ten_lop],
                                gv.ho_ten AS [ho_ten],
                                kh.ten_khoa_hoc AS [ten_khoa_hoc],
                                lh.ngay_bat_dau AS [ngay_bat_dau],
                                lh.ngay_ket_thuc AS [ngay_ket_thuc],
                                lh.tinhtrang AS [tinhtrang]
                            FROM lophoc lh
                            LEFT JOIN giangvien gv ON lh.giangvien_id = gv.giangvien_id
                            LEFT JOIN khoahoc kh ON lh.khoahoc_id = kh.khoahoc_id WHERE {searchString} ";
            return kn.GetData(sql);
        }
        public DataTable gettinhtrang()
        {
            string sql = "SELECT DISTINCT tinhtrang FROM lophoc";
            return kn.GetData(sql);
        }
    }
}
