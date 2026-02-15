using Microsoft.EntityFrameworkCore;
using QuanLyTrungTamTinHoc_NgoaiNgu.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    public partial class frmLogin : Form
    {
        QLTTDbContext db = new QLTTDbContext();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // check tài khoản
            var tk = db.TaiKhoan
         .Include(q => q.Quyen)
         .FirstOrDefault(x => x.TenDN == txtTenDN.Text &&
                             x.MatKhau == txtMatKhau.Text &&
                             x.TrangThai == true);

            if (tk == null)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu.");
                return;
            }

            // lấy quyền
            string quyen = tk.Quyen.MaQuyen;
            if (string.IsNullOrEmpty(quyen))
            {
                MessageBox.Show("Tài khoản chưa được phân quyền!");
                return;
            }

            // UserSession
            // ID
            UserSession.TaiKhoanID = tk.ID;

            // Ten
            if (quyen == "student")
            {
                UserSession.TenHienThi = db.HocVien.Where(h => h.TaiKhoanID == tk.ID).Select(h => h.HoTenHV).FirstOrDefault();
            }
            else if (quyen == "teacher")
            {
                UserSession.TenHienThi = db.GiangVien.Where(g => g.TaiKhoanID == tk.ID).Select(g => g.HoTenGV).FirstOrDefault();
            }

            this.Hide();

            switch (quyen)
            {
                case "student":
                    new frmStudent().ShowDialog();
                    break;
                case "teacher":
                    new frmTeacher().ShowDialog();
                    break;
                case "scheduler":
                    new frmScheduler().ShowDialog();
                    break;
                case "cashier":
                    new frmCashier().ShowDialog();
                    break;
                default:
                    MessageBox.Show("Quyền không hợp lệ!");
                    this.Show();
                    return;
            }
            Application.Exit();
        }     
    }
}
