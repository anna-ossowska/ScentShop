using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace ScentShop.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Perfume> Perfumes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seeding Categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "For Her" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "For Him" });

            // Seeding Perfumes
            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 1,
                Name = "Chance",
                Brand = "Chanel",
                CategoryId = 1,
                Capacity = 50,
                Price = 108M,
                Description = "Chance is a fragrance created like a constellation, a composition like an olfactory sphere that opens up in an infinite movement. At the heart of this sphere is a sensuous balance warmed by Vanilla, with pronounced Jasmine Absolute and Iris. A mysterious alchemy, heightened by the intensity of White Musk.",
                IsPerfumeOfTheWeek = true,
                InStock = true,
                KeyNotes = "Jasmine, Pink Pepper, Vanilla"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 2,
                Name = "N°5",
                Brand = "Chanel",
                CategoryId = 1,
                Capacity = 50,
                Price = 108M,
                Description = "With its unprecedented use of aldehydes, which add layers of complexity, N°5 was the world’s first abstract fragrance. The Eau de Parfum draws inspiration from the Parfum with which it shares its floral aldehyde signature. This floral bouquet composed around May Rose and Jasmine features bright citrus top notes. Aldehydes create a unique presence while the smooth touch of Bourbon Vanilla leaves an incredibly sensual trail.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Aldehydes, Jasmine, Sandalwood"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 3,
                Name = "J'adore",
                Brand = "Dior",
                CategoryId = 1,
                Capacity = 100,
                Price = 135M,
                Description = "This fragrance opens with the exotic, floral-fruity notes of ylang ylang, while Damascus rose, and both Grasse jasmine and Indian jasmine sambac exude a seductive warmth. This scent is the ultimate expression of femininity and luxury and is floral yet mysterious, a confident signature to celebrate your feminine allure.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Ylang Ylang, Damascus Rose, Jasmine"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 4,
                Name = "Miss Dior",
                Brand = "Dior",
                CategoryId = 1,
                Capacity = 50,
                Price = 105M,
                Description = "This eau de parfum is a floral declaration of love. In the heart of the perfume, the fresh, sensual beauty of the Grasse rose combines with the boldness of Damascus rose. They are woven with Calabrian bergamot, vivid rosewood from French Guiana, and pink pepper from Réunion Island.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Grasse Rose, Bergamot, Rosewood"
            });


            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 5,
                Name = "Flora",
                Brand = "Gucci",
                CategoryId = 1,
                Capacity = 50,
                Price = 85M,
                Description = "A sumptuous white floral Gorgeous Gardenia is Gucci’s faithful creation of the perfect gardenia. The Gorgeous Gardenia woman exudes a sultry sensuality that is lushly enticing. Men are drawn to her as bees are to a blossoming flower.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Red Berries, Pear, White Gardenia"
            });


            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 6,
                Name = "Bamboo",
                Brand = "Gucci",
                CategoryId = 1,
                Capacity = 47,
                Price = 89M,
                Description = "This fragrance contains notes of sparkling Mediterranean citruses that radiate from the top, while the perfume‘s feminine white floral heart is illuminated with dewy petals underscored with the lasting signature notes of the original essence. It is a fresh and bright scent that unfolds with a sheer sensuality.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Bergamot, Casablanca Lily, Sandalwood"
            });


            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 7,
                Name = "La Vie Est Belle",
                Brand = "Lancôme",
                CategoryId = 1,
                Capacity = 50,
                Price = 100M,
                Description = "Made with the most precious natural ingredients, expressing notes of iris, patchouli, praline, and vanilla, this feminine, complex scent is the modern interpretation of an oriental fragrance with a twist of gourmand.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Iris, Vanilla, Praline"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 8,
                Name = "Wonderlust",
                Brand = "Michael Kors",
                CategoryId = 1,
                Capacity = 100,
                Price = 120M,
                Description = "Michael Kors Wonderlust is an oriental gourmand fragrance that captures an infinite desire for discovery. A blend of luxurious blossoms mingled with delectably spiced notes charts a course to far-off destinations, instantly transporting you with each ingredient.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Almond Cream, Dianthus"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 9,
                Name = "Wood Sage & Sea Salt",
                Brand = "Jo Malone London",
                CategoryId = 1,
                Capacity = 100,
                Price = 149M,
                Description = "Built on a platform of rich amber, this contrasting fragrance is subtly woven with the clean smell of barber's soap. With top notes that evoke a natural, classic cologne - a rich blend of fresh mandarin, bergamot, and cardamom that melds into the sensual mid notes of patchouli, tonka bean, and vanilla; and finishes with the clean, leathery notes of vetiver, neroli, orange blossom, saffron, and suede, Amber Pour Homme is a fragrance for the self-assured man.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Almond Cream, Dianthus"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 10,
                Name = "Rag & Bone",
                Brand = "Neroli",
                CategoryId = 1,
                Capacity = 50,
                Price = 150M,
                Description = "This long-lasting eau de parfum centers around timeless orange flower and neroli mixed with a hint of pink pepper. Playful and feminine tones inspired by the flowers of Grasse are complemented by an airy and soft layer of honey and musk, which wraps you with a second-skin effect.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Neroli, Orange Flower, Pink Pepper"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 11,
                Name = "Romance",
                Brand = "Ralph Lauren",
                CategoryId = 1,
                Capacity = 50,
                Price = 178M,
                Description = "Sparkling notes of pink pepper and mandarin orange effervesce into a fantasy of rose and jasmine, finding a fairy tale ending in the sensual embrace of woody musk and patchouli.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Lily, White Floral"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 12,
                Name = "Velvet Orchid",
                Brand = "Tom Ford",
                CategoryId = 1,
                Capacity = 50,
                Price = 134M,
                Description = "This perfume is lavished with shimmering freshness, honey, rum, and a dramatic floral veil, and it lives in Black Orchid’s world of glamorous mystique, while exuding its own ultra-feminine essence.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Orange Blossom, Hyacinth, Jonquil"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 13,
                Name = "Eternity",
                Brand = "Calvin Klein",
                CategoryId = 1,
                Capacity = 50,
                Price = 155M,
                Description = "The composition opens with fresh citrus and green notes, that is followed by the note of violet and lily-of-the-valley. The note of carnation with its spiciness gives the floral heart slightly peppery accord. The final notes are gentle with powdery heliotrope, pink sandalwood and transparent musky notes.",
                IsPerfumeOfTheWeek = true,
                InStock = true,
                KeyNotes = "Citrus, Lily, Pink Sandalwood"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 14,
                Name = "Si",
                Brand = "Giorgio Armani",
                CategoryId = 1,
                Capacity = 50,
                Price = 98M,
                Description = "A sweet take on a floral fragrance, this women's perfume opens with luminous notes of blackcurrant nectar and mandarin. Orange blossom forms the heart of the fragrance and warm vanilla anchors the irresistible blend for a lasting scent.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Citrus, Lily, Pink Sandalwood"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 15,
                Name = "Black Orchid",
                Brand = "Tom Ford",
                CategoryId = 1,
                Capacity = 50,
                Price = 134M,
                Description = "In this new olfactive journey, ylang-ylang is amplified while rum absolute and black plum become even more pronounced, augmenting the sensuality of TOM FORD‘s original perfume, Black Orchid Eau de Parfum.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Black Truffle, Black Orchid, Patchouli"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 16,
                Name = "Pour Homme",
                Brand = "Dolce & Gabbana",
                CategoryId = 2,
                Capacity = 125,
                Price = 99M,
                Description = "The fragrance opens up with neroli and citrusy hints of mandarin and bergamot.At the heart is lavender.Touches of tobacco and tonka bean provide structure for the last dry notes of wood.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Sandalwood, Tonka Bean, Tobacco"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 17,
                Name = "Bleu de Chanel",
                Brand = "Chanel",
                CategoryId = 2,
                Capacity = 50,
                Price = 80M,
                Description = "A woody, aromatic fragrance for the man who defies convention; a provocative blend of citrus and woods that liberates the senses. Fresh, clean, and profoundly sensual.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Citrus Accord, Labdanum, Sandalwood Cedar"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 18,
                Name = "Sauvage",
                Brand = "Dior",
                CategoryId = 2,
                Capacity = 60,
                Price = 90M,
                Description = "A radically fresh composition, Sauvage is both raw and noble. Radiant top notes burst with the juicy freshness of Calabrian bergamot, while amberwood unleashes a powerfully woody trail. Sauvage is a fragrance inspired by wide-open spaces under a blue sky that dominates a white-hot desert landscape.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Bergamot, Pepper, Amberwood"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 19,
                Name = "Homme",
                Brand = "Dior",
                CategoryId = 2,
                Capacity = 50,
                Price = 120M,
                Description = "The Dior Homme Eau de Toilette is an alluring combination of power and freshness. It is intensely woody and masculine, taking hold and leaving a lasting impression.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Cedar, Haitian Vetiver, Patchouli Heart"
            });


            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 20,
                Name = "Eau Sauvage",
                Brand = "Dior",
                CategoryId = 2,
                Capacity = 50,
                Price = 95M,
                Description = "Lucid and willful, Eau Sauvage is the perfume of the cult of elegance, refinement, and good humor. With the zest of citrus fruits for freshness, an invigorating bouquet of herbs, a hint of jasmine and vetiver for the sensual touch, and oakmoss to conquer and seduce, it will remain a fresh, discreet classic.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Lemon, Rosemary, Petit Grain"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 21,
                Name = "Fahrenheit",
                Brand = "Dior",
                CategoryId = 2,
                Capacity = 50,
                Price = 77M,
                Description = "A resolutely contemporary fragrance characterized by a meeting of extremes. Fresh, elegant notes blend in perfect harmony with bolder, more virile overtones to create a scent that is warm, subtle, and distinguished.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Bergamot, Hawthorne, Honeysuckle"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 22,
                Name = "The One For Men",
                Brand = "Dolce & Gabbana",
                CategoryId = 2,
                Capacity = 50,
                Price = 120M,
                Description = "Elegant and sensual, this perfume is decidedly modern and uniquely timeless all at once. The spicy fragrance features fresh top notes of grapefruit, coriander, and basil; a warm heart of cardamom and ginger; and a deep masculine base of tobacco, amber, and cedarwood.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Cardamom, Cedarwood, Ginger, Tobacco"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 23,
                Name = "Terre d’Hermès",
                Brand = "Hermès",
                CategoryId = 2,
                Capacity = 55,
                Price = 126M,
                Description = "Terre d’Hermès is a symbolic narrative exploring raw material and its metamorphosis. A novel that expresses the alchemical power of the elements. An eau between earth and sky. A journey imbued with strength and poetry. Woody, vegetal, mineral.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Grapefruit Accord, Black Peppers, Flint"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 24,
                Name = "Amber",
                Brand = "Prada",
                CategoryId = 2,
                Capacity = 50,
                Price = 94M,
                Description = "The perfumer Daniela Roche-Andrier created the composition in four basic accords : Amber – the main accord, rich and complex oriental base which includes amber, vanilla, labdanum, Tonka and patchouli; Fougere – or the aromatic accord with a remarkable soapy note, includes notes of pelargonium, vetiver, orange blossom and myrrh at the heart; Cologne – the refreshing citrusy top of bergamot, mandarin, neroli and cardamom; Leather – leather note is present at the base of the composition (leather, saffron and sandalwood).",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Bergamot Oil, Mandarin, Cardamom"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 25,
                Name = "Polo Deep Blue",
                Brand = "Ralph Lauren",
                CategoryId = 2,
                Capacity = 102,
                Price = 125M,
                Description = "The heart of the fragrance is aromatic cypress and clary sage which add another level of sophistication, freshness, and sensuality.  The scent peaks with the salty mineral Deep Ocean Accord that energizes and activates an even deeper level of freshness.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Hawaiian Green Mango, Cypress Oil"
            });


            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 26,
                Name = "Oud Wood",
                Brand = "Tom Ford",
                CategoryId = 2,
                Capacity = 100,
                Price = 250M,
                Description = "A composition of exotic, smoky woods including rare oud, sandalwood, rosewood, eastern spices, and sensual amber—revealing oud‘s rich and compelling power.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Rare Oud Wood, Chinese Pepper, Vanilla"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 27,
                Name = "Noir Extreme",
                Brand = "Tom Ford",
                CategoryId = 2,
                Capacity = 50,
                Price = 180M,
                Description = "This perfume's rich blend of spicy heat and glowing citrus gives way to Indian kulfi, wrapped in rose absolute, jasmine accord, and orange flower. It also contains notes of extravagant amber with sandalwood and vanilla ember for a creamy, woody finish.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Cardamom, Orange Flower, Sandalwood"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 28,
                Name = "Dylan Blue",
                Brand = "Versace",
                CategoryId = 2,
                Capacity = 100,
                Price = 200M,
                Description = "New and exquisite qualities of natural citrus, aquatic notes, and violet leaves combine with modern hints of fig leaf to give an incisive, Mediterranean freshness.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Aquatic Notes, Bergamot, Patchouli"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 29,
                Name = "Pour Homme",
                Brand = "Versace",
                CategoryId = 2,
                Capacity = 100,
                Price = 200M,
                Description = "The new fragrance for men, Versace Pour Homme, blends essential ingredients of Mediterranean origin to hit aromatic notes.",
                IsPerfumeOfTheWeek = true,
                InStock = true,
                KeyNotes = "Bergamot, Neroli, Citron of Diamante"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 30,
                Name = "Voyage",
                Brand = "Nautica",
                CategoryId = 2,
                Capacity = 50,
                Price = 700M,
                Description = "The composition opens with cold, green notes of leaves and apple. There is a tender dewy mimose in the heart, which is blended with watery note of lotus and an interesting accord of linen sail of a yacht. The composition is laid on a woody base, combined of cedar, moss, musk and amber.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Apple, Lotus, Cedar"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 31,
                Name = "Acqua di Gio",
                Brand = "Giorgio Armani",
                CategoryId = 2,
                Capacity = 100,
                Price = 150M,
                Description = "The fragrance for men is a scent of freedom, full of wind and water. The composition is built of a perfect harmony of sweet and salty notes of sea water and nuances of sunny warmth on your skin. Aqua di Gio is full of scorching Mediterranean sun. Bitter citrus with aromatic nuance of rosemary intertwines with salty, sea nuances and pellucid hedione. Sharp notes of spices are softened by woody base with warm, musky trail.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Bergamot, Neroli, Green Tangerine"
            });
        }

        public static byte[] ReadFile(string sPath)
        {
            //Initialize byte array with a null value initially.
            byte[] data = null;

            //Use FileInfo object to get file size.
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            //Open FileStream to read file
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            //Use BinaryReader to read file stream into byte array.
            BinaryReader br = new BinaryReader(fStream);

            //When you use BinaryReader, you need to supply number of bytes 
            //to read from file.
            //In this case we want to read entire file. 
            //So supplying total number of bytes.
            data = br.ReadBytes((int)numBytes);

            return data;
        }
    }
}
