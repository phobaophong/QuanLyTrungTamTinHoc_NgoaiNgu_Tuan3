using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Data
{
    internal class Quyen
    {
        public int ID { get; set; }
        public string MaQuyen { get; set; } = null!;
        public string TenQuyen { get; set; } = null!;

        public virtual ICollection<TaiKhoan_Quyen> TaiKhoan_Quyens { get; set; } = new List<TaiKhoan_Quyen>();

    }
}
