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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }



        private void Anasayfa_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            Urun u = new Urun();
            u.UrunleriGetirFromAnasayfa(lvUrunler);

            lblKampanya.Text = u.KampanyaMiktari();

            Kategori k = new Kategori();
            k.KategorileriGetir(cbEnUstKat,"0");

            cbEnUstKat.Items.Insert(0, "Tüm Kategoriler");
            cbEnUstKat.SelectedIndex = 0;

        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            MYeniMusteri frm = new MYeniMusteri();
            frm.ShowDialog();
           
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Genel.GirisxKonumu = gbGiris.Location.X - 100;
            Genel.GirisyKonumu = gbGiris.Location.Y + 80;
            MGiris frm = new MGiris();
            frm.ShowDialog();

            if (Genel.FirmaGirisAcilsinMi)
            {
                FirmaGiris fg = new FirmaGiris();
                fg.Show();
            }
            else if (Genel.MusteriID != 0 )
            {
                gbGiris.Visible = false;
                toolStrip1.Visible = true;
                Musteriler m = new Musteriler();
                tslblMusteriAdi.Text = m.KullaniciGetir(Genel.MusteriID);
                Siparisler s = new Siparisler();
                s.MusteriID = Genel.MusteriID;
                s.OnayTarihi = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                s.OnayVerenID = 1;
                s.SiparisDurum = false;
                Genel.SiparisID = s.SiparisNoOlustur(s);
            }
        }

        private void btnSepet_Click(object sender, EventArgs e)
        {
            if (Genel.MusteriID != 0)
            {
                MSepet frm = new MSepet();
                frm.ShowDialog();
            }
            else
            {
                Giris();
            }
        }

        private void Giris()
        {
            Genel.GirisxKonumu = gbGiris.Location.X - 100;
            Genel.GirisyKonumu = gbGiris.Location.Y + 80;
            MGiris frm = new MGiris();
            frm.ShowDialog();

            if (Genel.FirmaGirisAcilsinMi)
            {
                FirmaGiris fg = new FirmaGiris();
                fg.Show();
            }
            else if (Genel.MusteriID != 0)
            {
                gbGiris.Visible = false;
                toolStrip1.Visible = true;
                Musteriler m = new Musteriler();
                tslblMusteriAdi.Text = m.KullaniciGetir(Genel.MusteriID);
                if (Genel.SiparisID == 0)
                {
                    Siparisler s = new Siparisler();
                    s.MusteriID = Genel.MusteriID;
                    s.OnayTarihi = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    s.OnayVerenID = 1;
                    s.SiparisDurum = false;
                    Genel.SiparisID = s.SiparisNoOlustur(s);
                }
            }
        }
        private void btnKampanya_Click(object sender, EventArgs e)
        {
            Genel.KampanyaxKonumu = btnKampanya.Location.X;
            Genel.KampanyayKonumu = btnKampanya.Location.Y;
            Genel.KampanyaAcikKalsinMi = false;
            lblKampanya.Visible = false;
            lblKampanya.Text = "0";
            MKampanya frm = new MKampanya();
            frm.ShowDialog();
            lblSepet.Text = Genel.SepettekiUrunMiktari.ToString();
            if (Genel.MusteriID != 0)
            {
                gbGiris.Visible = false;
                toolStrip1.Visible = true;
                Musteriler m = new Musteriler();
                tslblMusteriAdi.Text = m.KullaniciGetir(Genel.MusteriID);
            }
        }

        private void lvUrunler_DoubleClick(object sender, EventArgs e)
        {
            Genel.UrunID = Convert.ToInt32(lvUrunler.SelectedItems[0].SubItems[0].Text);
            Genel.SepettekiUrunMiktari = Convert.ToInt32(lblSepet.Text);

            UrunDetayGoruntuleme frm = new UrunDetayGoruntuleme();
            frm.ShowDialog();
            lblSepet.Text = Genel.SepettekiUrunMiktari.ToString();
            if (Genel.MusteriID != 0)
            {
                gbGiris.Visible = false;
                toolStrip1.Visible = true;
                Musteriler m = new Musteriler();
                tslblMusteriAdi.Text = m.KullaniciGetir(Genel.MusteriID);
            }
        }

        private void txtUrunArama_Click(object sender, EventArgs e)
        {
            if (txtUrunArama.Text == "Lütfen aramak istediğiniz ürünü giriniz..")
            {
                txtUrunArama.Text = "";
                txtUrunArama.Select(0, txtUrunArama.Text.Length);
            }
        }

        private void txtUrunArama_Leave(object sender, EventArgs e)
        {
            if (txtUrunArama.Text.Trim()== "")
                txtUrunArama.Text = "Lütfen aramak istediğiniz ürünü giriniz..";
        }

        private void txtUrunArama_TextChanged(object sender, EventArgs e)
        {
            Urun u = new Urun();
            if(txtUrunArama.Text=="Lütfen aramak istediğiniz ürünü giriniz..")
            {

                u.UrunleriGetirFromAnasayfaByUrunAdi("", lvUrunler);
            }
            else
                u.UrunleriGetirFromAnasayfaByUrunAdi(txtUrunArama.Text, lvUrunler);
        }

        private void cbEnUstKat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEnUstKat.SelectedIndex==0)
            {
                txtUstKat.Clear();
                txtAltKat.Clear();
                cbAltKat.Text = "";
                cbUstKat.Text = "";
                Urun u = new Urun();
                u.UrunleriGetirFromAnasayfa(lvUrunler);
            }
            else
            {
                txtEnUstKat.Clear();

                Kategori k = (Kategori)cbEnUstKat.SelectedItem;
                cbEnUstKat.SelectedItem = k.KategoriAdi;
                txtEnUstKat.Text = k.KategoriID.ToString();

                k.KategorileriGetir(cbUstKat, txtEnUstKat.Text);

            }
        }

        private void cbUstKat_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUstKat.Clear();

            Kategori k = (Kategori)cbUstKat.SelectedItem;
            cbUstKat.SelectedItem = k.KategoriAdi;
            txtUstKat.Text = k.KategoriID.ToString();
            k.KategorileriGetir(cbAltKat, txtUstKat.Text);

        }

        private void cbAltKat_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAltKat.Clear();
            Kategori k = (Kategori)cbAltKat.SelectedItem;
            cbAltKat.SelectedItem = k.KategoriAdi;
            txtAltKat.Text = k.KategoriID.ToString();

            Urun u = new Urun();
            u.UrunleriGetirFromAnasayfaByKategoriNo(lvUrunler, txtAltKat.Text);
        }

        private void btnUyeGiris_MouseHover(object sender, EventArgs e)
        {

            Giris();
        }

        private void lblHesabim_Click(object sender, EventArgs e)
        {
            if (Genel.MusteriID == 0)
            {
                Giris();
            }
            else
            {
                Hesabim h = new Hesabim();
                h.ShowDialog();
            }
        }

        private void lblYeniHesapOlustur_Click(object sender, EventArgs e)
        {
            MYeniMusteri frm = new MYeniMusteri();
            frm.ShowDialog();
        }

        private void lblOdeme_Click(object sender, EventArgs e)
        {
            if (Genel.MusteriID == 0)
            {
                Giris();
            }
            else
            {
                MSepet s = new MSepet();
                s.ShowDialog();
            }
        }

        private void lblTeslimat_Click(object sender, EventArgs e)
        {
            if (Genel.MusteriID == 0)
            {
                Giris();
            }
            else
            {
                SiparişBilgileri sb = new SiparişBilgileri();
                sb.ShowDialog();
            }
        }

        private void lblMusteriHizmetleri_Click(object sender, EventArgs e)
        {
            // sohbet penceresi aç
        }

        private void lblSikcaSorulanSorular_Click(object sender, EventArgs e)
        {
            // sıkça sorulan sorular
        }

        private void lblHakkimizda_Click(object sender, EventArgs e)
        {
            // hakkımızdakiler
        }

        private void lblIletisim_Click(object sender, EventArgs e)
        {
            // iletişim bilgileri
        }

        private void tsbtnHesabim_Click(object sender, EventArgs e)
        {
            Hesabim h = new Hesabim();
            h.ShowDialog();
        }

        private void tsbtnSiparislerim_Click(object sender, EventArgs e)
        {
            if (Genel.MusteriID == 0)
            {
                Giris();
            }
            else
            {
                SiparişBilgileri sb = new SiparişBilgileri();
                sb.ShowDialog();
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsbtnCikisYap_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        
    }
}
