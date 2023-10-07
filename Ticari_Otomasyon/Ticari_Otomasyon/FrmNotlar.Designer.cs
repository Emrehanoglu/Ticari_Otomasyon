namespace Ticari_Otomasyon
{
	partial class FrmNotlar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotlar));
			this.richTxtDetay = new System.Windows.Forms.RichTextBox();
			this.txtBaslik = new DevExpress.XtraEditors.TextEdit();
			this.maskTxtTarih = new System.Windows.Forms.MaskedTextBox();
			this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
			this.txtHitap = new DevExpress.XtraEditors.TextEdit();
			this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
			this.btnSil = new DevExpress.XtraEditors.SimpleButton();
			this.maskTxtSaat = new System.Windows.Forms.MaskedTextBox();
			this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
			this.AlışFiyat = new DevExpress.XtraEditors.LabelControl();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.txtId = new DevExpress.XtraEditors.TextEdit();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
			this.txtOlusturan = new DevExpress.XtraEditors.TextEdit();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.txtBaslik.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtHitap.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtOlusturan.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// richTxtDetay
			// 
			this.richTxtDetay.Location = new System.Drawing.Point(78, 249);
			this.richTxtDetay.Name = "richTxtDetay";
			this.richTxtDetay.Size = new System.Drawing.Size(100, 96);
			this.richTxtDetay.TabIndex = 34;
			this.richTxtDetay.Text = "";
			// 
			// txtBaslik
			// 
			this.txtBaslik.Location = new System.Drawing.Point(78, 149);
			this.txtBaslik.Name = "txtBaslik";
			this.txtBaslik.Size = new System.Drawing.Size(100, 20);
			this.txtBaslik.TabIndex = 31;
			// 
			// maskTxtTarih
			// 
			this.maskTxtTarih.Location = new System.Drawing.Point(78, 82);
			this.maskTxtTarih.Mask = "00/00/0000";
			this.maskTxtTarih.Name = "maskTxtTarih";
			this.maskTxtTarih.Size = new System.Drawing.Size(100, 21);
			this.maskTxtTarih.TabIndex = 29;
			this.maskTxtTarih.ValidatingType = typeof(System.DateTime);
			// 
			// labelControl8
			// 
			this.labelControl8.Location = new System.Drawing.Point(38, 216);
			this.labelControl8.Name = "labelControl8";
			this.labelControl8.Size = new System.Drawing.Size(32, 13);
			this.labelControl8.TabIndex = 27;
			this.labelControl8.Text = "Hitap :";
			// 
			// labelControl9
			// 
			this.labelControl9.Location = new System.Drawing.Point(34, 249);
			this.labelControl9.Name = "labelControl9";
			this.labelControl9.Size = new System.Drawing.Size(36, 13);
			this.labelControl9.TabIndex = 26;
			this.labelControl9.Text = "Detay :";
			// 
			// txtHitap
			// 
			this.txtHitap.Location = new System.Drawing.Point(78, 213);
			this.txtHitap.Name = "txtHitap";
			this.txtHitap.Size = new System.Drawing.Size(100, 20);
			this.txtHitap.TabIndex = 25;
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
			this.btnGuncelle.Location = new System.Drawing.Point(78, 502);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(100, 36);
			this.btnGuncelle.TabIndex = 23;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnSil
			// 
			this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
			this.btnSil.Location = new System.Drawing.Point(78, 444);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(100, 36);
			this.btnSil.TabIndex = 22;
			this.btnSil.Text = "Sil";
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// maskTxtSaat
			// 
			this.maskTxtSaat.Location = new System.Drawing.Point(78, 115);
			this.maskTxtSaat.Mask = "00:00";
			this.maskTxtSaat.Name = "maskTxtSaat";
			this.maskTxtSaat.Size = new System.Drawing.Size(100, 21);
			this.maskTxtSaat.TabIndex = 21;
			this.maskTxtSaat.ValidatingType = typeof(System.DateTime);
			// 
			// btnKaydet
			// 
			this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
			this.btnKaydet.Location = new System.Drawing.Point(78, 385);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(100, 36);
			this.btnKaydet.TabIndex = 20;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// AlışFiyat
			// 
			this.AlışFiyat.Location = new System.Drawing.Point(37, 152);
			this.AlışFiyat.Name = "AlışFiyat";
			this.AlışFiyat.Size = new System.Drawing.Size(33, 13);
			this.AlışFiyat.TabIndex = 13;
			this.AlışFiyat.Text = "Başlık :";
			// 
			// labelControl5
			// 
			this.labelControl5.Location = new System.Drawing.Point(41, 118);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(29, 13);
			this.labelControl5.TabIndex = 9;
			this.labelControl5.Text = "Saat :";
			// 
			// labelControl6
			// 
			this.labelControl6.Location = new System.Drawing.Point(39, 85);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(31, 13);
			this.labelControl6.TabIndex = 7;
			this.labelControl6.Text = "Tarih :";
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowGroupPanel = false;
			this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
			this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
			// 
			// gridControl1
			// 
			this.gridControl1.Location = new System.Drawing.Point(1, 1);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(744, 788);
			this.gridControl1.TabIndex = 4;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(53, 52);
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
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.btnTemizle);
			this.groupControl1.Controls.Add(this.txtOlusturan);
			this.groupControl1.Controls.Add(this.labelControl2);
			this.groupControl1.Controls.Add(this.richTxtDetay);
			this.groupControl1.Controls.Add(this.txtBaslik);
			this.groupControl1.Controls.Add(this.maskTxtTarih);
			this.groupControl1.Controls.Add(this.labelControl8);
			this.groupControl1.Controls.Add(this.labelControl9);
			this.groupControl1.Controls.Add(this.txtHitap);
			this.groupControl1.Controls.Add(this.btnGuncelle);
			this.groupControl1.Controls.Add(this.btnSil);
			this.groupControl1.Controls.Add(this.maskTxtSaat);
			this.groupControl1.Controls.Add(this.btnKaydet);
			this.groupControl1.Controls.Add(this.AlışFiyat);
			this.groupControl1.Controls.Add(this.labelControl5);
			this.groupControl1.Controls.Add(this.labelControl6);
			this.groupControl1.Controls.Add(this.labelControl1);
			this.groupControl1.Controls.Add(this.txtId);
			this.groupControl1.Location = new System.Drawing.Point(751, 1);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(220, 788);
			this.groupControl1.TabIndex = 5;
			this.groupControl1.Text = "Müşteriler";
			// 
			// btnTemizle
			// 
			this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
			this.btnTemizle.Location = new System.Drawing.Point(78, 553);
			this.btnTemizle.Name = "btnTemizle";
			this.btnTemizle.Size = new System.Drawing.Size(100, 36);
			this.btnTemizle.TabIndex = 37;
			this.btnTemizle.Text = "Temizle";
			this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
			// 
			// txtOlusturan
			// 
			this.txtOlusturan.Location = new System.Drawing.Point(78, 182);
			this.txtOlusturan.Name = "txtOlusturan";
			this.txtOlusturan.Size = new System.Drawing.Size(100, 20);
			this.txtOlusturan.TabIndex = 36;
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(16, 185);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(54, 13);
			this.labelControl2.TabIndex = 35;
			this.labelControl2.Text = "Oluşturan :";
			// 
			// FrmNotlar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(973, 791);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.gridControl1);
			this.Name = "FrmNotlar";
			this.Text = "FrmNotlar";
			this.Load += new System.EventHandler(this.FrmNotlar_Load);
			((System.ComponentModel.ISupportInitialize)(this.txtBaslik.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtHitap.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtOlusturan.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTxtDetay;
		private DevExpress.XtraEditors.TextEdit txtBaslik;
		private System.Windows.Forms.MaskedTextBox maskTxtTarih;
		private DevExpress.XtraEditors.LabelControl labelControl8;
		private DevExpress.XtraEditors.LabelControl labelControl9;
		private DevExpress.XtraEditors.TextEdit txtHitap;
		private DevExpress.XtraEditors.SimpleButton btnGuncelle;
		private DevExpress.XtraEditors.SimpleButton btnSil;
		private System.Windows.Forms.MaskedTextBox maskTxtSaat;
		private DevExpress.XtraEditors.SimpleButton btnKaydet;
		private DevExpress.XtraEditors.LabelControl AlışFiyat;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.TextEdit txtId;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraEditors.SimpleButton btnTemizle;
		private DevExpress.XtraEditors.TextEdit txtOlusturan;
		private DevExpress.XtraEditors.LabelControl labelControl2;
	}
}