using Microsoft.EntityFrameworkCore.Migrations;

namespace ScentShop.Migrations
{
    public partial class AddingImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageThumbnailUrl",
                value: "https://res.cloudinary.com/do0ohxztp/image/upload/v1618217335/ScentShop/card-1_mofrrw.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageThumbnailUrl",
                value: null);
        }
    }
}
