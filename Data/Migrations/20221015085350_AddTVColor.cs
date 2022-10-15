using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class AddTVColor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "TVs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "White" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Black" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Gray" });

            migrationBuilder.UpdateData(
                table: "TVs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ColorId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TVs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ColorId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TVs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ColorId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TVs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ColorId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_TVs_ColorId",
                table: "TVs",
                column: "ColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_TVs_Colors_ColorId",
                table: "TVs",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TVs_Colors_ColorId",
                table: "TVs");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropIndex(
                name: "IX_TVs_ColorId",
                table: "TVs");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "TVs");
        }
    }
}
