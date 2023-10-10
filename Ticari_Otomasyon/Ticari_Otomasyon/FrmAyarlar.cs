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
	public partial class FrmAyarlar : Form
	{
		public FrmAyarlar()
		{
			InitializeComponent();
		}
		SqlConnectionClass baglan = new SqlConnectionClass();
		void Listele()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Admin",baglan.baglanti());
			da.Fill(dt);
			gridControl1.DataSource = dt;
		}
		private void FrmAyarlar_Load(object sender, EventArgs e)
		{
			Listele();
			txtKullaniciAdi.Text = "";
			txtSifre.Text = "";
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			if(btnKaydet.Text == "Kaydet")
			{
				SqlCommand komut = new SqlCommand("insert into Tbl_Admin (KullaniciAdi,Sifre) values (@p1,@p2)", baglan.baglanti());
				komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
				komut.Parameters.AddWithValue("@p2", txtSifre.Text);
				komut.ExecuteNonQuery();
				baglan.baglanti().Close();
				MessageBox.Show("Admin Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if(btnKaydet.Text == "Güncelle")
			{
				SqlCommand komut = new SqlCommand("update Tbl_Admin set Sifre=@p2 where KullaniciAdi=@p1", baglan.baglanti());
				komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
				komut.Parameters.AddWithValue("@p2", txtSifre.Text);
				komut.ExecuteNonQuery();
				baglan.baglanti().Close();
				MessageBox.Show("Admin Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			Listele();
		}

		private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
		{
			if(txtKullaniciAdi.Text == "")
			{
				btnKaydet.Text = "Kaydet";
			}
			else
			{
				btnKaydet.Text = "Güncelle";
			}
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
			if(dr != null)
			{
				txtKullaniciAdi.Text = dr["KullaniciAdi"].ToString();
				txtSifre.Text = dr["Sifre"].ToString();
			}
		}
	}
}
