using Market_Otomasyonu.Data.Context;
using Market_Otomasyonu.Data.Repository;
using Market_Otomasyonu.Entity.Entities;
using Market_Otomasyonu.Entity.Enums;
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
	public partial class SaleScreen : Form
	{
		private readonly ProductRepository _productRepository;
		private readonly AppDbContext _context;
		private readonly SaleRepository _saleRepository;
		public SaleScreen()
		{
			_context = new AppDbContext();
			_productRepository = new ProductRepository();
			_saleRepository = new SaleRepository();
			InitializeComponent();
		}
		int selectedProductID;
		Product selectedProduct;
		private void txtUrunAra_TextChanged(object sender, EventArgs e)
		{
			lstArananUrunler.Items.Clear();
			string productSearch = txtUrunAra.Text;
			var productSearched = _context.Products.Where(x => x.Name.Contains(productSearch)).ToList();

			foreach (var item in productSearched)
			{
				string[] arr = {
					item.ProductID.ToString(),
					item.Name,
					item.Brand,
					item.Unit.ToString(),
					(item.SalePrice * item.TaxRatio).ToString("0.00") //ürünün vergili satış fiyatı
                };
				ListViewItem lvi = new ListViewItem(arr);
				lstArananUrunler.Items.Add(lvi);
			}
		}
		decimal selectedProductQuantity;
		decimal totalSalesQuantity = 0;
		decimal totalSalesPrice = 0;
		private void btnSiparisEkle_Click(object sender, EventArgs e)
		{
			if (lstArananUrunler.SelectedItems.Count == 0 && nmrBirimFiyat.Value == 0)
			{
				MessageBox.Show("Lütfen önce bir ürün seçin ve miktar belirtin");
			}
			else
			{

				selectedProductID = Convert.ToInt32(lstArananUrunler.SelectedItems[0].Text);
				selectedProductQuantity = nmrAdet.Value;
				var productSearched = _context.Products.Where(x => x.ProductID == selectedProductID).ToList();

				foreach (Product item in productSearched)
				{
					if (item.Stock == 0)
					{
						MessageBox.Show($"İstenen ürün stokta kalmamıştır");
					}
					else if (item.Stock < selectedProductQuantity)
					{
						MessageBox.Show($"İstenen üründen stokta {item.Stock} {item.Unit} kadar kaldı, Lütfen uygun miktarda satış yapınız");
					}
					else
					{
						string[] arr = {
						item.ProductID.ToString(),
						item.Name,
						item.Brand,
						_context.Categories.First(x=>x.CategoryID == item.CategoryID).Name,
						  item.Unit.ToString(),
						((item.SalePrice + (item.SalePrice * item.TaxRatio)) * selectedProductQuantity).ToString("0.00"),//üründen kaç tane alındı ise onun vergili fiyatinın hesaplanması
                        selectedProductQuantity.ToString(),
						DateTime.Now.ToString("d")
					};
						ListViewItem lvi = new ListViewItem(arr);
						lstSiparisler.Items.Add(lvi);

						totalSalesQuantity += selectedProductQuantity;
						totalSalesPrice += ((item.SalePrice + (item.SalePrice * item.TaxRatio)) * selectedProductQuantity);

						lblToplamSatisAdedi.Text = totalSalesQuantity.ToString("0.00");
						lblToplamFiyat.Text = totalSalesPrice.ToString("0.00");
					}

				}
			}
		}
		Product saledProduct;
		private void btnSiparisiTamamla_Click(object sender, EventArgs e)
		{
			var billID = _context.Sales.OrderByDescending(x => x.FaturaID).Select(x => x.FaturaID).FirstOrDefault();

			if (lstSiparisler.Items.Count == 0 || (rdbNakit.Checked == false && rdbKrediKarti.Checked == false))
			{
				MessageBox.Show("Lütfen sipariş listesine ekleme yapın ve bir ödeme yöntemi seçin");
			}
			else
			{
				foreach (ListViewItem item in lstSiparisler.Items)
				{
					saledProduct = _context.Products.First(x => x.ProductID == Convert.ToInt32(item.SubItems[0].Text));
					var sale = new Sale()
					{
						Name = saledProduct.Name,
						ProfitPrice = (saledProduct.SalePrice - saledProduct.PurchasePrice) * Convert.ToDecimal(item.SubItems[6].Text),
						Products = new List<Product>() { saledProduct },
						UnitPrice = saledProduct.UnitPrice,
						Quantity = Convert.ToDecimal(item.SubItems[6].Text),
						TotalPrice = Convert.ToDecimal(item.SubItems[5].Text),
						SaleDate = DateTime.Now,
						PaymentMethod = rdbKrediKarti.Checked ? PaymentMethod.CreditCard : PaymentMethod.Cash,
						FaturaID = billID + 1
					};
					saledProduct.Stock -= Convert.ToInt32(item.SubItems[6].Text);
				
					_saleRepository.Add(sale);
					//_context.Sales.Add(sale);
					//_context.SaveChanges();

					//context.SaveChanges();
				};

				MessageBox.Show("Sipariş başarılı bir şekilde tamamlandı");
				lstArananUrunler.Items.Clear();
				lstSiparisler.Items.Clear();

				//Helper.Temizle(grpUrunEkle.Controls);
				totalSalesPrice = 0;
				totalSalesQuantity = 0;
				lblToplamFiyat.Text = "0";
				lblToplamSatisAdedi.Text = "0";
				txtUrunAra.Text = string.Empty;
				nmrAdet.Value = 0;
				rdbKrediKarti.Checked = false;
				rdbNakit.Checked = false;
				billID++;
				InvoıceScreen report = new InvoıceScreen(billID);
				report.ShowDialog();
			}
		}

		private void btnSiparisSil_Click(object sender, EventArgs e)
		{
			if (lstSiparisler.SelectedItems.Count == 0)
			{
				MessageBox.Show("Lütfen silmek istediğiniz ürünü seçiniz");
			}
			else
			{
				if (lstSiparisler.SelectedItems.Count > 0)
				{
					foreach (ListViewItem item in lstSiparisler.SelectedItems)
					{
						totalSalesQuantity -= Convert.ToDecimal(item.SubItems[6].Text);
						totalSalesPrice -= Convert.ToDecimal(item.SubItems[5].Text);

						lblToplamSatisAdedi.Text = totalSalesQuantity.ToString("0.00");
						lblToplamFiyat.Text = totalSalesPrice.ToString("0.00");
					}
					int index = lstSiparisler.SelectedIndices[0];
					ListViewItem selectedItem = lstSiparisler.SelectedItems[0];
					lstSiparisler.Items.RemoveAt(index);
					lstSiparisler.Refresh();
					MessageBox.Show("Silme işleminiz gerçekleşti");

				}
			}
		}
	}
}
