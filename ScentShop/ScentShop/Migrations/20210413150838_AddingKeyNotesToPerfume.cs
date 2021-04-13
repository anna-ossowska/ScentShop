using Microsoft.EntityFrameworkCore.Migrations;

namespace ScentShop.Migrations
{
    public partial class AddingKeyNotesToPerfume : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KeyNotes",
                table: "Perfumes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KeyNotes",
                table: "Perfumes");
        }
    }
}
