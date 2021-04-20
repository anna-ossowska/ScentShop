using Microsoft.EntityFrameworkCore.Migrations;

namespace ScentShop.Migrations
{
    public partial class UpdatingSeedFile6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Wood Sage");

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 30,
                column: "Price",
                value: 300m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Wood Sage & Sea Salt");

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 30,
                column: "Price",
                value: 700m);
        }
    }
}
