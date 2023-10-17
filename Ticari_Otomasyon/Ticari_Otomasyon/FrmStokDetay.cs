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
	public partial class FrmStokDetay : Form
	{
		public FrmStokDetay()
		{
			InitializeComponent();
		}
		SqlConnectionClass baglan = new SqlConnectionClass();
		public string ad;
		private void FrmStokDetay_Load(object sender, EventArgs e)
		{
			SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Urunler where UrunAd = '"+ad+"'",baglan.baglanti());
			DataTable dt = new DataTable();
			da.Fill(dt);
			gridControl1.DataSource = dt;
		}
	}
}
