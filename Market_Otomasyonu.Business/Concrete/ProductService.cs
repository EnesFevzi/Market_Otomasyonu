using Market_Otomasyonu.Data.Repository;
using Market_Otomasyonu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Business.Concrete
{
	public class ProductService
	{
		private readonly ProductRepository _prdouctRepository;
        public ProductService()
        {
            _prdouctRepository = new ProductRepository();
        }
        public List<Product> GetAllProductWtihCategory()
		{
			return _prdouctRepository.GetAllProductWtihCategory();
		}
	}
}
