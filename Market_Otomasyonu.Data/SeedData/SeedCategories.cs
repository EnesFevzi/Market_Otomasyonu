using Market_Otomasyonu.Entity.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Data.SeedData
{
	public class SeedCategories : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder.HasData
				 (
					new Category { CategoryID = 1, Name = "Su & İçecek" },
					new Category { CategoryID = 2, Name = "Meyve & Sebze" },
					new Category { CategoryID = 3, Name = "Fırın Ürünleri" },
					new Category { CategoryID = 4, Name = "Temel Gıda" },
					new Category { CategoryID = 5, Name = "Süt Ürünleri" },
					new Category { CategoryID = 6, Name = "Kahvaltılık" },
					new Category { CategoryID = 7, Name = "Atıştırmalık" },
					new Category { CategoryID = 8, Name = "Kişisel Bakım" },
					new Category { CategoryID = 9, Name = "Temizlik Malzemeleri" }
				);
		}
	}
}
