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
		}
	}
}
