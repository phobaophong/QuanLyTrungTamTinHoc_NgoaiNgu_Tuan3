using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Data
{
    public class HocVien
    {
        public int ID { get; set; }

        public string MaHV { get; set; } = null!;
        public string HoTenHV { get; set; } = null!;
        public DateTime? NgaySinh { get; set; }
        public string? GioiTinh { get; set; }  
        public string? SoDienThoaiHV { get; set; }
        public string? DiaChi { get; set; }
        public string? EmailHV { get; set; }
        public string? HinhAnhHV { get; set; }
        public int LopHocID { get; set; }

        public virtual LopHoc LopHoc { get; set; } = null!;

        public virtual ICollection<KetQua> KetQuas { get; set; } = new List<KetQua>();
        public virtual ICollection<HocPhi> HocPhis { get; set; } = new List<HocPhi>();
        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; } = new List<TaiKhoan>();
    }
}
