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
    [Migration("20230927100059_mig_6")]
    partial class mig_6
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
                            CreatedDate = new DateTime(2023, 9, 27, 13, 0, 58, 695, DateTimeKind.Local).AddTicks(5749),
                            Gender = "Erkek",
                            IsWorking = "Çalışıyor",
                            Name = "Enes",
                            Password = "937D4852C65D801C404334353B1EF43D9A7C4EC43C0F4DF8F3BE33AE2A9DB5A7",
                            RoleID = 1,
                            Surname = "Fevzi",
                            Username = "enesfevzi"
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
                            Name = "Atıştırmalık"
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
                            Brand = "Milka",
                            CategoryID = 1,
                            ExpirationDate = new DateTime(2023, 9, 27, 13, 0, 58, 695, DateTimeKind.Local).AddTicks(5781),
                            IsContinued = true,
                            Name = "Çikolata",
                            PurchasePrice = 7m,
                            Quantity = 0m,
                            SalePrice = 10.59m,
                            Stock = 100,
                            TaxRatio = 1.18m,
                            Unit = 0,
                            UnitPrice = 5m
                        },
                        new
                        {
                            ProductID = 2,
                            Brand = "Eti",
                            CategoryID = 1,
                            ExpirationDate = new DateTime(2023, 9, 27, 13, 0, 58, 695, DateTimeKind.Local).AddTicks(5787),
                            IsContinued = true,
                            Name = "Çikolatalı Gofret",
                            PurchasePrice = 8m,
                            Quantity = 0m,
                            SalePrice = 15.59m,
                            Stock = 100,
                            TaxRatio = 1.18m,
                            Unit = 0,
                            UnitPrice = 6m
                        },
                        new
                        {
                            ProductID = 3,
                            Brand = "Ülker",
                            CategoryID = 1,
                            ExpirationDate = new DateTime(2023, 9, 27, 13, 0, 58, 695, DateTimeKind.Local).AddTicks(5789),
                            IsContinued = true,
                            Name = "Çikolatalı Gofret",
                            PurchasePrice = 8m,
                            Quantity = 0m,
                            SalePrice = 15.59m,
                            Stock = 10,
                            TaxRatio = 1.18m,
                            Unit = 0,
                            UnitPrice = 6m
                        });
                });

            modelBuilder.Entity("Market_Otomasyonu.Entity.Entities.Sale", b =>
                {
                    b.Property<int>("SaleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaleID"), 1L, 1);

                    b.Property<int>("FaturaID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

            modelBuilder.Entity("ProductSale", b =>
                {
                    b.Property<int>("ProductsProductID")
                        .HasColumnType("int");

                    b.Property<int>("SalesSaleID")
                        .HasColumnType("int");

                    b.HasKey("ProductsProductID", "SalesSaleID");

                    b.HasIndex("SalesSaleID");

                    b.ToTable("ProductSale");
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

            modelBuilder.Entity("ProductSale", b =>
                {
                    b.HasOne("Market_Otomasyonu.Entity.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Market_Otomasyonu.Entity.Entities.Sale", null)
                        .WithMany()
                        .HasForeignKey("SalesSaleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
#pragma warning restore 612, 618
        }
    }
}
