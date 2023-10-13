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
		public string ad;
		private void FrmKasa_Load(object sender, EventArgs e)
		{
			lblAktifKullanici.Text = ad;
			MusteriHareket();
			FirmaHareket();

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
	}
}
