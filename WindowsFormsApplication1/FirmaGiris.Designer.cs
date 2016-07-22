namespace WindowsFormsApplication1
{
    partial class FirmaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirmaGiris));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.slblKullaniciAdi = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblMesaj = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblTarih = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.firmaBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.kullanıcıBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miYeniKullaniciTanimla = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.miKullaniciSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.kasaHareketleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Gold;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slblKullaniciAdi,
            this.slblMesaj,
            this.slblTarih});
            this.statusStrip1.Location = new System.Drawing.Point(0, 580);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1020, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // slblKullaniciAdi
            // 
            this.slblKullaniciAdi.Name = "slblKullaniciAdi";
            this.slblKullaniciAdi.Size = new System.Drawing.Size(73, 17);
            this.slblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // slblMesaj
            // 
            this.slblMesaj.Name = "slblMesaj";
            this.slblMesaj.Size = new System.Drawing.Size(902, 17);
            this.slblMesaj.Spring = true;
            this.slblMesaj.Text = "Hoşgeldiniz";
            // 
            // slblTarih
            // 
            this.slblTarih.Name = "slblTarih";
            this.slblTarih.Size = new System.Drawing.Size(34, 17);
            this.slblTarih.Text = "Tarih";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Orange;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaBilgileriToolStripMenuItem,
            this.ürünBilgileriToolStripMenuItem,
            this.kullanıcıBilgileriToolStripMenuItem,
            this.kasaHareketleriToolStripMenuItem,
            this.miCikis});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1020, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // firmaBilgileriToolStripMenuItem
            // 
            this.firmaBilgileriToolStripMenuItem.Name = "firmaBilgileriToolStripMenuItem";
            this.firmaBilgileriToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.firmaBilgileriToolStripMenuItem.Text = "Firma Bilgileri";
            this.firmaBilgileriToolStripMenuItem.Click += new System.EventHandler(this.firmaBilgileriToolStripMenuItem_Click);
            // 
            // ürünBilgileriToolStripMenuItem
            // 
            this.ürünBilgileriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2});
            this.ürünBilgileriToolStripMenuItem.Name = "ürünBilgileriToolStripMenuItem";
            this.ürünBilgileriToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.ürünBilgileriToolStripMenuItem.Text = "Ürün Bilgileri";
            this.ürünBilgileriToolStripMenuItem.Click += new System.EventHandler(this.ürünBilgileriToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(57, 6);
            // 
            // kullanıcıBilgileriToolStripMenuItem
            // 
            this.kullanıcıBilgileriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miYeniKullaniciTanimla,
            this.toolStripSeparator3,
            this.miKullaniciSorgulama});
            this.kullanıcıBilgileriToolStripMenuItem.Name = "kullanıcıBilgileriToolStripMenuItem";
            this.kullanıcıBilgileriToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.kullanıcıBilgileriToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            // 
            // miYeniKullaniciTanimla
            // 
            this.miYeniKullaniciTanimla.Name = "miYeniKullaniciTanimla";
            this.miYeniKullaniciTanimla.Size = new System.Drawing.Size(161, 22);
            this.miYeniKullaniciTanimla.Text = "Kullanıcı Bilgileri";
            this.miYeniKullaniciTanimla.Click += new System.EventHandler(this.miYeniKullaniciTanimla_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(158, 6);
            // 
            // miKullaniciSorgulama
            // 
            this.miKullaniciSorgulama.Name = "miKullaniciSorgulama";
            this.miKullaniciSorgulama.Size = new System.Drawing.Size(161, 22);
            this.miKullaniciSorgulama.Text = "Müşteri Bilgileri";
            this.miKullaniciSorgulama.Click += new System.EventHandler(this.miKullaniciSorgulama_Click);
            // 
            // kasaHareketleriToolStripMenuItem
            // 
            this.kasaHareketleriToolStripMenuItem.Name = "kasaHareketleriToolStripMenuItem";
            this.kasaHareketleriToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.kasaHareketleriToolStripMenuItem.Text = "Kasa Hareketleri";
            this.kasaHareketleriToolStripMenuItem.Click += new System.EventHandler(this.kasaHareketleriToolStripMenuItem_Click);
            // 
            // miCikis
            // 
            this.miCikis.Name = "miCikis";
            this.miCikis.Size = new System.Drawing.Size(44, 20);
            this.miCikis.Text = "Çıkış";
            this.miCikis.Click += new System.EventHandler(this.miCikis_Click);
            // 
            // FirmaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.orange_and_yellow_background_by_sailorfirephoenix1_d6038lx;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 602);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FirmaGiris";
            this.Text = "Firma Girişi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FirmaGiris_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel slblKullaniciAdi;
        private System.Windows.Forms.ToolStripStatusLabel slblMesaj;
        private System.Windows.Forms.ToolStripStatusLabel slblTarih;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem firmaBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miYeniKullaniciTanimla;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem miKullaniciSorgulama;
        private System.Windows.Forms.ToolStripMenuItem miCikis;
        private System.Windows.Forms.ToolStripMenuItem kasaHareketleriToolStripMenuItem;
    }
}