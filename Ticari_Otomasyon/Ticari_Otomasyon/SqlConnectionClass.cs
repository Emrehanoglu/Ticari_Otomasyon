using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ticari_Otomasyon
{
	class SqlConnectionClass
	{
		public SqlConnection baglanti()
		{
			SqlConnection baglan = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TicariOtomasyonDb;Integrated Security=True");
			baglan.Open();
			return baglan;
		}
	}
}
