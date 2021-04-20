using Microsoft.EntityFrameworkCore.Migrations;

namespace ScentShop.Migrations
{
    public partial class UpdatingSeedFile5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Perfumes",
                columns: new[] { "Id", "Brand", "Capacity", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPerfumeOfTheWeek", "KeyNotes", "Name", "Price" },
                values: new object[] { 36, "Giorgio Armani", 50, 2, "The first oriental Giorgio Armani cologne for men, this aromatic fragrance blends the freshness of bergamot, the soft sensuality of olive flower, and the warmth of guaiac wood and tonka bean.", null, null, true, false, "Olive Tree Blossom, Guaiac Wood, Tonka Bean", "Armani Code", 68m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 36);
        }
    }
}
