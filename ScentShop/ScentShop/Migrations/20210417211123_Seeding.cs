using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ScentShop.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Perfumes_Image_ImageId",
                table: "Perfumes");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropIndex(
                name: "IX_Perfumes_ImageId",
                table: "Perfumes");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Perfumes");

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
                columns: new[] { "Id", "Brand", "Capacity", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPerfumeOfTheWeek", "KeyNotes", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Chanel", 50, 1, "Chance is a fragrance created like a constellation, a composition like an olfactory sphere that opens up in an infinite movement. At the heart of this sphere is a sensuous balance warmed by Vanilla, with pronounced Jasmine Absolute and Iris. A mysterious alchemy, heightened by the intensity of White Musk.", null, null, true, true, "Jasmine, Pink Pepper, Vanilla", "Chance", 108m },
                    { 29, "Versace", 100, 2, "The new fragrance for men, Versace Pour Homme, blends essential ingredients of Mediterranean origin to hit aromatic notes.", null, null, true, true, "Bergamot, Neroli, Citron of Diamante", "Pour Homme", 200m },
                    { 28, "Versace", 100, 2, "New and exquisite qualities of natural citrus, aquatic notes, and violet leaves combine with modern hints of fig leaf to give an incisive, Mediterranean freshness.", null, null, true, false, "Aquatic Notes, Bergamot, Patchouli", "Dylan Blue", 200m },
                    { 27, "Tom Ford", 50, 2, "This perfume's rich blend of spicy heat and glowing citrus gives way to Indian kulfi, wrapped in rose absolute, jasmine accord, and orange flower. It also contains notes of extravagant amber with sandalwood and vanilla ember for a creamy, woody finish.", null, null, true, false, "Cardamom, Orange Flower, Sandalwood", "Noir Extreme", 180m },
                    { 26, "Tom Ford", 100, 2, "A composition of exotic, smoky woods including rare oud, sandalwood, rosewood, eastern spices, and sensual amber—revealing oud‘s rich and compelling power.", null, null, true, false, "Rare Oud Wood, Chinese Pepper, Vanilla", "Oud Wood", 250m },
                    { 25, "Ralph Lauren", 102, 2, "The heart of the fragrance is aromatic cypress and clary sage which add another level of sophistication, freshness, and sensuality.  The scent peaks with the salty mineral Deep Ocean Accord that energizes and activates an even deeper level of freshness.", null, null, true, false, "Hawaiian Green Mango, Cypress Oil", "Polo Deep Blue", 125m },
                    { 24, "Prada", 50, 2, "The perfumer Daniela Roche-Andrier created the composition in four basic accords : Amber – the main accord, rich and complex oriental base which includes amber, vanilla, labdanum, Tonka and patchouli; Fougere – or the aromatic accord with a remarkable soapy note, includes notes of pelargonium, vetiver, orange blossom and myrrh at the heart; Cologne – the refreshing citrusy top of bergamot, mandarin, neroli and cardamom; Leather – leather note is present at the base of the composition (leather, saffron and sandalwood).", null, null, true, false, "Bergamot Oil, Mandarin, Cardamom", "Amber", 94m },
                    { 23, "Hermès", 55, 2, "Terre d’Hermès is a symbolic narrative exploring raw material and its metamorphosis. A novel that expresses the alchemical power of the elements. An eau between earth and sky. A journey imbued with strength and poetry. Woody, vegetal, mineral.", null, null, true, false, "Grapefruit Accord, Black Peppers, Flint", "Terre d’Hermès", 126m },
                    { 22, "Dolce & Gabbana", 50, 2, "Elegant and sensual, this perfume is decidedly modern and uniquely timeless all at once. The spicy fragrance features fresh top notes of grapefruit, coriander, and basil; a warm heart of cardamom and ginger; and a deep masculine base of tobacco, amber, and cedarwood.", null, null, true, false, "Cardamom, Cedarwood, Ginger, Tobacco", "The One For Men", 120m },
                    { 21, "Dior", 50, 2, "A resolutely contemporary fragrance characterized by a meeting of extremes. Fresh, elegant notes blend in perfect harmony with bolder, more virile overtones to create a scent that is warm, subtle, and distinguished.", null, null, true, false, "Bergamot, Hawthorne, Honeysuckle", "Fahrenheit", 77m },
                    { 20, "Dior", 50, 2, "Lucid and willful, Eau Sauvage is the perfume of the cult of elegance, refinement, and good humor. With the zest of citrus fruits for freshness, an invigorating bouquet of herbs, a hint of jasmine and vetiver for the sensual touch, and oakmoss to conquer and seduce, it will remain a fresh, discreet classic.", null, null, true, false, "Lemon, Rosemary, Petit Grain", "Eau Sauvage", 95m },
                    { 19, "Dior", 50, 2, "The Dior Homme Eau de Toilette is an alluring combination of power and freshness. It is intensely woody and masculine, taking hold and leaving a lasting impression.", null, null, true, false, "Cedar, Haitian Vetiver, Patchouli Heart", "Homme", 120m },
                    { 18, "Dior", 60, 2, "A radically fresh composition, Sauvage is both raw and noble. Radiant top notes burst with the juicy freshness of Calabrian bergamot, while amberwood unleashes a powerfully woody trail. Sauvage is a fragrance inspired by wide-open spaces under a blue sky that dominates a white-hot desert landscape.", null, null, true, false, "Bergamot, Pepper, Amberwood", "Sauvage", 90m },
                    { 17, "Chanel", 50, 2, "A woody, aromatic fragrance for the man who defies convention; a provocative blend of citrus and woods that liberates the senses. Fresh, clean, and profoundly sensual.", null, null, true, false, "Citrus Accord, Labdanum, Sandalwood Cedar", "Bleu de Chanel", 80m },
                    { 30, "Nautica", 50, 2, "The composition opens with cold, green notes of leaves and apple. There is a tender dewy mimose in the heart, which is blended with watery note of lotus and an interesting accord of linen sail of a yacht. The composition is laid on a woody base, combined of cedar, moss, musk and amber.", null, null, true, false, "Apple, Lotus, Cedar", "Voyage", 700m },
                    { 16, "Dolce & Gabbana", 125, 2, "The fragrance opens up with neroli and citrusy hints of mandarin and bergamot.At the heart is lavender.Touches of tobacco and tonka bean provide structure for the last dry notes of wood.", null, null, true, false, "Sandalwood, Tonka Bean, Tobacco", "Pour Homme", 99m },
                    { 14, "Giorgio Armani", 50, 1, "A sweet take on a floral fragrance, this women's perfume opens with luminous notes of blackcurrant nectar and mandarin. Orange blossom forms the heart of the fragrance and warm vanilla anchors the irresistible blend for a lasting scent.", null, null, true, false, "Citrus, Lily, Pink Sandalwood", "Si", 98m },
                    { 13, "Calvin Klein", 50, 1, "The composition opens with fresh citrus and green notes, that is followed by the note of violet and lily-of-the-valley. The note of carnation with its spiciness gives the floral heart slightly peppery accord. The final notes are gentle with powdery heliotrope, pink sandalwood and transparent musky notes.", null, null, true, true, "Citrus, Lily, Pink Sandalwood", "Eternity", 155m },
                    { 12, "Tom Ford", 50, 1, "This perfume is lavished with shimmering freshness, honey, rum, and a dramatic floral veil, and it lives in Black Orchid’s world of glamorous mystique, while exuding its own ultra-feminine essence.", null, null, true, false, "Orange Blossom, Hyacinth, Jonquil", "Velvet Orchid", 134m },
                    { 11, "Ralph Lauren", 50, 1, "Sparkling notes of pink pepper and mandarin orange effervesce into a fantasy of rose and jasmine, finding a fairy tale ending in the sensual embrace of woody musk and patchouli.", null, null, true, false, "Lily, White Floral", "Romance", 178m },
                    { 10, "Neroli", 50, 1, "This long-lasting eau de parfum centers around timeless orange flower and neroli mixed with a hint of pink pepper. Playful and feminine tones inspired by the flowers of Grasse are complemented by an airy and soft layer of honey and musk, which wraps you with a second-skin effect.", null, null, true, false, "Neroli, Orange Flower, Pink Pepper", "Rag & Bone", 150m },
                    { 9, "Jo Malone London", 100, 1, "Built on a platform of rich amber, this contrasting fragrance is subtly woven with the clean smell of barber's soap. With top notes that evoke a natural, classic cologne - a rich blend of fresh mandarin, bergamot, and cardamom that melds into the sensual mid notes of patchouli, tonka bean, and vanilla; and finishes with the clean, leathery notes of vetiver, neroli, orange blossom, saffron, and suede, Amber Pour Homme is a fragrance for the self-assured man.", null, null, true, false, "Almond Cream, Dianthus", "Wood Sage & Sea Salt", 149m },
                    { 8, "Michael Kors", 100, 1, "Michael Kors Wonderlust is an oriental gourmand fragrance that captures an infinite desire for discovery. A blend of luxurious blossoms mingled with delectably spiced notes charts a course to far-off destinations, instantly transporting you with each ingredient.", null, null, true, false, "Almond Cream, Dianthus", "Wonderlust", 120m },
                    { 7, "Lancôme", 50, 1, "Made with the most precious natural ingredients, expressing notes of iris, patchouli, praline, and vanilla, this feminine, complex scent is the modern interpretation of an oriental fragrance with a twist of gourmand.", null, null, true, false, "Iris, Vanilla, Praline", "La Vie Est Belle", 100m },
                    { 6, "Gucci", 47, 1, "This fragrance contains notes of sparkling Mediterranean citruses that radiate from the top, while the perfume‘s feminine white floral heart is illuminated with dewy petals underscored with the lasting signature notes of the original essence. It is a fresh and bright scent that unfolds with a sheer sensuality.", null, null, true, false, "Bergamot, Casablanca Lily, Sandalwood", "Bamboo", 89m },
                    { 5, "Gucci", 50, 1, "A sumptuous white floral Gorgeous Gardenia is Gucci’s faithful creation of the perfect gardenia. The Gorgeous Gardenia woman exudes a sultry sensuality that is lushly enticing. Men are drawn to her as bees are to a blossoming flower.", null, null, true, false, "Red Berries, Pear, White Gardenia", "Flora", 85m },
                    { 4, "Dior", 50, 1, "This eau de parfum is a floral declaration of love. In the heart of the perfume, the fresh, sensual beauty of the Grasse rose combines with the boldness of Damascus rose. They are woven with Calabrian bergamot, vivid rosewood from French Guiana, and pink pepper from Réunion Island.", null, null, true, false, "Grasse Rose, Bergamot, Rosewood", "Miss Dior", 105m },
                    { 3, "Dior", 100, 1, "This fragrance opens with the exotic, floral-fruity notes of ylang ylang, while Damascus rose, and both Grasse jasmine and Indian jasmine sambac exude a seductive warmth. This scent is the ultimate expression of femininity and luxury and is floral yet mysterious, a confident signature to celebrate your feminine allure.", null, null, true, false, "Ylang Ylang, Damascus Rose, Jasmine", "J'adore", 135m },
                    { 2, "Chanel", 50, 1, "With its unprecedented use of aldehydes, which add layers of complexity, N°5 was the world’s first abstract fragrance. The Eau de Parfum draws inspiration from the Parfum with which it shares its floral aldehyde signature. This floral bouquet composed around May Rose and Jasmine features bright citrus top notes. Aldehydes create a unique presence while the smooth touch of Bourbon Vanilla leaves an incredibly sensual trail.", null, null, true, false, "Aldehydes, Jasmine, Sandalwood", "N°5", 108m },
                    { 15, "Tom Ford", 50, 1, "In this new olfactive journey, ylang-ylang is amplified while rum absolute and black plum become even more pronounced, augmenting the sensuality of TOM FORD‘s original perfume, Black Orchid Eau de Parfum.", null, null, true, false, "Black Truffle, Black Orchid, Patchouli", "Black Orchid", 134m },
                    { 31, "Giorgio Armani", 100, 2, "The fragrance for men is a scent of freedom, full of wind and water. The composition is built of a perfect harmony of sweet and salty notes of sea water and nuances of sunny warmth on your skin. Aqua di Gio is full of scorching Mediterranean sun. Bitter citrus with aromatic nuance of rosemary intertwines with salty, sea nuances and pellucid hedione. Sharp notes of spices are softened by woody base with warm, musky trail.", null, null, true, false, "Bergamot, Neroli, Green Tangerine", "Acqua di Gio", 150m }
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
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Perfumes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    ImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.ImageId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Perfumes_ImageId",
                table: "Perfumes",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Perfumes_Image_ImageId",
                table: "Perfumes",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "ImageId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
