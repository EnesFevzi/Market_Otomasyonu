using Market_Otomasyonu.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Business.Concrete
{
	public class AppUserService
	{
		private readonly AppUserRepository _appUserRepository;
        public AppUserService()
        {
            _appUserRepository = new AppUserRepository();
        }
        public string PasswordHash(string password)
		{
			using (SHA256 hash = SHA256Managed.Create())
			{
				return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(l => l.ToString("X2")));
			}
		}
		public string AuthenticateUser(string username, string password)
		{
			return _appUserRepository.UserAuthenticationResult(username, password);
		}
	}
}
