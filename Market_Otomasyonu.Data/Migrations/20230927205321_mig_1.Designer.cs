﻿// <auto-generated />
using System;
using Market_Otomasyonu.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Market_Otomasyonu.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230927205321_mig_1")]
    partial class mig_1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Market_Otomasyonu.Entity.Entities.AppRole", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleID"), 1L, 1);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleID");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleID = 1,
                            RoleName = "Admin"
                        },
                        new
                        {
                            RoleID = 2,
                            RoleName = "Worker"
                        });
                });

            modelBuilder.Entity("Market_Otomasyonu.Entity.Entities.AppUser", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"), 1L, 1);

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IsWorking")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WorkUnit")
                        .HasColumnType("int");

                    b.HasKey("UserID");

                    b.HasIndex("RoleID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            ConfirmPassword = "937D4852C65D801C404334353B1EF43D9A7C4EC43C0F4DF8F3BE33AE2A9DB5A7",
                            CreatedDate = new DateTime(2023, 9, 27, 23, 53, 20, 830, DateTimeKind.Local).AddTicks(9592),
                            Gender = "Erkek",
                            IsWorking = "Çalışıyor",
                            Name = "Enes",
                            Password = "937D4852C65D801C404334353B1EF43D9A7C4EC43C0F4DF8F3BE33AE2A9DB5A7",
                            RoleID = 1,
                            Surname = "Fevzi",
                            Username = "enesfevzi"
                        },
                        new
                        {
                            UserID = 2,
                            ConfirmPassword = "937D4852C65D801C404334353B1EF43D9A7C4EC43C0F4DF8F3BE33AE2A9DB5A7",
                            CreatedDate = new DateTime(2023, 9, 27, 23, 53, 20, 830, DateTimeKind.Local).AddTicks(9606),
                            Gender = "Erkek",
                            IsWorking = "Çalışıyor",
                            Name = "İhsan",
                            Password = "937D4852C65D801C404334353B1EF43D9A7C4EC43C0F4DF8F3BE33AE2A9DB5A7",
                            RoleID = 2,
                            Surname = "Tapan",
                            Username = "ihsantapan"
                        },
                        new
                        {
                            UserID = 3,
                            ConfirmPassword = "937D4852C65D801C404334353B1EF43D9A7C4EC43C0F4DF8F3BE33AE2A9DB5A7",
                            CreatedDate = new DateTime(2023, 9, 27, 23, 53, 20, 830, DateTimeKind.Local).AddTicks(9609),
                            Gender = "Erkek",
                            IsWorking = "Çalışıyor",
                            Name = "Ebru",
                            Password = "937D4852C65D801C404334353B1EF43D9A7C4EC43C0F4DF8F3BE33AE2A9DB5A7",
                            RoleID = 2,
                            Surname = "Çevik",
                            Username = "ebrucevik"
                        });
                });

            modelBuilder.Entity("Market_Otomasyonu.Entity.Entities.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            Name = "Su & İçecek"
                        },
                        new
                        {
                            CategoryID = 2,
                            Name = "Meyve & Sebze"
                        },
                        new
                        {
                            CategoryID = 3,
                            Name = "Fırın Ürünleri"
                        },
                        new
                        {
                            CategoryID = 4,
                            Name = "Temel Gıda"
                        },
                        new
                        {
                            CategoryID = 5,
                            Name = "Süt Ürünleri"
                        },
                        new
                        {
                            CategoryID = 6,
                            Name = "Kahvaltılık"
                        },
                        new
                        {
                            CategoryID = 7,
                            Name = "Atıştırmalık"
                        },
                        new
                        {
                            CategoryID = 8,
                            Name = "Kişisel Bakım"
                        },
                        new
                        {
                            CategoryID = 9,
                            Name = "Temizlik Malzemeleri"
                        });
                });

            modelBuilder.Entity("Market_Otomasyonu.Entity.Entities.Market", b =>
                {
                    b.Property<int>("MarketID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MarketID"), 1L, 1);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EstablishmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("MarketID");

                    b.HasIndex("UserID");

                    b.ToTable("Markets");
                });

            modelBuilder.Entity("Market_Otomasyonu.Entity.Entities.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"), 1L, 1);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsContinued")
                        .HasColumnType("bit");

                    b.Property<int?>("MarketID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PurchasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<decimal>("TaxRatio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Unit")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("MarketID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            Brand = "Erikli",
                            CategoryID = 1,
                            ExpirationDate = new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsContinued = true,
                            Name = "Su (500mL)",
                            PurchasePrice = 6.80m,
                            Quantity = 1m,
                            SalePrice = 5m,
                            Stock = 100,
                            TaxRatio = 0.01m,
                            Unit = 4,
                            UnitPrice = 0m
                        },
                        new
                        {
                            ProductID = 2,
                            Brand = "Erikli",
                            CategoryID = 1,
                            ExpirationDate = new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsContinued = true,
                            Name = "Su (1,5L)",
                            PurchasePrice = 71.8m,
                            Quantity = 6m,
                            SalePrice = 52m,
                            Stock = 100,
                            TaxRatio = 0.01m,
                            Unit = 4,
                            UnitPrice = 0m
                        },
                        new
                        {
                            ProductID = 3,
                            Brand = "Coca-Cola",
                            CategoryID = 1,
                            ExpirationDate = new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsContinued = true,
                            Name = "Kola (1L)",
                            PurchasePrice = 28.99m,
                            Quantity = 1m,
                            SalePrice = 18.7m,
                            Stock = 100,
                            TaxRatio = 0.01m,
                            Unit = 4,
                            UnitPrice = 0m
                        },
                        new
                        {
                            ProductID = 4,
                            Brand = "",
                            CategoryID = 2,
                            ExpirationDate = new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsContinued = true,
                            Name = "İthal Muz",
                            PurchasePrice = 52.99m,
                            Quantity = 1m,
                            SalePrice = 41.49m,
                            Stock = 100,
                            TaxRatio = 0.01m,
                            Unit = 1,
                            UnitPrice = 0m
                        },
                        new
                        {
                            ProductID = 5,
                            Brand = "",
                            CategoryID = 2,
                            ExpirationDate = new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsContinued = true,
                            Name = "Salkım Domates",
                            PurchasePrice = 32.99m,
                            Quantity = 1m,
                            SalePrice = 27.79m,
                            Stock = 100,
                            TaxRatio = 0.01m,
                            Unit = 1,
                            UnitPrice = 0m
                        },
                        new
                        {
                            ProductID = 6,
                            Brand = "",
                            CategoryID = 2,
                            ExpirationDate = new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsContinued = true,
                            Name = "Kuru Soğan",
                            PurchasePrice = 26.49m,
                            Quantity = 1m,
                            SalePrice = 24.00m,
                            Stock = 100,
                            TaxRatio = 0.01m,
                            Unit = 1,
                            UnitPrice = 0m
                        },
                        new
                        {
                            ProductID = 7,
                            Brand = "",
                            CategoryID = 3,
                            ExpirationDate = new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsContinued = true,
                            Name = "Ekmek",
                            PurchasePrice = 6.50m,
                            Quantity = 1m,
                            SalePrice = 6.0m,
                            Stock = 100,
                            TaxRatio = 0.01m,
                            Unit = 4,
                            UnitPrice = 0m
                        },
                        new
                        {
                            ProductID = 8,
                            Brand = "",
                            CategoryID = 3,
                            ExpirationDate = new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsContinued = true,
                            Name = "Simit",
                            PurchasePrice = 7.5m,
                            Quantity = 1m,
                            SalePrice = 4.50m,
                            Stock = 100,
                            TaxRatio = 0.01m,
                            Unit = 4,
                            UnitPrice = 0m
                        },
                        new
                        {
                            ProductID = 9,
                            Brand = "",
                            CategoryID = 3,
                            ExpirationDate = new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsContinued = true,
                            Name = "Peynirli Poğaça",
                            PurchasePrice = 11.50m,
                            Quantity = 1m,
                            SalePrice = 6.50m,
                            Stock = 100,
                            TaxRatio = 0.01m,
                            Unit = 4,
                            UnitPrice = 0m
                        },
                        new
                        {
                            ProductID = 10,
                            Brand = "Yayla",
                            CategoryID = 4,
                            ExpirationDate = new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsContinued = true,
                            Name = "Pirinç (1kg)",
                            PurchasePrice = 76.90m,
                            Quantity = 1m,
                            SalePrice = 69.00m,
                            Stock = 100,
                            TaxRatio = 0.01m,
                            Unit = 4,
                            UnitPrice = 0m
                        },
                        new
                        {
                            ProductID = 11,
                            Brand = "Sinangil",
                            CategoryID = 4,
                            ExpirationDate = new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsContinued = true,
                            Name = "Un (1kg)",
                            PurchasePrice = 21.99m,
                            Quantity = 1m,
                            SalePrice = 16.99m,
                            Stock = 100,
                            TaxRatio = 0.01m,
                            Unit = 4,
                            UnitPrice = 0m
                        },
                        new
                        {
                            ProductID = 12,
                            Brand = "Komili",
                            CategoryID = 4,
                            ExpirationDate = new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsContinued = true,
                            Name = "Ayçiçek Yağı",
                            PurchasePrice = 119.90m,
                            Quantity = 1m,
                            SalePrice = 80.00m,
                            Stock = 100,
                            TaxRatio = 0.01m,
                            Unit = 4,
                            UnitPrice = 0m
                        },
                        new
                        {
                            ProductID = 13,
                            Brand = "İçim (1L)",
                            CategoryID = 5,
                            ExpirationDate = new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsContinued = true,
                            Name = "Süt",
                            PurchasePrice = 34.99m,
                            Quantity = 1m,
                            SalePrice = 29.99m,
                            Stock = 100,
                            TaxRatio = 0.01m,
                            Unit = 4,
                            UnitPrice = 0m
                        },
                        new
                        {
                            ProductID = 14,
                            Brand = "Tahsildaroğlu",
                            CategoryID = 5,
                            ExpirationDate = new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsContinued = true,
                            Name = "Beyaz Peynir (450g)",
                            PurchasePrice = 174.95m,
                            Quantity = 1m,
                            SalePrice = 148.00m,
                            Stock = 100,
                            TaxRatio = 0.01m,
                            Unit = 4,
                            UnitPrice = 0m
                        },
                        new
                        {
                            ProductID = 15,
                            Brand = "Pınar",
                            CategoryID = 5,
                            ExpirationDate = new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsContinued = true,
                            Name = "Yoğurt (750g)",
                            PurchasePrice = 43.99m,
                            Quantity = 1m,
                            SalePrice = 39.99m,
                            Stock = 100,
                            TaxRatio = 0.01m,
                            Unit = 4,
                            UnitPrice = 0m
                        },
                        new
                        {
                            ProductID = 16,
                            Brand = "CP",
                            CategoryID = 6,
                            ExpirationDate = new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsContinued = true,
                            Name = "Yumurta (10'lu)",
                            PurchasePrice = 73.99m,
                            Quantity = 1m,
                            SalePrice = 65.00m,
                            Stock = 100,
                            TaxRatio = 0.01m,
                            Unit = 4,
                            UnitPrice = 0m
                        },
                        new
                        {
                            ProductID = 17,
                            Brand = "Cumhuriyet",
                            CategoryID = 6,
                            ExpirationDate = new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsContinued = true,
                            Name = "Sucuk (220g)",
                            PurchasePrice = 176.50m,
                            Quantity = 1m,
                            SalePrice = 140.00m,
                            Stock = 100,
                            TaxRatio = 0.01m,
                            Unit = 4,
                            UnitPrice = 0m
                        },
                        new
                        {
                            ProductID = 18,
                            Brand = "Balparmak",
                            CategoryID = 6,
                            ExpirationDate = new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsContinued = true,
                            Name = "Bal (460g)",
                            PurchasePrice = 196.80m,
                            Quantity = 1m,
                            SalePrice = 140.00m,
                            Stock = 100,
                            TaxRatio = 0.01m,
                            Unit = 4,
                            UnitPrice = 0m
                        },
                        new
                        {
                            ProductID = 19,
                            Brand = "Lay's",
                            CategoryID = 7,
                            ExpirationDate = new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsContinued = true,
                            Name = "Lay's Klasik (107g)",
                            PurchasePrice = 23.99m,
                            Quantity = 1m,
                            SalePrice = 19.00m,
                            Stock = 100,
                            TaxRatio = 0.01m,
                            Unit = 4,
                            UnitPrice = 0m
                        },
                        new
                        {
                            ProductID = 20,
                            Brand = "Peyman",
                            CategoryID = 7,
                            ExpirationDate = new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsContinued = true,
                            Name = "Karışık Kuruyemiş (180g)",
                            PurchasePrice = 87.50m,
                            Quantity = 1m,
                            SalePrice = 62.49m,
                            Stock = 100,
                            TaxRatio = 0.01m,
                            Unit = 4,
                            UnitPrice = 0m
                        },
                        new
                        {
                            ProductID = 21,
                            Brand = "Ülker",
                            CategoryID = 7,
                            ExpirationDate = new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsContinued = true,
                            Name = "Çikolatalı Gofret",
                            PurchasePrice = 5.50m,
                            Quantity = 1m,
                            SalePrice = 4.5m,
                            Stock = 100,
                            TaxRatio = 0.01m,
                            Unit = 4,
                            UnitPrice = 0m
                        },
                        new
                        {
                            ProductID = 22,
                            Brand = "Signal",
                            CategoryID = 8,
                            ExpirationDate = new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsContinued = true,
                            Name = "Signal White Now Gold",
                            PurchasePrice = 133.11m,
                            Quantity = 1m,
                            SalePrice = 130.00m,
                            Stock = 100,
                            TaxRatio = 0.1m,
                            Unit = 4,
                            UnitPrice = 0m
                        },
                        new
                        {
                            ProductID = 23,
                            Brand = "Elidor",
                            CategoryID = 8,
                            ExpirationDate = new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsContinued = true,
                            Name = "Şampuan",
                            PurchasePrice = 103.50m,
                            Quantity = 1m,
                            SalePrice = 84.99m,
                            Stock = 100,
                            TaxRatio = 0.1m,
                            Unit = 4,
                            UnitPrice = 0m
                        },
                        new
                        {
                            ProductID = 24,
                            Brand = "Dove",
                            CategoryID = 8,
                            ExpirationDate = new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsContinued = true,
                            Name = "Sıvı El Sabunu",
                            PurchasePrice = 90.56m,
                            Quantity = 1m,
                            SalePrice = 80.00m,
                            Stock = 100,
                            TaxRatio = 0.1m,
                            Unit = 4,
                            UnitPrice = 0m
                        },
                        new
                        {
                            ProductID = 25,
                            Brand = "Domestos",
                            CategoryID = 9,
                            ExpirationDate = new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsContinued = true,
                            Name = "Domestos Dağ Esintisi",
                            PurchasePrice = 39.50m,
                            Quantity = 1m,
                            SalePrice = 33.49m,
                            Stock = 100,
                            TaxRatio = 0.2m,
                            Unit = 4,
                            UnitPrice = 0m
                        },
                        new
                        {
                            ProductID = 26,
                            Brand = "Solo",
                            CategoryID = 9,
                            ExpirationDate = new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsContinued = true,
                            Name = "Tuvalet Kağıdı (16'lı)",
                            PurchasePrice = 164.39m,
                            Quantity = 1m,
                            SalePrice = 130.00m,
                            Stock = 100,
                            TaxRatio = 0.2m,
                            Unit = 4,
                            UnitPrice = 0m
                        },
                        new
                        {
                            ProductID = 27,
                            Brand = "Finish",
                            CategoryID = 9,
                            ExpirationDate = new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsContinued = true,
                            Name = "Finish Quantum (40'lı)",
                            PurchasePrice = 71.10m,
                            Quantity = 1m,
                            SalePrice = 54.00m,
                            Stock = 100,
                            TaxRatio = 0.2m,
                            Unit = 4,
                            UnitPrice = 0m
                        });
                });

            modelBuilder.Entity("Market_Otomasyonu.Entity.Entities.Sale", b =>
                {
                    b.Property<int>("SaleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaleID"), 1L, 1);

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<decimal>("ProfitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("SaleDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("SaleID");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("Market_Otomasyonu.Entity.Entities.ShoppingCart", b =>
                {
                    b.Property<int>("ShoppingCartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShoppingCartID"), 1L, 1);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<decimal>("PurchasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SaleID")
                        .HasColumnType("int");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ShoppingCartID");

                    b.HasIndex("ProductID");

                    b.HasIndex("SaleID");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("Market_Otomasyonu.Entity.Entities.AppUser", b =>
                {
                    b.HasOne("Market_Otomasyonu.Entity.Entities.AppRole", "AppRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppRole");
                });

            modelBuilder.Entity("Market_Otomasyonu.Entity.Entities.Market", b =>
                {
                    b.HasOne("Market_Otomasyonu.Entity.Entities.AppUser", "User")
                        .WithMany("Markets")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Market_Otomasyonu.Entity.Entities.Product", b =>
                {
                    b.HasOne("Market_Otomasyonu.Entity.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Market_Otomasyonu.Entity.Entities.Market", null)
                        .WithMany("Products")
                        .HasForeignKey("MarketID");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Market_Otomasyonu.Entity.Entities.ShoppingCart", b =>
                {
                    b.HasOne("Market_Otomasyonu.Entity.Entities.Product", "Product")
                        .WithMany("ShoppingCarts")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Market_Otomasyonu.Entity.Entities.Sale", "Sale")
                        .WithMany("ShoppingCarts")
                        .HasForeignKey("SaleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("Market_Otomasyonu.Entity.Entities.AppRole", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Market_Otomasyonu.Entity.Entities.AppUser", b =>
                {
                    b.Navigation("Markets");
                });

            modelBuilder.Entity("Market_Otomasyonu.Entity.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Market_Otomasyonu.Entity.Entities.Market", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Market_Otomasyonu.Entity.Entities.Product", b =>
                {
                    b.Navigation("ShoppingCarts");
                });

            modelBuilder.Entity("Market_Otomasyonu.Entity.Entities.Sale", b =>
                {
                    b.Navigation("ShoppingCarts");
                });
#pragma warning restore 612, 618
        }
    }
}
