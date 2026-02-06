using QuanLyTrungTamTinHoc_NgoaiNgu.Data;
using QuanLyTrungTamTinHoc_NgoaiNgu.SupportClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.UserControls
{
    public partial class ucThoiKhoaBieu_HocVien : UserControl
    {
        public ucThoiKhoaBieu_HocVien()
        {
            InitializeComponent();
        }
        void LoadComboBoxTuan(LopHoc lopHoc)
        {
            if (lopHoc.NgayBD == null || lopHoc.NgayKT == null)
                return;

            DateTime ngayBatDau = TinhToanTuan.LayThuHai(lopHoc.NgayBD.Value);
            DateTime ngayKetThuc = lopHoc.NgayKT.Value;

            List<TuanItem> tuans = new List<TuanItem>();

            int soTuan = 1;
            DateTime tuNgay = ngayBatDau;

            while (tuNgay <= ngayKetThuc)
            {
                tuans.Add(new TuanItem{SoTuan = soTuan, TuNgay = tuNgay, DenNgay = tuNgay.AddDays(6)});
                tuNgay = tuNgay.AddDays(7);
                soTuan++;
            }

            cboTuan.DataSource = tuans;
            cboTuan.SelectedIndex = 0;
        }
        private void ucThoiKhoaBieu_HocVien_Load(object sender, EventArgs e)
        {
            
        }
    }
}
