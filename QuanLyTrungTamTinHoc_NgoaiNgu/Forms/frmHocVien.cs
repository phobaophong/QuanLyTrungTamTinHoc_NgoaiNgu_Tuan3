using QuanLyTrungTamTinHoc_NgoaiNgu.Data;
using QuanLyTrungTamTinHoc_NgoaiNgu.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    public partial class frmHocVien : Form
    {
        public frmHocVien()
        {
            InitializeComponent();
        }
        private LopHoc lopHocDangHoc;
        private void frmHocVien_Load(object sender, EventArgs e)
        {
            
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();

            UserControls.ucThongTin_HocVien uc = new UserControls.ucThongTin_HocVien();

            uc.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(uc);
        }

        private void btnThoiKhoaBieu_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            UserControls.ucThoiKhoaBieu_HocVien uc = new UserControls.ucThoiKhoaBieu_HocVien();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }

        private void btnLichThi_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            UserControls.ucLichThi_HocVien uc = new UserControls.ucLichThi_HocVien();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }

        private void btnKetQuaHocTap_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            UserControls.ucKetQuaHocTap_HocVien uc = new UserControls.ucKetQuaHocTap_HocVien();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }

        private void btnHocPhi_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            UserControls.ucHocPhi_HocVien uc = new UserControls.ucHocPhi_HocVien();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
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
