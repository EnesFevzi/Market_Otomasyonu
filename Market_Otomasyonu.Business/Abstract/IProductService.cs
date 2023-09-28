﻿using Market_Otomasyonu.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Business.Abstract
{
	public interface IProductService
	{
		void Add(Product product);
		void Update(Product product);
		void Delete(Product product);
		List<Product> GetAll();
		List<Product> GetAllProductWtihCategory();
		Product GetByID(int id);
		Product GetByFilter(Expression<Func<Product, bool>> filter);
		List<Product> GetByFilterList(Expression<Func<Product, bool>> filter);

	}
}