using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Charts;

namespace Ticari_Otomasyon
{
	public partial class FrmKasa : Form
	{
		public FrmKasa()
		{
			InitializeComponent();
		}
		SqlConnectionClass baglan = new SqlConnectionClass();
		void MusteriHareket()
		{
			SqlDataAdapter da = new SqlDataAdapter("Execute MusteriHareketler",baglan.baglanti());
			DataTable dt = new DataTable();
			da.Fill(dt);
			gridControl1.DataSource = dt;
		}
		void FirmaHareket()
		{
			SqlDataAdapter komut = new SqlDataAdapter("Execute FirmaHareketler",baglan.baglanti());
			DataTable dt = new DataTable();
			komut.Fill(dt);
			gridControl3.DataSource = dt;
		}
		void Giderler()
		{
			SqlDataAdapter komut = new SqlDataAdapter("select * from Tbl_Giderler", baglan.baglanti());
			DataTable dt = new DataTable();
			komut.Fill(dt);
			gridControl2.DataSource = dt;
		}
		public string ad;
		private void FrmKasa_Load(object sender, EventArgs e)
		{
			lblAktifKullanici.Text = ad;
			MusteriHareket();
			FirmaHareket();
			Giderler();

			SqlCommand komut1 = new SqlCommand("Select Sum(Tutar) from Tbl_FaturaDetay",baglan.baglanti());
			SqlDataReader dr1 = komut1.ExecuteReader();
			while (dr1.Read())
			{
				lblToplamTutar.Text = dr1[0].ToString();
			}
			baglan.baglanti().Close();

			SqlCommand komut2 = new SqlCommand("select top 1(Elektrik + Su + Doğalgaz) from Tbl_Giderler order by Id desc", baglan.baglanti());
			SqlDataReader dr2 = komut2.ExecuteReader();
			while (dr2.Read())
			{
				lblOdemeler.Text = dr2[0].ToString();
			}
			baglan.baglanti().Close();

			SqlCommand komut3 = new SqlCommand("select top 1 Maaslar from Tbl_Giderler order by Id desc", baglan.baglanti());
			SqlDataReader dr3 = komut3.ExecuteReader();
			while (dr3.Read())
			{
				lblPersonelMaaslari.Text = dr3[0].ToString();
			}
			baglan.baglanti().Close();

			SqlCommand komut4 = new SqlCommand("select count(*) from Tbl_Musteriler", baglan.baglanti());
			SqlDataReader dr4 = komut4.ExecuteReader();
			while (dr4.Read())
			{
				lblMusteriSayisi.Text = dr4[0].ToString();
			}
			baglan.baglanti().Close();

			SqlCommand komut5 = new SqlCommand("select count(*) from Tbl_Firmalar", baglan.baglanti());
			SqlDataReader dr5 = komut5.ExecuteReader();
			while (dr5.Read())
			{
				lblFirmaSayisi.Text = dr5[0].ToString();
			}
			baglan.baglanti().Close();

			SqlCommand komut6 = new SqlCommand("select count(distinct(Il)) from Tbl_Firmalar", baglan.baglanti());
			SqlDataReader dr6 = komut6.ExecuteReader();
			while (dr6.Read())
			{
				lblSehirSayisi.Text = dr6[0].ToString();
			}
			baglan.baglanti().Close();

			SqlCommand komut7 = new SqlCommand("select count(*) from Tbl_Personeller", baglan.baglanti());
			SqlDataReader dr7 = komut7.ExecuteReader();
			while (dr7.Read())
			{
				lblPersonelMaaslari.Text = dr7[0].ToString();
			}
			baglan.baglanti().Close();

			SqlCommand komut8 = new SqlCommand("select sum(adet) from Tbl_Urunler", baglan.baglanti());
			SqlDataReader dr8 = komut8.ExecuteReader();
			while (dr8.Read())
			{
				lblStokSayisi.Text = dr8[0].ToString();
			}
			baglan.baglanti().Close();
		}
		int sayac = 0;
		int sayac2 = 0;

		private void timer1_Tick(object sender, EventArgs e)
		{
			sayac++;
			if (sayac > 0 && sayac <= 5)
			{
				groupControl10.Text = "Elektrik";
				chartControl1.Series["Aylar"].Points.Clear();
				SqlCommand komut9 = new SqlCommand("select top 4 Ay,Elektrik from Tbl_Giderler order by Id desc", baglan.baglanti());
				SqlDataReader dr9 = komut9.ExecuteReader();
				while (dr9.Read())
				{
					chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr9[0], dr9[1]));
				}
				baglan.baglanti().Close();
			}
			if (sayac > 5 && sayac <= 10)
			{
				groupControl10.Text = "Su";
				chartControl1.Series["Aylar"].Points.Clear();
				SqlCommand komut10 = new SqlCommand("select top 4 Ay,Su from Tbl_Giderler order by Id desc", baglan.baglanti());
				SqlDataReader dr10 = komut10.ExecuteReader();
				while (dr10.Read())
				{
					chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
				}
				baglan.baglanti().Close();
			}
			if (sayac > 10 && sayac <= 15)
			{
				groupControl10.Text = "Doğalgaz";
				chartControl1.Series["Aylar"].Points.Clear();
				SqlCommand komut10 = new SqlCommand("select top 4 Ay,Doğalgaz from Tbl_Giderler order by Id desc", baglan.baglanti());
				SqlDataReader dr10 = komut10.ExecuteReader();
				while (dr10.Read())
				{
					chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
				}
				baglan.baglanti().Close();
			}
			if (sayac > 15 && sayac <= 20)
			{
				groupControl10.Text = "Internet";
				chartControl1.Series["Aylar"].Points.Clear();
				SqlCommand komut10 = new SqlCommand("select top 4 Ay,Internet from Tbl_Giderler order by Id desc", baglan.baglanti());
				SqlDataReader dr10 = komut10.ExecuteReader();
				while (dr10.Read())
				{
					chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
				}
				baglan.baglanti().Close();
			}
			if (sayac > 20 && sayac <= 25)
			{
				groupControl10.Text = "Ekstra";
				chartControl1.Series["Aylar"].Points.Clear();
				SqlCommand komut10 = new SqlCommand("select top 4 Ay,Ekstra from Tbl_Giderler order by Id desc", baglan.baglanti());
				SqlDataReader dr10 = komut10.ExecuteReader();
				while (dr10.Read())
				{
					chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
				}
				baglan.baglanti().Close();
			}
			if(sayac > 25)
			{
				sayac = 0;
			}
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			sayac2++;
			if (sayac2 > 0 && sayac2 <= 5)
			{
				groupControl11.Text = "Elektrik";
				chartControl2.Series["Aylar"].Points.Clear();
				SqlCommand komut9 = new SqlCommand("select top 4 Ay,Elektrik from Tbl_Giderler order by Id desc", baglan.baglanti());
				SqlDataReader dr9 = komut9.ExecuteReader();
				while (dr9.Read())
				{
					chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr9[0], dr9[1]));
				}
				baglan.baglanti().Close();
			}
			if (sayac2 > 5 && sayac2 <= 10)
			{
				groupControl11.Text = "Su";
				chartControl2.Series["Aylar"].Points.Clear();
				SqlCommand komut10 = new SqlCommand("select top 4 Ay,Su from Tbl_Giderler order by Id desc", baglan.baglanti());
				SqlDataReader dr10 = komut10.ExecuteReader();
				while (dr10.Read())
				{
					chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
				}
				baglan.baglanti().Close();
			}
			if (sayac2 > 10 && sayac2 <= 15)
			{
				groupControl11.Text = "Doğalgaz";
				chartControl2.Series["Aylar"].Points.Clear();
				SqlCommand komut10 = new SqlCommand("select top 4 Ay,Doğalgaz from Tbl_Giderler order by Id desc", baglan.baglanti());
				SqlDataReader dr10 = komut10.ExecuteReader();
				while (dr10.Read())
				{
					chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
				}
				baglan.baglanti().Close();
			}
			if (sayac2 > 15 && sayac2 <= 20)
			{
				groupControl11.Text = "Internet";
				chartControl2.Series["Aylar"].Points.Clear();
				SqlCommand komut10 = new SqlCommand("select top 4 Ay,Internet from Tbl_Giderler order by Id desc", baglan.baglanti());
				SqlDataReader dr10 = komut10.ExecuteReader();
				while (dr10.Read())
				{
					chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
				}
				baglan.baglanti().Close();
			}
			if (sayac2 > 20 && sayac2 <= 25)
			{
				groupControl11.Text = "Ekstra";
				chartControl2.Series["Aylar"].Points.Clear();
				SqlCommand komut10 = new SqlCommand("select top 4 Ay,Ekstra from Tbl_Giderler order by Id desc", baglan.baglanti());
				SqlDataReader dr10 = komut10.ExecuteReader();
				while (dr10.Read())
				{
					chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
				}
				baglan.baglanti().Close();
			}
			if (sayac2 > 25)
			{
				sayac2 = 0;
			}
		}
	}
}
