using Market_Otomasyonu.Business.Concrete;
using Market_Otomasyonu.Entity.Entities;

namespace Market_Otomasyonu.UI
{
	public partial class UserPanel : Form
	{
		private AppUser _user;
		private readonly RoleService _roleService;

		public UserPanel(AppUser user)
		{
			InitializeComponent();
			_user = user;
			_roleService = new RoleService();
		}
		private void UserPanel_Load(object sender, EventArgs e)
		{
			var role = _roleService.GetByRoleAdmin();
			if (_user.RoleID == role.RoleID)
			{
				btnKullaniciPaneli.Visible = true;
				this.Height = 621;
				this.Width = 389;
			}
			else
			{
				btnKullaniciPaneli.Visible = false;
				this.Height = 463;
				this.Width = 389;
			}
		}
		private void btnRapor_Click(object sender, EventArgs e)
		{
			Report report = new Report();
			this.Hide();
			report.ShowDialog();
			this.Show();
		}

		private void btnUrunEkle_Click(object sender, EventArgs e)
		{
			AddProduct addProduct = new AddProduct();
			this.Hide();
			addProduct.ShowDialog();
			this.Show();
		}

		private void btnKategoriEkle_Click(object sender, EventArgs e)
		{
			AddCategory addCategory = new AddCategory();
			this.Hide();
			addCategory.ShowDialog();
			this.Show();
		}

		private void btnSatisEkrani_Click(object sender, EventArgs e)
		{
			SaleScreen saleScreen = new SaleScreen();
			this.Hide();
			saleScreen.ShowDialog();
			this.Show();
		}

		private void btnKullaniciPaneli_Click(object sender, EventArgs e)
		{
			UserPanelSetting userPanelSetting = new UserPanelSetting();
			this.Hide();
			userPanelSetting.ShowDialog();
		}
	}
}
