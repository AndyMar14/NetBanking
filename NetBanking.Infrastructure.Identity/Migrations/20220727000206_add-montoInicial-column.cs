using Microsoft.EntityFrameworkCore.Migrations;

namespace NetBanking.Infrastructure.Identity.Migrations
{
    public partial class addmontoInicialcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MontoInicial",
                schema: "Identity",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MontoInicial",
                schema: "Identity",
                table: "Users");
        }
    }
}
