using Market_Otomasyonu.Data.Repository;
using Market_Otomasyonu.Entity.Entities;
using Market_Otomasyonu.Entity.Enums;
using Market_Otomasyonu.UI.Extensions;

namespace Market_Otomasyonu
{
	public partial class AddProduct : Form
	{
		private readonly ProductRepository _productRepository;
		private readonly CategoryRepository _categoryRepository;
		public AddProduct()
		{
			_categoryRepository = new CategoryRepository();
			_productRepository = new ProductRepository();
			InitializeComponent();
		}
		private void AddProduct_Load(object sender, EventArgs e)
		{
			AddCategoriesToCombobox();
			AddUnitsToCombobox();
			GetAllProducts();
		}


		private void btnKaydet_Click(object sender, EventArgs e)
		{
			if (Helper.CheckAreaAddProduct(grpUrunEkle.Controls))
			{
				MessageBox.Show("Lütfen tüm alanlarý doldurun.");
				return;
			}
			else
			{
				Product product = new Product();
				product.Name = txtUrunAdi.Text;
				var category = (Category)cmbKategori.SelectedItem;
				product.CategoryID = category.CategoryID;
				if (txtMarka.Text == string.Empty)
				{
					product.Brand = "Belirtilmedi";
				}
				else
				{
					product.Brand = txtMarka.Text;
				}
				product.Unit = (Unit)cmbBirim.SelectedItem;
				product.SalePrice = nmrAlisFiyati.Value;
				product.PurchasePrice = nmrSatisFiyati.Value;
				product.TaxRatio = nmrVergiOrani.Value;
				product.Quantity = nmrPakettekiUrunSayisi.Value;
				product.ExpirationDate = dtSonKullanmaTarihi.Value;
				product.Stock = (int)nmrStokAdedi.Value;
				product.IsContinued = true;

				_productRepository.Add(product);
				MessageBox.Show("Ýþlem baþarýlý!");
				GetAllProducts();
				Helper.Temizle(grpUrunEkle.Controls);
			}
		}

		private void grpUrunEkle_Enter(object sender, EventArgs e)
		{

		}
		private void GetAllProducts()
		{
			lstUrunler.Items.Clear();

			var products = _productRepository.GetAll();

			foreach (var item in products)
			{
				ListViewItem lv = new ListViewItem(item.ProductID.ToString());
				lv.SubItems.Add(item.Name);
				Category category = _categoryRepository.GetByID(item.CategoryID);
				if (category != null)
				{
					lv.SubItems.Add(category.Name);
				}

				lv.SubItems.Add(item.Brand);
				lv.SubItems.Add(item.Unit.ToString());
				lv.SubItems.Add(item.SalePrice.ToString());
				lv.SubItems.Add(item.PurchasePrice.ToString());
				lv.SubItems.Add(item.TaxRatio.ToString());
				lv.SubItems.Add(item.Quantity.ToString());

				lv.SubItems.Add(item.Stock.ToString());
				lv.SubItems.Add(item.ExpirationDate.ToString());
				lv.SubItems.Add(item.IsContinued.ToString());
				lstUrunler.Items.Add(lv);
				lv.Tag = item;
			}
		}
		private void AddCategoriesToCombobox()
		{
			var categories = _categoryRepository.GetAll();

			foreach (var item in categories)
			{
				cmbKategori.Items.Add(item);
			}
		}
		private void AddUnitsToCombobox()
		{
			foreach (Unit item in Enum.GetValues(typeof(Unit)))
			{
				cmbBirim.Items.Add(item);
			}
		}
		Product selectedProduct;
		private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstUrunler.SelectedItems.Count > 0)
			{
				selectedProduct = (Product)lstUrunler.SelectedItems[0].Tag; ;
				Category category = _categoryRepository.GetByID(selectedProduct.CategoryID);
				txtUrunAdi.Text = selectedProduct.Name;
				cmbKategori.SelectedItem = category;
				txtMarka.Text = selectedProduct.Brand;
				cmbBirim.SelectedItem = selectedProduct.Unit;
				nmrAlisFiyati.Value = selectedProduct.SalePrice;
				nmrStokAdedi.Value = selectedProduct.Stock;
				nmrSatisFiyati.Value = selectedProduct.PurchasePrice;
				nmrVergiOrani.Value = selectedProduct.TaxRatio;
				nmrPakettekiUrunSayisi.Value = selectedProduct.Quantity;
				dtSonKullanmaTarihi.Value = selectedProduct.ExpirationDate;
			}
		}
		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			if (lstUrunler.SelectedItems.Count > 0)
			{
				selectedProduct = (Product)lstUrunler.SelectedItems[0].Tag;

				selectedProduct.Name = txtUrunAdi.Text;

				var category = (Category)cmbKategori.SelectedItem;
				selectedProduct.CategoryID = category.CategoryID;

				selectedProduct.Unit = (Unit)cmbBirim.SelectedItem;
				selectedProduct.SalePrice = nmrAlisFiyati.Value;
				selectedProduct.Brand =txtMarka.Text;
				selectedProduct.Stock = (int)nmrStokAdedi.Value;
				selectedProduct.PurchasePrice = nmrSatisFiyati.Value;
				selectedProduct.TaxRatio = nmrVergiOrani.Value;
				selectedProduct.Quantity = nmrPakettekiUrunSayisi.Value;
				selectedProduct.ExpirationDate = dtSonKullanmaTarihi.Value;

				_productRepository.Update(selectedProduct);
				MessageBox.Show("Ýþlem baþarýlý!");
				GetAllProducts();
				Helper.Temizle(grpUrunEkle.Controls);
			}
			else
			{
				MessageBox.Show("Lütfen bir ürün seçiniz!");
			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if (lstUrunler.SelectedItems.Count > 0)
			{

				if (selectedProduct != null)
				{
					_productRepository.Delete(selectedProduct);
					MessageBox.Show("Silme iþlemi Baþarýyla Gerçekleþti");
					GetAllProducts();
				}
				else
				{
					MessageBox.Show("Ýlgili Ürün Bulunamadý");
				}
			}
		}

		
	}
}