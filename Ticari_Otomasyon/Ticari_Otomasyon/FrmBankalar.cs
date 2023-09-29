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
	public partial class FrmBankalar : Form
	{
		public FrmBankalar()
		{
			InitializeComponent();
		}
		SqlConnectionClass baglan = new SqlConnectionClass();
		void Listele()
		{
			SqlCommand komut = new SqlCommand("Execute BankaBilgileri", baglan.baglanti());
			SqlDataAdapter da = new SqlDataAdapter(komut);
			DataTable dt = new DataTable();
			da.Fill(dt);
			gridControl1.DataSource = dt;
			Iller();
			FirmaListesi();
		}
		private void FrmBankalar_Load(object sender, EventArgs e)
		{
			Listele();
			Temizle();
		}
		void FirmaListesi()
		{
			SqlCommand komut2 = new SqlCommand("Select Id,Ad from Tbl_Firmalar", baglan.baglanti());
			SqlDataAdapter da2 = new SqlDataAdapter(komut2);
			DataTable dt2 = new DataTable();
			da2.Fill(dt2);
			lookUpEdit1.Properties.DataSource = dt2;
		}
		void Iller()
		{
			SqlCommand komut = new SqlCommand("Select Sehir from Tbl_Iller",baglan.baglanti());
			SqlDataReader dr = komut.ExecuteReader();
			while (dr.Read())
			{
				cmBoxİl.Properties.Items.Add(dr[0]);
			}
			baglan.baglanti().Close();
		}
		void Temizle()
		{
			txtId.Text = "";
			txtBankaAd.Text = "";
			cmBoxİl.Text = "";
			cmBoxİlçe.Text = "";
			txtSube.Text = "";
			txtIban.Text = "";
			txtHesapNo.Text = "";
			txtYetkili.Text = "";
			maskTxtTelefon.Text = "";
			maskTxtTarih.Text = "";
			txtHesapTürü.Text = "";
			lookUpEdit1.EditValue = null;
		}
		private void cmBoxİl_SelectedIndexChanged(object sender, EventArgs e)
		{
			cmBoxİlçe.Properties.Items.Clear();
			cmBoxİlçe.Text = "";
			SqlCommand komut = new SqlCommand("Select Ilce from Tbl_Ilceler where Sehir = @p1",baglan.baglanti());
			komut.Parameters.AddWithValue("@p1", cmBoxİl.SelectedIndex + 1);
			SqlDataReader dr = komut.ExecuteReader();
			while (dr.Read())
			{
				cmBoxİlçe.Properties.Items.Add(dr[0]);
			}
			baglan.baglanti().Close();
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("insert into Tbl_Bankalar (BankaAdı,Il,Ilce,Sube,Iban,HesapNo,Yetkili,Telefon,Tarih,HesapTürü,FirmaId)" +
				"values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)",baglan.baglanti());
			komut.Parameters.AddWithValue("@p1",txtBankaAd.Text);
			komut.Parameters.AddWithValue("@p2",cmBoxİl.Text);
			komut.Parameters.AddWithValue("@p3",cmBoxİlçe.Text);
			komut.Parameters.AddWithValue("@p4",txtSube.Text);
			komut.Parameters.AddWithValue("@p5",txtIban.Text);
			komut.Parameters.AddWithValue("@p6",txtHesapNo.Text);
			komut.Parameters.AddWithValue("@p7",txtYetkili.Text);
			komut.Parameters.AddWithValue("@p8",maskTxtTelefon.Text);
			komut.Parameters.AddWithValue("@p9",maskTxtTarih.Text);
			komut.Parameters.AddWithValue("@p10",txtHesapTürü.Text);
			komut.Parameters.AddWithValue("@p11",lookUpEdit1.EditValue);
			komut.ExecuteNonQuery();
			baglan.baglanti().Close();
			MessageBox.Show("Banka Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Listele();
			Temizle();
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
			if(dr != null)
			{
				txtId.Text = dr["Id"].ToString();
				txtBankaAd.Text = dr["BankaAdı"].ToString();
				cmBoxİl.Text = dr["Il"].ToString();
				cmBoxİlçe.Text = dr["Ilce"].ToString();
				txtSube.Text = dr["Sube"].ToString();
				txtIban.Text = dr["Iban"].ToString();
				txtHesapNo.Text = dr["HesapNo"].ToString();
				txtYetkili.Text = dr["Yetkili"].ToString();
				maskTxtTelefon.Text = dr["Telefon"].ToString();
				maskTxtTarih.Text = dr["Tarih"].ToString();
				txtHesapTürü.Text = dr["HesapTürü"].ToString();
			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("Delete Tbl_Bankalar where Id = @p1", baglan.baglanti());
			komut.Parameters.AddWithValue("@p1",txtId.Text);
			komut.ExecuteNonQuery();
			baglan.baglanti().Close();
			MessageBox.Show("Banka Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Listele();
			Temizle();
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("update Tbl_Bankalar set BankaAdı=@p1,Il=@p2,Ilce=@p3,Sube=@p4,Iban=@p5,HesapNo=@p6," +
				"Yetkili=@p7,Telefon=@p8,Tarih=@p9,HesapTürü=@p10 where Id=@p12",baglan.baglanti());
			komut.Parameters.AddWithValue("@p12", txtId.Text);
			komut.Parameters.AddWithValue("@p1", txtBankaAd.Text);
			komut.Parameters.AddWithValue("@p2", cmBoxİl.Text);
			komut.Parameters.AddWithValue("@p3", cmBoxİlçe.Text);
			komut.Parameters.AddWithValue("@p4", txtSube.Text);
			komut.Parameters.AddWithValue("@p5", txtIban.Text);
			komut.Parameters.AddWithValue("@p6", txtHesapNo.Text);
			komut.Parameters.AddWithValue("@p7", txtYetkili.Text);
			komut.Parameters.AddWithValue("@p8", maskTxtTelefon.Text);
			komut.Parameters.AddWithValue("@p9", maskTxtTarih.Text);
			komut.Parameters.AddWithValue("@p10", txtHesapTürü.Text);
			komut.Parameters.AddWithValue("@p11", lookUpEdit1.EditValue);
			komut.ExecuteNonQuery();
			baglan.baglanti().Close();
			MessageBox.Show("Banka Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Listele();
			Temizle();
		}
	}
}
