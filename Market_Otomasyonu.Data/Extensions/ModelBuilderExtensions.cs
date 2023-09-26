using Market_Otomasyonu.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Data.Extensions
{
	public static class ModelBuilderExtensions
	{

		public static void SeedData(this ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<AppUser>()
				.HasData(
				new AppUser()
				{
					UserID = 1,
					Name = "Enes",
					Surname = "Fevzi",
					Username = "enesfevzi",
					Password = "937D4852C65D801C404334353B1EF43D9A7C4EC43C0F4DF8F3BE33AE2A9DB5A7",
					ConfirmPassword = "937D4852C65D801C404334353B1EF43D9A7C4EC43C0F4DF8F3BE33AE2A9DB5A7"
				}
				);
			modelBuilder.Entity<Category>().HasData(
				new Category { CategoryID = 1, Name = "Atıştırmalık" }
				);

			modelBuilder.Entity<Product>().HasData(

				new Product { ProductID = 1, Brand = "Milka", ExpirationDate = DateTime.Now, SalePrice = 10.59m, Name = "Çikolata", Stock = 100, TaxRatio = 1.18m, CategoryID = 1, IsContinued = true, PurchasePrice = 7m, Unit = Entity.Enums.Unit.Gram, UnitPrice = 5m },

				 new Product { ProductID = 2, Brand = "Eti", ExpirationDate = DateTime.Now, SalePrice = 15.59m, Name = "Çikolatalı Gofret", Stock = 100, TaxRatio = 1.18m, CategoryID = 1, IsContinued = true, PurchasePrice = 8m, Unit = Entity.Enums.Unit.Gram, UnitPrice = 6m },
				  new Product { ProductID = 3, Brand = "Ülker", ExpirationDate = DateTime.Now, SalePrice = 15.59m, Name = "Çikolatalı Gofret", Stock = 10, TaxRatio = 1.18m, CategoryID = 1, IsContinued = true, PurchasePrice = 8m, Unit = Entity.Enums.Unit.Gram, UnitPrice = 6m });
		}
	}
}