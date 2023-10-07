namespace Ticari_Otomasyon
{
	partial class FrmBankalar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBankalar));
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.cmBoxİlçe = new DevExpress.XtraEditors.ComboBoxEdit();
			this.cmBoxİl = new DevExpress.XtraEditors.ComboBoxEdit();
			this.txtYetkili = new DevExpress.XtraEditors.TextEdit();
			this.maskTxtTarih = new System.Windows.Forms.MaskedTextBox();
			this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
			this.txtHesapTürü = new DevExpress.XtraEditors.TextEdit();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.txtHesapNo = new DevExpress.XtraEditors.TextEdit();
			this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.txtIban = new DevExpress.XtraEditors.TextEdit();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.txtSube = new DevExpress.XtraEditors.TextEdit();
			this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
			this.btnSil = new DevExpress.XtraEditors.SimpleButton();
			this.maskTxtTelefon = new System.Windows.Forms.MaskedTextBox();
			this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.SatışFiyat = new DevExpress.XtraEditors.LabelControl();
			this.AlışFiyat = new DevExpress.XtraEditors.LabelControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.txtBankaAd = new DevExpress.XtraEditors.TextEdit();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.txtId = new DevExpress.XtraEditors.TextEdit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmBoxİlçe.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmBoxİl.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtYetkili.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtHesapTürü.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtHesapNo.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtIban.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSube.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBankaAd.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowGroupPanel = false;
			this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
			// 
			// gridControl1
			// 
			this.gridControl1.Location = new System.Drawing.Point(1, 1);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(745, 786);
			this.gridControl1.TabIndex = 4;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// cmBoxİlçe
			// 
			this.cmBoxİlçe.Location = new System.Drawing.Point(78, 128);
			this.cmBoxİlçe.Name = "cmBoxİlçe";
			this.cmBoxİlçe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cmBoxİlçe.Size = new System.Drawing.Size(100, 20);
			this.cmBoxİlçe.TabIndex = 33;
			// 
			// cmBoxİl
			// 
			this.cmBoxİl.Location = new System.Drawing.Point(78, 101);
			this.cmBoxİl.Name = "cmBoxİl";
			this.cmBoxİl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cmBoxİl.Size = new System.Drawing.Size(100, 20);
			this.cmBoxİl.TabIndex = 32;
			this.cmBoxİl.SelectedIndexChanged += new System.EventHandler(this.cmBoxİl_SelectedIndexChanged);
			// 
			// txtYetkili
			// 
			this.txtYetkili.Location = new System.Drawing.Point(79, 240);
			this.txtYetkili.Name = "txtYetkili";
			this.txtYetkili.Size = new System.Drawing.Size(100, 20);
			this.txtYetkili.TabIndex = 31;
			// 
			// maskTxtTarih
			// 
			this.maskTxtTarih.Location = new System.Drawing.Point(79, 297);
			this.maskTxtTarih.Mask = "00/00/0000";
			this.maskTxtTarih.Name = "maskTxtTarih";
			this.maskTxtTarih.Size = new System.Drawing.Size(99, 21);
			this.maskTxtTarih.TabIndex = 30;
			this.maskTxtTarih.ValidatingType = typeof(System.DateTime);
			// 
			// labelControl8
			// 
			this.labelControl8.Location = new System.Drawing.Point(10, 328);
			this.labelControl8.Name = "labelControl8";
			this.labelControl8.Size = new System.Drawing.Size(62, 13);
			this.labelControl8.TabIndex = 27;
			this.labelControl8.Text = "Hesap Türü :";
			// 
			// labelControl9
			// 
			this.labelControl9.Location = new System.Drawing.Point(39, 354);
			this.labelControl9.Name = "labelControl9";
			this.labelControl9.Size = new System.Drawing.Size(33, 13);
			this.labelControl9.TabIndex = 26;
			this.labelControl9.Text = "Firma :";
			// 
			// txtHesapTürü
			// 
			this.txtHesapTürü.Location = new System.Drawing.Point(78, 325);
			this.txtHesapTürü.Name = "txtHesapTürü";
			this.txtHesapTürü.Size = new System.Drawing.Size(100, 20);
			this.txtHesapTürü.TabIndex = 25;
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.labelControl10);
			this.groupControl1.Controls.Add(this.txtHesapNo);
			this.groupControl1.Controls.Add(this.lookUpEdit1);
			this.groupControl1.Controls.Add(this.labelControl6);
			this.groupControl1.Controls.Add(this.txtIban);
			this.groupControl1.Controls.Add(this.labelControl3);
			this.groupControl1.Controls.Add(this.txtSube);
			this.groupControl1.Controls.Add(this.cmBoxİlçe);
			this.groupControl1.Controls.Add(this.cmBoxİl);
			this.groupControl1.Controls.Add(this.txtYetkili);
			this.groupControl1.Controls.Add(this.maskTxtTarih);
			this.groupControl1.Controls.Add(this.labelControl8);
			this.groupControl1.Controls.Add(this.labelControl9);
			this.groupControl1.Controls.Add(this.txtHesapTürü);
			this.groupControl1.Controls.Add(this.btnGuncelle);
			this.groupControl1.Controls.Add(this.btnSil);
			this.groupControl1.Controls.Add(this.maskTxtTelefon);
			this.groupControl1.Controls.Add(this.btnKaydet);
			this.groupControl1.Controls.Add(this.labelControl7);
			this.groupControl1.Controls.Add(this.SatışFiyat);
			this.groupControl1.Controls.Add(this.AlışFiyat);
			this.groupControl1.Controls.Add(this.labelControl4);
			this.groupControl1.Controls.Add(this.labelControl5);
			this.groupControl1.Controls.Add(this.labelControl2);
			this.groupControl1.Controls.Add(this.txtBankaAd);
			this.groupControl1.Controls.Add(this.labelControl1);
			this.groupControl1.Controls.Add(this.txtId);
			this.groupControl1.Location = new System.Drawing.Point(752, 1);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(220, 786);
			this.groupControl1.TabIndex = 5;
			this.groupControl1.Text = "Müşteriler";
			// 
			// labelControl10
			// 
			this.labelControl10.Location = new System.Drawing.Point(19, 214);
			this.labelControl10.Name = "labelControl10";
			this.labelControl10.Size = new System.Drawing.Size(53, 13);
			this.labelControl10.TabIndex = 41;
			this.labelControl10.Text = "Hesap No :";
			// 
			// txtHesapNo
			// 
			this.txtHesapNo.Location = new System.Drawing.Point(78, 211);
			this.txtHesapNo.Name = "txtHesapNo";
			this.txtHesapNo.Size = new System.Drawing.Size(100, 20);
			this.txtHesapNo.TabIndex = 40;
			// 
			// lookUpEdit1
			// 
			this.lookUpEdit1.Location = new System.Drawing.Point(79, 351);
			this.lookUpEdit1.Name = "lookUpEdit1";
			this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.lookUpEdit1.Properties.DisplayMember = "Ad";
			this.lookUpEdit1.Properties.NullText = "Firma Seçiniz";
			this.lookUpEdit1.Properties.ValueMember = "Id";
			this.lookUpEdit1.Size = new System.Drawing.Size(99, 20);
			this.lookUpEdit1.TabIndex = 39;
			// 
			// labelControl6
			// 
			this.labelControl6.Location = new System.Drawing.Point(43, 185);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(29, 13);
			this.labelControl6.TabIndex = 38;
			this.labelControl6.Text = "Iban :";
			// 
			// txtIban
			// 
			this.txtIban.Location = new System.Drawing.Point(78, 182);
			this.txtIban.Name = "txtIban";
			this.txtIban.Size = new System.Drawing.Size(100, 20);
			this.txtIban.TabIndex = 37;
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(41, 158);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(31, 13);
			this.labelControl3.TabIndex = 36;
			this.labelControl3.Text = "Şube :";
			// 
			// txtSube
			// 
			this.txtSube.Location = new System.Drawing.Point(78, 155);
			this.txtSube.Name = "txtSube";
			this.txtSube.Size = new System.Drawing.Size(100, 20);
			this.txtSube.TabIndex = 35;
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
			this.btnGuncelle.Location = new System.Drawing.Point(78, 521);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(100, 36);
			this.btnGuncelle.TabIndex = 23;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnSil
			// 
			this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
			this.btnSil.Location = new System.Drawing.Point(79, 462);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(100, 36);
			this.btnSil.TabIndex = 22;
			this.btnSil.Text = "Sil";
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// maskTxtTelefon
			// 
			this.maskTxtTelefon.Location = new System.Drawing.Point(79, 268);
			this.maskTxtTelefon.Mask = "(999) 000-0000";
			this.maskTxtTelefon.Name = "maskTxtTelefon";
			this.maskTxtTelefon.Size = new System.Drawing.Size(100, 21);
			this.maskTxtTelefon.TabIndex = 21;
			// 
			// btnKaydet
			// 
			this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
			this.btnKaydet.Location = new System.Drawing.Point(78, 401);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(100, 36);
			this.btnKaydet.TabIndex = 20;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// labelControl7
			// 
			this.labelControl7.Location = new System.Drawing.Point(48, 131);
			this.labelControl7.Name = "labelControl7";
			this.labelControl7.Size = new System.Drawing.Size(24, 13);
			this.labelControl7.TabIndex = 17;
			this.labelControl7.Text = "İlçe :";
			// 
			// SatışFiyat
			// 
			this.SatışFiyat.Location = new System.Drawing.Point(59, 104);
			this.SatışFiyat.Name = "SatışFiyat";
			this.SatışFiyat.Size = new System.Drawing.Size(13, 13);
			this.SatışFiyat.TabIndex = 15;
			this.SatışFiyat.Text = "İl :";
			// 
			// AlışFiyat
			// 
			this.AlışFiyat.Location = new System.Drawing.Point(38, 243);
			this.AlışFiyat.Name = "AlışFiyat";
			this.AlışFiyat.Size = new System.Drawing.Size(34, 13);
			this.AlışFiyat.TabIndex = 13;
			this.AlışFiyat.Text = "Yetkili :";
			// 
			// labelControl4
			// 
			this.labelControl4.Location = new System.Drawing.Point(41, 300);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(31, 13);
			this.labelControl4.TabIndex = 11;
			this.labelControl4.Text = "Tarih :";
			// 
			// labelControl5
			// 
			this.labelControl5.Location = new System.Drawing.Point(29, 271);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(43, 13);
			this.labelControl5.TabIndex = 9;
			this.labelControl5.Text = "Telefon :";
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(18, 78);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(54, 13);
			this.labelControl2.TabIndex = 3;
			this.labelControl2.Text = "Banka Adı :";
			// 
			// txtBankaAd
			// 
			this.txtBankaAd.Location = new System.Drawing.Point(78, 75);
			this.txtBankaAd.Name = "txtBankaAd";
			this.txtBankaAd.Size = new System.Drawing.Size(100, 20);
			this.txtBankaAd.TabIndex = 2;
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(55, 52);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(17, 13);
			this.labelControl1.TabIndex = 1;
			this.labelControl1.Text = "Id :";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(78, 49);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(100, 20);
			this.txtId.TabIndex = 0;
			// 
			// FrmBankalar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(973, 791);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.gridControl1);
			this.Name = "FrmBankalar";
			this.Text = "FrmBankalar";
			this.Load += new System.EventHandler(this.FrmBankalar_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmBoxİlçe.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmBoxİl.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtYetkili.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtHesapTürü.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtHesapNo.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtIban.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSube.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBankaAd.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraEditors.ComboBoxEdit cmBoxİlçe;
		private DevExpress.XtraEditors.ComboBoxEdit cmBoxİl;
		private DevExpress.XtraEditors.TextEdit txtYetkili;
		private System.Windows.Forms.MaskedTextBox maskTxtTarih;
		private DevExpress.XtraEditors.LabelControl labelControl8;
		private DevExpress.XtraEditors.LabelControl labelControl9;
		private DevExpress.XtraEditors.TextEdit txtHesapTürü;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraEditors.SimpleButton btnGuncelle;
		private DevExpress.XtraEditors.SimpleButton btnSil;
		private System.Windows.Forms.MaskedTextBox maskTxtTelefon;
		private DevExpress.XtraEditors.SimpleButton btnKaydet;
		private DevExpress.XtraEditors.LabelControl labelControl7;
		private DevExpress.XtraEditors.LabelControl SatışFiyat;
		private DevExpress.XtraEditors.LabelControl AlışFiyat;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.TextEdit txtBankaAd;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.TextEdit txtId;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.TextEdit txtSube;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private DevExpress.XtraEditors.TextEdit txtIban;
		private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
		private DevExpress.XtraEditors.LabelControl labelControl10;
		private DevExpress.XtraEditors.TextEdit txtHesapNo;
	}
}