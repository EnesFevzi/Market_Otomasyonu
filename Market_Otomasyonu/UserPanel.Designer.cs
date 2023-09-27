﻿namespace Market_Otomasyonu.UI
{
	partial class UserPanel
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
			btnRapor = new Button();
			btnUrunEkle = new Button();
			btnKategoriEkle = new Button();
			btnSatisEkrani = new Button();
			btnKullaniciPaneli = new Button();
			SuspendLayout();
			// 
			// btnRapor
			// 
			btnRapor.BackColor = Color.Red;
			btnRapor.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			btnRapor.Location = new Point(85, 30);
			btnRapor.Name = "btnRapor";
			btnRapor.Size = new Size(191, 75);
			btnRapor.TabIndex = 0;
			btnRapor.Text = "RAPOR";
			btnRapor.UseVisualStyleBackColor = false;
			btnRapor.Click += btnRapor_Click;
			// 
			// btnUrunEkle
			// 
			btnUrunEkle.BackColor = Color.Red;
			btnUrunEkle.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			btnUrunEkle.Location = new Point(85, 129);
			btnUrunEkle.Name = "btnUrunEkle";
			btnUrunEkle.Size = new Size(191, 75);
			btnUrunEkle.TabIndex = 0;
			btnUrunEkle.Text = "ÜRÜN EKLE";
			btnUrunEkle.UseVisualStyleBackColor = false;
			btnUrunEkle.Click += btnUrunEkle_Click;
			// 
			// btnKategoriEkle
			// 
			btnKategoriEkle.BackColor = Color.Red;
			btnKategoriEkle.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			btnKategoriEkle.Location = new Point(85, 228);
			btnKategoriEkle.Name = "btnKategoriEkle";
			btnKategoriEkle.Size = new Size(191, 75);
			btnKategoriEkle.TabIndex = 0;
			btnKategoriEkle.Text = "KATEGORİ EKLE";
			btnKategoriEkle.UseVisualStyleBackColor = false;
			btnKategoriEkle.Click += btnKategoriEkle_Click;
			// 
			// btnSatisEkrani
			// 
			btnSatisEkrani.BackColor = Color.Chartreuse;
			btnSatisEkrani.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			btnSatisEkrani.Location = new Point(85, 329);
			btnSatisEkrani.Name = "btnSatisEkrani";
			btnSatisEkrani.Size = new Size(191, 75);
			btnSatisEkrani.TabIndex = 0;
			btnSatisEkrani.Text = "SATIŞ EKRANI";
			btnSatisEkrani.UseVisualStyleBackColor = false;
			btnSatisEkrani.Click += btnSatisEkrani_Click;
			// 
			// btnKullaniciPaneli
			// 
			btnKullaniciPaneli.BackColor = Color.Orange;
			btnKullaniciPaneli.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			btnKullaniciPaneli.Location = new Point(85, 426);
			btnKullaniciPaneli.Name = "btnKullaniciPaneli";
			btnKullaniciPaneli.Size = new Size(191, 75);
			btnKullaniciPaneli.TabIndex = 0;
			btnKullaniciPaneli.Text = "KULLANICI PANELİ";
			btnKullaniciPaneli.UseVisualStyleBackColor = false;
			btnKullaniciPaneli.Click += btnKullaniciPaneli_Click;
			// 
			// UserPanel
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(373, 521);
			Controls.Add(btnSatisEkrani);
			Controls.Add(btnKategoriEkle);
			Controls.Add(btnUrunEkle);
			Controls.Add(btnKullaniciPaneli);
			Controls.Add(btnRapor);
			Name = "UserPanel";
			Text = "UserPanel";
			Load += UserPanel_Load;
			ResumeLayout(false);
		}

		#endregion

		private Button btnRapor;
		private Button btnUrunEkle;
		private Button btnKategoriEkle;
		private Button btnSatisEkrani;
		private Button btnKullaniciPaneli;
	}
}