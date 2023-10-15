using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		FrmUrunler fr;
		private void btnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (fr == null || fr.IsDisposed)
			{
				fr = new FrmUrunler();
				fr.MdiParent = this;
				fr.Show();
			}
		}
		FrmMusteriler frMusteriler;
		private void btnMusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if(frMusteriler == null || frMusteriler.IsDisposed)
			{
				frMusteriler = new FrmMusteriler();
				frMusteriler.MdiParent = this;
				frMusteriler.Show();
			}
		}
		public string kullanici;
		private void Form1_Load(object sender, EventArgs e)
		{
			if (frmAnaSayfa == null || frmAnaSayfa.IsDisposed)
			{
				frmAnaSayfa = new FrmAnaSayfa();
				frmAnaSayfa.MdiParent = this;
				frmAnaSayfa.Show();
			}
		}

		FrmFirmalar frmFirmalar;
		private void btnFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if(frmFirmalar == null || frmFirmalar.IsDisposed)
			{
				frmFirmalar = new FrmFirmalar();
				frmFirmalar.MdiParent = this;
				frmFirmalar.Show();
			}
		}
		FrmPersoneller frmPersoneller;
		private void btnPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if(frmPersoneller == null || frmPersoneller.IsDisposed)
			{
				frmPersoneller = new FrmPersoneller();
				frmPersoneller.MdiParent = this;
				frmPersoneller.Show();
			}
		}
		FrmRehber frmRehber;
		private void btnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if(frmRehber == null || frmRehber.IsDisposed)
			{
				frmRehber = new FrmRehber(); 
				frmRehber.MdiParent = this;
				frmRehber.Show();   
			}
		}
		FrmGiderler frmGiderler;
		private void btnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if(frmGiderler == null || frmGiderler.IsDisposed)
			{
				frmGiderler = new FrmGiderler();
				frmGiderler.MdiParent = this;
				frmGiderler.Show();
			}
		}
		FrmBankalar frmBankalar;
		private void btnBankalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if(frmBankalar == null || frmBankalar.IsDisposed)
			{
				frmBankalar = new FrmBankalar();
				frmBankalar.MdiParent = this;
				frmBankalar.Show();
			}
		}
		FrmFaturalar frmFaturalar;
		private void btnFaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if(frmFaturalar == null || frmFaturalar.IsDisposed)
			{
				frmFaturalar = new FrmFaturalar();
				frmFaturalar.MdiParent = this;
				frmFaturalar.Show();
			}
		}
		FrmNotlar frmNotlar;
		private void btnNotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if(frmNotlar == null || frmNotlar.IsDisposed)
			{
				frmNotlar = new FrmNotlar();
				frmNotlar.MdiParent = this;
				frmNotlar.Show();
			}
		}
		FrmHareketler frmHareketler;
		private void btnHareketler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if(frmHareketler == null || frmHareketler.IsDisposed)
			{
				frmHareketler = new FrmHareketler();
				frmHareketler.MdiParent = this;
				frmHareketler.Show();
			}
		}
		FrmStoklar frmStoklar;
		private void btnStoklar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if(frmStoklar == null || frmStoklar.IsDisposed)
			{
				frmStoklar = new FrmStoklar();
				frmStoklar.MdiParent = this;
				frmStoklar.Show();
			}
		}
		FrmAyarlar frmAyarlar;
		private void btnAyarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if(frmAyarlar == null || frmAyarlar.IsDisposed)
			{
				frmAyarlar = new FrmAyarlar();
				frmAyarlar.Show();
			}
		}
		FrmKasa frmKasa;
		private void btnKasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if(frmKasa == null || frmKasa.IsDisposed)
			{
				frmKasa = new FrmKasa();
				frmKasa.ad = kullanici;
				frmKasa.MdiParent = this;
				frmKasa.Show();
			}
		}
		FrmAnaSayfa frmAnaSayfa;
		private void btnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (frmAnaSayfa == null || frmAnaSayfa.IsDisposed)
			{
				frmAnaSayfa = new FrmAnaSayfa();
				frmAnaSayfa.MdiParent = this;
				frmAnaSayfa.Show();
			}
		}
	}
}
