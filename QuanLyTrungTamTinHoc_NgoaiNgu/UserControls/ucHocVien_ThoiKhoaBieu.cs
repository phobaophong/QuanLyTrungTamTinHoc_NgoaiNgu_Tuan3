using Microsoft.EntityFrameworkCore;
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
    public partial class ucHocVien_ThoiKhoaBieu : UserControl
    {
        QLTTDbContext db = new QLTTDbContext();
        int id = UserSession.TaiKhoanID;
        public ucHocVien_ThoiKhoaBieu()
        {
            InitializeComponent();
        }

        void LoadComboBoxTuan()
        {


            var lop = db.HocVien
                .Include(h => h.LopHoc)
                .Where(h => h.ID == id)
                .Select(h => h.LopHoc)
                .FirstOrDefault();

            if (lop == null || lop.NgayBD == null || lop.NgayKT == null) return;

            List<TuanItem> dsTuan = new List<TuanItem>();

            DateTime ngayBD = lop.NgayBD.Value;
            DateTime ngayKT = lop.NgayKT.Value;

            DateTime startDay = TinhToanTuan.LayThuHai(ngayBD);

            int soTuan = 1;

            while (startDay <= ngayKT)
            {
                dsTuan.Add(new TuanItem
                {
                    SoTuan = soTuan++,
                    TuNgay = startDay,
                    DenNgay = startDay.AddDays(6)
                });
                startDay = startDay.AddDays(7);
            }

            cboTuan.DataSource = dsTuan;

            DateTime homNay = DateTime.Today;
            var tuanHienTai = dsTuan.FirstOrDefault(t => homNay >= t.TuNgay && homNay <= t.DenNgay);
            cboTuan.SelectedItem = tuanHienTai ?? dsTuan.FirstOrDefault();
        }
        public void FillDataToGrid(DateTime tuNgay, DateTime denNgay)
        {
            // clear
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < dataGridView.Columns.Count; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = "";
                    dataGridView.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }



            var dsLich = db.LichHoc
                .Include(l => l.CaHoc)
                .Include(l => l.PhongHoc)
                .Where(l => l.LopHoc.HocViens.Any(h => h.ID == id)
                            && l.NgayHoc >= tuNgay
                            && l.NgayHoc <= denNgay)
                .ToList();

            foreach (var item in dsLich)
            {
                int dayIndex = (int)item.NgayHoc.DayOfWeek;
                string colName = (dayIndex == 0) ? "colCN" : "colT" + (dayIndex + 1);

                int rowIndex = item.CaHocID - 1;

                if (rowIndex >= 0 && rowIndex < 4)
                {
                    var cell = dataGridView.Rows[rowIndex].Cells[colName];

                    cell.Value = $"{item.LopHoc.TenLop}\nPhòng: {item.PhongHoc.TenPhong}";

                    cell.Style.BackColor = Color.LightSkyBlue;
                    cell.Style.ForeColor = Color.Black;
                    cell.Style.WrapMode = DataGridViewTriState.True;
                }
            }
        }
        private void ucThoiKhoaBieu_HocVien_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 4; i++)
            {
                int rowIndex = dataGridView.Rows.Add();
                dataGridView.Rows[rowIndex].Cells["colCa"].Value = "Ca " + i;
                dataGridView.Rows[rowIndex].Height = 100;
            }
            LoadComboBoxTuan();
            if (cboTuan.SelectedItem is TuanItem selectedTuan)
            {
                FillDataToGrid(selectedTuan.TuNgay, selectedTuan.DenNgay);
            }
        }
        private void cboTuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTuan.SelectedItem is TuanItem selectedTuan)
            {
                FillDataToGrid(selectedTuan.TuNgay, selectedTuan.DenNgay);
            }
        }

        private void btnTuanSau_Click(object sender, EventArgs e)
        {
            if (cboTuan.SelectedIndex < 51) cboTuan.SelectedIndex++;
        }

        private void btnTuanTruoc_Click(object sender, EventArgs e)
        {
            if (cboTuan.SelectedIndex > 0) cboTuan.SelectedIndex--;
        }
    }
}
