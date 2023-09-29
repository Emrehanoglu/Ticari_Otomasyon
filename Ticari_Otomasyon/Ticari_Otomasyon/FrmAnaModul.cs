﻿using System;
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

		private void Form1_Load(object sender, EventArgs e)
		{

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
	}
}