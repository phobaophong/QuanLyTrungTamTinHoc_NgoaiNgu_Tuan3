using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Migrations
{
    /// <inheritdoc />
    public partial class KhoiTaoCSDL2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LopHocID",
                table: "HocVien",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaLopID",
                table: "HocVien",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HocVien_LopHocID",
                table: "HocVien",
                column: "LopHocID");

            migrationBuilder.AddForeignKey(
                name: "FK_HocVien_LopHoc_LopHocID",
                table: "HocVien",
                column: "LopHocID",
                principalTable: "LopHoc",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HocVien_LopHoc_LopHocID",
                table: "HocVien");

            migrationBuilder.DropIndex(
                name: "IX_HocVien_LopHocID",
                table: "HocVien");

            migrationBuilder.DropColumn(
                name: "LopHocID",
                table: "HocVien");

            migrationBuilder.DropColumn(
                name: "MaLopID",
                table: "HocVien");
        }
    }
}
