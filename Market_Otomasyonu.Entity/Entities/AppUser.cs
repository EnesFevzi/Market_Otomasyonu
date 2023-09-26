using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Entity.Entities
{
	public class AppUser
	{
        public AppUser()
        {
            Markets = new List<Market>();
        }
        [Key]
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        //Navigation prop
        public virtual  ICollection<Market> Markets { get; set; }
    }
}
