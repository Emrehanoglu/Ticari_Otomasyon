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
	public partial class FrmKasa : Form
	{
		public FrmKasa()
		{
			InitializeComponent();
		}
		SqlConnectionClass baglan = new SqlConnectionClass();
		void MusteriHareket()
		{
			SqlDataAdapter da = new SqlDataAdapter("Execute MusteriHareketler",baglan.baglanti());
			DataTable dt = new DataTable();
			da.Fill(dt);
			gridControl1.DataSource = dt;
		}
		void FirmaHareket()
		{
			SqlDataAdapter komut = new SqlDataAdapter("Execute FirmaHareketler",baglan.baglanti());
			DataTable dt = new DataTable();
			komut.Fill(dt);
			gridControl3.DataSource = dt;
		}
		private void FrmKasa_Load(object sender, EventArgs e)
		{
			MusteriHareket();
			FirmaHareket();

			SqlCommand komut1 = new SqlCommand("Select Sum(Tutar) from Tbl_FaturaDetay",baglan.baglanti());
			SqlDataReader dr1 = komut1.ExecuteReader();
			while (dr1.Read())
			{
				lblToplamTutar.Text = dr1[0].ToString();
			}
			baglan.baglanti().Close();

			SqlCommand komut2 = new SqlCommand("select top 1(Elektrik + Su + Doğalgaz) from Tbl_Giderler order by Id desc", baglan.baglanti());
			SqlDataReader dr2 = komut2.ExecuteReader();
			while (dr2.Read())
			{
				lblOdemeler.Text = dr2[0].ToString();
			}
			baglan.baglanti().Close();
			
		}
	}
}
