using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Data
{
    public class TaiKhoan
    {
        public int ID { get; set; }
        public string TenDN { get; set; } = null!;
        public string MatKhau { get; set; } = null!;
        public bool TrangThai { get; set; }
        public int QuyenID { get; set; } 
        public virtual Quyen Quyen { get; set; } = null!;
        public virtual ICollection<PhienDangNhap> PhienDangNhaps { get; set; } = new List<PhienDangNhap>();

    }
}
