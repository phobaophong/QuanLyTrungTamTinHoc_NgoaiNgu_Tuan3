using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Data
{
    public class GiangVien
    {
        public int ID { get; set; }
        public string MaGV { get; set; } = null!;
        public string HoTenGV { get; set; } = null!;
        public string? Sdt { get; set; }
        public string? EmailGV { get; set; }
        public string? ChuyenMon {  get; set; }
        public string? HinhAnhGV { get; set; }
        public int TaiKhoanID { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; } = null!;

        public virtual ICollection<LichHoc> LichHocs { get; set; } = new List<LichHoc>();
    }
}
