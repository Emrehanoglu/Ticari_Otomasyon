namespace Ticari_Otomasyon
{
	partial class FrmAdmin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
			this.label1 = new System.Windows.Forms.Label();
			this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
			this.txtSifre = new DevExpress.XtraEditors.TextEdit();
			this.label2 = new System.Windows.Forms.Label();
			this.btnGirisYap = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(313, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kullanıcı Adı :";
			// 
			// txtKullaniciAdi
			// 
			this.txtKullaniciAdi.Location = new System.Drawing.Point(438, 61);
			this.txtKullaniciAdi.Name = "txtKullaniciAdi";
			this.txtKullaniciAdi.Properties.Appearance.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtKullaniciAdi.Properties.Appearance.Options.UseFont = true;
			this.txtKullaniciAdi.Size = new System.Drawing.Size(117, 26);
			this.txtKullaniciAdi.TabIndex = 1;
			// 
			// txtSifre
			// 
			this.txtSifre.Location = new System.Drawing.Point(438, 103);
			this.txtSifre.Name = "txtSifre";
			this.txtSifre.Properties.Appearance.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSifre.Properties.Appearance.Options.UseFont = true;
			this.txtSifre.Properties.Mask.EditMask = "asd";
			this.txtSifre.Properties.UseSystemPasswordChar = true;
			this.txtSifre.Size = new System.Drawing.Size(117, 26);
			this.txtSifre.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(377, 105);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Şifre :";
			// 
			// btnGirisYap
			// 
			this.btnGirisYap.BackColor = System.Drawing.Color.Black;
			this.btnGirisYap.BackgroundImage = global::Ticari_Otomasyon.Properties.Resources._1327844;
			this.btnGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGirisYap.ForeColor = System.Drawing.SystemColors.Control;
			this.btnGirisYap.Location = new System.Drawing.Point(447, 145);
			this.btnGirisYap.Name = "btnGirisYap";
			this.btnGirisYap.Size = new System.Drawing.Size(99, 28);
			this.btnGirisYap.TabIndex = 4;
			this.btnGirisYap.Text = "Giriş Yap";
			this.btnGirisYap.UseVisualStyleBackColor = false;
			this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
			// 
			// FrmAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(573, 487);
			this.Controls.Add(this.btnGirisYap);
			this.Controls.Add(this.txtSifre);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtKullaniciAdi);
			this.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmAdmin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmAdmin";
			this.Load += new System.EventHandler(this.FrmAdmin_Load);
			((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
		private DevExpress.XtraEditors.TextEdit txtSifre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnGirisYap;
	}
}