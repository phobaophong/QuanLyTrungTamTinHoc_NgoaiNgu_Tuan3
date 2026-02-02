using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Data
{
    public class PhongHoc
    {
        public int ID { get; set; }
        public string MaPhong { get; set; } = null!;
        public string TenPhong { get; set; } = null!;
        public int SucChua { get; set; }

        public virtual ICollection<LichHoc> LichHocs { get; set; } = new List<LichHoc>();
    }
}
