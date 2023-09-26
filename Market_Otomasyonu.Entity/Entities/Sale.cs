﻿using Market_Otomasyonu.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Entity.Entities
{
	public class Sale
	{
        public Sale()
        {
			Products =  new List<Product>();

		}
        public int SaleID { get; set; }
		public string Name { get; set; }
		public decimal UnitPrice { get; set; }
		public decimal Quantity { get; set; }
		public decimal TotalPrice { get; set; }
		public decimal ProfitPrice { get; set; }
		public PaymentMethod PaymentMethod { get; set; }
		public DateTime SaleDate { get; set; }

		//Navigation Prop
		public virtual ICollection<Product> Products { get; set; }
	}
}
