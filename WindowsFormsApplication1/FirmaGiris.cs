using SaleOrganization;
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

namespace WindowsFormsApplication1
{
    public partial class FirmaGiris : Form
    {
        public FirmaGiris()
        {
            InitializeComponent();
        }

        private void FormAcilacakmi(Form AcilacakForm)
        {
            bool acikmi = false;
            for (int i = 0; i < this.MdiChildren.Count(); i++)
            {
                if (this.MdiChildren[i].Name == AcilacakForm.Name)
                {
                    this.MdiChildren[i].Focus();
                    acikmi = true;
                }
            }
            if (acikmi == false)
            {
                AcilacakForm.MdiParent = this;
                AcilacakForm.Show();
            }
            else
            {
                AcilacakForm.Dispose(); // oluşturulmuş form listesini doğrudan atabiliriz.
            }
        }

        private void FirmaGiris_Load(object sender, EventArgs e)
        {
            Musteriler m = new Musteriler();
            slblKullaniciAdi.Text = m.KullaniciGetir(Genel.KullaniciID);

            slblTarih.Text = DateTime.Now.ToShortDateString().ToString();
        }

        private void firmaBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirmaBilgileri frm = new FirmaBilgileri();
            FormAcilacakmi(frm);
        }

        private void ürünBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunBilgileri frm = new UrunBilgileri();
            FormAcilacakmi(frm);
        }
        private void miCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kasaHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KasaHareketleri frm = new KasaHareketleri();
            FormAcilacakmi(frm);
        }

        private void miYeniKullaniciTanimla_Click(object sender, EventArgs e)
        {
            Genel.sayfano = 0;
            KullaniciMusteriBilgileri frm = new KullaniciMusteriBilgileri();
            FormAcilacakmi(frm);
        }

        private void miKullaniciSorgulama_Click(object sender, EventArgs e)
        {
            Genel.sayfano = 1;
            KullaniciMusteriBilgileri frm = new KullaniciMusteriBilgileri();
            FormAcilacakmi(frm);
        }


    }
}
