using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Migrations
{
    /// <inheritdoc />
    public partial class KhoiTaóCDL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CaHoc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioBatDau = table.Column<TimeSpan>(type: "time", nullable: false),
                    GioKetThuc = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaHoc", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KhoaHoc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKH = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenKH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HocPhi = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ThoiLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoaHoc", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LoaiDiem",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaLD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenLD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeSo = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiDiem", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PhongHoc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaPhong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenPhong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SucChua = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongHoc", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Quyen",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaQuyen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenQuyen = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quyen", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LopHoc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaLop = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenLop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayBD = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayKT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    KhoaHocID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopHoc", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LopHoc_KhoaHoc_KhoaHocID",
                        column: x => x.KhoaHocID,
                        principalTable: "KhoaHoc",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    QuyenID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TaiKhoan_Quyen_QuyenID",
                        column: x => x.QuyenID,
                        principalTable: "Quyen",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GiangVien",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaGV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HoTenGV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailGV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChuyenMon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HinhAnhGV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaiKhoanID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiangVien", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GiangVien_TaiKhoan_TaiKhoanID",
                        column: x => x.TaiKhoanID,
                        principalTable: "TaiKhoan",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HocVien",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HoTenHV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailHV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HinhAnhHV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LopHocID = table.Column<int>(type: "int", nullable: false),
                    TaiKhoanID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocVien", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HocVien_LopHoc_LopHocID",
                        column: x => x.LopHocID,
                        principalTable: "LopHoc",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HocVien_TaiKhoan_TaiKhoanID",
                        column: x => x.TaiKhoanID,
                        principalTable: "TaiKhoan",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HoTenNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoPhan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChucVu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HinhAnhNV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaiKhoanID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NhanVien_TaiKhoan_TaiKhoanID",
                        column: x => x.TaiKhoanID,
                        principalTable: "TaiKhoan",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhienDangNhap",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThoiGianDangNhap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianDangXuat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhienDangNhap", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PhienDangNhap_TaiKhoan_TaiKhoanID",
                        column: x => x.TaiKhoanID,
                        principalTable: "TaiKhoan",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LichHoc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayHoc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BuoiSo = table.Column<int>(type: "int", nullable: false),
                    LopHocID = table.Column<int>(type: "int", nullable: false),
                    CaHocID = table.Column<int>(type: "int", nullable: false),
                    GiangVienID = table.Column<int>(type: "int", nullable: false),
                    PhongHocID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichHoc", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LichHoc_CaHoc_CaHocID",
                        column: x => x.CaHocID,
                        principalTable: "CaHoc",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LichHoc_GiangVien_GiangVienID",
                        column: x => x.GiangVienID,
                        principalTable: "GiangVien",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LichHoc_LopHoc_LopHocID",
                        column: x => x.LopHocID,
                        principalTable: "LopHoc",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LichHoc_PhongHoc_PhongHocID",
                        column: x => x.PhongHocID,
                        principalTable: "PhongHoc",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HocPhi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    NgayDongHocPhi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HocVienID = table.Column<int>(type: "int", nullable: false),
                    LopHocID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocPhi", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HocPhi_HocVien_HocVienID",
                        column: x => x.HocVienID,
                        principalTable: "HocVien",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HocPhi_LopHoc_LopHocID",
                        column: x => x.LopHocID,
                        principalTable: "LopHoc",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "KetQua",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HocVienID = table.Column<int>(type: "int", nullable: false),
                    LoaiDiemID = table.Column<int>(type: "int", nullable: false),
                    LanThi = table.Column<int>(type: "int", nullable: false),
                    DiemSo = table.Column<double>(type: "float", nullable: false),
                    LopHocID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KetQua", x => x.ID);
                    table.ForeignKey(
                        name: "FK_KetQua_HocVien_HocVienID",
                        column: x => x.HocVienID,
                        principalTable: "HocVien",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KetQua_LoaiDiem_LoaiDiemID",
                        column: x => x.LoaiDiemID,
                        principalTable: "LoaiDiem",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KetQua_LopHoc_LopHocID",
                        column: x => x.LopHocID,
                        principalTable: "LopHoc",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_GiangVien_MaGV",
                table: "GiangVien",
                column: "MaGV",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GiangVien_TaiKhoanID",
                table: "GiangVien",
                column: "TaiKhoanID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HocPhi_HocVienID",
                table: "HocPhi",
                column: "HocVienID");

            migrationBuilder.CreateIndex(
                name: "IX_HocPhi_LopHocID",
                table: "HocPhi",
                column: "LopHocID");

            migrationBuilder.CreateIndex(
                name: "IX_HocVien_LopHocID",
                table: "HocVien",
                column: "LopHocID");

            migrationBuilder.CreateIndex(
                name: "IX_HocVien_MaHV",
                table: "HocVien",
                column: "MaHV",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HocVien_TaiKhoanID",
                table: "HocVien",
                column: "TaiKhoanID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KetQua_HocVienID",
                table: "KetQua",
                column: "HocVienID");

            migrationBuilder.CreateIndex(
                name: "IX_KetQua_LoaiDiemID",
                table: "KetQua",
                column: "LoaiDiemID");

            migrationBuilder.CreateIndex(
                name: "IX_KetQua_LopHocID",
                table: "KetQua",
                column: "LopHocID");

            migrationBuilder.CreateIndex(
                name: "IX_KhoaHoc_MaKH",
                table: "KhoaHoc",
                column: "MaKH",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LichHoc_CaHocID",
                table: "LichHoc",
                column: "CaHocID");

            migrationBuilder.CreateIndex(
                name: "IX_LichHoc_GiangVienID",
                table: "LichHoc",
                column: "GiangVienID");

            migrationBuilder.CreateIndex(
                name: "IX_LichHoc_LopHocID",
                table: "LichHoc",
                column: "LopHocID");

            migrationBuilder.CreateIndex(
                name: "IX_LichHoc_NgayHoc_CaHocID_GiangVienID",
                table: "LichHoc",
                columns: new[] { "NgayHoc", "CaHocID", "GiangVienID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LichHoc_NgayHoc_CaHocID_PhongHocID",
                table: "LichHoc",
                columns: new[] { "NgayHoc", "CaHocID", "PhongHocID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LichHoc_PhongHocID",
                table: "LichHoc",
                column: "PhongHocID");

            migrationBuilder.CreateIndex(
                name: "IX_LopHoc_KhoaHocID",
                table: "LopHoc",
                column: "KhoaHocID");

            migrationBuilder.CreateIndex(
                name: "IX_LopHoc_MaLop",
                table: "LopHoc",
                column: "MaLop",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_MaNV",
                table: "NhanVien",
                column: "MaNV",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_TaiKhoanID",
                table: "NhanVien",
                column: "TaiKhoanID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhienDangNhap_TaiKhoanID",
                table: "PhienDangNhap",
                column: "TaiKhoanID");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoan_QuyenID",
                table: "TaiKhoan",
                column: "QuyenID");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoan_TenDN",
                table: "TaiKhoan",
                column: "TenDN",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HocPhi");

            migrationBuilder.DropTable(
                name: "KetQua");

            migrationBuilder.DropTable(
                name: "LichHoc");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "PhienDangNhap");

            migrationBuilder.DropTable(
                name: "HocVien");

            migrationBuilder.DropTable(
                name: "LoaiDiem");

            migrationBuilder.DropTable(
                name: "CaHoc");

            migrationBuilder.DropTable(
                name: "GiangVien");

            migrationBuilder.DropTable(
                name: "PhongHoc");

            migrationBuilder.DropTable(
                name: "LopHoc");

            migrationBuilder.DropTable(
                name: "TaiKhoan");

            migrationBuilder.DropTable(
                name: "KhoaHoc");

            migrationBuilder.DropTable(
                name: "Quyen");
        }
    }
}
