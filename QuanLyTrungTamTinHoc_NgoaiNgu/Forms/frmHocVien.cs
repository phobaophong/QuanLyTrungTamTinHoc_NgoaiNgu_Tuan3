using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyTrungTamTinHoc_NgoaiNgu.UserControls;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    public partial class frmHocVien : Form
    {
        public frmHocVien()
        {
            InitializeComponent();
        }

        private void frmHocVien_Load(object sender, EventArgs e)
        {

        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();

            UserControls.ucThongTin_HocVien uc = new UserControls.ucThongTin_HocVien();

            uc.Dock = DockStyle.Fill;

            //test
            Data.KhoaHoc khGia = new Data.KhoaHoc()
            {
                ID = 1,
                MaKH = "KH001",
                TenKH = "Lập trình C# WinForms",
                HocPhi = 4500000,
                ThoiLuong = 60
            };

            Data.LopHoc lopGia = new Data.LopHoc()
            {
                ID = 1,
                MaLop = "LH001",
                TenLop = "C# WinForms 01",
                NgayBD = new DateTime(2026, 03, 01),
                NgayKT = new DateTime(2026, 05, 01),
                TrangThai = true,

                KhoaHocID = khGia.ID,
                KhoaHoc = khGia
            };

            Data.HocVien hvGia = new Data.HocVien()
            {
                MaHV = "HV001",
                HoTenHV = "Trần Đăng Khoa",
                NgaySinh = new DateTime(2005, 01, 01),
                GioiTinh = "Nam",
                SoDienThoaiHV = null,
                EmailHV = "hocvien@gmail.com",
                DiaChi = "123 Đường ABC, Quận 1, TP.HCM",
                MaLopID = lopGia.ID,

                // 🔥 DÒNG QUYẾT ĐỊNH
                LopHoc = lopGia
            };

            uc.LoadData(hvGia);

            pnlContent.Controls.Add(uc);
        }

        private void btnThoiKhoaBieu_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            UserControls.ucThoiKhoaBieu_HocVien uc = new UserControls.ucThoiKhoaBieu_HocVien();
            uc.Dock = DockStyle.Fill;
        }

        private void btnLichThi_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            UserControls.ucLichThi_HocVien uc = new UserControls.ucLichThi_HocVien();
            uc.Dock = DockStyle.Fill;
        }

        private void btnKetQuaHocTap_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            UserControls.ucKetQuaHocTap_HocVien uc = new UserControls.ucKetQuaHocTap_HocVien();
            uc.Dock = DockStyle.Fill;
        }

        private void btnHocPhi_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            UserControls.ucHocPhi_HocVien uc = new UserControls.ucHocPhi_HocVien();
            uc.Dock = DockStyle.Fill;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất không?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                frmLogin frm = new frmLogin();
                frm.Show();
                this.Close();
            }
        }
    }
}
