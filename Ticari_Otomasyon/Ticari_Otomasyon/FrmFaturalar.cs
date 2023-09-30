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
	public partial class FrmFaturalar : Form
	{
		public FrmFaturalar()
		{
			InitializeComponent();
		}
		SqlConnectionClass baglan = new SqlConnectionClass();

		void Listele()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_FaturaBilgi",baglan.baglanti());
			da.Fill(dt);
			gridControl1.DataSource = dt;
		}

		void Temizle()
		{
			txtId.Text = "";
			txtSeri.Text = "";
			txtSiraNo.Text = "";
			maskTxtTarih.Text = "";
			maskTxtSaat.Text = "";
			txtVergiDaire.Text = "";
			txtAlici.Text = "";
			txtTeslimEden.Text = "";
			txtTeslimAlan.Text = "";
			txtUrunId.Text = "";
			txtUrun.Text = "";
			txtMiktar.Text = "";
			txtFiyat.Text = "";
			txtTutar.Text = "";
			txtFaturaId.Text = "";
		}

		private void FrmFaturalar_Load(object sender, EventArgs e)
		{
			Listele();
			Temizle();
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			if(txtFaturaId.Text == "")
			{
				SqlCommand faturabilgi = new SqlCommand("insert into Tbl_FaturaBilgi (Seri,SiraNo,Tarih,Saat,VergiDaire,Alici,TeslimEden,TeslimAlan) " +
					"values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)",baglan.baglanti());
				faturabilgi.Parameters.AddWithValue("@p1", txtSeri.Text);
				faturabilgi.Parameters.AddWithValue("@p2", txtSiraNo.Text);
				faturabilgi.Parameters.AddWithValue("@p3", maskTxtTarih.Text);
				faturabilgi.Parameters.AddWithValue("@p4", maskTxtSaat.Text);
				faturabilgi.Parameters.AddWithValue("@p5", txtVergiDaire.Text);
				faturabilgi.Parameters.AddWithValue("@p6", txtAlici.Text);
				faturabilgi.Parameters.AddWithValue("@p7", txtTeslimEden.Text);
				faturabilgi.Parameters.AddWithValue("@p8", txtTeslimAlan.Text);
				faturabilgi.ExecuteNonQuery();
				baglan.baglanti().Close();
				MessageBox.Show("Fatura Bilgisi Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Listele();
				Temizle();
			}
			else
			{
				double fiyat, miktar;
				fiyat = double.Parse(txtFiyat.Text);
				miktar = double.Parse(txtMiktar.Text);
				txtTutar.Text = (fiyat * miktar).ToString();

				SqlCommand faturadetay = new SqlCommand("insert into Tbl_FaturaDetay (UrunAd,Miktar,Fiyat,Tutar,FaturaId) " +
					"values (@p1,@p2,@p3,@p4,@p5)", baglan.baglanti());
				faturadetay.Parameters.AddWithValue("@p1", txtUrun.Text);
				faturadetay.Parameters.AddWithValue("@p2", txtMiktar.Text);
				faturadetay.Parameters.AddWithValue("@p3", txtFiyat.Text);
				faturadetay.Parameters.AddWithValue("@p4", txtTutar.Text);
				faturadetay.Parameters.AddWithValue("@p5", txtFaturaId.Text);
				faturadetay.ExecuteNonQuery();
				baglan.baglanti().Close();
				MessageBox.Show("Fatura Detayı Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Listele();
				Temizle();
			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if(txtId.Text != "")
			{
				SqlCommand faturaBilgiSil = new SqlCommand("Delete Tbl_FaturaBilgi where Id = @p1",baglan.baglanti());
				faturaBilgiSil.Parameters.AddWithValue("@p1",txtId.Text);
				faturaBilgiSil.ExecuteNonQuery();
				baglan.baglanti().Close();
				MessageBox.Show("Fatura Bilgisi Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Listele();
				Temizle();
			}
			else if(txtFaturaId.Text != "")
			{
				SqlCommand faturaDetaySil = new SqlCommand("Delete Tbl_FaturaDetay where FaturaUrunId = @p1", baglan.baglanti());
				faturaDetaySil.Parameters.AddWithValue("@p1", txtFaturaId.Text);
				faturaDetaySil.ExecuteNonQuery();
				baglan.baglanti().Close();
				MessageBox.Show("Fatura Detayı Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Listele();
				Temizle();
			}
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
			if(dr != null)
			{
				txtId.Text = dr["Id"].ToString();
				txtSeri.Text = dr["Seri"].ToString();
				txtSiraNo.Text = dr["SiraNo"].ToString();
				maskTxtTarih.Text = dr["Tarih"].ToString();
				maskTxtSaat.Text = dr["Saat"].ToString();
				txtVergiDaire.Text = dr["VergiDaire"].ToString();
				txtAlici.Text = dr["Alici"].ToString();
				txtTeslimEden.Text = dr["TeslimEden"].ToString();
				txtTeslimAlan.Text = dr["TeslimAlan"].ToString();
			}
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			if(txtId.Text != "")
			{
				SqlCommand faturabilgi = new SqlCommand("update Tbl_FaturaBilgi set Seri=@p1,SiraNo=@p2,Tarih=@p3,Saat=@p4,VergiDaire=@p5,Alici=@p6,TeslimEden=@p7,TeslimAlan=@p8 " +
					"where Id = @p9", baglan.baglanti());
				faturabilgi.Parameters.AddWithValue("@p9", txtId.Text);
				faturabilgi.Parameters.AddWithValue("@p1", txtSeri.Text);
				faturabilgi.Parameters.AddWithValue("@p2", txtSiraNo.Text);
				faturabilgi.Parameters.AddWithValue("@p3", maskTxtTarih.Text);
				faturabilgi.Parameters.AddWithValue("@p4", maskTxtSaat.Text);
				faturabilgi.Parameters.AddWithValue("@p5", txtVergiDaire.Text);
				faturabilgi.Parameters.AddWithValue("@p6", txtAlici.Text);
				faturabilgi.Parameters.AddWithValue("@p7", txtTeslimEden.Text);
				faturabilgi.Parameters.AddWithValue("@p8", txtTeslimAlan.Text);
				faturabilgi.ExecuteNonQuery();
				baglan.baglanti().Close();
				MessageBox.Show("Fatura Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Listele();
				Temizle();
			}
		}

		private void btnTemizle_Click(object sender, EventArgs e)
		{
			txtId.Text = "";
			txtSeri.Text = "";
			txtSiraNo.Text = "";
			maskTxtTarih.Text = "";
			maskTxtSaat.Text = "";
			txtVergiDaire.Text = "";
			txtAlici.Text = "";
			txtTeslimEden.Text = "";
			txtTeslimAlan.Text = "";
			txtUrunId.Text = "";
			txtUrun.Text = "";
			txtMiktar.Text = "";
			txtFiyat.Text = "";
			txtTutar.Text = "";
			txtFaturaId.Text = "";
		}

		private void gridView1_DoubleClick(object sender, EventArgs e)
		{
			FrmFaturaBilgiDetay fr = new FrmFaturaBilgiDetay();
			DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
			if(dr != null)
			{
				fr.id = dr["Id"].ToString();
				fr.Show();
			}
		}
	}
}
