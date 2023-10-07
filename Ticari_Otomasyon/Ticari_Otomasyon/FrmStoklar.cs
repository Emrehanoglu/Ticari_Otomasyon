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
	public partial class FrmStoklar : Form
	{
		public FrmStoklar()
		{
			InitializeComponent();
		}
		SqlConnectionClass baglan = new SqlConnectionClass();
		private void FrmStoklar_Load(object sender, EventArgs e)
		{
			Listele();

			SqlCommand komut = new SqlCommand("select UrunAd,Sum(Adet) from Tbl_Urunler group by UrunAd", baglan.baglanti());
			SqlDataReader dr = komut.ExecuteReader();
			while (dr.Read())
			{
				chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
			}
			baglan.baglanti().Close();


		}
		void Listele()
		{
			SqlDataAdapter komut = new SqlDataAdapter("select UrunAd,Sum(Adet) from Tbl_Urunler group by UrunAd", baglan.baglanti());
			DataTable dt = new DataTable();
			komut.Fill(dt);
			gridControl1.DataSource = dt;
		}
	}
}
