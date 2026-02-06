using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.SupportClass
{
    public class TuanItem
    {
        public int SoTuan { get; set; }
        public DateTime TuNgay { get; set; }
        public DateTime DenNgay { get; set; }

        public override string ToString()
            => $"Tuần {SoTuan} ({TuNgay:dd/MM} - {DenNgay:dd/MM})";
    }
}
