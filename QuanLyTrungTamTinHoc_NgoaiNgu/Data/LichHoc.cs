using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Data
{
    public class LichHoc
    {
        public int ID { get; set; }
        public DateTime NgayHoc { get; set; }
        public int BuoiSo { get; set; }
        public int LopHocID { get; set; }
        public int CaHocID { get; set; }
        public int GiangVienID { get; set; }
        public int PhongHocID { get; set; }

        public virtual LopHoc LopHoc { get; set; } = null!;
        public virtual CaHoc CaHoc { get; set; } = null!;
        public virtual GiangVien GiangVien { get; set; } = null!;
        public virtual PhongHoc PhongHoc { get; set; } = null!;
    }
}
