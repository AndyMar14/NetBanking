﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetBanking.Infrastructure.Persistence.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BankProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainProduct = table.Column<int>(type: "int", nullable: false),
                    IdProducType = table.Column<int>(type: "int", nullable: false),
                    Identifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Limit = table.Column<double>(type: "float", nullable: false),
                    Monto = table.Column<double>(type: "float", nullable: false),
                    Balance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_BankProducts_IdProducType",
                        column: x => x.IdProducType,
                        principalTable: "BankProducts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUserProduct = table.Column<int>(type: "int", nullable: false),
                    IdRecipientProduct = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Monto = table.Column<double>(type: "float", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
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

            migrationBuilder.InsertData(
                table: "BankProducts",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Cuenta de ahorro" });

            migrationBuilder.InsertData(
                table: "BankProducts",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Tarjeta de crédito" });

            migrationBuilder.InsertData(
                table: "BankProducts",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Préstamo" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_IdProducType",
                table: "Products",
                column: "IdProducType");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_IdRecipientProduct",
                table: "Transactions",
                column: "IdRecipientProduct");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_IdUserProduct",
                table: "Transactions",
                column: "IdUserProduct");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "BankProducts");
        }
    }
}
