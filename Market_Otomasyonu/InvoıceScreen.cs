using Market_Otomasyonu.Data.Context;
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
	public partial class InvoıceScreen : Form
	{
		private readonly AppDbContext _context;
		private int _billID;
		int billID = 0;
		public InvoıceScreen(int billID)
		{
			_context = new AppDbContext();
			InitializeComponent();
			_billID = billID;
		}

		private void InvoıceScreen_Load(object sender, EventArgs e)
		{
			var billSaledProducts = _context.Sales.Where(x => x.FaturaID == billID).ToList();
			decimal billPrice = 0;
			foreach (var item in billSaledProducts)
			{
				string[] arr = { item.Name, item.Quantity.ToString(), item.TotalPrice.ToString(), item.SaleDate.ToString(), item.PaymentMethod.ToString() };
				ListViewItem lvi = new ListViewItem(arr);
				lstFatura.Items.Add(lvi);
				billPrice += item.TotalPrice;
			}
			lblFaturaTutarı.Text = $"Toplam Fatura Tutarı: {billPrice} TL'dir";
		}
	}
}
