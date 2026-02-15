using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Data
{
    public class NhanVien
    {
        public int ID { get; set; }
        public string MaNV { get; set; } = null!;
        public string HoTenNV { get; set; } = null!;
        public string? Sdt { get; set; }
        public string? BoPhan { get; set; }
        public string? ChucVu {  get; set; }
        public string? HinhAnhNV { get; set; }

        public int TaiKhoanID { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; } = null!;
    }
}
