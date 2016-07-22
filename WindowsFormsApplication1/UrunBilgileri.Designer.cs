namespace WindowsFormsApplication1
{
    partial class UrunBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunBilgileri));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.slblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblMesaj = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblKullanici = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMarkaID = new System.Windows.Forms.TextBox();
            this.cbMarkalar = new System.Windows.Forms.ComboBox();
            this.txtFirmaAdı = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUrunID = new System.Windows.Forms.TextBox();
            this.cbAltKat = new System.Windows.Forms.ComboBox();
            this.cbUstKat = new System.Windows.Forms.ComboBox();
            this.cbEnUstKat = new System.Windows.Forms.ComboBox();
            this.txtAltKat = new System.Windows.Forms.TextBox();
            this.txtUstKat = new System.Windows.Forms.TextBox();
            this.txtEnUstKat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunKodu = new System.Windows.Forms.TextBox();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvUrunler = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblKullanici = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsYeni = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.tsDegistirGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Stok Miktarı";
            this.columnHeader6.Width = 115;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kategori";
            this.columnHeader4.Width = 134;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ürün Adı";
            this.columnHeader3.Width = 165;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Kodu";
            this.columnHeader2.Width = 81;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ÜrünID";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fiyat";
            this.columnHeader5.Width = 135;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(104, 70);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(119, 21);
            this.txtUrunAdi.TabIndex = 7;
            this.txtUrunAdi.TextChanged += new System.EventHandler(this.txtUrunAdi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ürün Adı";
            // 
            // slblDate
            // 
            this.slblDate.Name = "slblDate";
            this.slblDate.Size = new System.Drawing.Size(79, 17);
            this.slblDate.Text = "28 Nisan 2016";
            // 
            // slblMesaj
            // 
            this.slblMesaj.Name = "slblMesaj";
            this.slblMesaj.Size = new System.Drawing.Size(566, 17);
            this.slblMesaj.Spring = true;
            this.slblMesaj.Text = "Ürün Bilgileri Ekranı";
            // 
            // slblKullanici
            // 
            this.slblKullanici.Name = "slblKullanici";
            this.slblKullanici.Size = new System.Drawing.Size(104, 17);
            this.slblKullanici.Text = "Sales Organization";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Gold;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slblKullanici,
            this.slblMesaj,
            this.slblDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 559);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(764, 22);
            this.statusStrip1.TabIndex = 61;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Kodu";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gold;
            this.groupBox1.Controls.Add(this.txtMarkaID);
            this.groupBox1.Controls.Add(this.cbMarkalar);
            this.groupBox1.Controls.Add(this.txtFirmaAdı);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtUrunID);
            this.groupBox1.Controls.Add(this.cbAltKat);
            this.groupBox1.Controls.Add(this.cbUstKat);
            this.groupBox1.Controls.Add(this.cbEnUstKat);
            this.groupBox1.Controls.Add(this.txtAltKat);
            this.groupBox1.Controls.Add(this.txtUstKat);
            this.groupBox1.Controls.Add(this.txtEnUstKat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUrunAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUrunKodu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(0, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 106);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            // 
            // txtMarkaID
            // 
            this.txtMarkaID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMarkaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMarkaID.Location = new System.Drawing.Point(80, 41);
            this.txtMarkaID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMarkaID.Name = "txtMarkaID";
            this.txtMarkaID.Size = new System.Drawing.Size(8, 23);
            this.txtMarkaID.TabIndex = 188;
            this.txtMarkaID.Visible = false;
            this.txtMarkaID.TextChanged += new System.EventHandler(this.txtMarkaID_TextChanged);
            // 
            // cbMarkalar
            // 
            this.cbMarkalar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbMarkalar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarkalar.DropDownWidth = 100;
            this.cbMarkalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMarkalar.FormattingEnabled = true;
            this.cbMarkalar.Location = new System.Drawing.Point(200, 44);
            this.cbMarkalar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMarkalar.Name = "cbMarkalar";
            this.cbMarkalar.Size = new System.Drawing.Size(23, 23);
            this.cbMarkalar.TabIndex = 187;
            this.cbMarkalar.SelectedIndexChanged += new System.EventHandler(this.cbMarkalar_SelectedIndexChanged);
            // 
            // txtFirmaAdı
            // 
            this.txtFirmaAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirmaAdı.Location = new System.Drawing.Point(104, 44);
            this.txtFirmaAdı.Name = "txtFirmaAdı";
            this.txtFirmaAdı.ReadOnly = true;
            this.txtFirmaAdı.Size = new System.Drawing.Size(119, 23);
            this.txtFirmaAdı.TabIndex = 186;
            this.txtFirmaAdı.TextChanged += new System.EventHandler(this.txtFirmaAdı_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 185;
            this.label5.Text = "Marka";
            // 
            // txtUrunID
            // 
            this.txtUrunID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUrunID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunID.Location = new System.Drawing.Point(78, 19);
            this.txtUrunID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.Size = new System.Drawing.Size(8, 23);
            this.txtUrunID.TabIndex = 55;
            this.txtUrunID.Visible = false;
            // 
            // cbAltKat
            // 
            this.cbAltKat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbAltKat.DropDownWidth = 100;
            this.cbAltKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbAltKat.FormattingEnabled = true;
            this.cbAltKat.Location = new System.Drawing.Point(502, 70);
            this.cbAltKat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbAltKat.Name = "cbAltKat";
            this.cbAltKat.Size = new System.Drawing.Size(152, 23);
            this.cbAltKat.TabIndex = 51;
            this.cbAltKat.SelectedIndexChanged += new System.EventHandler(this.cbAltKat_SelectedIndexChanged);
            // 
            // cbUstKat
            // 
            this.cbUstKat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbUstKat.DropDownWidth = 100;
            this.cbUstKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbUstKat.FormattingEnabled = true;
            this.cbUstKat.Location = new System.Drawing.Point(502, 44);
            this.cbUstKat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbUstKat.Name = "cbUstKat";
            this.cbUstKat.Size = new System.Drawing.Size(152, 23);
            this.cbUstKat.TabIndex = 50;
            this.cbUstKat.SelectedIndexChanged += new System.EventHandler(this.cbUstKat_SelectedIndexChanged);
            // 
            // cbEnUstKat
            // 
            this.cbEnUstKat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbEnUstKat.DropDownWidth = 100;
            this.cbEnUstKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbEnUstKat.FormattingEnabled = true;
            this.cbEnUstKat.Location = new System.Drawing.Point(502, 18);
            this.cbEnUstKat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbEnUstKat.Name = "cbEnUstKat";
            this.cbEnUstKat.Size = new System.Drawing.Size(152, 23);
            this.cbEnUstKat.TabIndex = 48;
            this.cbEnUstKat.SelectedIndexChanged += new System.EventHandler(this.cbEnUstKat_SelectedIndexChanged);
            // 
            // txtAltKat
            // 
            this.txtAltKat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAltKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAltKat.Location = new System.Drawing.Point(658, 70);
            this.txtAltKat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAltKat.Name = "txtAltKat";
            this.txtAltKat.Size = new System.Drawing.Size(15, 23);
            this.txtAltKat.TabIndex = 54;
            this.txtAltKat.Visible = false;
            // 
            // txtUstKat
            // 
            this.txtUstKat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUstKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUstKat.Location = new System.Drawing.Point(658, 43);
            this.txtUstKat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUstKat.Name = "txtUstKat";
            this.txtUstKat.Size = new System.Drawing.Size(15, 23);
            this.txtUstKat.TabIndex = 53;
            this.txtUstKat.Visible = false;
            // 
            // txtEnUstKat
            // 
            this.txtEnUstKat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEnUstKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEnUstKat.Location = new System.Drawing.Point(658, 18);
            this.txtEnUstKat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEnUstKat.Name = "txtEnUstKat";
            this.txtEnUstKat.Size = new System.Drawing.Size(15, 23);
            this.txtEnUstKat.TabIndex = 52;
            this.txtEnUstKat.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(392, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Kategori Seçiniz";
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Location = new System.Drawing.Point(104, 19);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(119, 21);
            this.txtUrunKodu.TabIndex = 5;
            this.txtUrunKodu.TextChanged += new System.EventHandler(this.txtUrunKodu_TextChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "KritikSeviye";
            this.columnHeader7.Width = 109;
            // 
            // lvUrunler
            // 
            this.lvUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader9,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvUrunler.FullRowSelect = true;
            this.lvUrunler.GridLines = true;
            this.lvUrunler.Location = new System.Drawing.Point(-1, 152);
            this.lvUrunler.Name = "lvUrunler";
            this.lvUrunler.Size = new System.Drawing.Size(763, 406);
            this.lvUrunler.TabIndex = 62;
            this.lvUrunler.UseCompatibleStateImageBehavior = false;
            this.lvUrunler.View = System.Windows.Forms.View.Details;
            this.lvUrunler.Click += new System.EventHandler(this.lvUrunler_Click);
            this.lvUrunler.DoubleClick += new System.EventHandler(this.lvUrunler_DoubleClick);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Marka";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Orange;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.lblKullanici,
            this.toolStripSeparator3,
            this.toolStripSeparator13,
            this.toolStripSeparator5,
            this.toolStripSeparator4,
            this.tsYeni,
            this.toolStripSeparator8,
            this.toolStripSeparator9,
            this.toolStripSeparator10,
            this.toolStripSeparator11,
            this.tsDegistirGuncelle,
            this.toolStripSeparator15,
            this.toolStripSeparator16,
            this.toolStripSeparator12,
            this.toolStripSeparator6,
            this.tsSil,
            this.toolStripSeparator7,
            this.toolStripSeparator14});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(764, 46);
            this.toolStrip1.TabIndex = 60;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 46);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 46);
            // 
            // lblKullanici
            // 
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(99, 43);
            this.lblKullanici.Text = "Administration";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 46);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 46);
            // 
            // tsYeni
            // 
            this.tsYeni.Image = global::WindowsFormsApplication1.Properties.Resources.add;
            this.tsYeni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsYeni.Name = "tsYeni";
            this.tsYeni.Size = new System.Drawing.Size(102, 43);
            this.tsYeni.Text = "&Yeni Urun Ekle";
            this.tsYeni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsYeni.Click += new System.EventHandler(this.tsYeni_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 46);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 46);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 46);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 46);
            // 
            // tsDegistirGuncelle
            // 
            this.tsDegistirGuncelle.Enabled = false;
            this.tsDegistirGuncelle.Image = global::WindowsFormsApplication1.Properties.Resources.Update;
            this.tsDegistirGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDegistirGuncelle.Name = "tsDegistirGuncelle";
            this.tsDegistirGuncelle.Size = new System.Drawing.Size(69, 43);
            this.tsDegistirGuncelle.Text = "&Güncelle ";
            this.tsDegistirGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsDegistirGuncelle.Click += new System.EventHandler(this.tsDegistirGuncelle_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 46);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 46);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 46);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 46);
            // 
            // tsSil
            // 
            this.tsSil.Enabled = false;
            this.tsSil.Image = global::WindowsFormsApplication1.Properties.Resources.Cancel;
            this.tsSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSil.Name = "tsSil";
            this.tsSil.Size = new System.Drawing.Size(26, 43);
            this.tsSil.Text = "&Sil";
            this.tsSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsSil.Click += new System.EventHandler(this.tsSil_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 46);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 46);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(6, 46);
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(6, 46);
            // 
            // UrunBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(764, 581);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvUrunler);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UrunBilgileri";
            this.Text = "Ürün Bilgileri";
            this.Load += new System.EventHandler(this.UrunBilgileri_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel slblDate;
        private System.Windows.Forms.ToolStripStatusLabel slblMesaj;
        private System.Windows.Forms.ToolStripStatusLabel slblKullanici;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUrunKodu;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ListView lvUrunler;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel lblKullanici;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsYeni;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton tsDegistirGuncelle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripButton tsSil;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TextBox txtUrunID;
        private System.Windows.Forms.ComboBox cbAltKat;
        private System.Windows.Forms.ComboBox cbUstKat;
        private System.Windows.Forms.ComboBox cbEnUstKat;
        private System.Windows.Forms.TextBox txtAltKat;
        private System.Windows.Forms.TextBox txtUstKat;
        private System.Windows.Forms.TextBox txtEnUstKat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMarkaID;
        private System.Windows.Forms.ComboBox cbMarkalar;
        private System.Windows.Forms.TextBox txtFirmaAdı;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
    }
}