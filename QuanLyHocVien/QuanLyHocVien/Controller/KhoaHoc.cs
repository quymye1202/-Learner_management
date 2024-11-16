using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
