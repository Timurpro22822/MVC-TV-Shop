using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class AddImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Resolution",
                table: "TVs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "TVs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Diagonal",
                table: "TVs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "TVs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "TVs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePath",
                value: "https://samsungshop.com.ua/res/cache/images/7d/15/7d153c06cf8aeafa0307b002847130ad/ad6844aa1e4caa49c317ac5114ec9346.jpg");

            migrationBuilder.UpdateData(
                table: "TVs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePath",
                value: "https://samsungshop.com.ua/res/cache/images/1d/90/1d90f289e972b72228c32289202be042/e8d9a3ca400b66bf8c8c692f14da64a2.jpg");

            migrationBuilder.UpdateData(
                table: "TVs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagePath",
                value: "https://samsungshop.com.ua/res/cache/images/40/19/401937ab040b932e4f2c1e9337ddd3c0/15a98e0cd6a396d4bca1ca2dc6617e43.jpg");

            migrationBuilder.UpdateData(
                table: "TVs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagePath",
                value: "https://samsungshop.com.ua/res/cache/images/1c/4f/1c4f73fd470d63249f4a0763dff03d89/4262c548db10324900e61c6853ce44f8.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "TVs");

            migrationBuilder.AlterColumn<string>(
                name: "Resolution",
                table: "TVs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "TVs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Diagonal",
                table: "TVs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }
    }
}
