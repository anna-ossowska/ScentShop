using Microsoft.EntityFrameworkCore.Migrations;

namespace ScentShop.Migrations
{
    public partial class UpdatingSeedFile9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 31,
                column: "Description",
                value: "A light, distinguished fragrance inspired by the fresh sea, warm sun and the richness of the earth. It opens with a splash of fresh calabrian bergamot, neroli and green tangerine. Light, aquatic nuances mix with jasmine petal, crisp rock rose, rosemary, fruity persimmon and warm Indonesian patchouli to create a masculine scent that is both fresh and sensual.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 31,
                column: "Description",
                value: "Aqua di Gio is full of scorching Mediterranean sun. Bitter citrus with aromatic nuance of rosemary intertwines with salty, sea nuances and pellucid hedione. Sharp notes of spices are softened by woody base with warm, musky trail.");
        }
    }
}
