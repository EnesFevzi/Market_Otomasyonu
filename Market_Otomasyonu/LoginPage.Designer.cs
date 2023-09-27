namespace Market_Otomasyonu.UI
{
	partial class LoginPage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
			grpGirisPaneli = new GroupBox();
			button3 = new Button();
			button2 = new Button();
			button1 = new Button();
			btnSifreyiGoster = new Button();
			label2 = new Label();
			label1 = new Label();
			txtSifre = new TextBox();
			txtKullaniciAdi = new TextBox();
			btnGirisYap = new Button();
			grpGirisPaneli.SuspendLayout();
			SuspendLayout();
			// 
			// grpGirisPaneli
			// 
			grpGirisPaneli.Controls.Add(button3);
			grpGirisPaneli.Controls.Add(button2);
			grpGirisPaneli.Controls.Add(button1);
			grpGirisPaneli.Controls.Add(btnSifreyiGoster);
			grpGirisPaneli.Controls.Add(label2);
			grpGirisPaneli.Controls.Add(label1);
			grpGirisPaneli.Controls.Add(txtSifre);
			grpGirisPaneli.Controls.Add(txtKullaniciAdi);
			grpGirisPaneli.Location = new Point(12, 12);
			grpGirisPaneli.Name = "grpGirisPaneli";
			grpGirisPaneli.Size = new Size(347, 147);
			grpGirisPaneli.TabIndex = 0;
			grpGirisPaneli.TabStop = false;
			grpGirisPaneli.Text = "Giriş Paneli";
			// 
			// button3
			// 
			button3.Location = new Point(0, 99);
			button3.Name = "button3";
			button3.Size = new Size(75, 23);
			button3.TabIndex = 3;
			button3.Text = "ebru";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button2
			// 
			button2.Location = new Point(0, 70);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 3;
			button2.Text = "ihsan";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.Location = new Point(0, 41);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 3;
			button1.Text = "enes";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// btnSifreyiGoster
			// 
			btnSifreyiGoster.BackgroundImage = (Image)resources.GetObject("btnSifreyiGoster.BackgroundImage");
			btnSifreyiGoster.BackgroundImageLayout = ImageLayout.Stretch;
			btnSifreyiGoster.Location = new Point(270, 107);
			btnSifreyiGoster.Name = "btnSifreyiGoster";
			btnSifreyiGoster.Size = new Size(32, 23);
			btnSifreyiGoster.TabIndex = 2;
			btnSifreyiGoster.UseVisualStyleBackColor = true;
			btnSifreyiGoster.MouseDown += btnSifreyiGoster_MouseDown;
			btnSifreyiGoster.MouseUp += btnSifreyiGoster_MouseUp;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Calibri", 12F, FontStyle.Italic, GraphicsUnit.Point);
			label2.Location = new Point(148, 76);
			label2.Name = "label2";
			label2.Size = new Size(38, 19);
			label2.TabIndex = 1;
			label2.Text = "Şifre";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Calibri", 12F, FontStyle.Italic, GraphicsUnit.Point);
			label1.Location = new Point(119, 19);
			label1.Name = "label1";
			label1.Size = new Size(89, 19);
			label1.TabIndex = 1;
			label1.Text = "Kullanıcı Adı";
			// 
			// txtSifre
			// 
			txtSifre.Location = new Point(82, 107);
			txtSifre.Name = "txtSifre";
			txtSifre.PasswordChar = '*';
			txtSifre.Size = new Size(182, 23);
			txtSifre.TabIndex = 0;
			// 
			// txtKullaniciAdi
			// 
			txtKullaniciAdi.Location = new Point(82, 41);
			txtKullaniciAdi.Name = "txtKullaniciAdi";
			txtKullaniciAdi.Size = new Size(182, 23);
			txtKullaniciAdi.TabIndex = 0;
			// 
			// btnGirisYap
			// 
			btnGirisYap.BackColor = Color.LightGreen;
			btnGirisYap.Font = new Font("Calibri", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
			btnGirisYap.Location = new Point(12, 179);
			btnGirisYap.Name = "btnGirisYap";
			btnGirisYap.Size = new Size(349, 49);
			btnGirisYap.TabIndex = 5;
			btnGirisYap.Text = "GİRİŞ YAP";
			btnGirisYap.UseVisualStyleBackColor = false;
			btnGirisYap.Click += btnGirisYap_Click;
			// 
			// LoginPage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(373, 240);
			Controls.Add(btnGirisYap);
			Controls.Add(grpGirisPaneli);
			Name = "LoginPage";
			Text = "LoginPage";
			grpGirisPaneli.ResumeLayout(false);
			grpGirisPaneli.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox grpGirisPaneli;
		private TextBox txtKullaniciAdi;
		private Label label1;
		private Label label2;
		private TextBox txtSifre;
		private Button btnGirisYap;
		private Button btnSifreyiGoster;
		private Button button1;
		private Button button3;
		private Button button2;
	}
}