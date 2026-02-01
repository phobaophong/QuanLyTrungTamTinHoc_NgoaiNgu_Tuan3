using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Data
{
    internal class TaiKhoan
    {
        public int ID { get; set; }
        public string TenDN { get; set; } = null!;
        public string MatKhau { get; set; } = null!;
        public bool TrangThai { get; set; }

        public int? NhanVienID { get; set; }
        public int? GiangVienID { get; set; }
        public int? HocVienID { get; set; }

        public virtual ICollection<TaiKhoan_Quyen> TaiKhoan_Quyens { get; set; } = new List<TaiKhoan_Quyen>();
        public virtual ICollection<PhienDangNhap> PhienDangNhaps { get; set; } = new List<PhienDangNhap>();

    }
}
