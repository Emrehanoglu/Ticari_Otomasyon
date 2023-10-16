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
	public partial class FrmAnaSayfa : Form
	{
		public FrmAnaSayfa()
		{
			InitializeComponent();
		}
		SqlConnectionClass baglan = new SqlConnectionClass();
		void azalanStoklar()
		{
			SqlDataAdapter komut = new SqlDataAdapter("select UrunAd,sum(Adet) as Adet from Tbl_Urunler group by UrunAd " +
														"having sum(Adet)<=100 order by sum(Adet) desc",baglan.baglanti());
			DataTable dt = new DataTable();
			komut.Fill(dt);
			gridControl1.DataSource = dt;
		}
		void Ajanda()
		{
			SqlDataAdapter komut = new SqlDataAdapter("select Tarih,Saat,Baslik from Tbl_Notlar order by Id desc", baglan.baglanti());
			DataTable dt = new DataTable();
			komut.Fill(dt);
			gridControl2.DataSource = dt;
		}
		void sonOnHareket()
		{
			SqlDataAdapter komut = new SqlDataAdapter("exec SonOnHareket", baglan.baglanti());
			DataTable dt = new DataTable();
			komut.Fill(dt);
			gridControl4.DataSource = dt;
			
		}
		private void FrmAnaSayfa_Load(object sender, EventArgs e)
		{
			azalanStoklar();
			Ajanda();
			sonOnHareket();
		}
	}
}
