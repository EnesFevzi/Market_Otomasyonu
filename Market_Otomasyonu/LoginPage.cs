using Market_Otomasyonu.Business.Concrete;
using Market_Otomasyonu.Entity.Entities;
using Market_Otomasyonu.UI.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Otomasyonu.UI
{
	public partial class LoginPage : Form
	{
		private readonly AppUserService _userService;
		public LoginPage()
		{
			_userService = new AppUserService();
			InitializeComponent();
		}

		private void btnGirisYap_Click(object sender, EventArgs e)
		{
			if (Helper.AlanlariKontrolEt(grpGirisPaneli.Controls))
			{
				MessageBox.Show("Lütfen tüm alanları doldurun.");
				return;
			}
			var result = _userService.AuthenticateUser(txtKullaniciAdi.Text, _userService.PasswordHash(txtSifre.Text));
			if (result == "Giriş Başarılı")
			{
				UserPanel userpanel = new UserPanel();
				this.Hide();
				userpanel.ShowDialog();
			}
			if (result == "Şifre Yanlış")
			{
				MessageBox.Show("Lütfen şifrenizi kontrol ediniz");

			}
			if (result == "Kullanıcı Bulunamadı")
			{
				MessageBox.Show("Böyle bir kullanıcı bulunamadı");

			}
		}

		private void btnSifreyiGoster_MouseUp(object sender, MouseEventArgs e)
		{
			txtSifre.PasswordChar = '*';
		}

		private void btnSifreyiGoster_MouseDown(object sender, MouseEventArgs e)
		{
			txtSifre.PasswordChar = default;
		}
	}
}
