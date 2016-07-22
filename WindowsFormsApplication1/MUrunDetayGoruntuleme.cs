using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Model;

namespace SaleOrganization
{
    public partial class MUrunDetayGoruntuleme : Form
    {
        private Label lblUrunID;
        private TextBox txtAciklamasi;
        private Label label3;
        private Label lblMarka;
        private Button btnKapat;
        private Button btnSepeteEkle;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label1;
        private Label lblStokMiktari;
        private Label lblUrunFiyati;
        private Label lblUrunAdi;
        private Label lblUrunKodu;
        private PictureBox pbUrunResim;
    
        public MUrunDetayGoruntuleme()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            // tıklandığında urunId si sepet bloğuna gönderilecek ardından sayfa kapatılacak. 
        }

        private void MUrunDetayGoruntuleme_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            Urun u = new Urun();
            u.UrunleriGetirDetayli(Genel.UrunID, lblUrunID, lblMarka, lblUrunAdi, lblUrunKodu, txtAciklamasi);
        }

        

        private void MUrunDetayGoruntuleme_Load_1(object sender, EventArgs e)
        {

        }

        private void btnSepeteEkle_Click_1(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click_1(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MUrunDetayGoruntuleme
            // 
            this.ClientSize = new System.Drawing.Size(866, 662);
            this.Name = "MUrunDetayGoruntuleme";
            this.ResumeLayout(false);

        }
    }
}
