using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PhamVanNhatHuy_ThucHanhEF.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Khoa",
                columns: new[] { "Id", "TenKhoa" },
                values: new object[,]
                {
                    { 1, "Công nghệ số" },
                    { 2, "Cơ khí" },
                    { 3, "Xây dựng" }
                });

            migrationBuilder.InsertData(
                table: "Lop",
                columns: new[] { "Id", "MaKhoa", "TenLop" },
                values: new object[,]
                {
                    { 1, 1, "21T1" },
                    { 2, 1, "21T2" },
                    { 3, 1, "21T3" }
                });

            migrationBuilder.InsertData(
                table: "SinhVien",
                columns: new[] { "Id", "HoTen", "MaLop", "MaSinhVien", "Tuoi" },
                values: new object[,]
                {
                    { 1, "Phạm Văn Nhật Huy", 3, "21115053120318", 21 },
                    { 2, "Nguyễn Văn A", 2, "21115053120336", 21 },
                    { 3, "Nguyễn Văn B", 1, "21115053120323", 21 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Khoa",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Khoa",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SinhVien",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SinhVien",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SinhVien",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Lop",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lop",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lop",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Khoa",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
