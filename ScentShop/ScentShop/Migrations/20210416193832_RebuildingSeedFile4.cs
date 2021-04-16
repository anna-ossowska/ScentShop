using Microsoft.EntityFrameworkCore.Migrations;

namespace ScentShop.Migrations
{
    public partial class RebuildingSeedFile4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Brand", "Capacity", "Description", "KeyNotes", "Name", "Price" },
                values: new object[] { "Nautica", 50, "The composition opens with cold, green notes of leaves and apple. There is a tender dewy mimose in the heart, which is blended with watery note of lotus and an interesting accord of linen sail of a yacht. The composition is laid on a woody base, combined of cedar, moss, musk and amber.", "Apple, Lotus, Cedar", "Voyage", 700m });

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Brand", "Capacity", "Description", "KeyNotes", "Name", "Price" },
                values: new object[] { "Giorgio Armani", 100, "The fragrance for men is a scent of freedom, full of wind and water. The composition is built of a perfect harmony of sweet and salty notes of sea water and nuances of sunny warmth on your skin. Aqua di Gio is full of scorching Mediterranean sun. Bitter citrus with aromatic nuance of rosemary intertwines with salty, sea nuances and pellucid hedione. Sharp notes of spices are softened by woody base with warm, musky trail.", "Bergamot, Neroli, Green Tangerine", "Acqua di Gio", 150m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Brand", "Capacity", "Description", "KeyNotes", "Name", "Price" },
                values: new object[] { "Giorgio Armani", 100, "The fragrance for men is a scent of freedom, full of wind and water. The composition is built of a perfect harmony of sweet and salty notes of sea water and nuances of sunny warmth on your skin. Aqua di Gio is full of scorching Mediterranean sun. Bitter citrus with aromatic nuance of rosemary intertwines with salty, sea nuances and pellucid hedione. Sharp notes of spices are softened by woody base with warm, musky trail.", "Bergamot, Neroli, Green Tangerine", "Acqua di Gio", 150m });

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Brand", "Capacity", "Description", "KeyNotes", "Name", "Price" },
                values: new object[] { "Nautica", 50, "The composition opens with cold, green notes of leaves and apple. There is a tender dewy mimose in the heart, which is blended with watery note of lotus and an interesting accord of linen sail of a yacht. The composition is laid on a woody base, combined of cedar, moss, musk and amber.", "Apple, Lotus, Cedar", "Voyage", 700m });
        }
    }
}
