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
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861769/ScentShop/for%20Her/chanel-chance_opctto.png",
                CategoryId = 1,
                Capacity = 50,
                Price = 108M,
                Description = "Chance is a fragrance created like a constellation, a composition like an olfactory sphere that opens up in an infinite movement. At the heart of this sphere is a sensuous balance warmed by Vanilla, with pronounced Jasmine Absolute and Iris. A mysterious alchemy, heightened by the intensity of White Musk.",
                IsPerfumeOfTheWeek = true,
                InStock = true,
                KeyNotes = "Jasmine, Pink Pepper, Vanilla, Iris"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 2,
                Name = "N°5",
                Brand = "Chanel",
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861769/ScentShop/for%20Her/chanel-n5_nogmdh.png",
                CategoryId = 1,
                Capacity = 50,
                Price = 108M,
                Description = "With its unprecedented use of aldehydes, which add layers of complexity, N°5 was the world’s first abstract fragrance. This floral bouquet composed around May Rose and Jasmine features bright citrus top notes. Aldehydes create a unique presence while the smooth touch of Bourbon Vanilla leaves an incredibly sensual trail.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Aldehydes, Jasmine, Sandalwood"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 3,
                Name = "J'adore",
                Brand = "Dior",
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1619012420/ScentShop/for%20Her/dior-jadore_eewtw5.png",
                CategoryId = 1,
                Capacity = 100,
                Price = 135M,
                Description = "This fragrance opens with the exotic, floral-fruity notes of ylang ylang, while Damascus rose, and both Grasse jasmine and Indian jasmine sambac exude a warmth. This scent is the ultimate expression of femininity and luxury and is floral yet mysterious, a confident signature to celebrate the feminine allure.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Ylang Ylang, Damascus Rose, Jasmine"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 4,
                Name = "Miss Dior",
                Brand = "Dior",
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861769/ScentShop/for%20Her/dior-missdior_fpeatw.png",
                CategoryId = 1,
                Capacity = 50,
                Price = 105M,
                Description = "In the heart of this perfume, the fresh, sensual beauty of the Grasse rose combines with the boldness of Damascus rose. They are woven with Calabrian bergamot, vivid rosewood from French Guiana, and pink pepper from Réunion Island.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Grasse Rose, Bergamot, Rosewood"
            });


            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 5,
                Name = "Flora",
                Brand = "Gucci",
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861770/ScentShop/for%20Her/gucci-flora_p6gbdl.png",
                CategoryId = 1,
                Capacity = 50,
                Price = 85M,
                Description = "Gucci Flora is the utterly feminine, deeply sensual fragrance for women inspired by Gucci's iconic Flora Pattern. The fragrance is characterized by contrasts and is for the classic, modern woman who has a youthful, feminine spirit.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Osmanthus, Peony, Rose"
            });


            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 6,
                Name = "Bamboo",
                Brand = "Gucci",
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861771/ScentShop/for%20Her/gucci-bamboo_sc4i5a.png",
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
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861773/ScentShop/for%20Her/lancome-la-vie-est-belle_ihurwf.png",
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
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861776/ScentShop/for%20Her/michael-kors-wonderlust_jvadod.png",
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
                Name = "Wood Sage",
                Brand = "Jo Malone London",
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861773/ScentShop/for%20Her/jo-malone-wood-sage-sea-salt-cologne_syarnx.png",
                CategoryId = 1,
                Capacity = 100,
                Price = 149M,
                Description = "Escape the everyday along the windswept shore where white waves break and the air is fresh with sea salt and spray. Alive with the mineral scent of the rugged cliffs mingled with the woody earthiness of sage, this fragrance is lively, spirited, and totally joyful.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Ambrette Seeds, Sea Salt, Sage"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 10,
                Name = "Rag & Bone",
                Brand = "Neroli",
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861773/ScentShop/for%20Her/rag-bone-neroli_vkneh5.png",
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
                Name = "Tobacco Vanille",
                Brand = "Tom Ford",
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861776/ScentShop/for%20Her/tom-ford-tobacco-vanille_xwtadn.png",
                CategoryId = 1,
                Capacity = 100,
                Price = 340M,
                Description = "Tom Ford reinvents classic tobacco with creamy tonka bean, vanilla, cocoa, dry fruit accords, and sweet wood sap for a modern, opulent, and heady impression of confidence.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Tobacco Leaf, Ginger, Cocoa"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 12,
                Name = "Velvet Orchid",
                Brand = "Tom Ford",
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618900528/ScentShop/for%20Her/tom-ford-velvet-orchid_my0mzu.png",
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
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618862854/ScentShop/for%20Her/calvin-klein-eternity_nx42ln.png",
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
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861773/ScentShop/for%20Her/giorgio-armani-si_mg396i.png",
                CategoryId = 1,
                Capacity = 50,
                Price = 98M,
                Description = "A sweet take on a floral scent. It opens with luminous notes of blackcurrant nectar and mandarin. Orange blossom forms the heart of the fragrance and warm vanilla anchors the irresistible blend for a lasting scent.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Citrus, Lily, Pink Sandalwood"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 15,
                Name = "Black Orchid",
                Brand = "Tom Ford",
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618900532/ScentShop/for%20Her/tom-ford-black-orchid_izuvrm.png",
                CategoryId = 1,
                Capacity = 50,
                Price = 134M,
                Description = "Black Orchid opens with aphrodisiacal black truffle and narcotic ylang ylang – touched with effervescent bergamot and bitter orange. Rum-soaked, sweet black plum surrounds the perfume‘s black orchid extract, while woody patchouli and creamy vanilla wrap the orchid in rich warmth.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Black Truffle, Black Orchid, Patchouli"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 16,
                Name = "Pour Homme",
                Brand = "Dolce & Gabbana",
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861787/ScentShop/for%20Him/dolcegabbana-por-homme_j9xht5.png",
                CategoryId = 2,
                Capacity = 125,
                Price = 99M,
                Description = "The fragrance opens up with neroli and citrusy hints of mandarin and bergamot. At the heart is lavender. Touches of tobacco and tonka bean provide structure for the last dry notes of wood.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Sandalwood, Tonka Bean, Tobacco"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 17,
                Name = "Bleu de Chanel",
                Brand = "Chanel",
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861787/ScentShop/for%20Him/chanel-bleu-de-chanel_mhu9dp.png",
                CategoryId = 2,
                Capacity = 50,
                Price = 80M,
                Description = "A woody, aromatic fragrance for the man who defies convention. A provocative blend of citrus and woods that liberates the senses. Fresh, clean, and profoundly sensual.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Citrus Accord, Labdanum, Sandalwood Cedar"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 18,
                Name = "Sauvage",
                Brand = "Dior",
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861786/ScentShop/for%20Him/dior-sauvage_jvgijx.png",
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
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861787/ScentShop/for%20Him/dior-homme_ek0ni5.png",
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
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861788/ScentShop/for%20Him/dior-eau-sauvage_txzqlm.png",
                CategoryId = 2,
                Capacity = 50,
                Price = 95M,
                Description = "Eau Sauvage is the perfume of the cult of elegance, refinement, and good humor. With the zest of citrus fruits for freshness, an invigorating bouquet of herbs, and a hint of jasmine and vetiver, it will remain a fresh, discreet classic.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Lemon, Rosemary, Petit Grain"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 21,
                Name = "Fahrenheit",
                Brand = "Dior",
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861786/ScentShop/for%20Him/dior-fahrenheit_farikl.png",
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
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861789/ScentShop/for%20Him/dolcegabbana-the-one-for-men_vcv0qq.png",
                CategoryId = 2,
                Capacity = 50,
                Price = 120M,
                Description = "Elegant and sensual, this perfume is decidedly modern and uniquely timeless all at once. The spicy fragrance features fresh top notes of grapefruit, coriander, and basil, warm heart of cardamom and ginger, and a deep masculine base of tobacco, amber, and cedarwood.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Cardamom, Cedarwood, Ginger, Tobacco"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 23,
                Name = "Terre d’Hermès",
                Brand = "Hermès",
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861789/ScentShop/for%20Him/hermes-terre-dhermes_bchhfn.png",
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
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861790/ScentShop/for%20Him/prada-amber_ypozz9.png",
                CategoryId = 2,
                Capacity = 50,
                Price = 94M,
                Description = "With its highly natural charm, Prada makes and leaves a lasting impression. A rich, complex Amber intermingles with the clean, fresh scent of barber’s soap, typical of a fougère, and continues to evolve between a duet of olfactory contrasts.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Bergamot Oil, Mandarin, Cardamom, Neroli"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 25,
                Name = "Polo Deep Blue",
                Brand = "Ralph Lauren",
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861791/ScentShop/for%20Him/ralph-lauren-polo-deep-blue_ueo6b6.png",
                CategoryId = 2,
                Capacity = 102,
                Price = 125M,
                Description = "The heart of the fragrance is aromatic cypress and clary sage which add another level of sophistication, freshness, and sensuality. The scent peaks with the salty mineral Deep Ocean Accord that energizes and activates an even deeper level of freshness.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Hawaiian Green Mango, Cypress Oil"
            });


            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 26,
                Name = "Oud Wood",
                Brand = "Tom Ford",
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861792/ScentShop/for%20Him/tom-ford-oud-wood_fhx3vn.png",
                CategoryId = 2,
                Capacity = 100,
                Price = 250M,
                Description = "A composition of exotic, smoky woods including rare oud, sandalwood, rosewood, eastern spices, and sensual amber — revealing oud‘s rich and compelling power.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Rare Oud Wood, Chinese Pepper, Vanilla"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 27,
                Name = "Noir Extreme",
                Brand = "Tom Ford",
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861791/ScentShop/for%20Him/tom-ford-noir-extreme_eohhlm.png",
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
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861793/ScentShop/for%20Him/versace-dylan-blue_canfvk.png",
                CategoryId = 2,
                Capacity = 100,
                Price = 200M,
                Description = "New and exquisite qualities of natural citrus, aquatic notes, and violet leaves combined with modern hints of fig leaf to give an incisive, Mediterranean freshness.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Fig Leaf, Bergamot, Patchouli"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 29,
                Name = "Pour Homme",
                Brand = "Versace",
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861793/ScentShop/for%20Him/versace-pour-homme_he9rl1.png",
                CategoryId = 2,
                Capacity = 100,
                Price = 200M,
                Description = "Diamante Citrus, Bitter Orange leaves and Neiroli flowers light up the fragrance with Mediterranean accents. The heart of Versace Pour Homme is characterized by the mineral-floral aroma, almost tactile, of Clary Sage and Blue Hyacinth. Amber and Musk deliver deep and sensual base notes.",
                IsPerfumeOfTheWeek = true,
                InStock = true,
                KeyNotes = "Bergamot, Neroli, Citron of Diamante"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 30,
                Name = "Voyage",
                Brand = "Nautica",
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861792/ScentShop/for%20Him/nautica-voyage_nhtnhw.png",
                CategoryId = 2,
                Capacity = 50,
                Price = 300M,
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
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861789/ScentShop/for%20Him/giorgio-armani-acqua_vgzmvl.png",
                CategoryId = 2,
                Capacity = 100,
                Price = 150M,
                Description = "A light, distinguished fragrance inspired by the fresh sea, warm sun and the richness of the earth. It opens with a splash of fresh calabrian bergamot, neroli and green tangerine. Light, aquatic nuances mix with jasmine petal, crisp rock rose, rosemary, fruity persimmon and warm Indonesian patchouli to create a masculine scent that is both fresh and sensual.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Bergamot, Neroli, Green Tangerine"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 32,
                Name = "Boss Nuit",
                Brand = "Hugo Boss",
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861771/ScentShop/for%20Her/hugo-boss-nuit_elbd6k.png",
                CategoryId = 1,
                Capacity = 100,
                Price = 190M,
                Description = "A radiant and sensual fragrance that opens with juicy white peach for a lively, fizzy character with an enticing sweetness. The modern top is complemented with an ultra-feminine heart comprising classic white florals and violet.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Peach, Jasmine, Almond"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 33,
                Name = "Amouage Gold",
                Brand = "Amouage",
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861770/ScentShop/for%20Her/amouage-gold-woman_ivbu3k.png",
                CategoryId = 1,
                Capacity = 100,
                Price = 270M,
                Description = "Amouage Gold is the first fragrance of Amouage. The top notes blend wild rose, lily-of-the-valley and silver frankincense. The heart notes include myrrh, orris and jasmine. The oriental base is of ambergris, civet, musk, cedarwood and sandalwood.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Jasmine, Orris Root, Myrrh, Musk"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 34,
                Name = "Eros",
                Brand = "Versace",
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861794/ScentShop/for%20Him/versace-eros_dgyr6q.png",
                CategoryId = 2,
                Capacity = 100,
                Price = 98M,
                Description = "Eros is a vibrant, and glowing combination of fresh mint leaves, Italian lemon zest, and green apple. An addictive sensuality accented by oriental, intriguing, and enveloping notes like tonka beans, amrboxan amber, geranium flower, and vanilla melds with a racy virility symbolized by woods — such as cedarwood from Atlas and Virginia.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Mint Leaves, Green Apple, Lemon, Orange Blossom"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 35,
                Name = "Bottled Night",
                Brand = "Hugo Boss",
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861789/ScentShop/for%20Him/hugo_boss_bottled_night_byvaj7.png",
                CategoryId = 2,
                Capacity = 100,
                Price = 155M,
                Description = "Boss Bottled Night is a fragrance which abounds in intense and masculine woody accords. It opens with lavender and birch tree aromas, while accentuating intense heart aromas of African violet, resting on a base constructed of warm, precious woody nuances of Louro Amarelo tree and sensual musk.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Afircan Violet, Amarelo Tree, Musk"
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 36,
                Name = "Armani Code",
                Brand = "Giorgio Armani",
                ImageUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618861772/ScentShop/for%20Her/giorgio-armani-armani-code_mek46g.png",
                CategoryId = 2,
                Capacity = 50,
                Price = 68M,
                Description = "The first oriental Giorgio Armani cologne for men, this aromatic fragrance blends the freshness of bergamot, the soft sensuality of olive flower, and the warmth of guaiac wood and tonka bean.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                KeyNotes = "Olive Tree Blossom, Guaiac Wood, Tonka Bean"
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
