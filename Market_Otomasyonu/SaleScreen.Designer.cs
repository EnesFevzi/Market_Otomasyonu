namespace Market_Otomasyonu.UI
{
	partial class SaleScreen
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			grpUrunEkle = new GroupBox();
			numericUpDown1 = new NumericUpDown();
			label1 = new Label();
			txtUrunAra = new TextBox();
			lstArananUrunler = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			columnHeader4 = new ColumnHeader();
			columnHeader3 = new ColumnHeader();
			columnHeader5 = new ColumnHeader();
			btnSiparisiTamamla = new Button();
			label6 = new Label();
			lstSiparisler = new ListView();
			columnHeader6 = new ColumnHeader();
			columnHeader7 = new ColumnHeader();
			columnHeader14 = new ColumnHeader();
			columnHeader8 = new ColumnHeader();
			columnHeader9 = new ColumnHeader();
			columnHeader10 = new ColumnHeader();
			columnHeader11 = new ColumnHeader();
			columnHeader12 = new ColumnHeader();
			grpFiyatAlani = new GroupBox();
			label8 = new Label();
			lblToplamFiyat = new Label();
			lblToplamSatisAdedi = new Label();
			label7 = new Label();
			btnSiparisEkle = new Button();
			grpOdemeYontemi = new GroupBox();
			rdbKrediKarti = new RadioButton();
			rdbNakit = new RadioButton();
			grpUrunEkle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			grpFiyatAlani.SuspendLayout();
			grpOdemeYontemi.SuspendLayout();
			SuspendLayout();
			// 
			// grpUrunEkle
			// 
			grpUrunEkle.Controls.Add(numericUpDown1);
			grpUrunEkle.Controls.Add(label1);
			grpUrunEkle.Location = new Point(422, 37);
			grpUrunEkle.Name = "grpUrunEkle";
			grpUrunEkle.Size = new Size(205, 77);
			grpUrunEkle.TabIndex = 11;
			grpUrunEkle.TabStop = false;
			grpUrunEkle.Text = "Ürün Ekleme Sayfası";
			// 
			// numericUpDown1
			// 
			numericUpDown1.Location = new Point(61, 31);
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(120, 23);
			numericUpDown1.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(17, 31);
			label1.Name = "label1";
			label1.Size = new Size(38, 18);
			label1.TabIndex = 0;
			label1.Text = "Adet";
			// 
			// txtUrunAra
			// 
			txtUrunAra.Location = new Point(80, 8);
			txtUrunAra.Name = "txtUrunAra";
			txtUrunAra.Size = new Size(259, 23);
			txtUrunAra.TabIndex = 1;
			// 
			// lstArananUrunler
			// 
			lstArananUrunler.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader4, columnHeader3, columnHeader5 });
			lstArananUrunler.FullRowSelect = true;
			lstArananUrunler.GridLines = true;
			lstArananUrunler.Location = new Point(12, 37);
			lstArananUrunler.Name = "lstArananUrunler";
			lstArananUrunler.Size = new Size(395, 181);
			lstArananUrunler.TabIndex = 10;
			lstArananUrunler.UseCompatibleStateImageBehavior = false;
			lstArananUrunler.View = View.Details;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "ID";
			columnHeader1.Width = 100;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Ürün Adı";
			columnHeader2.Width = 100;
			// 
			// columnHeader4
			// 
			columnHeader4.Text = "Marka";
			// 
			// columnHeader3
			// 
			columnHeader3.Text = "Birimi";
			// 
			// columnHeader5
			// 
			columnHeader5.Text = "Fiyat";
			// 
			// btnSiparisiTamamla
			// 
			btnSiparisiTamamla.Location = new Point(933, 522);
			btnSiparisiTamamla.Name = "btnSiparisiTamamla";
			btnSiparisiTamamla.Size = new Size(150, 43);
			btnSiparisiTamamla.TabIndex = 9;
			btnSiparisiTamamla.Text = "Siparişi Tamamla";
			btnSiparisiTamamla.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(12, 13);
			label6.Name = "label6";
			label6.Size = new Size(62, 18);
			label6.TabIndex = 0;
			label6.Text = "Ürün Ara";
			// 
			// lstSiparisler
			// 
			lstSiparisler.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader14, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12 });
			lstSiparisler.FullRowSelect = true;
			lstSiparisler.GridLines = true;
			lstSiparisler.Location = new Point(12, 224);
			lstSiparisler.Name = "lstSiparisler";
			lstSiparisler.Size = new Size(813, 341);
			lstSiparisler.TabIndex = 12;
			lstSiparisler.UseCompatibleStateImageBehavior = false;
			lstSiparisler.View = View.Details;
			// 
			// columnHeader6
			// 
			columnHeader6.Text = "ID";
			columnHeader6.Width = 100;
			// 
			// columnHeader7
			// 
			columnHeader7.Text = "Ürün Adı";
			columnHeader7.Width = 100;
			// 
			// columnHeader14
			// 
			columnHeader14.Text = "Marka";
			// 
			// columnHeader8
			// 
			columnHeader8.DisplayIndex = 4;
			columnHeader8.Text = "Kategori";
			columnHeader8.Width = 100;
			// 
			// columnHeader9
			// 
			columnHeader9.DisplayIndex = 3;
			columnHeader9.Text = "Birimi";
			columnHeader9.Width = 100;
			// 
			// columnHeader10
			// 
			columnHeader10.Text = "Birim Fiyatı";
			columnHeader10.Width = 100;
			// 
			// columnHeader11
			// 
			columnHeader11.Text = "Stok Adedi";
			columnHeader11.Width = 100;
			// 
			// columnHeader12
			// 
			columnHeader12.Text = "Tarih";
			columnHeader12.Width = 100;
			// 
			// grpFiyatAlani
			// 
			grpFiyatAlani.Controls.Add(label8);
			grpFiyatAlani.Controls.Add(lblToplamFiyat);
			grpFiyatAlani.Controls.Add(lblToplamSatisAdedi);
			grpFiyatAlani.Controls.Add(label7);
			grpFiyatAlani.Location = new Point(851, 412);
			grpFiyatAlani.Name = "grpFiyatAlani";
			grpFiyatAlani.Size = new Size(232, 104);
			grpFiyatAlani.TabIndex = 13;
			grpFiyatAlani.TabStop = false;
			grpFiyatAlani.Text = "Tutar";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label8.Location = new Point(6, 63);
			label8.Name = "label8";
			label8.Size = new Size(86, 18);
			label8.TabIndex = 0;
			label8.Text = "Toplam Fiyat";
			// 
			// lblToplamFiyat
			// 
			lblToplamFiyat.AutoSize = true;
			lblToplamFiyat.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblToplamFiyat.Location = new Point(172, 63);
			lblToplamFiyat.Name = "lblToplamFiyat";
			lblToplamFiyat.Size = new Size(15, 18);
			lblToplamFiyat.TabIndex = 0;
			lblToplamFiyat.Text = "0";
			// 
			// lblToplamSatisAdedi
			// 
			lblToplamSatisAdedi.AutoSize = true;
			lblToplamSatisAdedi.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblToplamSatisAdedi.Location = new Point(172, 29);
			lblToplamSatisAdedi.Name = "lblToplamSatisAdedi";
			lblToplamSatisAdedi.Size = new Size(15, 18);
			lblToplamSatisAdedi.TabIndex = 0;
			lblToplamSatisAdedi.Text = "0";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label7.Location = new Point(6, 29);
			label7.Name = "label7";
			label7.Size = new Size(124, 18);
			label7.TabIndex = 0;
			label7.Text = "Toplam Satış Adedi";
			// 
			// btnSiparisEkle
			// 
			btnSiparisEkle.Location = new Point(422, 175);
			btnSiparisEkle.Name = "btnSiparisEkle";
			btnSiparisEkle.Size = new Size(205, 43);
			btnSiparisEkle.TabIndex = 9;
			btnSiparisEkle.Text = "Siparis Ekle";
			btnSiparisEkle.UseVisualStyleBackColor = true;
			// 
			// grpOdemeYontemi
			// 
			grpOdemeYontemi.Controls.Add(rdbKrediKarti);
			grpOdemeYontemi.Controls.Add(rdbNakit);
			grpOdemeYontemi.Location = new Point(851, 330);
			grpOdemeYontemi.Name = "grpOdemeYontemi";
			grpOdemeYontemi.Size = new Size(232, 76);
			grpOdemeYontemi.TabIndex = 13;
			grpOdemeYontemi.TabStop = false;
			grpOdemeYontemi.Text = "Ödeme Yöntemi";
			// 
			// rdbKrediKarti
			// 
			rdbKrediKarti.AutoSize = true;
			rdbKrediKarti.Location = new Point(147, 32);
			rdbKrediKarti.Name = "rdbKrediKarti";
			rdbKrediKarti.Size = new Size(79, 19);
			rdbKrediKarti.TabIndex = 0;
			rdbKrediKarti.TabStop = true;
			rdbKrediKarti.Text = "Kredi Kartı";
			rdbKrediKarti.UseVisualStyleBackColor = true;
			// 
			// rdbNakit
			// 
			rdbNakit.AutoSize = true;
			rdbNakit.Location = new Point(6, 32);
			rdbNakit.Name = "rdbNakit";
			rdbNakit.Size = new Size(53, 19);
			rdbNakit.TabIndex = 0;
			rdbNakit.TabStop = true;
			rdbNakit.Text = "Nakit";
			rdbNakit.UseVisualStyleBackColor = true;
			// 
			// SaleScreen
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1095, 585);
			Controls.Add(grpOdemeYontemi);
			Controls.Add(grpFiyatAlani);
			Controls.Add(lstSiparisler);
			Controls.Add(label6);
			Controls.Add(grpUrunEkle);
			Controls.Add(lstArananUrunler);
			Controls.Add(btnSiparisEkle);
			Controls.Add(btnSiparisiTamamla);
			Controls.Add(txtUrunAra);
			Name = "SaleScreen";
			Text = "SaleScreen";
			grpUrunEkle.ResumeLayout(false);
			grpUrunEkle.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			grpFiyatAlani.ResumeLayout(false);
			grpFiyatAlani.PerformLayout();
			grpOdemeYontemi.ResumeLayout(false);
			grpOdemeYontemi.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private GroupBox grpUrunEkle;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label5;
		private Label label4;
		private NumericUpDown nmrStokAdedi;
		private NumericUpDown nmrBirimFiyat;
		private ComboBox cmbKategori;
		private ComboBox cmbBirim;
		private TextBox txtUrunAra;
		private ListView lstArananUrunler;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private Button btnSil;
		private Button btnGuncelle;
		private Button btnSiparisiTamamla;
		private Label label6;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader4;
		private ColumnHeader columnHeader5;
		private ListView lstSiparisler;
		private ColumnHeader columnHeader6;
		private ColumnHeader columnHeader7;
		private ColumnHeader columnHeader8;
		private ColumnHeader columnHeader9;
		private ColumnHeader columnHeader10;
		private ColumnHeader columnHeader11;
		private ColumnHeader columnHeader12;
		private GroupBox grpFiyatAlani;
		private Label label7;
		private ColumnHeader columnHeader14;
		private Label label8;
		private Label lblToplamFiyat;
		private Label lblToplamSatisAdedi;
		private NumericUpDown numericUpDown1;
		private Button btnSiparisEkle;
		private GroupBox grpOdemeYontemi;
		private RadioButton rdbKrediKarti;
		private RadioButton rdbNakit;
	}
}