using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Data
{
    internal class HocVien
    {
        public int ID { get; set; }
        public string MaHV { get; set; } = null!;
        public string HoTenHV { get; set; } = null!;
        public DateTime? NgaySinh { get; set; }
        public string? GioiTinh { get; set; }
        public string? SoDienThoaiHV { get; set; }
        public string? DiaChi { get; set; }
        public string? EmailHV { get; set; }

        public ICollection<KetQua> KetQuas { get; set; } = new List<KetQua>();
        public ICollection<HocPhi> HocPhis { get; set; } = new List<HocPhi>();
        public ICollection<TaiKhoan> TaiKhoans { get; set; } = new List<TaiKhoan>();
    }
}
