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
	public partial class FrmGiderler : Form
	{
		public FrmGiderler()
		{
			InitializeComponent();
		}
		SqlConnectionClass baglan = new SqlConnectionClass();

		void Listele()
		{
			SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Giderler", baglan.baglanti());
			DataTable dt = new DataTable();
			da.Fill(dt);
			gridControl1.DataSource = dt;
		}

		private void FrmGiderler_Load(object sender, EventArgs e)
		{
			//Listele
			Listele();
		}

		void Temizle()
		{
			txtId.Text = "";
			cmBoxAy.Text = "";
			cmBoxYil.Text = "";
			txtElektrik.Text = "";
			txtSu.Text = "";
			txtDogalgaz.Text = "";
			txtInternet.Text = "";
			txtMaaslar.Text = "";
			txtEkstra.Text = "";
			richTxtNotlar.Text = "";
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			SqlCommand komutEkle = new SqlCommand("insert into Tbl_Giderler (Ay,Yil,Elektrik,Su,Doğalgaz,Internet,Maaslar,Ekstra,Notlar) values " +
				"(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)",baglan.baglanti());
			komutEkle.Parameters.AddWithValue("@p1", cmBoxAy.Text);
			komutEkle.Parameters.AddWithValue("@p2", cmBoxYil.Text);
			komutEkle.Parameters.AddWithValue("@p3", txtElektrik.Text);
			komutEkle.Parameters.AddWithValue("@p4", txtSu.Text);
			komutEkle.Parameters.AddWithValue("@p5", txtDogalgaz.Text);
			komutEkle.Parameters.AddWithValue("@p6", txtInternet.Text);
			komutEkle.Parameters.AddWithValue("@p7", txtMaaslar.Text);
			komutEkle.Parameters.AddWithValue("@p8", txtEkstra.Text);
			komutEkle.Parameters.AddWithValue("@p9", richTxtNotlar.Text);
			komutEkle.ExecuteNonQuery();
			baglan.baglanti().Close();
			MessageBox.Show("Gider Sisteme Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Listele();
			Temizle();
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
			if(dr != null)
			{
				txtId.Text = dr["Id"].ToString();
				cmBoxAy.Text = dr["Ay"].ToString();
				cmBoxYil.Text = dr["Yil"].ToString();
				txtElektrik.Text = dr["Elektrik"].ToString();
				txtSu.Text = dr["Su"].ToString();
				txtDogalgaz.Text = dr["Doğalgaz"].ToString();
				txtInternet.Text = dr["Internet"].ToString();
				txtMaaslar.Text = dr["Maaslar"].ToString();
				txtEkstra.Text = dr["Ekstra"].ToString();
				richTxtNotlar.Text = dr["Notlar"].ToString();
			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			SqlCommand komutSil = new SqlCommand("delete Tbl_Giderler where Id = @p1",baglan.baglanti());
			komutSil.Parameters.AddWithValue("@p1",txtId.Text);
			komutSil.ExecuteNonQuery();
			baglan.baglanti().Close();
			MessageBox.Show("Gider Sistemden Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Listele();
			Temizle();
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			SqlCommand komutGuncelle = new SqlCommand("update Tbl_Giderler set Ay=@p1,Yil=@p2,Elektrik=@p3,Su=@p4,Doğalgaz=@p5,Internet=@p6,Maaslar=@p7," +
				"Ekstra=@p8,Notlar=@p9 where Id=@p10",baglan.baglanti());
			komutGuncelle.Parameters.AddWithValue("@p1", cmBoxAy.Text);
			komutGuncelle.Parameters.AddWithValue("@p2", cmBoxYil.Text);
			komutGuncelle.Parameters.AddWithValue("@p3", decimal.Parse(txtElektrik.Text));
			komutGuncelle.Parameters.AddWithValue("@p4", decimal.Parse(txtSu.Text));
			komutGuncelle.Parameters.AddWithValue("@p5", decimal.Parse(txtDogalgaz.Text));
			komutGuncelle.Parameters.AddWithValue("@p6", decimal.Parse(txtInternet.Text));
			komutGuncelle.Parameters.AddWithValue("@p7", decimal.Parse(txtMaaslar.Text));
			komutGuncelle.Parameters.AddWithValue("@p8", decimal.Parse(txtEkstra.Text));
			komutGuncelle.Parameters.AddWithValue("@p9", richTxtNotlar.Text);
			komutGuncelle.Parameters.AddWithValue("@p10", txtId.Text);
			komutGuncelle.ExecuteNonQuery();
			baglan.baglanti().Close();
			MessageBox.Show("Gider Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Listele();
			Temizle();
		}
	}
}
