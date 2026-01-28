using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Data
{
    internal class KhoaHoc
    {
        public int ID { get; set; }
        public string MaKH { get; set; } = null!;
        public string TenKH { get; set; } = null!;
        public decimal HocPhi { get; set; }
        public int ThoiLuong { get; set; }

        public ICollection<LopHoc> LopHoc { get; set; } = new List<LopHoc>();

    }
}
