using Microsoft.EntityFrameworkCore.Migrations;

namespace NetBanking.Infrastructure.Identity.Migrations
{
    public partial class addcedulacolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Identification",
                schema: "Identity",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Identification",
                schema: "Identity",
                table: "Users");
        }
    }
}
