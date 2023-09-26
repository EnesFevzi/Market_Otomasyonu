using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Business.Abstract
{
	public interface IAppUserService
	{
		string PasswordHash(string password);
		string AuthenticateUser(string username, string password);
	}
}
