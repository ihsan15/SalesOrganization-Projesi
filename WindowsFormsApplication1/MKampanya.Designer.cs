namespace WindowsFormsApplication1
{
    partial class MKampanya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MKampanya));
            this.cbAltKat = new System.Windows.Forms.ComboBox();
            this.cbUstKat = new System.Windows.Forms.ComboBox();
            this.cbEnUstKat = new System.Windows.Forms.ComboBox();
            this.txtAltKat = new System.Windows.Forms.TextBox();
            this.txtUstKat = new System.Windows.Forms.TextBox();
            this.txtEnUstKat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunArama = new System.Windows.Forms.TextBox();
            this.lvKampanyalar = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtUrunID = new System.Windows.Forms.TextBox();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbAltKat
            // 
            this.cbAltKat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbAltKat.DropDownWidth = 100;
            this.cbAltKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbAltKat.FormattingEnabled = true;
            this.cbAltKat.Location = new System.Drawing.Point(196, 60);
            this.cbAltKat.Margin = new System.Windows.Forms.Padding(2);
            this.cbAltKat.Name = "cbAltKat";
            this.cbAltKat.Size = new System.Drawing.Size(152, 23);
            this.cbAltKat.TabIndex = 51;
            this.cbAltKat.SelectedIndexChanged += new System.EventHandler(this.cbAltKat_SelectedIndexChanged);
            // 
            // cbUstKat
            // 
            this.cbUstKat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbUstKat.DropDownWidth = 100;
            this.cbUstKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbUstKat.FormattingEnabled = true;
            this.cbUstKat.Location = new System.Drawing.Point(196, 34);
            this.cbUstKat.Margin = new System.Windows.Forms.Padding(2);
            this.cbUstKat.Name = "cbUstKat";
            this.cbUstKat.Size = new System.Drawing.Size(152, 23);
            this.cbUstKat.TabIndex = 50;
            this.cbUstKat.SelectedIndexChanged += new System.EventHandler(this.cbUstKat_SelectedIndexChanged);
            // 
            // cbEnUstKat
            // 
            this.cbEnUstKat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbEnUstKat.DropDownWidth = 100;
            this.cbEnUstKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbEnUstKat.FormattingEnabled = true;
            this.cbEnUstKat.Location = new System.Drawing.Point(196, 8);
            this.cbEnUstKat.Margin = new System.Windows.Forms.Padding(2);
            this.cbEnUstKat.Name = "cbEnUstKat";
            this.cbEnUstKat.Size = new System.Drawing.Size(152, 23);
            this.cbEnUstKat.TabIndex = 48;
            this.cbEnUstKat.SelectedIndexChanged += new System.EventHandler(this.cbEnUstKat_SelectedIndexChanged);
            // 
            // txtAltKat
            // 
            this.txtAltKat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAltKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAltKat.Location = new System.Drawing.Point(352, 60);
            this.txtAltKat.Margin = new System.Windows.Forms.Padding(2);
            this.txtAltKat.Name = "txtAltKat";
            this.txtAltKat.Size = new System.Drawing.Size(15, 23);
            this.txtAltKat.TabIndex = 54;
            this.txtAltKat.Visible = false;
            // 
            // txtUstKat
            // 
            this.txtUstKat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUstKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUstKat.Location = new System.Drawing.Point(352, 33);
            this.txtUstKat.Margin = new System.Windows.Forms.Padding(2);
            this.txtUstKat.Name = "txtUstKat";
            this.txtUstKat.Size = new System.Drawing.Size(15, 23);
            this.txtUstKat.TabIndex = 53;
            this.txtUstKat.Visible = false;
            // 
            // txtEnUstKat
            // 
            this.txtEnUstKat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEnUstKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEnUstKat.Location = new System.Drawing.Point(352, 8);
            this.txtEnUstKat.Margin = new System.Windows.Forms.Padding(2);
            this.txtEnUstKat.Name = "txtEnUstKat";
            this.txtEnUstKat.Size = new System.Drawing.Size(15, 23);
            this.txtEnUstKat.TabIndex = 52;
            this.txtEnUstKat.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(53, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Kategori Seçiniz";
            // 
            // txtUrunArama
            // 
            this.txtUrunArama.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUrunArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunArama.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUrunArama.Location = new System.Drawing.Point(392, 58);
            this.txtUrunArama.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrunArama.Name = "txtUrunArama";
            this.txtUrunArama.Size = new System.Drawing.Size(262, 24);
            this.txtUrunArama.TabIndex = 55;
            this.txtUrunArama.Text = "Lütfen aramak istediğiniz ürünü giriniz..";
            this.txtUrunArama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUrunArama.Click += new System.EventHandler(this.txtUrunArama_Click);
            this.txtUrunArama.TextChanged += new System.EventHandler(this.txtUrunArama_TextChanged);
            this.txtUrunArama.Leave += new System.EventHandler(this.txtUrunArama_Leave);
            // 
            // lvKampanyalar
            // 
            this.lvKampanyalar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader4});
            this.lvKampanyalar.FullRowSelect = true;
            this.lvKampanyalar.GridLines = true;
            this.lvKampanyalar.Location = new System.Drawing.Point(59, 95);
            this.lvKampanyalar.Margin = new System.Windows.Forms.Padding(2);
            this.lvKampanyalar.Name = "lvKampanyalar";
            this.lvKampanyalar.Size = new System.Drawing.Size(524, 336);
            this.lvKampanyalar.TabIndex = 0;
            this.lvKampanyalar.UseCompatibleStateImageBehavior = false;
            this.lvKampanyalar.View = System.Windows.Forms.View.Details;
            this.lvKampanyalar.Click += new System.EventHandler(this.lvKampanyalar_Click);
            this.lvKampanyalar.DoubleClick += new System.EventHandler(this.lvKampanyalar_DoubleClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "UrunID";
            this.columnHeader5.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Kodu";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 77;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ürün";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kampanyalar";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Açıklama";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 225;
            // 
            // txtUrunID
            // 
            this.txtUrunID.Location = new System.Drawing.Point(587, 119);
            this.txtUrunID.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.ReadOnly = true;
            this.txtUrunID.Size = new System.Drawing.Size(8, 20);
            this.txtUrunID.TabIndex = 1;
            this.txtUrunID.Visible = false;
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSepeteEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSepeteEkle.Image = global::WindowsFormsApplication1.Properties.Resources._1464016474_cart;
            this.btnSepeteEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSepeteEkle.Location = new System.Drawing.Point(598, 361);
            this.btnSepeteEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(75, 70);
            this.btnSepeteEkle.TabIndex = 2;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSepeteEkle.UseVisualStyleBackColor = false;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // MKampanya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.orange_and_yellow_background_by_sailorfirephoenix1_d6038lx;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(693, 452);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.txtUrunArama);
            this.Controls.Add(this.txtUrunID);
            this.Controls.Add(this.cbAltKat);
            this.Controls.Add(this.lvKampanyalar);
            this.Controls.Add(this.cbUstKat);
            this.Controls.Add(this.cbEnUstKat);
            this.Controls.Add(this.txtAltKat);
            this.Controls.Add(this.txtUstKat);
            this.Controls.Add(this.txtEnUstKat);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MKampanya";
            this.Text = "Kampanyalar";
            this.Load += new System.EventHandler(this.MKampanya_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAltKat;
        private System.Windows.Forms.ComboBox cbUstKat;
        private System.Windows.Forms.ComboBox cbEnUstKat;
        private System.Windows.Forms.TextBox txtAltKat;
        private System.Windows.Forms.TextBox txtUstKat;
        private System.Windows.Forms.TextBox txtEnUstKat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrunArama;
        private System.Windows.Forms.ListView lvKampanyalar;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtUrunID;
        private System.Windows.Forms.Button btnSepeteEkle;
    }
}