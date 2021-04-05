using Microsoft.EntityFrameworkCore.Migrations;

namespace ScentShop.Migrations
{
    public partial class SeedDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 1, "For Her" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 2, "For Him" });

            migrationBuilder.InsertData(
                table: "Perfumes",
                columns: new[] { "Id", "Brand", "Capacity", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPerfumeOfTheWeek", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Versace", 198, 1, "Inspired by a mixture of Donatella Versace's favorite floral fragrances, Bright Crystal is a fresh, sensual blend of refreshing chilled yuzu and pomegranate mingled with soothing blossoms of peony, magnolia, and lotus flower, warmed with notes of musk and amber.", null, null, true, true, "Bright Crystal", 140m },
                    { 2, "Chanel", 50, 1, "With its unprecedented use of aldehydes, which add layers of complexity, N°5 was the world’s first abstract fragrance. The Eau de Parfum draws inspiration from the Parfum with which it shares its floral aldehyde signature. This floral bouquet composed around May Rose and Jasmine features bright citrus top notes. Aldehydes create a unique presence while the smooth touch of Bourbon Vanilla leaves an incredibly sensual trail.", null, null, true, false, "N°5", 108m },
                    { 3, "Dior", 100, 1, "This fragrance opens with the exotic, floral-fruity notes of ylang ylang, while Damascus rose, and both Grasse jasmine and Indian jasmine sambac exude a seductive warmth. This scent is the ultimate expression of femininity and luxury and is floral yet mysterious, a confident signature to celebrate your feminine allure.", null, null, true, true, "J'adore", 135m },
                    { 4, "Chanel", 50, 2, "BLEU DE CHANEL unites the invigorating zest of Grapefruit and the power of an aromatic accord with the woody whisper of Dry Cedar. New Caledonian Sandalwood lends it a warm and sensual trail. A meeting of strength and elegance.", null, null, true, true, "Bleu de Chanel", 80m },
                    { 5, "Tom Ford", 50, 2, "A composition of exotic, smoky woods including rare oud, sandalwood, rosewood, eastern spices, and sensual amber—revealing oud‘s rich and compelling power.", null, null, true, false, "Oud Wood", 250m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);
        }
    }
}
