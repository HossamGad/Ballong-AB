using Microsoft.EntityFrameworkCore.Migrations;

namespace Projekt.Migrations
{
    public partial class New123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProdukterProduktId",
                table: "DbNyProdukt",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DbNyProdukt_ProdukterProduktId",
                table: "DbNyProdukt",
                column: "ProdukterProduktId");

            migrationBuilder.AddForeignKey(
                name: "FK_DbNyProdukt_Produkter_ProdukterProduktId",
                table: "DbNyProdukt",
                column: "ProdukterProduktId",
                principalTable: "Produkter",
                principalColumn: "ProduktId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DbNyProdukt_Produkter_ProdukterProduktId",
                table: "DbNyProdukt");

            migrationBuilder.DropIndex(
                name: "IX_DbNyProdukt_ProdukterProduktId",
                table: "DbNyProdukt");

            migrationBuilder.DropColumn(
                name: "ProdukterProduktId",
                table: "DbNyProdukt");
        }
    }
}
