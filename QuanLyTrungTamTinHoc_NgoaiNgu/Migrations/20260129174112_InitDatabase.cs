using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Migrations
{
    /// <inheritdoc />
    public partial class InitDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HocVienID",
                table: "TaiKhoan",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoan_HocVienID",
                table: "TaiKhoan",
                column: "HocVienID");

            migrationBuilder.AddForeignKey(
                name: "FK_TaiKhoan_HocVien_HocVienID",
                table: "TaiKhoan",
                column: "HocVienID",
                principalTable: "HocVien",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaiKhoan_HocVien_HocVienID",
                table: "TaiKhoan");

            migrationBuilder.DropIndex(
                name: "IX_TaiKhoan_HocVienID",
                table: "TaiKhoan");

            migrationBuilder.DropColumn(
                name: "HocVienID",
                table: "TaiKhoan");
        }
    }
}
