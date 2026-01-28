using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Data
{
    internal class NhanVien
    {
        public int ID { get; set; }
        public string MaNV { get; set; } = null!;
        public string HoTenNV { get; set; } = null!;
        public string? SoDienThoaiNV { get; set; }
        public string? BoPhan { get; set; }
        public string? ChucVu {  get; set; }

        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; } = new List<TaiKhoan>();
    }
}
