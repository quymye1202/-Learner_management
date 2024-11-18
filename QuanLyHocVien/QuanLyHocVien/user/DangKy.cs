using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocVien.user
{
    public partial class DangKy : Form
    {
        KetNoi kn= new KetNoi();    
        public DangKy()
        {
            InitializeComponent();
        }

        private void lbTaoTK_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
            this.Show();
        }
        public int quyen = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string confirmPassword = txtxacnhanmk.Text;
                string role = cbquantri.Text;
                if (username == "")
                {
                    MessageBox.Show("Username trống");
                    txtUsername.Focus();
                }
                else if (password == "")
                {
                    MessageBox.Show("Password trống");
                    txtPassword.Focus();
                }
                else if (confirmPassword == "")
                {
                    MessageBox.Show("Confirm password trống");
                    txtxacnhanmk.Focus();
                }
                else if (password != confirmPassword)
                {
                    MessageBox.Show("Password và Confirm password không khớp");
                    txtPassword.Clear();
                    txtxacnhanmk.Clear();
                    txtPassword.Focus();
                }
                else
                {
                    DataTable dt = kn.getUser(username, password);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Tài khoản đã tồn tại!");
                    }
                    else
                    {
                        if (role == "Giảng viên") {
                           quyen = 1; 
                        }
                        string sqlInsert = @"
                            INSERT INTO users (username, password, position) 
                            VALUES (@username, @password, @role)";

                        SqlParameter[] parameters = new SqlParameter[]
                        {
                        new SqlParameter("@username", username),
                        new SqlParameter("@password", password),
                        new SqlParameter("@role", quyen)
                        };

                        if (kn.CreateUpdateDelete(sqlInsert, parameters))
                        {
                            MessageBox.Show("Đăng ký thành công!");
                            DangNhap dn=new DangNhap();
                            this.Hide();
                            dn.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Đăng ký thất bại, vui lòng thử lại!");
                        }
                    }
                }
            }

           

        
    }
}
