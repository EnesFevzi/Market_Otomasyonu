namespace Market_Otomasyonu.UI
{
	partial class InvoıceScreen
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
			lstFatura = new ListView();
			columnHeader2 = new ColumnHeader();
			columnHeader4 = new ColumnHeader();
			columnHeader5 = new ColumnHeader();
			columnHeader6 = new ColumnHeader();
			columnHeader7 = new ColumnHeader();
			lblFaturaTutarı = new Label();
			SuspendLayout();
			// 
			// lstFatura
			// 
			lstFatura.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
			lstFatura.FullRowSelect = true;
			lstFatura.GridLines = true;
			lstFatura.Location = new Point(12, 41);
			lstFatura.Name = "lstFatura";
			lstFatura.Size = new Size(513, 341);
			lstFatura.TabIndex = 6;
			lstFatura.UseCompatibleStateImageBehavior = false;
			lstFatura.View = View.Details;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Ürün Adı";
			columnHeader2.Width = 100;
			// 
			// columnHeader4
			// 
			columnHeader4.Text = "Ürün Adedi";
			columnHeader4.Width = 100;
			// 
			// columnHeader5
			// 
			columnHeader5.Text = "Birim Fiyatı";
			columnHeader5.Width = 100;
			// 
			// columnHeader6
			// 
			columnHeader6.Text = "Satın Alınma Tarihi";
			columnHeader6.Width = 100;
			// 
			// columnHeader7
			// 
			columnHeader7.Text = "Ödeme Tipi";
			columnHeader7.Width = 100;
			// 
			// lblFaturaTutarı
			// 
			lblFaturaTutarı.BorderStyle = BorderStyle.Fixed3D;
			lblFaturaTutarı.FlatStyle = FlatStyle.Popup;
			lblFaturaTutarı.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblFaturaTutarı.Location = new Point(12, 411);
			lblFaturaTutarı.Name = "lblFaturaTutarı";
			lblFaturaTutarı.Size = new Size(513, 36);
			lblFaturaTutarı.TabIndex = 7;
			lblFaturaTutarı.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// InvoıceScreen
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(545, 499);
			Controls.Add(lblFaturaTutarı);
			Controls.Add(lstFatura);
			Name = "InvoıceScreen";
			Text = "InvoıceScreen";
			Load += InvoıceScreen_Load;
			ResumeLayout(false);
		}

		#endregion

		private ListView lstFatura;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader4;
		private ColumnHeader columnHeader5;
		private ColumnHeader columnHeader6;
		private ColumnHeader columnHeader7;
		private Label lblFaturaTutarı;
	}
}