namespace WindowsFormsApplication1
{
    partial class SiparişBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparişBilgileri));
            this.dgvSiparis = new System.Windows.Forms.DataGridView();
            this.dgvSiparisDetayi = new System.Windows.Forms.DataGridView();
            this.dtpSonTarih = new System.Windows.Forms.DateTimePicker();
            this.dtpIlkTarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtToplamAlisveris = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAlisveriTutar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAlisverisMiktari = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetayi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSiparis
            // 
            this.dgvSiparis.BackgroundColor = System.Drawing.Color.Khaki;
            this.dgvSiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparis.Location = new System.Drawing.Point(3, 95);
            this.dgvSiparis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSiparis.Name = "dgvSiparis";
            this.dgvSiparis.RowTemplate.Height = 24;
            this.dgvSiparis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiparis.Size = new System.Drawing.Size(595, 558);
            this.dgvSiparis.TabIndex = 0;
            this.dgvSiparis.Click += new System.EventHandler(this.dgvSiparis_Click);
            this.dgvSiparis.DoubleClick += new System.EventHandler(this.dgvSiparis_DoubleClick);
            // 
            // dgvSiparisDetayi
            // 
            this.dgvSiparisDetayi.BackgroundColor = System.Drawing.Color.Khaki;
            this.dgvSiparisDetayi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisDetayi.Location = new System.Drawing.Point(603, 95);
            this.dgvSiparisDetayi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSiparisDetayi.Name = "dgvSiparisDetayi";
            this.dgvSiparisDetayi.RowTemplate.Height = 24;
            this.dgvSiparisDetayi.Size = new System.Drawing.Size(595, 558);
            this.dgvSiparisDetayi.TabIndex = 1;
            this.dgvSiparisDetayi.Visible = false;
            // 
            // dtpSonTarih
            // 
            this.dtpSonTarih.Location = new System.Drawing.Point(375, 54);
            this.dtpSonTarih.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpSonTarih.Name = "dtpSonTarih";
            this.dtpSonTarih.Size = new System.Drawing.Size(149, 22);
            this.dtpSonTarih.TabIndex = 42;
            // 
            // dtpIlkTarih
            // 
            this.dtpIlkTarih.Location = new System.Drawing.Point(199, 54);
            this.dtpIlkTarih.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpIlkTarih.Name = "dtpIlkTarih";
            this.dtpIlkTarih.Size = new System.Drawing.Size(149, 22);
            this.dtpIlkTarih.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Tarih Aralığı Seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(355, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(171, 682);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Toplam Alışveriş Miktarı";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtToplamAlisveris
            // 
            this.txtToplamAlisveris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamAlisveris.Location = new System.Drawing.Point(237, 724);
            this.txtToplamAlisveris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtToplamAlisveris.Multiline = true;
            this.txtToplamAlisveris.Name = "txtToplamAlisveris";
            this.txtToplamAlisveris.Size = new System.Drawing.Size(55, 43);
            this.txtToplamAlisveris.TabIndex = 46;
            this.txtToplamAlisveris.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(195, 655);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Bizden Yaptığınız";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(832, 655);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 54;
            this.label6.Text = "Bu Fişte ki";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Visible = false;
            // 
            // txtAlisveriTutar
            // 
            this.txtAlisveriTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlisveriTutar.Location = new System.Drawing.Point(995, 724);
            this.txtAlisveriTutar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAlisveriTutar.Multiline = true;
            this.txtAlisveriTutar.Name = "txtAlisveriTutar";
            this.txtAlisveriTutar.Size = new System.Drawing.Size(89, 43);
            this.txtAlisveriTutar.TabIndex = 53;
            this.txtAlisveriTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAlisveriTutar.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(947, 682);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 20);
            this.label7.TabIndex = 52;
            this.label7.Text = "Toplam Alışveriş Tutarı\r\n";
            this.label7.Visible = false;
            // 
            // txtAlisverisMiktari
            // 
            this.txtAlisverisMiktari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlisverisMiktari.Location = new System.Drawing.Point(751, 724);
            this.txtAlisverisMiktari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAlisverisMiktari.Multiline = true;
            this.txtAlisverisMiktari.Name = "txtAlisverisMiktari";
            this.txtAlisverisMiktari.Size = new System.Drawing.Size(55, 43);
            this.txtAlisverisMiktari.TabIndex = 51;
            this.txtAlisverisMiktari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAlisverisMiktari.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(685, 682);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 20);
            this.label8.TabIndex = 50;
            this.label8.Text = "Toplam Alışveriş Miktarı";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Visible = false;
            // 
            // SiparişBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1213, 775);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAlisveriTutar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAlisverisMiktari);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtToplamAlisveris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpSonTarih);
            this.Controls.Add(this.dtpIlkTarih);
            this.Controls.Add(this.dgvSiparisDetayi);
            this.Controls.Add(this.dgvSiparis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SiparişBilgileri";
            this.Text = "Sipariş Bilgileri";
            this.Load += new System.EventHandler(this.SiparişBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetayi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSiparis;
        private System.Windows.Forms.DataGridView dgvSiparisDetayi;
        private System.Windows.Forms.DateTimePicker dtpSonTarih;
        private System.Windows.Forms.DateTimePicker dtpIlkTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtToplamAlisveris;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAlisveriTutar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAlisverisMiktari;
        private System.Windows.Forms.Label label8;
    }
}