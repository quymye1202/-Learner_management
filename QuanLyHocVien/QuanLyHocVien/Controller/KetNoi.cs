using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace QuanLyHocVien
{
    internal class KetNoi
    {
        public SqlConnection conn;
        public void openConnect()
        {
            conn = new SqlConnection("Data Source=LAPTOP-LC1LJAI6\\SQLEXPRESS;Initial Catalog=quanlyhocvien;Integrated Security=True");
            conn.Open();
        }
        public void closeConnect()
        {
            conn.Close();
        }
        public DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                openConnect();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra " + ex.Message);
            }
            finally
            {
                closeConnect();
            }
            return dt;
        }
        public bool CreateUpdateDelete(string sql, SqlParameter[] parameters = null)
        {
            try
            {
                openConnect();
                using(SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if(parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    int rs = cmd.ExecuteNonQuery();
                    return rs > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra " + ex.Message);
                return false;
            }
            finally
            {
                closeConnect();
            }
        }
        public DataTable getUser(string username, string password)
        {
            DataTable dt = new DataTable();
            try
            {
                openConnect();
                string sql = "SELECT * FROM users WHERE username = @username and password=@password";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra " + ex.Message);
            }
            finally
            {
                closeConnect();
            }
            return dt;
        }
    }
}
