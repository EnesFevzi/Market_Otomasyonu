using Market_Otomasyonu.Entity.Enums;
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
			ShoppingCarts= new List<ShoppingCart>();

		}
        public int SaleID { get; set; }
		public decimal UnitPrice { get; set; }
		public decimal Quantity { get; set; }
		public decimal TotalPrice { get; set; }
		public decimal ProfitPrice { get; set; }
		public PaymentMethod PaymentMethod { get; set; }
		public DateTime SaleDate { get; set; }
	
		//public int InvoıceID { get; set; }

		//Navigation Prop
		//public List<Product> Products { get; set; }
		public ICollection<ShoppingCart> ShoppingCarts { get; set; }
	}
}
