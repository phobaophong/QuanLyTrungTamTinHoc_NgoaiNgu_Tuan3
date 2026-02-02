using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Data
{
    public class LoaiDiem
    {
        public int ID { get; set; }
        public string MaLD { get; set; } = null!;
        public string TenLD { get; set; } = null!;
        public double HeSo { get; set; }

        public virtual ICollection<KetQua> KetQuas { get; set; } = new List<KetQua>();
    }
}
