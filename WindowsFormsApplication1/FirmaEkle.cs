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
    public partial class FirmaEkle : Form
    {
        public FirmaEkle()
        {
            InitializeComponent();
        }

        private void FirmaEkle_Load(object sender, EventArgs e)
        {
            Musteriler mus = new Musteriler();
            mus.IlleriGetir(cbIl);
            if (Genel.MarkaID != 0)
            {
                Markalar m = new Markalar();
                m.FirmalariGetirByDoubleClick(Genel.MarkaID, txtFirmaID, txtFirmaIsmi, txtSektor, txtFirmaYetkiliAdi, txtFirmaYetkiliSoyadi, txtFirmaTel, txtYetkiliMail, txtFirmaAdres, txtIl, txtIlce, txtAciklama, txtVergiDairesi, txtVergiNo, txtKayitTarihi, txtSehirNo, txtIlceNo);
                btnGuncelle.Visible = true;
                btnKaydet.Visible = false;
                Genel.MarkaID = 0;
            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Temizle()
        {
            txtFirmaID.Clear();
            txtFirmaIsmi.Clear();
            txtFirmaYetkiliAdi.Clear();
            txtFirmaYetkiliSoyadi.Clear();
            txtSektor.Clear();
            txtFirmaTel.Clear();
            txtYetkiliMail.Clear();
            txtFirmaAdres.Clear();
            //txtIl.Clear();
            //txtIlce.Clear();
            txtAciklama.Clear();
            txtVergiDairesi.Clear();
            txtVergiNo.Clear();
            txtKayitTarihi.Clear();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void cbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSehirNo.Clear();
            txtIl.Text = cbIl.SelectedItem.ToString();

            Musteriler m = new Musteriler();
            txtSehirNo.Text = m.SehirNoGetir(txtIl.Text);
        }

        private void cbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIlceNo.Clear();
            txtIlce.Text = cbIlce.SelectedItem.ToString();

            Musteriler m = new Musteriler();
            txtIlceNo.Text = m.IlceNoGetir(txtIlce.Text);
        }

        private void txtIl_TextChanged(object sender, EventArgs e)
        {
            Musteriler m = new Musteriler();
            txtSehirNo.Text = m.SehirNoGetir(txtIl.Text);
            m.IlceleriGetir(cbIlce, txtSehirNo.Text);
            cbIlce.Enabled = true;
        }

        private void txtIlce_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtFirmaIsmi.Text.Trim() != "" && txtFirmaYetkiliAdi.Text.Trim() != "" && txtFirmaYetkiliSoyadi.Text.Trim() != "" && txtFirmaTel.Text.Trim() != "" && txtYetkiliMail.Text.Trim() != "" && txtFirmaAdres.Text.Trim() != "" && txtSehirNo.Text.Trim() != "" && txtIlceNo.Text.Trim() != "" && txtVergiDairesi.Text.Trim() != "" && txtVergiNo.Text.Trim() != "")
            {
                Markalar m = new Markalar();
                bool Sonuc = m.MarkaVarmi(txtFirmaIsmi.Text, txtVergiNo.Text);
                if (Sonuc)
                {
                    MessageBox.Show("Bu Firma Daha Önceden Kayıtlı");
                    txtFirmaIsmi.Focus();
                }
                else
                {
                    m.MarkaAdi = txtFirmaIsmi.Text;
                    m.MarkaYetkiliAdi = txtFirmaYetkiliAdi.Text;
                    m.MarkaYetkiliSoyadi = txtFirmaYetkiliSoyadi.Text;
                    m.MarkaYetkiliTelefon = txtFirmaTel.Text;
                    m.MarkaYetkiliMail = txtYetkiliMail.Text;
                    m.MarkaYetkiliAdres = txtFirmaAdres.Text;
                    m.MarkaIl = Convert.ToInt32(txtSehirNo.Text);
                    m.MarkaIlce = Convert.ToInt32(txtIlceNo.Text);
                    m.MarkaVergiDairesi = txtVergiDairesi.Text;
                    m.MarkaVergiNo = txtVergiNo.Text;
                    m.MarkaKayitTarihi = Convert.ToDateTime(txtKayitTarihi.Text);
                    m.Aciklama = txtAciklama.Text;
                    m.SektorAdi = txtSektor.Text;
                    if (m.MarkaEkle(m))
                    {
                        MessageBox.Show("Firma Kayıt Edildi");
                        btnKaydet.Enabled = false;
                        Temizle();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Firma Güncellenemedi");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bilgileri Eksiksiz Giriniz");
            }
        }

        private void dtpKayitTarihi_ValueChanged(object sender, EventArgs e)
        {
            txtKayitTarihi.Text = dtpKayitTarihi.Value.ToShortDateString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtFirmaIsmi.Text.Trim() != "" && txtFirmaYetkiliAdi.Text.Trim() != "" && txtFirmaYetkiliSoyadi.Text.Trim() != "" && txtFirmaTel.Text.Trim() != "" && txtYetkiliMail.Text.Trim() != "" && txtFirmaAdres.Text.Trim() != "" && txtSehirNo.Text.Trim() != "" && txtIlceNo.Text.Trim() != "" && txtVergiDairesi.Text.Trim() != "" && txtVergiNo.Text.Trim() != "")
            {
                Markalar m = new Markalar();
                m.MarkaID =Convert.ToInt32(txtFirmaID.Text);
                m.MarkaAdi = txtFirmaIsmi.Text;
                m.MarkaYetkiliAdi = txtFirmaYetkiliAdi.Text;
                m.MarkaYetkiliSoyadi = txtFirmaYetkiliSoyadi.Text;
                m.MarkaYetkiliTelefon = txtFirmaTel.Text;
                m.MarkaYetkiliMail =txtYetkiliMail.Text;
                m.MarkaYetkiliAdres = txtFirmaAdres.Text;
                m.MarkaIl = Convert.ToInt32(txtSehirNo.Text);
                m.MarkaIlce = Convert.ToInt32(txtIlceNo.Text);
                m.MarkaVergiDairesi = txtVergiDairesi.Text;
                m.MarkaVergiNo = txtVergiNo.Text;
                m.MarkaKayitTarihi = Convert.ToDateTime(txtKayitTarihi.Text);
                m.Aciklama = txtAciklama.Text;
                m.SektorAdi = txtSektor.Text;
                if (m.MarkaGuncelle(m))
                {
                    MessageBox.Show("Firma Bilgileri Güncellendi");
                    btnKaydet.Enabled = false;
                    btnGuncelle.Enabled = false;
                    Temizle();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Firma Bilgileri Güncellenemedi.");
                }
            }
        }
    }
}
