using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Data
{
    internal class CaHoc
    {
        public int ID { get; set; }
        public string MaCa { get; set; } = null!;
        public TimeSpan GioBatDau { get; set; }
        public TimeSpan GioKetThuc { get; set; }

        public virtual ICollection<LichHoc> LichHocs { get; set; } = new List<LichHoc>();
    }
}
