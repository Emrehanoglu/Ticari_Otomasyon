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
	public partial class FrmNotlar : Form
	{
		public FrmNotlar()
		{
			InitializeComponent();
		}

		SqlConnectionClass baglan = new SqlConnectionClass();

		void Listele()
		{
			SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Notlar",baglan.baglanti());
			DataTable dt = new DataTable();
			da.Fill(dt);
			gridControl1.DataSource = dt;
		}

		void Temizle()
		{
			txtId.Text = "";
			maskTxtTarih.Text = "";
			maskTxtSaat.Text = "";
			txtBaslik.Text = "";
			richTxtDetay.Text = "";
			txtOlusturan.Text = "";
			txtHitap.Text = "";
		}

		private void FrmNotlar_Load(object sender, EventArgs e)
		{
			Listele();
			Temizle();
		}

		private void btnTemizle_Click(object sender, EventArgs e)
		{
			Temizle();
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("insert into Tbl_Notlar (Tarih,Saat,Baslik,Detay,Olusturan,Hitap) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglan.baglanti());
			komut.Parameters.AddWithValue("@p1",maskTxtTarih.Text);
			komut.Parameters.AddWithValue("@p2",maskTxtSaat.Text);
			komut.Parameters.AddWithValue("@p3",txtBaslik.Text);
			komut.Parameters.AddWithValue("@p4",richTxtDetay.Text);
			komut.Parameters.AddWithValue("@p5",txtOlusturan.Text);
			komut.Parameters.AddWithValue("@p6",txtHitap.Text);
			komut.ExecuteNonQuery();
			baglan.baglanti().Close();
			MessageBox.Show("Not Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Listele();
			Temizle();
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("delete Tbl_Notlar where Id = @p1",baglan.baglanti());
			komut.Parameters.AddWithValue("@p1", txtId.Text);
			komut.ExecuteNonQuery();
			baglan.baglanti().Close();
			MessageBox.Show("Not Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Listele();
			Temizle();
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("update Tbl_Notlar set Tarih=@p1,Saat=@p2,Baslik=@p3,Detay=@p4,Olusturan=@p5,Hitap=@p6 where Id=@p7", baglan.baglanti());
			komut.Parameters.AddWithValue("@p1", maskTxtTarih.Text);
			komut.Parameters.AddWithValue("@p2", maskTxtSaat.Text);
			komut.Parameters.AddWithValue("@p3", txtBaslik.Text);
			komut.Parameters.AddWithValue("@p4", richTxtDetay.Text);
			komut.Parameters.AddWithValue("@p5", txtOlusturan.Text);
			komut.Parameters.AddWithValue("@p6", txtHitap.Text);
			komut.Parameters.AddWithValue("@p7", txtId.Text);
			komut.ExecuteNonQuery();
			baglan.baglanti().Close();
			MessageBox.Show("Not Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Listele();
			Temizle();
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
			if(dr != null)
			{
				txtId.Text = dr["Id"].ToString();
				maskTxtTarih.Text = dr["Tarih"].ToString();
				maskTxtSaat.Text = dr["Saat"].ToString();
				txtBaslik.Text = dr["Baslik"].ToString();
				richTxtDetay.Text = dr["Detay"].ToString();
				txtOlusturan.Text = dr["Olusturan"].ToString();
				txtHitap.Text = dr["Hitap"].ToString();
			}
		}

		private void gridView1_DoubleClick(object sender, EventArgs e)
		{
			FrmNotDetay fr = new FrmNotDetay();
			DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
			if(dr != null)
			{
				fr.detay = dr["Detay"].ToString();
				fr.Show();
			}
		}
	}
}
