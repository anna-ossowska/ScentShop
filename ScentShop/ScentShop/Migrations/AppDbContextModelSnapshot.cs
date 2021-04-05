﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ScentShop.Models;

namespace ScentShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ScentShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "For Her"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "For Him"
                        });
                });

            modelBuilder.Entity("ScentShop.Models.Perfume", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDiscounted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPerfumeOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Perfumes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Versace",
                            Capacity = 198,
                            CategoryId = 1,
                            Description = "Inspired by a mixture of Donatella Versace's favorite floral fragrances, Bright Crystal is a fresh, sensual blend of refreshing chilled yuzu and pomegranate mingled with soothing blossoms of peony, magnolia, and lotus flower, warmed with notes of musk and amber.",
                            InStock = true,
                            IsDiscounted = false,
                            IsPerfumeOfTheWeek = true,
                            Name = "Bright Crystal",
                            Price = 140m
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Chanel",
                            Capacity = 50,
                            CategoryId = 1,
                            Description = "With its unprecedented use of aldehydes, which add layers of complexity, N°5 was the world’s first abstract fragrance. The Eau de Parfum draws inspiration from the Parfum with which it shares its floral aldehyde signature. This floral bouquet composed around May Rose and Jasmine features bright citrus top notes. Aldehydes create a unique presence while the smooth touch of Bourbon Vanilla leaves an incredibly sensual trail.",
                            InStock = true,
                            IsDiscounted = false,
                            IsPerfumeOfTheWeek = false,
                            Name = "N°5",
                            Price = 108m
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Dior",
                            Capacity = 100,
                            CategoryId = 1,
                            Description = "This fragrance opens with the exotic, floral-fruity notes of ylang ylang, while Damascus rose, and both Grasse jasmine and Indian jasmine sambac exude a seductive warmth. This scent is the ultimate expression of femininity and luxury and is floral yet mysterious, a confident signature to celebrate your feminine allure.",
                            InStock = true,
                            IsDiscounted = false,
                            IsPerfumeOfTheWeek = true,
                            Name = "J'adore",
                            Price = 135m
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Chanel",
                            Capacity = 50,
                            CategoryId = 2,
                            Description = "BLEU DE CHANEL unites the invigorating zest of Grapefruit and the power of an aromatic accord with the woody whisper of Dry Cedar. New Caledonian Sandalwood lends it a warm and sensual trail. A meeting of strength and elegance.",
                            InStock = true,
                            IsDiscounted = false,
                            IsPerfumeOfTheWeek = true,
                            Name = "Bleu de Chanel",
                            Price = 80m
                        },
                        new
                        {
                            Id = 5,
                            Brand = "Tom Ford",
                            Capacity = 50,
                            CategoryId = 2,
                            Description = "A composition of exotic, smoky woods including rare oud, sandalwood, rosewood, eastern spices, and sensual amber—revealing oud‘s rich and compelling power.",
                            InStock = true,
                            IsDiscounted = false,
                            IsPerfumeOfTheWeek = false,
                            Name = "Oud Wood",
                            Price = 250m
                        });
                });

            modelBuilder.Entity("ScentShop.Models.Perfume", b =>
                {
                    b.HasOne("ScentShop.Models.Category", "Category")
                        .WithMany("Perfumes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ScentShop.Models.Category", b =>
                {
                    b.Navigation("Perfumes");
                });
#pragma warning restore 612, 618
        }
    }
}
