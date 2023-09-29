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
	public partial class FrmFirmalar : Form
	{
		public FrmFirmalar()
		{
			InitializeComponent();
		}

		SqlConnectionClass baglan = new SqlConnectionClass();

		void Listele()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Firmalar",baglan.baglanti());
			da.Fill(dt);
			gridControl1.DataSource = dt;
		}

		void CariKodAciklamalar()
		{
			SqlCommand komut = new SqlCommand("Select FirmaKod1 from Tbl_Kodlar",baglan.baglanti());
			SqlDataReader dr = komut.ExecuteReader();
			while (dr.Read())
			{
				richTxtOzelKod1.Text = dr[0].ToString();
			}
			baglan.baglanti().Close();
		}

		void Temizle()
		{
			txtId.Text = "";
			txtAd.Text = "";
			txtYetkiliGorev.Text = "";
			txtYetkili.Text = "";
			maskTxtYetkiliTc.Text = "";
			txtSektor.Text = "";
			maskTxtTelefon1.Text = "";
			maskTxtTelefon2.Text = "";
			maskTxtTelefon3.Text = "";
			txtMail.Text = "";
			maskTxtFaks.Text = "";
			cmBoxİl.Text = "";
			cmBoxİlçe.Text = "";
			txtVergiDairesi.Text = "";
			richTxtAdres.Text = "";
			richTxtOzelKod1.Text = "";
			richTxtOzelKod2.Text = "";
			richTxtOzelKod3.Text = "";
		}

		private void FrmFirmalar_Load(object sender, EventArgs e)
		{
			Listele();
			Temizle();
			Iller();
			CariKodAciklamalar();
		}

		public void Iller()
		{
			SqlCommand komut = new SqlCommand("Select Sehir from Tbl_Iller", baglan.baglanti());
			SqlDataReader dr = komut.ExecuteReader();
			while (dr.Read())
			{
				cmBoxİl.Properties.Items.Add(dr[0]);
			}
			baglan.baglanti().Close();
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
			txtId.Text = dr["Id"].ToString();
			txtAd.Text = dr["Ad"].ToString();
			txtYetkiliGorev.Text = dr["YetkiliStatu"].ToString();
			txtYetkili.Text = dr["YetkiliAdSoyad"].ToString();
			maskTxtYetkiliTc.Text = dr["YetkiliTc"].ToString();
			txtSektor.Text = dr["Sektor"].ToString();
			maskTxtTelefon1.Text = dr["Telefon1"].ToString();
			maskTxtTelefon2.Text = dr["Telefon2"].ToString();
			maskTxtTelefon3.Text = dr["Telefon3"].ToString();
			txtMail.Text = dr["Mail"].ToString();
			maskTxtFaks.Text = dr["Fax"].ToString();
			cmBoxİl.Text = dr["Il"].ToString();
			cmBoxİlçe.Text = dr["Ilce"].ToString();
			txtVergiDairesi.Text = dr["VergiDaire"].ToString();
			richTxtAdres.Text = dr["Adres"].ToString();
			txtKod1.Text = dr["OzelKod1"].ToString();
			txtKod2.Text = dr["OzelKod2"].ToString();
			txtKod3.Text = dr["OzelKod3"].ToString();
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			SqlCommand komutKaydet = new SqlCommand("insert into Tbl_Firmalar (Ad,YetkiliStatu,YetkiliAdSoyad,YetkiliTc,Sektor,Telefon1,Telefon2,Telefon3,Mail,Fax,Il,Ilce,VergiDaire,Adres,OzelKod1,OzelKod2,OzelKod3) values " +
				"(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)",baglan.baglanti());
			komutKaydet.Parameters.AddWithValue("@p1", txtAd.Text);
			komutKaydet.Parameters.AddWithValue("@p2", txtYetkiliGorev.Text);
			komutKaydet.Parameters.AddWithValue("@p3", txtYetkili.Text);
			komutKaydet.Parameters.AddWithValue("@p4", maskTxtYetkiliTc.Text);
			komutKaydet.Parameters.AddWithValue("@p5", txtSektor.Text);
			komutKaydet.Parameters.AddWithValue("@p6", maskTxtTelefon1.Text);
			komutKaydet.Parameters.AddWithValue("@p7", maskTxtTelefon2.Text);
			komutKaydet.Parameters.AddWithValue("@p8", maskTxtTelefon3.Text);
			komutKaydet.Parameters.AddWithValue("@p9", txtMail.Text);
			komutKaydet.Parameters.AddWithValue("@p10", maskTxtFaks.Text);
			komutKaydet.Parameters.AddWithValue("@p11", cmBoxİl.Text);
			komutKaydet.Parameters.AddWithValue("@p12", cmBoxİlçe.Text);
			komutKaydet.Parameters.AddWithValue("@p13", richTxtAdres.Text);
			komutKaydet.Parameters.AddWithValue("@p14", txtVergiDairesi.Text);
			komutKaydet.Parameters.AddWithValue("@p15", txtKod1.Text);
			komutKaydet.Parameters.AddWithValue("@p16", txtKod2.Text);
			komutKaydet.Parameters.AddWithValue("@p17", txtKod3.Text);
			komutKaydet.ExecuteNonQuery();
			baglan.baglanti().Close();
			MessageBox.Show("Firma Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Listele();
			Temizle();
		}

		private void cmBoxİl_SelectedIndexChanged(object sender, EventArgs e)
		{
			cmBoxİlçe.Properties.Items.Clear();
			cmBoxİlçe.Text = "";
			SqlCommand komut = new SqlCommand("Select Ilce from Tbl_Ilceler where Sehir=@p1", baglan.baglanti());
			komut.Parameters.AddWithValue("@p1", cmBoxİl.SelectedIndex + 1);
			SqlDataReader dr = komut.ExecuteReader();
			while (dr.Read())
			{
				cmBoxİlçe.Properties.Items.Add(dr[0]);
			}
			baglan.baglanti().Close();
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			SqlCommand komutSil = new SqlCommand("Delete Tbl_Firmalar where Id=@p1", baglan.baglanti());
			komutSil.Parameters.AddWithValue("@p1",txtId.Text);
			komutSil.ExecuteNonQuery();
			baglan.baglanti().Close();
			MessageBox.Show("Firma Sistemden Silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
			Listele();
			Temizle();
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			SqlCommand komutGuncelle = new SqlCommand("update Tbl_Firmalar set " +
				"Ad=@p1,YetkiliStatu=@p2,YetkiliAdSoyad=@p3,YetkiliTc=@p4,Sektor=@p5,Telefon1=@p6,Telefon2=@p7,Telefon3=@p8,Mail=@p9,Fax=@p10," +
				"Il=@p11,Ilce=@p12,VergiDaire=@p13,Adres=@p14,OzelKod1=@p15,OzelKod2=@p16,OzelKod3=@p17 where Id=@p18",baglan.baglanti());
			komutGuncelle.Parameters.AddWithValue("@p1", txtAd.Text);
			komutGuncelle.Parameters.AddWithValue("@p2", txtYetkiliGorev.Text);
			komutGuncelle.Parameters.AddWithValue("@p3", txtYetkili.Text);
			komutGuncelle.Parameters.AddWithValue("@p4", maskTxtYetkiliTc.Text);
			komutGuncelle.Parameters.AddWithValue("@p5", txtSektor.Text);
			komutGuncelle.Parameters.AddWithValue("@p6", maskTxtTelefon1.Text);
			komutGuncelle.Parameters.AddWithValue("@p7", maskTxtTelefon2.Text);
			komutGuncelle.Parameters.AddWithValue("@p8", maskTxtTelefon3.Text);
			komutGuncelle.Parameters.AddWithValue("@p9", txtMail.Text);
			komutGuncelle.Parameters.AddWithValue("@p10", maskTxtFaks.Text);
			komutGuncelle.Parameters.AddWithValue("@p11", cmBoxİl.Text);
			komutGuncelle.Parameters.AddWithValue("@p12", cmBoxİlçe.Text);
			komutGuncelle.Parameters.AddWithValue("@p13", richTxtAdres.Text);
			komutGuncelle.Parameters.AddWithValue("@p14", txtVergiDairesi.Text);
			komutGuncelle.Parameters.AddWithValue("@p15", txtKod1.Text);
			komutGuncelle.Parameters.AddWithValue("@p16", txtKod2.Text);
			komutGuncelle.Parameters.AddWithValue("@p17", txtKod3.Text);
			komutGuncelle.Parameters.AddWithValue("@p18",txtId.Text);
			komutGuncelle.ExecuteNonQuery();
			baglan.baglanti().Close();
			MessageBox.Show("Firma Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Listele();
			Temizle();
		}
	}
}
