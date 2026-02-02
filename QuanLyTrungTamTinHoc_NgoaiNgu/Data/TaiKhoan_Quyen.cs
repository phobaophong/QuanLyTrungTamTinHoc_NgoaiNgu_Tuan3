using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Data
{
    public class TaiKhoan_Quyen
    {
        public int ID { get; set; }
        public int TaiKhoanID { get; set; }
        public int QuyenID { get; set; }

        public TaiKhoan TaiKhoan { get; set; } = null!;
        public Quyen Quyen { get; set; } = null!;
    }
}
