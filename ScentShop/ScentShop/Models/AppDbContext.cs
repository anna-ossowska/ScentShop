using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                Name = "Bright Crystal",
                Brand = "Versace",
                Capacity = 198,
                Price = 140M,
                ImageThumbnailUrl = "https://res.cloudinary.com/do0ohxztp/image/upload/v1618217350/ScentShop/card-3_chnyqj.png",
                Description = "Inspired by a mixture of Donatella Versace's favorite floral fragrances, Bright Crystal is a fresh, sensual blend of refreshing chilled yuzu and pomegranate mingled with soothing blossoms of peony, magnolia, and lotus flower, warmed with notes of musk and amber.",
                IsPerfumeOfTheWeek = true,
                InStock = true,
                CategoryId = 1
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 2,
                Name = "N°5",
                Brand = "Chanel",
                Capacity = 50,
                Price = 108M,
                Description = "With its unprecedented use of aldehydes, which add layers of complexity, N°5 was the world’s first abstract fragrance. The Eau de Parfum draws inspiration from the Parfum with which it shares its floral aldehyde signature. This floral bouquet composed around May Rose and Jasmine features bright citrus top notes. Aldehydes create a unique presence while the smooth touch of Bourbon Vanilla leaves an incredibly sensual trail.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                CategoryId = 1
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 3,
                Name = "J'adore",
                Brand = "Dior",
                Capacity = 100,
                Price = 135M,
                Description = "This fragrance opens with the exotic, floral-fruity notes of ylang ylang, while Damascus rose, and both Grasse jasmine and Indian jasmine sambac exude a seductive warmth. This scent is the ultimate expression of femininity and luxury and is floral yet mysterious, a confident signature to celebrate your feminine allure.",
                IsPerfumeOfTheWeek = true,
                InStock = true,
                CategoryId = 1
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 4,
                Name = "Bleu de Chanel",
                Brand = "Chanel",
                Capacity = 50,
                Price = 80M,
                Description = "BLEU DE CHANEL unites the invigorating zest of Grapefruit and the power of an aromatic accord with the woody whisper of Dry Cedar. New Caledonian Sandalwood lends it a warm and sensual trail. A meeting of strength and elegance.",
                IsPerfumeOfTheWeek = true,
                InStock = true,
                CategoryId = 2
            });

            modelBuilder.Entity<Perfume>().HasData(new Perfume
            {
                Id = 5,
                Name = "Oud Wood",
                Brand = "Tom Ford",
                Capacity = 50,
                Price = 250M,
                Description = "A composition of exotic, smoky woods including rare oud, sandalwood, rosewood, eastern spices, and sensual amber—revealing oud‘s rich and compelling power.",
                IsPerfumeOfTheWeek = false,
                InStock = true,
                CategoryId = 2
            });
        }
    }
}
