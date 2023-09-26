namespace Market_Otomasyonu.UI
{
	public partial class UserPanel : Form
	{
		public UserPanel()
		{
			InitializeComponent();
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
	}
}
