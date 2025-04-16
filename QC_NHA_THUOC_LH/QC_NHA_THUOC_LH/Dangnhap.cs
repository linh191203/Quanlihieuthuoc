using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QC_NHA_THUOC_LH.UC_Admin; // thay bằng tên namespace của bạn

namespace QC_NHA_THUOC_LH
{
    public partial class Dangnhap : Form
    {
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = textBox3.Text; // Đảm bảo sử dụng đúng tên điều khiển
            string matKhau = textBox2.Text;

            // Hard-code kiểm tra tài khoản
            if (tenDangNhap == "admin" && matKhau == "123")
            {
                this.Hide(); // Ẩn form đăng nhập
                QC_NHA_THUOC_LH.UC_Admin.
                Menu formMenu = new QC_NHA_THUOC_LH.UC_Admin.Menu(); // Tạo form menu
                formMenu.Show(); // Hiển thị form menu
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
