using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ticari_Otomasyon
{
	public partial class FrmRehber : Form
	{
		public FrmRehber()
		{
			InitializeComponent();
		}
		SqlConnectionClass baglan = new SqlConnectionClass();
		private void FrmRehber_Load(object sender, EventArgs e)
		{
			DataTable dt1 = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter("Select Ad,Soyad,Telefon,Telefon2,Mail from Tbl_Musteriler",baglan.baglanti());
			da.Fill(dt1);
			gridControl1.DataSource = dt1;

			DataTable dt2 = new DataTable();
			SqlDataAdapter da2 = new SqlDataAdapter("Select Ad,YetkiliAdSoyad,Telefon1,Telefon2,Telefon3,Mail,Fax from Tbl_Firmalar",baglan.baglanti());
			da2.Fill(dt2);
			gridControl2.DataSource = dt2;
		}

		private void gridView1_DoubleClick(object sender, EventArgs e)
		{
			FrmMail frmMail = new FrmMail();
			DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
			if(dr != null)
			{
				frmMail.mail = dr["Mail"].ToString();
				frmMail.Show();
			}
		}

		private void gridControl2_DoubleClick(object sender, EventArgs e)
		{
			FrmMail frmMail = new FrmMail();
			DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
			if (dr != null)
			{
				frmMail.mail = dr["Mail"].ToString();
				frmMail.Show();
			}
		}
	}
}
