﻿using Market_Otomasyonu.Data.Context;
using Market_Otomasyonu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Data.Repository
{
	public class ProductRepository
	{
		private readonly AppDbContext _context;
		public ProductRepository()
		{
			_context = new AppDbContext();
		}
		public void Add(Product product)
		{
			_context.Products.Add(product);
			_context.SaveChanges();
		}

		public void Update(Product product)
		{
			_context.Products.Update(product);
			_context.SaveChanges();
		}

		public void Delete(Product product)
		{
			_context.Products.Remove(product);
			_context.SaveChanges();

		}
		public List<Product> GetAll()
		{
			return _context.Set<Product>().ToList();
		}

		public Product GetByID(int id)
		{
			return _context.Set<Product>().Find(id);
		}

		public Product GetByFilter(Expression<Func<Product, bool>> filter)
		{
			return _context.Set<Product>().First(filter);
		}

		public List<Product> GetByFilterList(Expression<Func<Product, bool>> filter)
		{
			return _context.Set<Product>().Where(filter).ToList();
		}
	}
}