using Market_Otomasyonu.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Data.Repository
{
	public class AppUserRepository
	{
		private readonly AppDbContext _context;
        public AppUserRepository()
        {
            _context = new AppDbContext();
        }

		public string UserAuthenticationResult(string username, string password)
		{
			var userExists = _context.Users.FirstOrDefault(u => u.Username == username);

			if (userExists != null)
			{
				if (userExists.Password == password)
				{
					return "Giriş Başarılı";
				}
				else
				{
					return "Şifre Yanlış";
				}
			}
			else
			{
				return "Kullanıcı Bulunamadı";
			}
		}
	}
}
