using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ticari_Otomasyon
{
	public partial class FrmUrunler : Form
	{
		public FrmUrunler()
		{
			InitializeComponent();
		}
		SqlConnectionClass command = new SqlConnectionClass();

		void Listele()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Urunler",command.baglanti());
			da.Fill(dt);
			gridControl1.DataSource = dt;
		}

		private void FrmUrunler_Load(object sender, EventArgs e)
		{
			Listele();
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("Insert into Tbl_Urunler (UrunAd,Marka,Model,Yil,Adet,AlisFiyat,SatisFiyat,Detay) values " +
				"(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)",command.baglanti());
			komut.Parameters.AddWithValue("@p1", txtAd.Text);
			komut.Parameters.AddWithValue("@p2", txtMarka.Text);
			komut.Parameters.AddWithValue("@p3", txtModel.Text);
			komut.Parameters.AddWithValue("@p4", maskTxtYil.Text);
			komut.Parameters.AddWithValue("@p5", int.Parse((numAdet.Value).ToString()));
			komut.Parameters.AddWithValue("@p6", decimal.Parse(txtAlisFiyat.Text));
			komut.Parameters.AddWithValue("@p7", decimal.Parse(txtSatisFiyat.Text));
			komut.Parameters.AddWithValue("@p8", rTbDetay.Text);
			komut.ExecuteNonQuery();
			command.baglanti().Close();
			MessageBox.Show("Ürün Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Listele();
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			SqlCommand komutSil = new SqlCommand("Delete Tbl_Urunler where Id = @p1",command.baglanti());
			komutSil.Parameters.AddWithValue("@p1", txtId.Text);
			komutSil.ExecuteNonQuery();
			command.baglanti().Close();
			MessageBox.Show("Ürün Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Listele();
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
			txtId.Text = dr["Id"].ToString();
			txtAd.Text = dr["UrunAd"].ToString();
			txtMarka.Text = dr["Marka"].ToString();
			txtModel.Text = dr["Model"].ToString();
			maskTxtYil.Text = dr["Yil"].ToString();
			numAdet.Value = decimal.Parse(dr["Adet"].ToString());
			txtAlisFiyat.Text = dr["AlisFiyat"].ToString();
			txtSatisFiyat.Text = dr["SatisFiyat"].ToString();
			rTbDetay.Text = dr["Detay"].ToString();
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			SqlCommand komutGuncelle = new SqlCommand("Update Tbl_Urunler set UrunAd=@p1, Marka=@p2, Model=@p3, Yil=@p4, Adet=@p5, " +
				"AlisFiyat=@p6, SatisFiyat=@p7, Detay=@p8 where Id=@p9");
			komutGuncelle.Parameters.AddWithValue("@p1", txtAd.Text);
			komutGuncelle.Parameters.AddWithValue("@p2", txtMarka.Text);
			komutGuncelle.Parameters.AddWithValue("@p3", txtModel.Text);
			komutGuncelle.Parameters.AddWithValue("@p4", maskTxtYil.Text);
			komutGuncelle.Parameters.AddWithValue("@p5", int.Parse((numAdet.Value).ToString()));
			komutGuncelle.Parameters.AddWithValue("@p6", decimal.Parse(txtAlisFiyat.Text));
			komutGuncelle.Parameters.AddWithValue("@p7", decimal.Parse(txtSatisFiyat.Text));
			komutGuncelle.Parameters.AddWithValue("@p8", rTbDetay.Text);
			komutGuncelle.Parameters.AddWithValue("@p9", txtId.Text);
			komutGuncelle.ExecuteNonQuery();
			command.baglanti().Close();
			MessageBox.Show("Ürün Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Listele();
		}
	}
}
