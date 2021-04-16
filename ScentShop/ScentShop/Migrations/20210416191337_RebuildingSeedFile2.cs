using Microsoft.EntityFrameworkCore.Migrations;

namespace ScentShop.Migrations
{
    public partial class RebuildingSeedFile2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageThumbnailUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Capacity", "Description", "KeyNotes", "Name", "Price" },
                values: new object[] { 50, "This perfume's rich blend of spicy heat and glowing citrus gives way to Indian kulfi, wrapped in rose absolute, jasmine accord, and orange flower. It also contains notes of extravagant amber with sandalwood and vanilla ember for a creamy, woody finish.", "Cardamom, Orange Flower, Sandalwood", "Noir Extreme", 180m });

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Brand", "Capacity", "Description", "KeyNotes", "Name", "Price" },
                values: new object[] { "Versace", 100, "New and exquisite qualities of natural citrus, aquatic notes, and violet leaves combine with modern hints of fig leaf to give an incisive, Mediterranean freshness.", "Aquatic Notes, Bergamot, Patchouli", "Dylan Blue", 200m });

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "IsPerfumeOfTheWeek", "KeyNotes", "Name" },
                values: new object[] { "The new fragrance for men, Versace Pour Homme, blends essential ingredients of Mediterranean origin to hit aromatic notes.", true, "Bergamot, Neroli, Citron of Diamante", "Pour Homme" });

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Brand", "Description", "IsPerfumeOfTheWeek", "KeyNotes", "Name", "Price" },
                values: new object[] { "Giorgio Armani", "The fragrance for men is a scent of freedom, full of wind and water. The composition is built of a perfect harmony of sweet and salty notes of sea water and nuances of sunny warmth on your skin. Aqua di Gio is full of scorching Mediterranean sun. Bitter citrus with aromatic nuance of rosemary intertwines with salty, sea nuances and pellucid hedione. Sharp notes of spices are softened by woody base with warm, musky trail.", false, "Bergamot, Neroli, Green Tangerine", "Acqua di Gio", 150m });

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Brand", "Capacity", "Description", "KeyNotes", "Name", "Price" },
                values: new object[] { "Nautica", 50, "The composition opens with cold, green notes of leaves and apple. There is a tender dewy mimose in the heart, which is blended with watery note of lotus and an interesting accord of linen sail of a yacht. The composition is laid on a woody base, combined of cedar, moss, musk and amber.", "Apple, Lotus, Cedar", "Voyage", 700m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageThumbnailUrl",
                value: "https://res.cloudinary.com/do0ohxztp/image/upload/v1618217350/ScentShop/card-3_chnyqj.png");

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Capacity", "Description", "KeyNotes", "Name", "Price" },
                values: new object[] { 100, "A composition of exotic, smoky woods including rare oud, sandalwood, rosewood, eastern spices, and sensual amber—revealing oud‘s rich and compelling power.", "Rare Oud Wood, Chinese Pepper, Vanilla", "Oud Wood", 250m });

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Brand", "Capacity", "Description", "KeyNotes", "Name", "Price" },
                values: new object[] { "Tom Ford", 50, "This perfume's rich blend of spicy heat and glowing citrus gives way to Indian kulfi, wrapped in rose absolute, jasmine accord, and orange flower. It also contains notes of extravagant amber with sandalwood and vanilla ember for a creamy, woody finish.", "Cardamom, Orange Flower, Sandalwood", "Noir Extreme", 180m });

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "IsPerfumeOfTheWeek", "KeyNotes", "Name" },
                values: new object[] { "New and exquisite qualities of natural citrus, aquatic notes, and violet leaves combine with modern hints of fig leaf to give an incisive, Mediterranean freshness.", false, "Aquatic Notes, Bergamot, Patchouli", "Dylan Blue" });

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Brand", "Description", "IsPerfumeOfTheWeek", "KeyNotes", "Name", "Price" },
                values: new object[] { "Versace", "The new fragrance for men, Versace Pour Homme, blends essential ingredients of Mediterranean origin to hit aromatic notes.", true, "Bergamot, Neroli, Citron of Diamante", "Pour Homme", 200m });

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Brand", "Capacity", "Description", "KeyNotes", "Name", "Price" },
                values: new object[] { "Giorgio Armani", 100, "The fragrance for men is a scent of freedom, full of wind and water. The composition is built of a perfect harmony of sweet and salty notes of sea water and nuances of sunny warmth on your skin. Aqua di Gio is full of scorching Mediterranean sun. Bitter citrus with aromatic nuance of rosemary intertwines with salty, sea nuances and pellucid hedione. Sharp notes of spices are softened by woody base with warm, musky trail.", "Bergamot, Neroli, Green Tangerine", "Acqua di Gio", 150m });

            migrationBuilder.InsertData(
                table: "Perfumes",
                columns: new[] { "Id", "Brand", "Capacity", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsDiscounted", "IsPerfumeOfTheWeek", "KeyNotes", "Name", "Price" },
                values: new object[] { 32, "Nautica", 50, 2, "The composition opens with cold, green notes of leaves and apple. There is a tender dewy mimose in the heart, which is blended with watery note of lotus and an interesting accord of linen sail of a yacht. The composition is laid on a woody base, combined of cedar, moss, musk and amber.", null, null, true, false, false, "Apple, Lotus, Cedar", "Voyage", 700m });
        }
    }
}
