namespace Market_Otomasyonu.UI
{
	partial class AddCategory
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
			grpKategoriEkle = new GroupBox();
			label1 = new Label();
			txtKategoriAdi = new TextBox();
			btnKaydet = new Button();
			btnGuncelle = new Button();
			btnSil = new Button();
			lstKategoriler = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			grpKategoriEkle.SuspendLayout();
			SuspendLayout();
			// 
			// grpKategoriEkle
			// 
			grpKategoriEkle.Controls.Add(label1);
			grpKategoriEkle.Controls.Add(txtKategoriAdi);
			grpKategoriEkle.Controls.Add(btnKaydet);
			grpKategoriEkle.Controls.Add(btnGuncelle);
			grpKategoriEkle.Controls.Add(btnSil);
			grpKategoriEkle.Location = new Point(3, 7);
			grpKategoriEkle.Name = "grpKategoriEkle";
			grpKategoriEkle.Size = new Size(309, 119);
			grpKategoriEkle.TabIndex = 11;
			grpKategoriEkle.TabStop = false;
			grpKategoriEkle.Text = "Kategori Ekleme Sayfası";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(17, 31);
			label1.Name = "label1";
			label1.Size = new Size(83, 18);
			label1.TabIndex = 0;
			label1.Text = "Kategori Adı";
			// 
			// txtKategoriAdi
			// 
			txtKategoriAdi.Location = new Point(107, 30);
			txtKategoriAdi.Name = "txtKategoriAdi";
			txtKategoriAdi.Size = new Size(188, 23);
			txtKategoriAdi.TabIndex = 1;
			// 
			// btnKaydet
			// 
			btnKaydet.Location = new Point(58, 78);
			btnKaydet.Name = "btnKaydet";
			btnKaydet.Size = new Size(75, 23);
			btnKaydet.TabIndex = 9;
			btnKaydet.Text = "Kaydet";
			btnKaydet.UseVisualStyleBackColor = true;
			btnKaydet.Click += btnKaydet_Click;
			// 
			// btnGuncelle
			// 
			btnGuncelle.Location = new Point(139, 78);
			btnGuncelle.Name = "btnGuncelle";
			btnGuncelle.Size = new Size(75, 23);
			btnGuncelle.TabIndex = 8;
			btnGuncelle.Text = "Güncelle";
			btnGuncelle.UseVisualStyleBackColor = true;
			btnGuncelle.Click += btnGuncelle_Click;
			// 
			// btnSil
			// 
			btnSil.Location = new Point(220, 78);
			btnSil.Name = "btnSil";
			btnSil.Size = new Size(75, 23);
			btnSil.TabIndex = 7;
			btnSil.Text = "Sil";
			btnSil.UseVisualStyleBackColor = true;
			btnSil.Click += btnSil_Click;
			// 
			// lstKategoriler
			// 
			lstKategoriler.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
			lstKategoriler.FullRowSelect = true;
			lstKategoriler.GridLines = true;
			lstKategoriler.Location = new Point(3, 132);
			lstKategoriler.Name = "lstKategoriler";
			lstKategoriler.Size = new Size(309, 240);
			lstKategoriler.TabIndex = 10;
			lstKategoriler.UseCompatibleStateImageBehavior = false;
			lstKategoriler.View = View.Details;
			lstKategoriler.SelectedIndexChanged += lstKategoriler_SelectedIndexChanged;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "ID";
			columnHeader1.Width = 100;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Kategori Adı";
			columnHeader2.Width = 100;
			// 
			// AddCategory
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(323, 378);
			Controls.Add(grpKategoriEkle);
			Controls.Add(lstKategoriler);
			Name = "AddCategory";
			Text = "AddCategory";
			Load += AddCategory_Load;
			grpKategoriEkle.ResumeLayout(false);
			grpKategoriEkle.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox grpKategoriEkle;
		private Label label1;
		private TextBox txtKategoriAdi;
		private Button btnKaydet;
		private Button btnGuncelle;
		private Button btnSil;
		private ListView lstKategoriler;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
	}
}