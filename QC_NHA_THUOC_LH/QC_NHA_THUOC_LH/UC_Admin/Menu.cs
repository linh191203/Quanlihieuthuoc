using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QC_NHA_THUOC_LH.UC_Admin
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private bool isSidebarExpanded = true;
        private void btnSidebarExpand_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start(); // Bắt đầu chạy timer
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (isSidebarExpanded)
            {
                panelSidebar.Width -= 10;
                if (panelSidebar.Width <= 60)
                {
                    sidebarTimer.Stop();
                    isSidebarExpanded = false;

                    // Ẩn text của các button
                    btnQuanLiThongTinThuoc.Text = "";
                    btnHoaDon.Text = "";
                    btnNhaCungCap.Text = "";
                    btnQuanLiNhanVien.Text = "";
                    btnQuanLiKho.Text = "";
                }
            }
            else
            {
                panelSidebar.Width += 10;
                if (panelSidebar.Width >= 300)
                {
                    sidebarTimer.Stop();
                    isSidebarExpanded = true;

                    // Hiện lại text của các button
                    btnQuanLiThongTinThuoc.Text = "QUẢN LÍ THÔNG TIN THUỐC";
                    btnHoaDon.Text = "QUẢN LÍ HOÁ ĐƠN";
                    btnNhaCungCap.Text = "QUẢN LÍ NHÀ CUNG CẤP";
                    btnQuanLiNhanVien.Text = " QUẢN LÍ NHÂN VIÊN";
                    btnQuanLiKho.Text = "QUẢN LÍ KHO";
                }
            }
        }
        private Form activeForm = null;

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close(); // Đóng form cũ nếu có

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnQuanLiThongTinThuoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLiThuoc());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLiDonThuoc());
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLiNhaCungCap());
        }

        private void btnQuanLiNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanNhanVien());
        }

        private void btnQuanLiKho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLiKho());
        }
    }
}