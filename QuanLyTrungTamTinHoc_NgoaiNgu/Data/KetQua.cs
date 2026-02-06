using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Data
{
    public class KetQua
    {
        public int ID { get; set; }

        public int HocVienID { get; set; }
        public int LoaiDiemID { get; set; }

        public int LanThi { get; set; }
        public double DiemSo { get; set; }

        public virtual HocVien HocVien { get; set; } = null!;
        public virtual LoaiDiem LoaiDiem { get; set; } = null!;
    }
}
