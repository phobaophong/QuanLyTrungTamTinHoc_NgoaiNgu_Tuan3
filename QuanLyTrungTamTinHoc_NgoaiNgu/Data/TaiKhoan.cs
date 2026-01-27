using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Data
{
    internal class TaiKhoan
    {
        public string TenDN { get; set; } = null!;
        public string MatKhau { get; set; } = null!;
        public int TrangThai { get; set; }
        public string? MaNV { get; set; }
        public string? MaGV { get; set; }
        public virtual GiangVien? GiangVien { get; set; }
        public virtual ICollection<TaiKhoan_Quyen> TaiKhoan_Quyens { get; set; } = new HashSet<TaiKhoan_Quyen>();
    }
}
