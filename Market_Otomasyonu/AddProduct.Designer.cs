namespace Market_Otomasyonu
{
	partial class AddProduct
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			txtUrunAdi = new TextBox();
			cmbKategori = new ComboBox();
			cmbBirim = new ComboBox();
			nmrBirimFiyat = new NumericUpDown();
			nmrStokAdedi = new NumericUpDown();
			btnKaydet = new Button();
			btnGuncelle = new Button();
			btnSil = new Button();
			lstUrunler = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			columnHeader3 = new ColumnHeader();
			columnHeader4 = new ColumnHeader();
			columnHeader5 = new ColumnHeader();
			columnHeader6 = new ColumnHeader();
			columnHeader7 = new ColumnHeader();
			columnHeader8 = new ColumnHeader();
			grpUrunEkle = new GroupBox();
			((System.ComponentModel.ISupportInitialize)nmrBirimFiyat).BeginInit();
			((System.ComponentModel.ISupportInitialize)nmrStokAdedi).BeginInit();
			grpUrunEkle.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(17, 31);
			label1.Name = "label1";
			label1.Size = new Size(61, 18);
			label1.TabIndex = 0;
			label1.Text = "Ürün Adı";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(17, 70);
			label2.Name = "label2";
			label2.Size = new Size(60, 18);
			label2.TabIndex = 0;
			label2.Text = "Kategori";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(17, 154);
			label3.Name = "label3";
			label3.Size = new Size(77, 18);
			label3.TabIndex = 0;
			label3.Text = "Birim Fiyatı";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(17, 113);
			label4.Name = "label4";
			label4.Size = new Size(45, 18);
			label4.TabIndex = 0;
			label4.Text = "Birimi";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(17, 194);
			label5.Name = "label5";
			label5.Size = new Size(75, 18);
			label5.TabIndex = 0;
			label5.Text = "Stok Adedi";
			// 
			// txtUrunAdi
			// 
			txtUrunAdi.Location = new Point(107, 30);
			txtUrunAdi.Name = "txtUrunAdi";
			txtUrunAdi.Size = new Size(188, 23);
			txtUrunAdi.TabIndex = 1;
			// 
			// cmbKategori
			// 
			cmbKategori.FormattingEnabled = true;
			cmbKategori.Location = new Point(107, 70);
			cmbKategori.Name = "cmbKategori";
			cmbKategori.Size = new Size(188, 23);
			cmbKategori.TabIndex = 2;
			// 
			// cmbBirim
			// 
			cmbBirim.FormattingEnabled = true;
			cmbBirim.Location = new Point(107, 112);
			cmbBirim.Name = "cmbBirim";
			cmbBirim.Size = new Size(188, 23);
			cmbBirim.TabIndex = 2;
			// 
			// nmrBirimFiyat
			// 
			nmrBirimFiyat.Location = new Point(107, 154);
			nmrBirimFiyat.Name = "nmrBirimFiyat";
			nmrBirimFiyat.Size = new Size(188, 23);
			nmrBirimFiyat.TabIndex = 3;
			// 
			// nmrStokAdedi
			// 
			nmrStokAdedi.Location = new Point(107, 189);
			nmrStokAdedi.Name = "nmrStokAdedi";
			nmrStokAdedi.Size = new Size(188, 23);
			nmrStokAdedi.TabIndex = 3;
			// 
			// btnKaydet
			// 
			btnKaydet.Location = new Point(341, 226);
			btnKaydet.Name = "btnKaydet";
			btnKaydet.Size = new Size(75, 23);
			btnKaydet.TabIndex = 4;
			btnKaydet.Text = "Kaydet";
			btnKaydet.UseVisualStyleBackColor = true;
			// 
			// btnGuncelle
			// 
			btnGuncelle.Location = new Point(341, 197);
			btnGuncelle.Name = "btnGuncelle";
			btnGuncelle.Size = new Size(75, 23);
			btnGuncelle.TabIndex = 4;
			btnGuncelle.Text = "Güncelle";
			btnGuncelle.UseVisualStyleBackColor = true;
			// 
			// btnSil
			// 
			btnSil.Location = new Point(341, 168);
			btnSil.Name = "btnSil";
			btnSil.Size = new Size(75, 23);
			btnSil.TabIndex = 4;
			btnSil.Text = "Sil";
			btnSil.UseVisualStyleBackColor = true;
			// 
			// lstUrunler
			// 
			lstUrunler.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
			lstUrunler.FullRowSelect = true;
			lstUrunler.GridLines = true;
			lstUrunler.Location = new Point(12, 267);
			lstUrunler.Name = "lstUrunler";
			lstUrunler.Size = new Size(813, 341);
			lstUrunler.TabIndex = 5;
			lstUrunler.UseCompatibleStateImageBehavior = false;
			lstUrunler.View = View.Details;
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
			// columnHeader3
			// 
			columnHeader3.Text = "Kategori";
			columnHeader3.Width = 100;
			// 
			// columnHeader4
			// 
			columnHeader4.Text = "Birimi";
			columnHeader4.Width = 100;
			// 
			// columnHeader5
			// 
			columnHeader5.Text = "Birim Fiyatı";
			columnHeader5.Width = 100;
			// 
			// columnHeader6
			// 
			columnHeader6.Text = "Stok Adedi";
			columnHeader6.Width = 100;
			// 
			// columnHeader7
			// 
			columnHeader7.Text = "Tarih";
			columnHeader7.Width = 100;
			// 
			// columnHeader8
			// 
			columnHeader8.Text = "Satışa Açık Mı ?";
			columnHeader8.Width = 100;
			// 
			// grpUrunEkle
			// 
			grpUrunEkle.Controls.Add(label1);
			grpUrunEkle.Controls.Add(label2);
			grpUrunEkle.Controls.Add(label3);
			grpUrunEkle.Controls.Add(label5);
			grpUrunEkle.Controls.Add(label4);
			grpUrunEkle.Controls.Add(nmrStokAdedi);
			grpUrunEkle.Controls.Add(txtUrunAdi);
			grpUrunEkle.Controls.Add(nmrBirimFiyat);
			grpUrunEkle.Controls.Add(cmbKategori);
			grpUrunEkle.Controls.Add(cmbBirim);
			grpUrunEkle.Location = new Point(12, 12);
			grpUrunEkle.Name = "grpUrunEkle";
			grpUrunEkle.Size = new Size(309, 237);
			grpUrunEkle.TabIndex = 6;
			grpUrunEkle.TabStop = false;
			grpUrunEkle.Text = "Ürün Ekleme Sayfası";
			// 
			// AddProduct
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(829, 620);
			Controls.Add(grpUrunEkle);
			Controls.Add(lstUrunler);
			Controls.Add(btnSil);
			Controls.Add(btnGuncelle);
			Controls.Add(btnKaydet);
			Name = "AddProduct";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)nmrBirimFiyat).EndInit();
			((System.ComponentModel.ISupportInitialize)nmrStokAdedi).EndInit();
			grpUrunEkle.ResumeLayout(false);
			grpUrunEkle.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private TextBox txtUrunAdi;
		private ComboBox cmbKategori;
		private ComboBox cmbBirim;
		private NumericUpDown nmrBirimFiyat;
		private NumericUpDown nmrStokAdedi;
		private Button btnKaydet;
		private Button btnGuncelle;
		private Button btnSil;
		private ListView lstUrunler;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader4;
		private ColumnHeader columnHeader5;
		private ColumnHeader columnHeader6;
		private ColumnHeader columnHeader7;
		private ColumnHeader columnHeader8;
		private GroupBox grpUrunEkle;
	}
}