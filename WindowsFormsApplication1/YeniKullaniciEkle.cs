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
    public partial class YeniKullaniciEkle : Form
    {
        public YeniKullaniciEkle()
        {
            InitializeComponent();
        }

        private void cbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSehirNo.Clear();
            txtIl.Text = cbIl.SelectedItem.ToString();
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
        private void YeniKullaniciEkle_Load(object sender, EventArgs e)
        {
            Musteriler m = new Musteriler();
            m.IlleriGetir(cbIl);
            if (Genel.SecilenKullaniciID != 0 || Genel.SecilenMusteriID != 0)
            {
                int kullanici = 0;
                string cinsiyet = "";
                if (Genel.SecilenKullaniciID != 0)
                {
                    kullanici = Genel.SecilenKullaniciID;
                }
                else
                    kullanici = Genel.SecilenMusteriID;

                cinsiyet = m.HesapBilgileriniGetir(kullanici, txtAdres, txtEMail, txtIl, txtIlce, txtIlceNo, txtKullaniciAdi, txtPostaKodu, txtSehirNo, txtSifre, txtSifreTekrar, mtxtDogumTarihi, mtxtTC, mtxtTelefon, txtMusteriAdi, txtSoyad);
                if (cinsiyet == "ERKEK")
                {
                    rbErkek.Checked = true;
                }
                else if (cinsiyet == "KADIN")
                {
                    rbKadin.Checked = true;
                }
                if (m.kullaniciMi(kullanici))
                {
                    cbxKullaniciMi.Checked = true;
                }
                else if (m.kullaniciMi(kullanici) == false)
                {
                    cbxKullaniciMi.Checked = false;
                }
            }
            else
            {
                Temizle();
            }
        }

        private void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
                else if (item is MaskedTextBox)
                {
                    MaskedTextBox mtbox = (MaskedTextBox)item;
                    mtbox.Clear();
                }
            }
            txtMusteriAdi.Focus();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Musteriler m = new Musteriler();
            if (Genel.SecilenKullaniciID != 0 || Genel.SecilenMusteriID != 0)
            {
                if (Genel.SecilenKullaniciID != 0)
                {
                    m.MusteriID = Genel.SecilenKullaniciID;
                }
                else
                    m.MusteriID = Genel.SecilenMusteriID;
                m.MusteriMail = txtEMail.Text;
                m.MusteriNick = txtKullaniciAdi.Text;
                m.MusterSifre = txtSifre.Text;
                m.MusteriAdi = txtMusteriAdi.Text;
                m.MusteriSoyadi = txtSoyad.Text;
                if (rbErkek.Checked)
                    m.Cinsiyet = "erkek";
                else if (rbKadin.Checked)
                    m.Cinsiyet = "kadın";
                m.DogumTarihi = Convert.ToDateTime(mtxtDogumTarihi.Text);
                m.MusteriTelefon = mtxtTelefon.Text;
                m.TCKimlikNo = mtxtTC.Text;
                m.MusteriAdresi = txtAdres.Text;
                m.MusteriIlID = Convert.ToInt32(txtSehirNo.Text);
                m.MusteriIlceID = Convert.ToInt32(txtIlceNo.Text);
                m.PostaKodu = txtPostaKodu.Text;
                if (m.KullaniciGuncelle(m))
                {
                    MessageBox.Show("Güncellendi");
                    Genel.SecilenMusteriID = 0;
                    Genel.SecilenKullaniciID = 0;
                    this.Close();
                }
            }
            else
            {
                m.MusteriMail = txtEMail.Text;
                m.MusteriNick = txtKullaniciAdi.Text;
                m.MusterSifre = txtSifre.Text;
                m.MusteriAdi = txtMusteriAdi.Text;
                m.MusteriSoyadi = txtSoyad.Text;
                if (rbErkek.Checked)
                    m.Cinsiyet = "erkek";
                else if (rbErkek.Checked)
                    m.Cinsiyet = "kadın";
                m.DogumTarihi = Convert.ToDateTime(mtxtDogumTarihi.Text);
                m.MusteriTelefon = mtxtTelefon.Text;
                m.TCKimlikNo = mtxtTC.Text;
                m.MusteriAdresi = txtAdres.Text;
                m.MusteriIlID = Convert.ToInt32(txtSehirNo.Text);
                m.MusteriIlceID = Convert.ToInt32(txtIlceNo.Text);
                m.PostaKodu = txtPostaKodu.Text;
                if (cbxKullaniciMi.Checked == true)
                    m.KullaniciMi = 1;
                else
                    m.KullaniciMi = 0;
                if (m.MusteriKaydet(m))
                {
                    MessageBox.Show("Kaydedildi.");
                    Genel.SecilenMusteriID = 0;
                    Genel.SecilenKullaniciID = 0;
                    this.Close();
                }
            }
        }

    }
}
