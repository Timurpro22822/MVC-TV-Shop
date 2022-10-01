using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_TV_Shop.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TVs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diagonal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TVs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TVs",
                columns: new[] { "Id", "Diagonal", "Model", "Price", "Year" },
                values: new object[,]
                {
                    { 1, "55″", "Samsung QE55QN90BAUXUA Neo", 73999m, 2022 },
                    { 2, "65″", "Samsung QE65Q70BAUXUA", 62999m, 2022 },
                    { 3, "65″", "Samsung QE65Q60BAUXUA", 52199m, 2022 },
                    { 4, "55″", "Samsung UE55BU8500UXUA", 28399m, 2022 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TVs");
        }
    }
}
