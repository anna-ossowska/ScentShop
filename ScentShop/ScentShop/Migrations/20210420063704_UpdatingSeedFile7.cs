using Microsoft.EntityFrameworkCore.Migrations;

namespace ScentShop.Migrations
{
    public partial class UpdatingSeedFile7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/do0ohxztp/image/upload/v1618900528/ScentShop/for%20Her/tom-ford-velvet-orchid_my0mzu.png");

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/do0ohxztp/image/upload/v1618900532/ScentShop/for%20Her/tom-ford-black-orchid_izuvrm.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861775/ScentShop/for%20Her/tom-ford-velvet-orchid_xwsrg9.png");

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861774/ScentShop/for%20Her/tom-ford-black-orchid_xsypzg.png");
        }
    }
}
