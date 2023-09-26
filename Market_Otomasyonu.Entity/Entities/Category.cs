using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Entity.Entities
{
	public class Category
	{
        public Category()
        {
            Products= new List<Product>();  
        }
        public int CategoryID { get; set; }
        public string Name { get; set; }


        //Navigation Prop
        public virtual ICollection<Product> Products { get; set;}
    }
}
