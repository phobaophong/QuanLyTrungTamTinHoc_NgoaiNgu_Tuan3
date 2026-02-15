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
    public partial class frmStudent : Form
    {
        private int _hocVienId;
        public frmStudent()
        {
            InitializeComponent();
        }
        //constructor
        public frmStudent(int hocVienId)
        {
            InitializeComponent();
            _hocVienId = hocVienId;
        }
        private void frmHocVien_Load(object sender, EventArgs e)
        {

        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();

            UserControls.ucHocVien_ThongTinChiTiet uc = new UserControls.ucHocVien_ThongTinChiTiet();

            uc.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(uc);
        }

        private void btnThoiKhoaBieu_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            UserControls.ucHocVien_ThoiKhoaBieu uc = new UserControls.ucHocVien_ThoiKhoaBieu();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }

        private void btnLichThi_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            UserControls.ucHocVien_LichThi uc = new UserControls.ucHocVien_LichThi();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }

        private void btnKetQuaHocTap_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            UserControls.ucHocVien_KetQuaHocTap uc = new UserControls.ucHocVien_KetQuaHocTap();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }

        private void btnHocPhi_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            UserControls.ucHocVien_HocPhi uc = new UserControls.ucHocVien_HocPhi();
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
                this.Tag = "Logout";
                this.Close();
            }
        }

        private void frmStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Tag?.ToString() == "Logout")
            {    
                this.Hide();
                frmLogin frm = new frmLogin();
                frm.ShowDialog();
            }
            else
            {          
                Application.Exit();
            }
        }
    }
}
