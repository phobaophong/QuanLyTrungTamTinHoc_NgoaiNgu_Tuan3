using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Data
{
    public class Quyen
    {
        public int ID { get; set; }
        public string MaQuyen { get; set; } = null!;
        public string TenQuyen { get; set; } = null!;

        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; } = new List<TaiKhoan>();

    }
}
