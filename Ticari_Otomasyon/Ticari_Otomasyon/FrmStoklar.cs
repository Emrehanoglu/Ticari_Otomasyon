﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
			chartControl1.Series["Series 1"].Points.AddPoint("İstanbul", 4);
			chartControl1.Series["Series 1"].Points.AddPoint("Ankara", 3);
			chartControl1.Series["Series 1"].Points.AddPoint("İzmir", 5);
			chartControl1.Series["Series 1"].Points.AddPoint("Muğla", 10);
		}
	}
}
