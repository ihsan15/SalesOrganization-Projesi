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
    public partial class UrunBilgileri : Form
    {
        public UrunBilgileri()
        {
            InitializeComponent();
        }
        private void tsYeni_Click(object sender, EventArgs e)
        {
            Genel.UrunID = 0;
            UrunEkleGuncelle frm = new UrunEkleGuncelle();
            frm.ShowDialog();
            Urun u = new Urun();
            u.UrunleriGetirFromUrunBilgileri(lvUrunler);
        }

        private void UrunBilgileri_Load(object sender, EventArgs e)
        {
            Musteriler m = new Musteriler();
            lblKullanici.Text = m.KullaniciGetir(Genel.KullaniciID);

            Kategori k = new Kategori();
            k.KategorileriGetir(cbEnUstKat, "0");

            Urun u = new Urun();
            u.UrunleriGetirFromUrunBilgileri(lvUrunler);

            Markalar mar = new Markalar();
            mar.MarkaAdiGetir(cbMarkalar);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            u.UrunleriGetirFromUrunBilgileriByKategoriID(Convert.ToInt32(txtAltKat.Text), lvUrunler);
        }

        private void txtUrunKodu_TextChanged(object sender, EventArgs e)
        {
            DetayliUrunArama();
        }

        private void txtMarkaID_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtUrunAdi_TextChanged(object sender, EventArgs e)
        {
            DetayliUrunArama();
        }

        private void lvUrunler_Click(object sender, EventArgs e)
        {
            tsDegistirGuncelle.Enabled = true;
            tsSil.Enabled = true;
            txtUrunID.Text = lvUrunler.SelectedItems[0].SubItems[0].Text;
        }

        private void lvUrunler_DoubleClick(object sender, EventArgs e)
        {
            Genel.UrunID = Convert.ToInt32(lvUrunler.SelectedItems[0].SubItems[0].Text);
            UrunEkleGuncelle frm = new UrunEkleGuncelle();
            frm.ShowDialog();
            Urun u = new Urun();
            u.UrunleriGetirFromUrunBilgileri(lvUrunler);
        }

        private void cbMarkalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMarkaID.Clear();
            txtFirmaAdı.Text = cbMarkalar.SelectedItem.ToString();

            Markalar mar = (Markalar)cbMarkalar.SelectedItem;
            cbMarkalar.SelectedItem = mar.MarkaAdi;
            txtMarkaID.Text = mar.MarkaID.ToString();
        }

        private void DetayliUrunArama()
        {
            Urun u = new Urun();
            u.UrunleriGetirFromUrunBilgileriForDetayliArama(txtUrunKodu.Text, txtUrunAdi.Text, txtFirmaAdı.Text,  lvUrunler);
        }

        private void txtFirmaAdı_TextChanged(object sender, EventArgs e)
        {
            DetayliUrunArama();
        }

        private void tsDegistirGuncelle_Click(object sender, EventArgs e)
        {
            Genel.UrunID = Convert.ToInt32(lvUrunler.SelectedItems[0].SubItems[0].Text);
            UrunEkleGuncelle frm = new UrunEkleGuncelle();
            frm.ShowDialog();
            Urun u = new Urun();
            u.UrunleriGetirFromUrunBilgileri(lvUrunler);
        }

        private void tsSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor Musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Urun u = new Urun();
                if (u.UrunSil(Convert.ToInt32(lvUrunler.SelectedItems[0].SubItems[0].Text)))
                {
                    MessageBox.Show("Ürün Silindi");
                    u.UrunleriGetirFromUrunBilgileri(lvUrunler);
                }
            }
        }
    }
}
