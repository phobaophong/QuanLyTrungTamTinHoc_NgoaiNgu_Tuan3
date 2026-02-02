using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Data
{
    public class QLTTDbContext : DbContext
    {
        public DbSet<HocVien> HocVien { get; set; }
        public DbSet<GiangVien> GiangVien { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<TaiKhoan> TaiKhoan { get; set; }
        public DbSet<PhienDangNhap> PhienDangNhap { get; set; }
        public DbSet<Quyen> Quyen { get; set; }
        public DbSet<TaiKhoan_Quyen> TaiKhoan_Quyen { get; set; }
        public DbSet<KhoaHoc> KhoaHoc { get; set; }
        public DbSet<LopHoc> LopHoc { get; set; }
        public DbSet<PhongHoc> PhongHoc { get; set; }
        public DbSet<CaHoc> CaHoc { get; set; }
        public DbSet<LichHoc> LichHoc { get; set; }
        public DbSet<LoaiDiem> LoaiDiem { get; set; }
        public DbSet<KetQua> KetQua { get; set; }
        public DbSet<HocPhi> HocPhi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString
            );
        }
    }
}
