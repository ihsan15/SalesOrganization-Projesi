namespace WindowsFormsApplication1
{
    partial class MSepet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSepet));
            this.btnTamamla = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtToplamKDV = new System.Windows.Forms.TextBox();
            this.dgvSepet = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSepettenCikar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrunID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.btneksi = new System.Windows.Forms.Button();
            this.btnarti = new System.Windows.Forms.Button();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnDevamEt = new System.Windows.Forms.Button();
            this.ppdFis = new System.Windows.Forms.PrintPreviewDialog();
            this.pdocFis = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSepet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTamamla
            // 
            this.btnTamamla.BackColor = System.Drawing.Color.DarkOrange;
            this.btnTamamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamamla.Location = new System.Drawing.Point(405, 466);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(188, 35);
            this.btnTamamla.TabIndex = 1;
            this.btnTamamla.Text = "Alışverişi Tamamla";
            this.btnTamamla.UseVisualStyleBackColor = false;
            this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(403, 417);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 73;
            this.label8.Text = "TOPKDV";
            // 
            // txtToplamKDV
            // 
            this.txtToplamKDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamKDV.Location = new System.Drawing.Point(506, 414);
            this.txtToplamKDV.Name = "txtToplamKDV";
            this.txtToplamKDV.ReadOnly = true;
            this.txtToplamKDV.Size = new System.Drawing.Size(89, 21);
            this.txtToplamKDV.TabIndex = 72;
            this.txtToplamKDV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvSepet
            // 
            this.dgvSepet.AllowUserToAddRows = false;
            this.dgvSepet.AllowUserToDeleteRows = false;
            this.dgvSepet.BackgroundColor = System.Drawing.Color.Khaki;
            this.dgvSepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSepet.Location = new System.Drawing.Point(35, 74);
            this.dgvSepet.Name = "dgvSepet";
            this.dgvSepet.ReadOnly = true;
            this.dgvSepet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSepet.Size = new System.Drawing.Size(558, 324);
            this.dgvSepet.TabIndex = 70;
            this.dgvSepet.Click += new System.EventHandler(this.dgvSepet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.YellowGreen;
            this.btnGuncelle.Location = new System.Drawing.Point(617, 159);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(99, 35);
            this.btnGuncelle.TabIndex = 74;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSepettenCikar
            // 
            this.btnSepettenCikar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSepettenCikar.Enabled = false;
            this.btnSepettenCikar.Location = new System.Drawing.Point(616, 201);
            this.btnSepettenCikar.Name = "btnSepettenCikar";
            this.btnSepettenCikar.Size = new System.Drawing.Size(100, 35);
            this.btnSepettenCikar.TabIndex = 75;
            this.btnSepettenCikar.Text = "Seçili Ürünü Çıkar";
            this.btnSepettenCikar.UseVisualStyleBackColor = false;
            this.btnSepettenCikar.Click += new System.EventHandler(this.btnSepettenCikar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(615, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 73;
            this.label1.Text = "Ürün Adet Güncelle";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(-358, -270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 74;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(155, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 22);
            this.label2.TabIndex = 73;
            this.label2.Text = "SEPETİNİZDE BULUNAN ÜRÜNLER";
            // 
            // txtUrunID
            // 
            this.txtUrunID.Location = new System.Drawing.Point(35, 24);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.Size = new System.Drawing.Size(16, 20);
            this.txtUrunID.TabIndex = 77;
            this.txtUrunID.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(403, 443);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 79;
            this.label3.Text = "TOPLAM";
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamTutar.Location = new System.Drawing.Point(506, 440);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.ReadOnly = true;
            this.txtToplamTutar.Size = new System.Drawing.Size(89, 21);
            this.txtToplamTutar.TabIndex = 78;
            this.txtToplamTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btneksi
            // 
            this.btneksi.BackColor = System.Drawing.Color.YellowGreen;
            this.btneksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btneksi.Location = new System.Drawing.Point(617, 125);
            this.btneksi.Margin = new System.Windows.Forms.Padding(2);
            this.btneksi.Name = "btneksi";
            this.btneksi.Size = new System.Drawing.Size(19, 20);
            this.btneksi.TabIndex = 82;
            this.btneksi.Text = "-";
            this.btneksi.UseVisualStyleBackColor = false;
            this.btneksi.Click += new System.EventHandler(this.btneksi_Click);
            // 
            // btnarti
            // 
            this.btnarti.BackColor = System.Drawing.Color.YellowGreen;
            this.btnarti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnarti.Location = new System.Drawing.Point(674, 125);
            this.btnarti.Margin = new System.Windows.Forms.Padding(2);
            this.btnarti.Name = "btnarti";
            this.btnarti.Size = new System.Drawing.Size(19, 20);
            this.btnarti.TabIndex = 81;
            this.btnarti.Text = "+";
            this.btnarti.UseVisualStyleBackColor = false;
            this.btnarti.Click += new System.EventHandler(this.btnarti_Click);
            // 
            // txtMiktar
            // 
            this.txtMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktar.Location = new System.Drawing.Point(640, 124);
            this.txtMiktar.Margin = new System.Windows.Forms.Padding(2);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(30, 23);
            this.txtMiktar.TabIndex = 80;
            this.txtMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMiktar.Click += new System.EventHandler(this.txtMiktar_Click);
            this.txtMiktar.TextChanged += new System.EventHandler(this.txtMiktar_TextChanged);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.YellowGreen;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Location = new System.Drawing.Point(617, 242);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(100, 35);
            this.btnIptal.TabIndex = 83;
            this.btnIptal.Text = "İptal Et";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnDevamEt
            // 
            this.btnDevamEt.BackColor = System.Drawing.Color.Orange;
            this.btnDevamEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDevamEt.Location = new System.Drawing.Point(35, 466);
            this.btnDevamEt.Name = "btnDevamEt";
            this.btnDevamEt.Size = new System.Drawing.Size(188, 35);
            this.btnDevamEt.TabIndex = 84;
            this.btnDevamEt.Text = "Sepete Urun Ekle";
            this.btnDevamEt.UseVisualStyleBackColor = false;
            this.btnDevamEt.Click += new System.EventHandler(this.btnDevamEt_Click);
            // 
            // ppdFis
            // 
            this.ppdFis.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdFis.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdFis.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdFis.Document = this.pdocFis;
            this.ppdFis.Enabled = true;
            this.ppdFis.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdFis.Icon")));
            this.ppdFis.Name = "printPreviewDialog1";
            this.ppdFis.Visible = false;
            // 
            // pdocFis
            // 
            this.pdocFis.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdocFis_PrintPage);
            // 
            // MSepet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.orange_and_yellow_background_by_sailorfirephoenix1_d6038lx;
            this.ClientSize = new System.Drawing.Size(778, 536);
            this.Controls.Add(this.btnDevamEt);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btneksi);
            this.Controls.Add(this.btnarti);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.txtUrunID);
            this.Controls.Add(this.btnSepettenCikar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtToplamKDV);
            this.Controls.Add(this.dgvSepet);
            this.Controls.Add(this.btnTamamla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MSepet";
            this.Text = "Sepetiniz";
            this.Load += new System.EventHandler(this.MSepet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSepet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTamamla;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtToplamKDV;
        private System.Windows.Forms.DataGridView dgvSepet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSepettenCikar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrunID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Button btneksi;
        private System.Windows.Forms.Button btnarti;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnDevamEt;
        private System.Windows.Forms.PrintPreviewDialog ppdFis;
        private System.Drawing.Printing.PrintDocument pdocFis;

    }
}