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
    public partial class UrunDetayGoruntuleme : Form
    {
        public UrunDetayGoruntuleme()
        {
            InitializeComponent();
        }

        int sayi = 1;
        double fiyat;
        private void UrunDetayGoruntuleme_Load(object sender, EventArgs e)
        {
            txtMiktar.Text = sayi.ToString();
            txtMiktar.Select(0, txtMiktar.Text.Length);

            this.StartPosition = FormStartPosition.CenterScreen;
            Urun u = new Urun();
            u.UrunleriGetirDetayli(Genel.UrunID, lblUrunID, lblMarka, lblUrunAdi, lblUrunKodu, txtAciklamasi,lblUrunFiyati);

            fiyat = Convert.ToDouble(lblUrunFiyati.Text);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (Genel.MusteriID==0)
            {
                Genel.girisYapilmismi = false;
                Genel.GirisxKonumu = btnSepeteEkle.Location.X;
                Genel.GirisyKonumu = btnSepeteEkle.Location.Y;
                MGiris frm = new MGiris();
                frm.ShowDialog();
                Siparisler s = new Siparisler();
                s.MusteriID = Genel.MusteriID;
                s.OnayTarihi = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                s.OnayVerenID = 1;
                s.SiparisDurum = false;
                Genel.SiparisID = s.SiparisNoOlustur(s);
            }
            else
            {
                SiparisDetayi sd = new SiparisDetayi();
                if (sd.UrunVarmi(Convert.ToInt32(lblUrunID.Text),Genel.SiparisID))
                {
                    if (sd.SiparisDetayiGuncelle(Convert.ToInt32(lblUrunID.Text), Convert.ToInt32(txtMiktar.Text)))
                    {
                        MessageBox.Show("Ürün sepete eklendi");
                        this.Close();
                    }
                }
                else
                {
                    sd.MusteriID = Genel.MusteriID;
                    sd.BirimFiyat = Convert.ToDouble(lblUrunFiyati.Text) / Convert.ToInt32(txtMiktar.Text);
                    sd.SiparisID = Genel.SiparisID;
                    sd.UrunAciklama = txtAciklamasi.Text;
                    sd.UrunAdet = Convert.ToInt32(txtMiktar.Text);
                    sd.UrunID = Convert.ToInt32(lblUrunID.Text);
                    sd.UrunKDV = Convert.ToDouble(lblUrunFiyati.Text) * 18 / 100;
                    if (sd.SiparisDetayiKaydet(sd))
                    {
                        MessageBox.Show("Ürün sepete eklendi");
                        Genel.SepettekiUrunMiktari += 1;
                        this.Close();
                    }
                }
            }
            
        }

        private void btnarti_Click(object sender, EventArgs e)
        {
            btneksi.Enabled = true;
            Urun u = new Urun();
            if (sayi < u.UrunMiktarOgren(Convert.ToInt32(lblUrunID.Text)))
            {
                sayi++;
                txtMiktar.Text = sayi.ToString();
                lblUrunFiyati.Text = (Math.Round(Convert.ToDouble(fiyat*sayi), 2, MidpointRounding.AwayFromZero)).ToString();
            }
            else
                btnarti.Enabled = false;
        }

        private void btneksi_Click(object sender, EventArgs e)
        {
            btnarti.Enabled = true;
            if (sayi == 0)
            {
                btneksi.Enabled = false;
            }
            else
            {
                sayi--;
                txtMiktar.Text = sayi.ToString();
                lblUrunFiyati.Text = (Math.Round(Convert.ToDouble(fiyat * sayi), 2, MidpointRounding.AwayFromZero)).ToString();
            }
            
        }

        private void txtMiktar_Click(object sender, EventArgs e)
        {
            txtMiktar.Select(0, txtMiktar.Text.Length);
        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {

            txtMiktar.Select(0, txtMiktar.Text.Length);
        }
    }
}
