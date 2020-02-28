using Microsoft.EntityFrameworkCore.Migrations;

namespace Projekt.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 7,
                column: "CategoryId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 8,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 9,
                column: "CategoryId",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 7,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 8,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 9,
                column: "CategoryId",
                value: 3);
        }
    }
}
