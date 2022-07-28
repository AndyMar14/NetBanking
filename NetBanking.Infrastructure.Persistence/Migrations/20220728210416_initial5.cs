using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetBanking.Infrastructure.Persistence.Migrations
{
    public partial class initial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdRecipientProduct = table.Column<int>(type: "int", nullable: false),
                    IdUserProduct = table.Column<int>(type: "int", nullable: false),
                    Monto = table.Column<double>(type: "float", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_Products_IdRecipientProduct",
                        column: x => x.IdRecipientProduct,
                        principalTable: "Products",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Transactions_Products_IdUserProduct",
                        column: x => x.IdUserProduct,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_IdRecipientProduct",
                table: "Transactions",
                column: "IdRecipientProduct");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_IdUserProduct",
                table: "Transactions",
                column: "IdUserProduct");
        }
    }
}
