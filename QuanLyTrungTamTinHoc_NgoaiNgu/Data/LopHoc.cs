using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Data
{
    internal class LopHoc
    {
        public int ID { get; set; }
        public string MaLop { get; set; } = null!;
        public string TenLop { get; set; } = null!;
        public DateTime? NgayBD { get; set; }
        public DateTime? NgayKT { get; set; }
        public bool TrangThai { get; set; }
        public int KhoaHocID { get; set; }

        public virtual KhoaHoc KhoaHoc { get; set; } = null!;
        public virtual ICollection<LichHoc> LichHocs { get; set; } = new List<LichHoc>();
        public virtual ICollection<KetQua> KetQuas { get; set; } = new List<KetQua>();
        public virtual ICollection<HocPhi> HocPhis { get; set; } = new List<HocPhi>();

    }
}
