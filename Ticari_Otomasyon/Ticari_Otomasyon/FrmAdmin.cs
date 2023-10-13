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
	public partial class FrmAdmin : Form
	{
		public FrmAdmin()
		{
			InitializeComponent();
		}
		SqlConnectionClass baglan = new SqlConnectionClass();
		private void btnGirisYap_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("Select * from Tbl_Admin where KullaniciAdi = @p1 and Sifre = @p2",baglan.baglanti());
			komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
			komut.Parameters.AddWithValue("@p2", txtSifre.Text);
			SqlDataReader dr = komut.ExecuteReader();
			if (dr.Read())
			{
				Form1 fr = new Form1();
				fr.kullanici = txtKullaniciAdi.Text;
				fr.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı, Tekrar Deneyiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void FrmAdmin_Load(object sender, EventArgs e)
		{

		}
	}
}
