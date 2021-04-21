using Microsoft.EntityFrameworkCore.Migrations;

namespace ScentShop.Migrations
{
    public partial class UpdatingSeedFile11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/do0ohxztp/image/upload/v1619012420/ScentShop/for%20Her/dior-jadore_eewtw5.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861768/ScentShop/for%20Her/dior-jadore_exnrym.png");
        }
    }
}
