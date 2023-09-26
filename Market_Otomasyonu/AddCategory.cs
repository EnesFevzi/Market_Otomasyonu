using Market_Otomasyonu.Business.Concrete;
using Market_Otomasyonu.Data.Repository;
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
	public partial class AddCategory : Form
	{
		private readonly CategoryService _categoryService;
		public AddCategory()
		{
			_categoryService = new CategoryService();
			InitializeComponent();
		}
		private void AddCategory_Load(object sender, EventArgs e)
		{
			UrunleriDoldur(_categoryService.GetAllCategory());
		}
		private void btnKaydet_Click(object sender, EventArgs e)
		{
			if (Helper.AlanlariKontrolEt(grpKategoriEkle.Controls))
			{
				MessageBox.Show("Lütfen tüm alanları doldurun.");
				return;
			}

			var category = new Category()
			{
				Name = txtKategoriAdi.Text,
			};
			_categoryService.AddCategory(category);
			MessageBox.Show("Kaydetme İşlemi Başarılı");
			UrunleriDoldur(_categoryService.GetAllCategory());
			Helper.Temizle(grpKategoriEkle.Controls);
		}
		private void UrunleriDoldur(List<Category> categories)
		{
			lstKategoriler.Items.Clear();
			foreach (var category in categories)
			{
				ListViewItem item = new ListViewItem();
				item.Text = category.CategoryID.ToString();
				item.SubItems.Add(category.Name);
				item.Tag = category;
				lstKategoriler.Items.Add(item);
			}
		}

		Category selectedCategory;
		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			if (lstKategoriler.SelectedItems.Count > 0)
			{
				selectedCategory = (Category)lstKategoriler.SelectedItems[0].Tag;
				string updatedCategoryName = txtKategoriAdi.Text;
				selectedCategory.Name = updatedCategoryName;
				_categoryService.UpdateCategory(selectedCategory);
				MessageBox.Show("Güncelleme işlemi Başarıyla Gerçekleşti");
				UrunleriDoldur(_categoryService.GetAllCategory());
				Helper.Temizle(grpKategoriEkle.Controls);
			}
			else
			{
				MessageBox.Show("Lütfen bir ürün seçiniz");
			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if (lstKategoriler.SelectedItems.Count > 0)
			{

				if (selectedCategory != null)
				{
					_categoryService.DeleteCategory(selectedCategory);
					MessageBox.Show("Silme işlemi Başarıyla Gerçekleşti");
					UrunleriDoldur(_categoryService.GetAllCategory());
				}
				else
				{
					MessageBox.Show("İlgili Ürün Bulunamadı");
				}
			}
		}

		private void lstKategoriler_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstKategoriler.SelectedItems.Count > 0)
			{
				selectedCategory = (Category)lstKategoriler.SelectedItems[0].Tag;
				txtKategoriAdi.Text = selectedCategory.Name;
			}
		}
	}
}
