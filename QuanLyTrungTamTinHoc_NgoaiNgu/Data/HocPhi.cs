using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Data
{
    public class HocPhi
    {
        public int ID { get; set; }
        public string MaHP { get; set; } = null!;
        public decimal SoTien { get; set; }
        public bool TrangThai { get; set; }
        public DateTime? NgayDongHocPhi { get; set; }
        public int HocVienID { get; set; }
        public int LopHocID { get; set; }

        public virtual HocVien HocVien { get; set; } = null!;
        public virtual LopHoc LopHoc { get; set; } = null!;
    }
}
