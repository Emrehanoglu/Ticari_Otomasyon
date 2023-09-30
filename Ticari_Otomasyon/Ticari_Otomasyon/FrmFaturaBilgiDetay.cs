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
	public partial class FrmFaturaBilgiDetay : Form
	{
		public FrmFaturaBilgiDetay()
		{
			InitializeComponent();
		}
		public string id;
		SqlConnectionClass baglan = new SqlConnectionClass();
		public void Listele()
		{
			SqlDataAdapter komut = new SqlDataAdapter("select * from Tbl_FaturaDetay where FaturaId = '" + id + "'", baglan.baglanti());
			DataTable dt = new DataTable();
			komut.Fill(dt);
			gridControl1.DataSource = dt;
		}
		private void FrmFaturaBilgiDetay_Load(object sender, EventArgs e)
		{
			Listele();
		}

		private void gridControl1_DoubleClick(object sender, EventArgs e)
		{
			FrmFaturaBilgiDetayDüzenleme fr = new FrmFaturaBilgiDetayDüzenleme();
			DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
			if(dr != null)
			{
				fr.urunId = dr["FaturaUrunId"].ToString();
				fr.Show();
			}
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			Listele();
		}
	}
}
