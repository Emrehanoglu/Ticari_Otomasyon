namespace Ticari_Otomasyon
{
	partial class FrmUrunler
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunler));
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.maskTxtYil = new System.Windows.Forms.MaskedTextBox();
			this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
			this.rTbDetay = new System.Windows.Forms.RichTextBox();
			this.numAdet = new System.Windows.Forms.NumericUpDown();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.SatışFiyat = new DevExpress.XtraEditors.LabelControl();
			this.txtSatisFiyat = new DevExpress.XtraEditors.TextEdit();
			this.AlışFiyat = new DevExpress.XtraEditors.LabelControl();
			this.txtAlisFiyat = new DevExpress.XtraEditors.TextEdit();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.txtModel = new DevExpress.XtraEditors.TextEdit();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.txtMarka = new DevExpress.XtraEditors.TextEdit();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.txtAd = new DevExpress.XtraEditors.TextEdit();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.txtId = new DevExpress.XtraEditors.TextEdit();
			this.btnSil = new DevExpress.XtraEditors.SimpleButton();
			this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numAdet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyat.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAlisFiyat.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMarka.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl1
			// 
			this.gridControl1.Location = new System.Drawing.Point(1, 0);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(623, 615);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowGroupPanel = false;
			this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.btnGuncelle);
			this.groupControl1.Controls.Add(this.btnSil);
			this.groupControl1.Controls.Add(this.maskTxtYil);
			this.groupControl1.Controls.Add(this.btnKaydet);
			this.groupControl1.Controls.Add(this.rTbDetay);
			this.groupControl1.Controls.Add(this.numAdet);
			this.groupControl1.Controls.Add(this.labelControl7);
			this.groupControl1.Controls.Add(this.SatışFiyat);
			this.groupControl1.Controls.Add(this.txtSatisFiyat);
			this.groupControl1.Controls.Add(this.AlışFiyat);
			this.groupControl1.Controls.Add(this.txtAlisFiyat);
			this.groupControl1.Controls.Add(this.labelControl4);
			this.groupControl1.Controls.Add(this.labelControl5);
			this.groupControl1.Controls.Add(this.labelControl6);
			this.groupControl1.Controls.Add(this.txtModel);
			this.groupControl1.Controls.Add(this.labelControl3);
			this.groupControl1.Controls.Add(this.txtMarka);
			this.groupControl1.Controls.Add(this.labelControl2);
			this.groupControl1.Controls.Add(this.txtAd);
			this.groupControl1.Controls.Add(this.labelControl1);
			this.groupControl1.Controls.Add(this.txtId);
			this.groupControl1.Location = new System.Drawing.Point(630, 0);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(220, 615);
			this.groupControl1.TabIndex = 1;
			this.groupControl1.Text = "groupControl1";
			// 
			// maskTxtYil
			// 
			this.maskTxtYil.Location = new System.Drawing.Point(78, 250);
			this.maskTxtYil.Mask = "0000";
			this.maskTxtYil.Name = "maskTxtYil";
			this.maskTxtYil.Size = new System.Drawing.Size(100, 21);
			this.maskTxtYil.TabIndex = 21;
			this.maskTxtYil.ValidatingType = typeof(int);
			// 
			// btnKaydet
			// 
			this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
			this.btnKaydet.Location = new System.Drawing.Point(78, 488);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(100, 36);
			this.btnKaydet.TabIndex = 20;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// rTbDetay
			// 
			this.rTbDetay.Location = new System.Drawing.Point(78, 386);
			this.rTbDetay.Name = "rTbDetay";
			this.rTbDetay.Size = new System.Drawing.Size(100, 96);
			this.rTbDetay.TabIndex = 19;
			this.rTbDetay.Text = "";
			// 
			// numAdet
			// 
			this.numAdet.Location = new System.Drawing.Point(78, 284);
			this.numAdet.Name = "numAdet";
			this.numAdet.Size = new System.Drawing.Size(100, 21);
			this.numAdet.TabIndex = 18;
			// 
			// labelControl7
			// 
			this.labelControl7.Location = new System.Drawing.Point(34, 389);
			this.labelControl7.Name = "labelControl7";
			this.labelControl7.Size = new System.Drawing.Size(36, 13);
			this.labelControl7.TabIndex = 17;
			this.labelControl7.Text = "Detay :";
			// 
			// SatışFiyat
			// 
			this.SatışFiyat.Location = new System.Drawing.Point(16, 353);
			this.SatışFiyat.Name = "SatışFiyat";
			this.SatışFiyat.Size = new System.Drawing.Size(54, 13);
			this.SatışFiyat.TabIndex = 15;
			this.SatışFiyat.Text = "SatışFiyat :";
			// 
			// txtSatisFiyat
			// 
			this.txtSatisFiyat.Location = new System.Drawing.Point(78, 350);
			this.txtSatisFiyat.Name = "txtSatisFiyat";
			this.txtSatisFiyat.Size = new System.Drawing.Size(100, 20);
			this.txtSatisFiyat.TabIndex = 14;
			// 
			// AlışFiyat
			// 
			this.AlışFiyat.Location = new System.Drawing.Point(23, 320);
			this.AlışFiyat.Name = "AlışFiyat";
			this.AlışFiyat.Size = new System.Drawing.Size(47, 13);
			this.AlışFiyat.TabIndex = 13;
			this.AlışFiyat.Text = "AlışFiyat :";
			// 
			// txtAlisFiyat
			// 
			this.txtAlisFiyat.Location = new System.Drawing.Point(78, 317);
			this.txtAlisFiyat.Name = "txtAlisFiyat";
			this.txtAlisFiyat.Size = new System.Drawing.Size(100, 20);
			this.txtAlisFiyat.TabIndex = 12;
			// 
			// labelControl4
			// 
			this.labelControl4.Location = new System.Drawing.Point(40, 286);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(30, 13);
			this.labelControl4.TabIndex = 11;
			this.labelControl4.Text = "Adet :";
			// 
			// labelControl5
			// 
			this.labelControl5.Location = new System.Drawing.Point(53, 253);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(17, 13);
			this.labelControl5.TabIndex = 9;
			this.labelControl5.Text = "Yıl :";
			// 
			// labelControl6
			// 
			this.labelControl6.Location = new System.Drawing.Point(35, 220);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(35, 13);
			this.labelControl6.TabIndex = 7;
			this.labelControl6.Text = "Model :";
			// 
			// txtModel
			// 
			this.txtModel.Location = new System.Drawing.Point(78, 217);
			this.txtModel.Name = "txtModel";
			this.txtModel.Size = new System.Drawing.Size(100, 20);
			this.txtModel.TabIndex = 6;
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(34, 185);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(36, 13);
			this.labelControl3.TabIndex = 5;
			this.labelControl3.Text = "Marka :";
			// 
			// txtMarka
			// 
			this.txtMarka.Location = new System.Drawing.Point(78, 182);
			this.txtMarka.Name = "txtMarka";
			this.txtMarka.Size = new System.Drawing.Size(100, 20);
			this.txtMarka.TabIndex = 4;
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(50, 149);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(20, 13);
			this.labelControl2.TabIndex = 3;
			this.labelControl2.Text = "Ad :";
			// 
			// txtAd
			// 
			this.txtAd.Location = new System.Drawing.Point(78, 146);
			this.txtAd.Name = "txtAd";
			this.txtAd.Size = new System.Drawing.Size(100, 20);
			this.txtAd.TabIndex = 2;
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(53, 116);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(17, 13);
			this.labelControl1.TabIndex = 1;
			this.labelControl1.Text = "Id :";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(78, 113);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(100, 20);
			this.txtId.TabIndex = 0;
			// 
			// btnSil
			// 
			this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
			this.btnSil.Location = new System.Drawing.Point(78, 530);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(100, 36);
			this.btnSil.TabIndex = 22;
			this.btnSil.Text = "Sil";
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
			this.btnGuncelle.Location = new System.Drawing.Point(78, 568);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(100, 36);
			this.btnGuncelle.TabIndex = 23;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// FrmUrunler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(851, 616);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.gridControl1);
			this.Name = "FrmUrunler";
			this.Text = "FrmUrunler";
			this.Load += new System.EventHandler(this.FrmUrunler_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numAdet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyat.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAlisFiyat.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMarka.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private System.Windows.Forms.RichTextBox rTbDetay;
		private System.Windows.Forms.NumericUpDown numAdet;
		private DevExpress.XtraEditors.LabelControl labelControl7;
		private DevExpress.XtraEditors.LabelControl SatışFiyat;
		private DevExpress.XtraEditors.TextEdit txtSatisFiyat;
		private DevExpress.XtraEditors.LabelControl AlışFiyat;
		private DevExpress.XtraEditors.TextEdit txtAlisFiyat;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private DevExpress.XtraEditors.TextEdit txtModel;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.TextEdit txtMarka;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.TextEdit txtAd;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.TextEdit txtId;
		private DevExpress.XtraEditors.SimpleButton btnKaydet;
		private System.Windows.Forms.MaskedTextBox maskTxtYil;
		private DevExpress.XtraEditors.SimpleButton btnGuncelle;
		private DevExpress.XtraEditors.SimpleButton btnSil;
	}
}