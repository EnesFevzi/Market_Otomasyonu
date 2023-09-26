using Market_Otomasyonu.Data.Extensions;
using Market_Otomasyonu.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Data.Context
{
	public class AppDbContext:DbContext
	{


		public DbSet<Sale> Sales { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<AppUser> Users { get; set; }
		public DbSet<Market> Markets { get; set; }
	
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=MarketOtomasyonuDB;integrated security=true");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.SeedData();
			base.OnModelCreating(modelBuilder);
		}
	}
}
