namespace SaleOrganization
{
    partial class KasaHareketleri
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
            this.dtpGun = new System.Windows.Forms.DateTimePicker();
            this.lvKasaHareketler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbSatisTipi = new System.Windows.Forms.ComboBox();
            this.txtMusteriID = new System.Windows.Forms.TextBox();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKasadaToplamtutar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpGun
            // 
            this.dtpGun.Location = new System.Drawing.Point(17, 62);
            this.dtpGun.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtpGun.Name = "dtpGun";
            this.dtpGun.Size = new System.Drawing.Size(137, 22);
            this.dtpGun.TabIndex = 73;
            this.dtpGun.ValueChanged += new System.EventHandler(this.dtpGun_ValueChanged);
            // 
            // lvKasaHareketler
            // 
            this.lvKasaHareketler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader11});
            this.lvKasaHareketler.FullRowSelect = true;
            this.lvKasaHareketler.Location = new System.Drawing.Point(213, 62);
            this.lvKasaHareketler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvKasaHareketler.Name = "lvKasaHareketler";
            this.lvKasaHareketler.Size = new System.Drawing.Size(871, 440);
            this.lvKasaHareketler.TabIndex = 74;
            this.lvKasaHareketler.UseCompatibleStateImageBehavior = false;
            this.lvKasaHareketler.View = System.Windows.Forms.View.Details;
            this.lvKasaHareketler.DoubleClick += new System.EventHandler(this.lvKasaHareketler_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Satış Tipi";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tarih";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Saat";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tutar";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Müşteri";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Açıklama";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "KasaID";
            this.columnHeader8.Width = 0;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "MusteriID";
            this.columnHeader9.Width = 0;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "İşlemTuru";
            this.columnHeader11.Width = 0;
            // 
            // cbSatisTipi
            // 
            this.cbSatisTipi.FormattingEnabled = true;
            this.cbSatisTipi.Location = new System.Drawing.Point(17, 95);
            this.cbSatisTipi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSatisTipi.Name = "cbSatisTipi";
            this.cbSatisTipi.Size = new System.Drawing.Size(137, 24);
            this.cbSatisTipi.TabIndex = 75;
            this.cbSatisTipi.SelectedIndexChanged += new System.EventHandler(this.cbSatisTipi_SelectedIndexChanged);
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.Location = new System.Drawing.Point(187, 15);
            this.txtMusteriID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.Size = new System.Drawing.Size(132, 22);
            this.txtMusteriID.TabIndex = 76;
            this.txtMusteriID.Visible = false;
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(381, 15);
            this.txtTarih.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(132, 22);
            this.txtTarih.TabIndex = 77;
            this.txtTarih.Visible = false;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(520, 510);
            this.txtToplamTutar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.ReadOnly = true;
            this.txtToplamTutar.Size = new System.Drawing.Size(177, 22);
            this.txtToplamTutar.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 513);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 79;
            this.label1.Text = "Toplam Tutar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(740, 513);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 81;
            this.label2.Text = "Kasada Toplam Tutar";
            // 
            // txtKasadaToplamtutar
            // 
            this.txtKasadaToplamtutar.Location = new System.Drawing.Point(907, 510);
            this.txtKasadaToplamtutar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKasadaToplamtutar.Name = "txtKasadaToplamtutar";
            this.txtKasadaToplamtutar.ReadOnly = true;
            this.txtKasadaToplamtutar.Size = new System.Drawing.Size(177, 22);
            this.txtKasadaToplamtutar.TabIndex = 80;
            // 
            // KasaHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1348, 684);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKasadaToplamtutar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.txtMusteriID);
            this.Controls.Add(this.cbSatisTipi);
            this.Controls.Add(this.lvKasaHareketler);
            this.Controls.Add(this.dtpGun);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KasaHareketleri";
            this.Text = "Kasa Hareketleri";
            this.Load += new System.EventHandler(this.KasaHareketleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpGun;
        private System.Windows.Forms.ListView lvKasaHareketler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ComboBox cbSatisTipi;
        private System.Windows.Forms.TextBox txtMusteriID;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKasadaToplamtutar;

    }
}