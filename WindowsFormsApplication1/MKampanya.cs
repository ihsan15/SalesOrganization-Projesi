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
    public partial class MKampanya : Form
    {
        public MKampanya()
        {
            InitializeComponent();
        }

        private void lvKampanyalar_DoubleClick(object sender, EventArgs e)
        {
            if ((MessageBox.Show(lvKampanyalar.SelectedItems[0].SubItems[1].Text + "\n" + lvKampanyalar.SelectedItems[0].SubItems[2].Text + "\n" + lvKampanyalar.SelectedItems[0].SubItems[4].Text, "Yararlanmak İster misiniz? / Sepete Eklensin mi?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)) == DialogResult.OK)
            {
                Genel.UrunID = Convert.ToInt32(lvKampanyalar.SelectedItems[0].SubItems[0].Text);

                // sepet tablosuna eklenecek fakat müşteriıd si girilmemişken işlem yapamayabiliriz.

                // olumlu olursa ekran kapanacak
            }
        }

        private void lvKampanyalar_Click(object sender, EventArgs e)
        {
            txtUrunID.Text = lvKampanyalar.SelectedItems[0].SubItems[0].Text;
        }

        private void MKampanya_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            Urun u = new Urun();
            u.UrunleriGetirOnlyKampanyali(lvKampanyalar);

            Kategori k = new Kategori();
            k.KategorileriGetir(cbEnUstKat, "0");

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
            if (txtUrunArama.Text.Trim() == "")
                txtUrunArama.Text = "Lütfen aramak istediğiniz ürünü giriniz..";
        }

        private void txtUrunArama_TextChanged(object sender, EventArgs e)
        {
            Urun u = new Urun();
            if (txtUrunArama.Text == "Lütfen aramak istediğiniz ürünü giriniz..")
            {

                u.UrunleriGetirOnlyKampanyaliByUrunAdi("", lvKampanyalar);
            }
            else
                u.UrunleriGetirOnlyKampanyaliByUrunAdi(txtUrunArama.Text, lvKampanyalar);
        }

        private void cbEnUstKat_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEnUstKat.Clear();

            Kategori k = (Kategori)cbEnUstKat.SelectedItem;
            cbEnUstKat.SelectedItem = k.KategoriAdi;
            txtEnUstKat.Text = k.KategoriID.ToString();

            k.KategorileriGetir(cbUstKat, txtEnUstKat.Text);

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
            u.UrunleriGetirOnlyKampanyaliByKategoriNo(lvKampanyalar, txtAltKat.Text);
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (Genel.MusteriID == 0)
            {
                Genel.girisYapilmismi = false;
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
                if (sd.UrunVarmi(Convert.ToInt32(lvKampanyalar.SelectedItems[0].SubItems[0].Text),Genel.SiparisID))
                {
                    if (sd.SiparisDetayiGuncelle(Convert.ToInt32(lvKampanyalar.SelectedItems[0].SubItems[0].Text),1))
                    {
                        MessageBox.Show("Ürün sepete eklendi");
                        this.Close();
                    }
                }
                else
                {
                    sd.MusteriID = Genel.MusteriID;
                    sd.BirimFiyat = Convert.ToDouble(lvKampanyalar.SelectedItems[0].SubItems[3].Text);
                    sd.SiparisID = Genel.SiparisID;
                    sd.UrunAciklama = lvKampanyalar.SelectedItems[0].SubItems[4].Text;
                    sd.UrunAdet = 1;
                    sd.UrunID = Convert.ToInt32(lvKampanyalar.SelectedItems[0].SubItems[0].Text);
                    sd.UrunKDV = Convert.ToDouble(lvKampanyalar.SelectedItems[0].SubItems[3].Text) * 18 / 100;
                    if (sd.SiparisDetayiKaydet(sd))
                    {
                        MessageBox.Show("Ürün sepete eklendi");
                        Genel.SepettekiUrunMiktari += 1;
                        this.Close();
                    }
                }
                
            }
        }


    }
}
