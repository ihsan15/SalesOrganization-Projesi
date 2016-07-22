namespace WindowsFormsApplication1
{
    partial class TariheGoreArama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TariheGoreArama));
            this.btnGetir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpSonTarih = new System.Windows.Forms.DateTimePicker();
            this.dtpIlkTarih = new System.Windows.Forms.DateTimePicker();
            this.dgvFirmalar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirmalar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetir
            // 
            this.btnGetir.BackColor = System.Drawing.Color.YellowGreen;
            this.btnGetir.Location = new System.Drawing.Point(210, 49);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(180, 23);
            this.btnGetir.TabIndex = 76;
            this.btnGetir.Text = "Firmaları Getir";
            this.btnGetir.UseVisualStyleBackColor = false;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(293, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 75;
            this.label3.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(243, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 74;
            this.label4.Text = "Tarih Aralığı Seçiniz";
            // 
            // dtpSonTarih
            // 
            this.dtpSonTarih.Location = new System.Drawing.Point(308, 24);
            this.dtpSonTarih.Margin = new System.Windows.Forms.Padding(2);
            this.dtpSonTarih.Name = "dtpSonTarih";
            this.dtpSonTarih.Size = new System.Drawing.Size(104, 20);
            this.dtpSonTarih.TabIndex = 73;
            // 
            // dtpIlkTarih
            // 
            this.dtpIlkTarih.Location = new System.Drawing.Point(176, 24);
            this.dtpIlkTarih.Margin = new System.Windows.Forms.Padding(2);
            this.dtpIlkTarih.Name = "dtpIlkTarih";
            this.dtpIlkTarih.Size = new System.Drawing.Size(113, 20);
            this.dtpIlkTarih.TabIndex = 72;
            this.dtpIlkTarih.Value = new System.DateTime(2016, 5, 1, 0, 0, 0, 0);
            // 
            // dgvFirmalar
            // 
            this.dgvFirmalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFirmalar.Location = new System.Drawing.Point(11, 77);
            this.dgvFirmalar.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFirmalar.Name = "dgvFirmalar";
            this.dgvFirmalar.RowTemplate.Height = 24;
            this.dgvFirmalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFirmalar.Size = new System.Drawing.Size(605, 453);
            this.dgvFirmalar.TabIndex = 71;
            this.dgvFirmalar.DoubleClick += new System.EventHandler(this.dgvFirmalar_DoubleClick);
            // 
            // TariheGoreArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(627, 534);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpSonTarih);
            this.Controls.Add(this.dtpIlkTarih);
            this.Controls.Add(this.dgvFirmalar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TariheGoreArama";
            this.Text = "Tarihe Göre Arama";
            this.Load += new System.EventHandler(this.TariheGoreArama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirmalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpSonTarih;
        private System.Windows.Forms.DateTimePicker dtpIlkTarih;
        private System.Windows.Forms.DataGridView dgvFirmalar;

    }
}