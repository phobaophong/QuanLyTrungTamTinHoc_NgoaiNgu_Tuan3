using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Data
{
    internal class GiangVien
    {
        public int ID { get; set; }
        public string MaGV { get; set; } = null!;
        public string HoTenGV { get; set; } = null!;
        public string? SoDienThoaiGV { get; set; }
        public string? EmailGV { get; set; }
        public string? ChuyenMon {  get; set; }

        public virtual ICollection<LichHoc> LichHocs { get; set; } = new List<LichHoc>();
        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; } = new List<TaiKhoan>();
    }
}
