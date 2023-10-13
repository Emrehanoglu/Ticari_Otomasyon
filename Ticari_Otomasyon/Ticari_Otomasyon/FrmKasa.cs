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
		}
	}
}
