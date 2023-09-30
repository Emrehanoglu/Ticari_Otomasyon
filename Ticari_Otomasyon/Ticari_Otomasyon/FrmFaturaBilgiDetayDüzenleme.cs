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
	public partial class FrmFaturaBilgiDetayDüzenleme : Form
	{
		public FrmFaturaBilgiDetayDüzenleme()
		{
			InitializeComponent();
		}
		public string urunId;
		SqlConnectionClass baglan = new SqlConnectionClass();
		private void FrmFaturaBilgiDetayDüzenleme_Load(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("select * from Tbl_FaturaDetay where FaturaUrunId = '"+urunId+"'", baglan.baglanti());
			SqlDataReader dr = komut.ExecuteReader();
			while (dr.Read())
			{
				txtUrunId.Text = dr["FaturaUrunId"].ToString();
				txtUrun.Text = dr["UrunAd"].ToString();
				txtMiktar.Text = dr["Miktar"].ToString();
				txtFiyat.Text = dr["Fiyat"].ToString();
				txtTutar.Text = dr["Tutar"].ToString();
			}
			baglan.baglanti().Close();
		}
		FrmFaturaBilgiDetay fr = new FrmFaturaBilgiDetay();
		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			double fiyat, miktar;
			fiyat = double.Parse(txtFiyat.Text);
			miktar = double.Parse(txtMiktar.Text);
			txtTutar.Text = (fiyat * miktar).ToString();

			SqlCommand komut = new SqlCommand("update Tbl_FaturaDetay set UrunAd=@p1,Miktar=@p2,Fiyat=@p3,Tutar=@p4 where FaturaUrunId=@p5",baglan.baglanti());
			komut.Parameters.AddWithValue("@p1", txtUrun.Text);
			komut.Parameters.AddWithValue("@p2", int.Parse(txtMiktar.Text));
			komut.Parameters.AddWithValue("@p3", decimal.Parse(txtFiyat.Text));
			komut.Parameters.AddWithValue("@p4", decimal.Parse(txtTutar.Text));
			komut.Parameters.AddWithValue("@p5", txtUrunId.Text);
			komut.ExecuteNonQuery();
			baglan.baglanti().Close();
			this.Hide();
			fr.Listele();
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("delete Tbl_FaturaDetay where FaturaUrunId=@p5", baglan.baglanti());
			komut.Parameters.AddWithValue("@p5", txtUrunId.Text);
			komut.ExecuteNonQuery();
			baglan.baglanti().Close();
			this.Hide();
			fr.Listele();
		}
	}
}
