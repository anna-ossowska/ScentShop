using Microsoft.EntityFrameworkCore.Migrations;

namespace ScentShop.Migrations
{
    public partial class UpdatingSeedFile10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 1,
                column: "KeyNotes",
                value: "Jasmine, Pink Pepper, Vanilla, Iris");

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "With its unprecedented use of aldehydes, which add layers of complexity, N°5 was the world’s first abstract fragrance. This floral bouquet composed around May Rose and Jasmine features bright citrus top notes. Aldehydes create a unique presence while the smooth touch of Bourbon Vanilla leaves an incredibly sensual trail.");

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "This fragrance opens with the exotic, floral-fruity notes of ylang ylang, while Damascus rose, and both Grasse jasmine and Indian jasmine sambac exude a warmth. This scent is the ultimate expression of femininity and luxury and is floral yet mysterious, a confident signature to celebrate the feminine allure.");

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "In the heart of this perfume, the fresh, sensual beauty of the Grasse rose combines with the boldness of Damascus rose. They are woven with Calabrian bergamot, vivid rosewood from French Guiana, and pink pepper from Réunion Island.");

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "KeyNotes" },
                values: new object[] { "Gucci Flora is the utterly feminine, deeply sensual fragrance for women inspired by Gucci's iconic Flora Pattern. The fragrance is characterized by contrasts and is for the classic, modern woman who has a youthful, feminine spirit.", "Osmanthus, Peony, Rose" });

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "KeyNotes" },
                values: new object[] { "Escape the everyday along the windswept shore where white waves break and the air is fresh with sea salt and spray. Alive with the mineral scent of the rugged cliffs mingled with the woody earthiness of sage, this fragrance is lively, spirited, and totally joyful.", "Ambrette Seeds, Sea Salt, Sage" });

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "A sweet take on a floral scent. It opens with luminous notes of blackcurrant nectar and mandarin. Orange blossom forms the heart of the fragrance and warm vanilla anchors the irresistible blend for a lasting scent.");

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "Black Orchid opens with aphrodisiacal black truffle and narcotic ylang ylang – touched with effervescent bergamot and bitter orange. Rum-soaked, sweet black plum surrounds the perfume‘s black orchid extract, while woody patchouli and creamy vanilla wrap the orchid in rich warmth.");

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "The fragrance opens up with neroli and citrusy hints of mandarin and bergamot. At the heart is lavender. Touches of tobacco and tonka bean provide structure for the last dry notes of wood.");

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 17,
                column: "Description",
                value: "A woody, aromatic fragrance for the man who defies convention. A provocative blend of citrus and woods that liberates the senses. Fresh, clean, and profoundly sensual.");

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 20,
                column: "Description",
                value: "Eau Sauvage is the perfume of the cult of elegance, refinement, and good humor. With the zest of citrus fruits for freshness, an invigorating bouquet of herbs, and a hint of jasmine and vetiver, it will remain a fresh, discreet classic.");

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 22,
                column: "Description",
                value: "Elegant and sensual, this perfume is decidedly modern and uniquely timeless all at once. The spicy fragrance features fresh top notes of grapefruit, coriander, and basil, warm heart of cardamom and ginger, and a deep masculine base of tobacco, amber, and cedarwood.");

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "KeyNotes" },
                values: new object[] { "With its highly natural charm, Prada makes and leaves a lasting impression. A rich, complex Amber intermingles with the clean, fresh scent of barber’s soap, typical of a fougère, and continues to evolve between a duet of olfactory contrasts.", "Bergamot Oil, Mandarin, Cardamom, Neroli" });

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 25,
                column: "Description",
                value: "The heart of the fragrance is aromatic cypress and clary sage which add another level of sophistication, freshness, and sensuality. The scent peaks with the salty mineral Deep Ocean Accord that energizes and activates an even deeper level of freshness.");

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 26,
                column: "Description",
                value: "A composition of exotic, smoky woods including rare oud, sandalwood, rosewood, eastern spices, and sensual amber — revealing oud‘s rich and compelling power.");

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "KeyNotes" },
                values: new object[] { "New and exquisite qualities of natural citrus, aquatic notes, and violet leaves combined with modern hints of fig leaf to give an incisive, Mediterranean freshness.", "Fig Leaf, Bergamot, Patchouli" });

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 29,
                column: "Description",
                value: "Diamante Citrus, Bitter Orange leaves and Neiroli flowers light up the fragrance with Mediterranean accents. The heart of Versace Pour Homme is characterized by the mineral-floral aroma, almost tactile, of Clary Sage and Blue Hyacinth. Amber and Musk deliver deep and sensual base notes.");

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Description", "KeyNotes" },
                values: new object[] { "Eros is a vibrant, and glowing combination of fresh mint leaves, Italian lemon zest, and green apple. An addictive sensuality accented by oriental, intriguing, and enveloping notes like tonka beans, amrboxan amber, geranium flower, and vanilla melds with a racy virility symbolized by woods — such as cedarwood from Atlas and Virginia.", "Mint Leaves, Green Apple, Lemon, Orange Blossom" });

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 35,
                column: "Description",
                value: "Boss Bottled Night is a fragrance which abounds in intense and masculine woody accords. It opens with lavender and birch tree aromas, while accentuating intense heart aromas of African violet, resting on a base constructed of warm, precious woody nuances of Louro Amarelo tree and sensual musk.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 1,
                column: "KeyNotes",
                value: "Jasmine, Pink Pepper, Vanilla");

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "With its unprecedented use of aldehydes, which add layers of complexity, N°5 was the world’s first abstract fragrance. The Eau de Parfum draws inspiration from the Parfum with which it shares its floral aldehyde signature. This floral bouquet composed around May Rose and Jasmine features bright citrus top notes. Aldehydes create a unique presence while the smooth touch of Bourbon Vanilla leaves an incredibly sensual trail.");

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "This fragrance opens with the exotic, floral-fruity notes of ylang ylang, while Damascus rose, and both Grasse jasmine and Indian jasmine sambac exude a seductive warmth. This scent is the ultimate expression of femininity and luxury and is floral yet mysterious, a confident signature to celebrate your feminine allure.");

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "This eau de parfum is a floral declaration of love. In the heart of the perfume, the fresh, sensual beauty of the Grasse rose combines with the boldness of Damascus rose. They are woven with Calabrian bergamot, vivid rosewood from French Guiana, and pink pepper from Réunion Island.");

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "KeyNotes" },
                values: new object[] { "A sumptuous white floral Gorgeous Gardenia is Gucci’s faithful creation of the perfect gardenia. The Gorgeous Gardenia woman exudes a sultry sensuality that is lushly enticing. Men are drawn to her as bees are to a blossoming flower.", "Red Berries, Pear, White Gardenia" });

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "KeyNotes" },
                values: new object[] { "Built on a platform of rich amber, this contrasting fragrance is subtly woven with the clean smell of barber's soap. With top notes that evoke a natural, classic cologne - a rich blend of fresh mandarin, bergamot, and cardamom that melds into the sensual mid notes of patchouli, tonka bean, and vanilla; and finishes with the clean, leathery notes of vetiver, neroli, orange blossom, saffron, and suede, Amber Pour Homme is a fragrance for the self-assured man.", "Almond Cream, Dianthus" });

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "A sweet take on a floral fragrance, this women's perfume opens with luminous notes of blackcurrant nectar and mandarin. Orange blossom forms the heart of the fragrance and warm vanilla anchors the irresistible blend for a lasting scent.");

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "In this new olfactive journey, ylang-ylang is amplified while rum absolute and black plum become even more pronounced, augmenting the sensuality of TOM FORD‘s original perfume, Black Orchid Eau de Parfum.");

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "The fragrance opens up with neroli and citrusy hints of mandarin and bergamot.At the heart is lavender.Touches of tobacco and tonka bean provide structure for the last dry notes of wood.");

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 17,
                column: "Description",
                value: "A woody, aromatic fragrance for the man who defies convention; a provocative blend of citrus and woods that liberates the senses. Fresh, clean, and profoundly sensual.");

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 20,
                column: "Description",
                value: "Lucid and willful, Eau Sauvage is the perfume of the cult of elegance, refinement, and good humor. With the zest of citrus fruits for freshness, an invigorating bouquet of herbs, a hint of jasmine and vetiver for the sensual touch, and oakmoss to conquer and seduce, it will remain a fresh, discreet classic.");

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 22,
                column: "Description",
                value: "Elegant and sensual, this perfume is decidedly modern and uniquely timeless all at once. The spicy fragrance features fresh top notes of grapefruit, coriander, and basil; a warm heart of cardamom and ginger; and a deep masculine base of tobacco, amber, and cedarwood.");

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "KeyNotes" },
                values: new object[] { "The perfumer Daniela Roche-Andrier created the composition in four basic accords : Amber – the main accord, rich and complex oriental base which includes amber, vanilla, labdanum, Tonka and patchouli; Fougere – or the aromatic accord with a remarkable soapy note, includes notes of pelargonium, vetiver, orange blossom and myrrh at the heart; Cologne – the refreshing citrusy top of bergamot, mandarin, neroli and cardamom; Leather – leather note is present at the base of the composition (leather, saffron and sandalwood).", "Bergamot Oil, Mandarin, Cardamom" });

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 25,
                column: "Description",
                value: "The heart of the fragrance is aromatic cypress and clary sage which add another level of sophistication, freshness, and sensuality.  The scent peaks with the salty mineral Deep Ocean Accord that energizes and activates an even deeper level of freshness.");

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 26,
                column: "Description",
                value: "A composition of exotic, smoky woods including rare oud, sandalwood, rosewood, eastern spices, and sensual amber—revealing oud‘s rich and compelling power.");

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "KeyNotes" },
                values: new object[] { "New and exquisite qualities of natural citrus, aquatic notes, and violet leaves combine with modern hints of fig leaf to give an incisive, Mediterranean freshness.", "Aquatic Notes, Bergamot, Patchouli" });

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 29,
                column: "Description",
                value: "The new fragrance for men, Versace Pour Homme, blends essential ingredients of Mediterranean origin to hit aromatic notes.");

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Description", "KeyNotes" },
                values: new object[] { "Eros is a vibrant, and glowing combination of fresh mint leaves, Italian lemon zest, and green apple. An addictive sensuality accented by oriental, intriguing, and enveloping notes like tonka beans, amrboxan amber, geranium flower, and vanilla melds with a racy virility symbolized by woods—such as cedarwood from Atlas and Virginia.", "Mint Leaves, Orange Blossom, Vanilla" });

            migrationBuilder.UpdateData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: 35,
                column: "Description",
                value: "Boss Bottled Night is an aromatic fragrance which abounds in intense and masculine woody accords. It opens with lavender and birch tree aromas, while accentuating intense heart aromas of African violet, resting on a base constructed of warm, precious woody nuances of Louro Amarelo tree and sensual musk.");
        }
    }
}
