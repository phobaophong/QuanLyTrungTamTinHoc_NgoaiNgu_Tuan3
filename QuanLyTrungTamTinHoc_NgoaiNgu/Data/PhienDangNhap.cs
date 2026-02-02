using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Data
{
    public class PhienDangNhap
    {
        public int ID { get; set; }
        public DateTime ThoiGianDangNhap {  get; set; }
        public DateTime? ThoiGianDangXuat {  get; set; }
        public int TaiKhoanID { get; set; }

        public TaiKhoan TaiKhoan { get; set; } = null!;
    }
}
