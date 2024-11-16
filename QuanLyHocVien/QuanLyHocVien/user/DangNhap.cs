using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocVien.Controller;
using QuanLyHocVien.hocvien;

namespace QuanLyHocVien.user
{
    public partial class DangNhap : Form
    {
        KetNoi kn;
        public DangNhap()
        {
            InitializeComponent();
            kn = new KetNoi();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtpassword.Text;
            if(username == "")
            {
                MessageBox.Show("Username trống");
                txtUsername.Focus();
            }
            else if (password == "")
            {
                MessageBox.Show("Password trống");
                txtpassword.Focus();
            }
            else
            {
                DataTable dt = kn.getUser(username, password);
                if (dt.Rows.Count > 0)
                {
                    var main = new Main(int.Parse(dt.Rows[0][3].ToString()));
                    this.Hide();
                    main.ShowDialog();
                    this.Show();
                    //txtUsername.Text = username;
                    txtpassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Đăng Nhập thất bại!!!");
                }
            }
        }
    }
}
