using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class addResolution : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Resolution",
                table: "TVs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "TVs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Resolution",
                value: "3840x2160 UHD 4K");

            migrationBuilder.UpdateData(
                table: "TVs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Resolution",
                value: "3840x2160 UHD 4K");

            migrationBuilder.UpdateData(
                table: "TVs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Resolution",
                value: "3840x2160 UHD 4K");

            migrationBuilder.UpdateData(
                table: "TVs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Resolution",
                value: "3840x2160 UHD 4K");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Resolution",
                table: "TVs");
        }
    }
}
