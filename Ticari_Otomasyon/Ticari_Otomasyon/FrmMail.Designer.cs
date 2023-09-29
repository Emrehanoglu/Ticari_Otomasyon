namespace Ticari_Otomasyon
{
	partial class FrmMail
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMail));
			this.label1 = new System.Windows.Forms.Label();
			this.txtMail = new System.Windows.Forms.TextBox();
			this.txtKonu = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.richTxtMesaj = new System.Windows.Forms.RichTextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnGonder = new DevExpress.XtraEditors.SimpleButton();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(18, 153);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mail Adresi :";
			// 
			// txtMail
			// 
			this.txtMail.Location = new System.Drawing.Point(116, 152);
			this.txtMail.Name = "txtMail";
			this.txtMail.Size = new System.Drawing.Size(185, 20);
			this.txtMail.TabIndex = 1;
			// 
			// txtKonu
			// 
			this.txtKonu.Location = new System.Drawing.Point(116, 181);
			this.txtKonu.Name = "txtKonu";
			this.txtKonu.Size = new System.Drawing.Size(185, 20);
			this.txtKonu.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(55, 182);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Konu :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(48, 210);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Mesaj :";
			// 
			// richTxtMesaj
			// 
			this.richTxtMesaj.Location = new System.Drawing.Point(116, 210);
			this.richTxtMesaj.Name = "richTxtMesaj";
			this.richTxtMesaj.Size = new System.Drawing.Size(185, 161);
			this.richTxtMesaj.TabIndex = 5;
			this.richTxtMesaj.Text = "";
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.Location = new System.Drawing.Point(1, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(324, 118);
			this.panel1.TabIndex = 6;
			// 
			// btnGonder
			// 
			this.btnGonder.Location = new System.Drawing.Point(116, 389);
			this.btnGonder.Name = "btnGonder";
			this.btnGonder.Size = new System.Drawing.Size(173, 24);
			this.btnGonder.TabIndex = 7;
			this.btnGonder.Text = "Gönder";
			this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
			// 
			// FrmMail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(325, 434);
			this.Controls.Add(this.btnGonder);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.richTxtMesaj);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtKonu);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtMail);
			this.Controls.Add(this.label1);
			this.Name = "FrmMail";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmMail";
			this.Load += new System.EventHandler(this.FrmMail_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMail;
		private System.Windows.Forms.TextBox txtKonu;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox richTxtMesaj;
		private System.Windows.Forms.Panel panel1;
		private DevExpress.XtraEditors.SimpleButton btnGonder;
	}
}