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
	public partial class FrmPersoneller : Form
	{
		public FrmPersoneller()
		{
			InitializeComponent();
		}

		SqlConnectionClass baglan = new SqlConnectionClass();

		void ListelePersonel()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Personeller",baglan.baglanti());
			da.Fill(dt);
			gridControl1.DataSource = dt;
		}
		void Temizle()
		{
			txtId.Text = "";
			txtAd.Text = "";
			txtSoyad.Text = "";
			maskTxtTelefon.Text = "";
			maskTxtTc.Text = "";
			txtMail.Text = "";
			cmBoxİl.Text = "";
			cmBoxİlçe.Text = "";
			richTxtAdres.Text = "";
			txtGorev.Text = "";
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			SqlCommand komutKaydet = new SqlCommand("insert into Tbl_Personeller (Ad,Soyad,Telefon,Tc,Mail,Il,Ilce,Adres,Gorev) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)"
				,baglan.baglanti());
			komutKaydet.Parameters.AddWithValue("@p1", txtAd.Text);
			komutKaydet.Parameters.AddWithValue("@p2", txtSoyad.Text);
			komutKaydet.Parameters.AddWithValue("@p3", maskTxtTelefon.Text);
			komutKaydet.Parameters.AddWithValue("@p4", maskTxtTc.Text);
			komutKaydet.Parameters.AddWithValue("@p5", txtMail.Text);
			komutKaydet.Parameters.AddWithValue("@p6", cmBoxİl.Text);
			komutKaydet.Parameters.AddWithValue("@p7", cmBoxİlçe.Text);
			komutKaydet.Parameters.AddWithValue("@p8", richTxtAdres.Text);
			komutKaydet.Parameters.AddWithValue("@p9", txtGorev.Text);
			komutKaydet.ExecuteNonQuery();
			baglan.baglanti().Close();
			MessageBox.Show("Personel Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			ListelePersonel();
			Temizle();
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			SqlCommand komutSil = new SqlCommand("delete from Tbl_Personeller where Id = @p1",baglan.baglanti());
			komutSil.Parameters.AddWithValue("@p1",txtId.Text);
			komutSil.ExecuteNonQuery();
			baglan.baglanti().Close();
			MessageBox.Show("Personel Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			ListelePersonel();
			Temizle();
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
			txtId.Text = dr[0].ToString();
			txtAd.Text = dr[1].ToString();
			txtSoyad.Text = dr[2].ToString();
			maskTxtTelefon.Text = dr[3].ToString();
			maskTxtTc.Text = dr[4].ToString();
			txtMail.Text = dr[5].ToString();
			cmBoxİl.Text = dr[6].ToString();
			cmBoxİlçe.Text = dr[7].ToString();
			richTxtAdres.Text = dr[8].ToString();
			txtGorev.Text = dr[9].ToString();
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			SqlCommand komutGuncelle = new SqlCommand("update Tbl_Personeller set Ad=@p1, Soyad=@p2, Telefon=@p3, Tc=@p4, Mail=@p5, Il=@p6, Ilce=@p7, Adres=@p8, Gorev=@p9 where Id=@p10", 
				baglan.baglanti());
			komutGuncelle.Parameters.AddWithValue("@p1", txtAd.Text);
			komutGuncelle.Parameters.AddWithValue("@p2", txtSoyad.Text);
			komutGuncelle.Parameters.AddWithValue("@p3", maskTxtTelefon.Text);
			komutGuncelle.Parameters.AddWithValue("@p4", maskTxtTc.Text);
			komutGuncelle.Parameters.AddWithValue("@p5", txtMail.Text);
			komutGuncelle.Parameters.AddWithValue("@p6", cmBoxİl.Text);
			komutGuncelle.Parameters.AddWithValue("@p7", cmBoxİlçe.Text);
			komutGuncelle.Parameters.AddWithValue("@p8", richTxtAdres.Text);
			komutGuncelle.Parameters.AddWithValue("@p9", txtGorev.Text);
			komutGuncelle.Parameters.AddWithValue("@p10", txtId.Text);
			komutGuncelle.ExecuteNonQuery();
			baglan.baglanti().Close();
			MessageBox.Show("Personel Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			ListelePersonel();
			Temizle();
		}

		private void FrmPersoneller_Load(object sender, EventArgs e)
		{
			ListelePersonel();
			Temizle();
		}
	}
}
