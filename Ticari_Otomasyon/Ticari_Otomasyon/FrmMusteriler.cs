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
	public partial class FrmMusteriler : Form
	{
		public FrmMusteriler()
		{
			InitializeComponent();
		}
		SqlConnectionClass baglan = new SqlConnectionClass();

		public void Listele()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Musteriler",baglan.baglanti());
			da.Fill(dt);
			gridControl1.DataSource = dt;
		}

		public void Iller()
		{
			SqlCommand komut = new SqlCommand("Select Sehir from Tbl_Iller",baglan.baglanti());
			SqlDataReader dr = komut.ExecuteReader();
			while (dr.Read())
			{
				cmBoxİl.Properties.Items.Add(dr[0]);
			}
			baglan.baglanti().Close();
		}

		private void FrmMusteriler_Load(object sender, EventArgs e)
		{
			Listele();
			Iller();
		}

		private void cmBoxİlçe_SelectedIndexChanged(object sender, EventArgs e)
		{
			
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

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("insert into Tbl_Musteriler (Ad,Soyad,Telefon,Telefon2,Tc,Mail,Il,Ilce,Adres,VergiDaire) values " +
				"(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)",baglan.baglanti());
			komut.Parameters.AddWithValue("@p1", txtAd.Text);
			komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
			komut.Parameters.AddWithValue("@p3", maskTxtTelefon1.Text);
			komut.Parameters.AddWithValue("@p4", maskTxtTelefon2.Text);
			komut.Parameters.AddWithValue("@p5", maskTxtTc.Text);
			komut.Parameters.AddWithValue("@p6", txtMail.Text);
			komut.Parameters.AddWithValue("@p7", cmBoxİl.Text);
			komut.Parameters.AddWithValue("@p8", cmBoxİlçe.Text);
			komut.Parameters.AddWithValue("@p9", richTxtAdres.Text);
			komut.Parameters.AddWithValue("@p10", txtVergiDairesi.Text);
			komut.ExecuteNonQuery();
			baglan.baglanti().Close();
			MessageBox.Show("Müşteri Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Listele();
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
			txtId.Text = dr["Id"].ToString();
			txtAd.Text = dr["Ad"].ToString();
			txtSoyad.Text = dr["Soyad"].ToString();
			maskTxtTelefon1.Text = dr["Telefon"].ToString();
			maskTxtTelefon2.Text = dr["Telefon2"].ToString();
			maskTxtTc.Text = dr["Tc"].ToString();
			txtMail.Text = dr["Mail"].ToString();
			cmBoxİl.Text = dr["Il"].ToString();
			cmBoxİlçe.Text = dr["Ilce"].ToString();
			richTxtAdres.Text = dr["Adres"].ToString();
			txtVergiDairesi.Text = dr["VergiDaire"].ToString();
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("Delete Tbl_Musteriler where Id=@p1",baglan.baglanti());
			komut.Parameters.AddWithValue("@p1",txtId.Text);
			komut.ExecuteNonQuery();
			baglan.baglanti().Close();
			MessageBox.Show("Müşteri Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Listele();
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("Update Tbl_Musteriler set Ad=@p1, Soyad=@p2, Telefon=@p3, Telefon2=@p4, Tc=@p5, " +
				"Mail=@p6, Il=@p7, Ilce=@p8, Adres=@p9, VergiDaire=@p10 where Id=@p11",baglan.baglanti());
			komut.Parameters.AddWithValue("@p11",txtId.Text);
			komut.Parameters.AddWithValue("@p1", txtAd.Text);
			komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
			komut.Parameters.AddWithValue("@p3", maskTxtTelefon1.Text);
			komut.Parameters.AddWithValue("@p4", maskTxtTelefon2.Text);
			komut.Parameters.AddWithValue("@p5", maskTxtTc.Text);
			komut.Parameters.AddWithValue("@p6", txtMail.Text);
			komut.Parameters.AddWithValue("@p7", cmBoxİl.Text);
			komut.Parameters.AddWithValue("@p8", cmBoxİlçe.Text);
			komut.Parameters.AddWithValue("@p9", richTxtAdres.Text);
			komut.Parameters.AddWithValue("@p10", txtVergiDairesi.Text);
			komut.ExecuteNonQuery();
			baglan.baglanti().Close();
			MessageBox.Show("Müşteri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Listele();
		}
	}
}
