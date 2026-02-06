using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Migrations
{
    /// <inheritdoc />
    public partial class KhoiTaoCSDL : Migration
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
                name: "GiangVien",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaGV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoTenGV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoaiGV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailGV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChuyenMon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HinhAnhGV = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiangVien", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KhoaHoc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKH = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "NhanVien",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoTenNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoaiNV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoPhan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChucVu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HinhAnhNV = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.ID);
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
                    MaLop = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "HocVien",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoTenHV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoDienThoaiHV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailHV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HinhAnhHV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LopHocID = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    NhanVienID = table.Column<int>(type: "int", nullable: true),
                    GiangVienID = table.Column<int>(type: "int", nullable: true),
                    HocVienID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TaiKhoan_GiangVien_GiangVienID",
                        column: x => x.GiangVienID,
                        principalTable: "GiangVien",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TaiKhoan_HocVien_HocVienID",
                        column: x => x.HocVienID,
                        principalTable: "HocVien",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TaiKhoan_NhanVien_NhanVienID",
                        column: x => x.NhanVienID,
                        principalTable: "NhanVien",
                        principalColumn: "ID");
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
                name: "TaiKhoan_Quyen",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaiKhoanID = table.Column<int>(type: "int", nullable: false),
                    QuyenID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan_Quyen", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TaiKhoan_Quyen_Quyen_QuyenID",
                        column: x => x.QuyenID,
                        principalTable: "Quyen",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaiKhoan_Quyen_TaiKhoan_TaiKhoanID",
                        column: x => x.TaiKhoanID,
                        principalTable: "TaiKhoan",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_LichHoc_PhongHocID",
                table: "LichHoc",
                column: "PhongHocID");

            migrationBuilder.CreateIndex(
                name: "IX_LopHoc_KhoaHocID",
                table: "LopHoc",
                column: "KhoaHocID");

            migrationBuilder.CreateIndex(
                name: "IX_PhienDangNhap_TaiKhoanID",
                table: "PhienDangNhap",
                column: "TaiKhoanID");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoan_GiangVienID",
                table: "TaiKhoan",
                column: "GiangVienID");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoan_HocVienID",
                table: "TaiKhoan",
                column: "HocVienID");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoan_NhanVienID",
                table: "TaiKhoan",
                column: "NhanVienID");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoan_Quyen_QuyenID",
                table: "TaiKhoan_Quyen",
                column: "QuyenID");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoan_Quyen_TaiKhoanID",
                table: "TaiKhoan_Quyen",
                column: "TaiKhoanID");
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
                name: "PhienDangNhap");

            migrationBuilder.DropTable(
                name: "TaiKhoan_Quyen");

            migrationBuilder.DropTable(
                name: "LoaiDiem");

            migrationBuilder.DropTable(
                name: "CaHoc");

            migrationBuilder.DropTable(
                name: "PhongHoc");

            migrationBuilder.DropTable(
                name: "Quyen");

            migrationBuilder.DropTable(
                name: "TaiKhoan");

            migrationBuilder.DropTable(
                name: "GiangVien");

            migrationBuilder.DropTable(
                name: "HocVien");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "LopHoc");

            migrationBuilder.DropTable(
                name: "KhoaHoc");
        }
    }
}
