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
					ConfirmPassword= "937D4852C65D801C404334353B1EF43D9A7C4EC43C0F4DF8F3BE33AE2A9DB5A7"
				}
				);
		}
	}
}