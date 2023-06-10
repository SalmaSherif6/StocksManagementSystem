using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StocksManagementSystem.Infrastucture.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Name", "Price" },
                values: new object[,]
                {
                    { "Vianet", 10.5 },
                    { "Agritek", 20.5 },
                    { "Akamai", 50 },
                    { "Baidu", 100 },
                    { "Blinkx", 10 },
                    { "Blucora", 172.5 },
                    { "Boingo", 10.5 },
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
