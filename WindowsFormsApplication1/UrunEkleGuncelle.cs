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
    public partial class UrunEkleGuncelle : Form
    {
        public UrunEkleGuncelle()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        private void UrunEkleGuncelle_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;
            if (Genel.UrunID != 0)
            {
                Urun u = new Urun();
                if (u.UrunBilgileriGetir(Genel.UrunID, txtAltKat, txtAltKategori, txtFirmaAdı, txtFiyat, txtIndirimAciklamasi, txtIndirimliFiyat, txtKritikSeviye, txtMarkaID, txtStokMiktarı, txtUrunAciklamasi, txtUrunAdı, txtUrunID, txtUrunKodu))
                {
                    cbxKampanyaVarmi.Checked = true;
                }
                else
                    cbxKampanyaVarmi.Checked = false;

                txtStokMiktarı.ReadOnly = false;
            }
            else
            {
                txtStokMiktarı.ReadOnly = true;
                Temizle();
                txtStokMiktarı.Text = "1";
            }
            // kategoriler seçilecek
            Kategori k = new Kategori();
            k.KategorileriGetir(cbEnUstKat, "0");

            Markalar m = new Markalar();
            m.MarkaAdiGetir(cbMarkalar);

            // marka adları giriecek ve comboboz a dolacak
        }

        private void cbxKampanyaVarmi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxKampanyaVarmi.Checked)
            {
                gbKampanyaVar.Visible = true;
                gbKampanyaVar.Enabled = true;
            }
            else
            {
                gbKampanyaVar.Visible = false;
            }

            // eğer seçili olursa groupbox gözükecek
            // eğer seçim kapalıysa groupbox gözükmeyecek
        }

        private void cbEnUstKat_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEnUstKat.Clear();

            Kategori k = (Kategori)cbEnUstKat.SelectedItem;
            cbEnUstKat.SelectedItem = k.KategoriAdi;
            txtEnUstKat.Text = k.KategoriID.ToString();
            txtEnUstKategori.Text = cbEnUstKat.SelectedItem.ToString();
            k.KategorileriGetir(cbUstKat, txtEnUstKat.Text);
        }

        private void cbUstKat_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUstKat.Clear();

            Kategori k = (Kategori)cbUstKat.SelectedItem;
            cbUstKat.SelectedItem = k.KategoriAdi;
            txtUstKat.Text = k.KategoriID.ToString();
            txtUstKategori.Text = cbUstKat.SelectedItem.ToString();
            k.KategorileriGetir(cbAltKat, txtUstKat.Text);
        }

        private void cbAltKat_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAltKat.Clear();
            Kategori k = (Kategori)cbAltKat.SelectedItem;
            cbAltKat.SelectedItem = k.KategoriAdi;
            txtAltKat.Text = k.KategoriID.ToString();
            txtAltKategori.Text = cbAltKat.SelectedItem.ToString();
            txtUrunKodu.Text = cbEnUstKat.Text.Substring(0, 1) + cbUstKat.Text.Substring(0, 1) + cbAltKat.Text.Substring(0, 1) + rnd.Next(1000, 10000).ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMarkaID.Clear();
            txtFirmaAdı.Text = cbMarkalar.SelectedItem.ToString();

            Markalar mar = (Markalar)cbMarkalar.SelectedItem;
            cbMarkalar.SelectedItem = mar.MarkaAdi;
            txtMarkaID.Text = mar.MarkaID.ToString();

            //secilen markanın adı textbox a, ıd si, ıd textbox ına dolacak
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Urun u = new Urun();
            if (Genel.UrunID != 0)
            {
                u.UrunID = Convert.ToInt32(txtUrunID.Text);
                u.UrunAdi = txtUrunAdı.Text;
                u.UrunKodu = txtUrunKodu.Text;
                u.MarkaID = Convert.ToInt32(txtMarkaID.Text);
                u.KategoriID = Convert.ToInt32(txtAltKat.Text);
                u.Aciklamasi = txtUrunAciklamasi.Text;
                u.Fiyat = Convert.ToDouble(txtFiyat.Text);
                u.Miktar = Convert.ToInt32(txtStokMiktarı.Text);
                u.KritikSeviye = Convert.ToInt32(txtKritikSeviye.Text);
                if (cbxKampanyaVarmi.Checked)
                {
                    u.KampanyaVarMi = true;
                    u.KampanyaAciklamasi = txtIndirimAciklamasi.Text;
                    u.UrunIndirim = Convert.ToDouble(txtIndirimliFiyat.Text);
                }
                else
                {
                    u.KampanyaAciklamasi = "";
                    u.KampanyaVarMi = false;
                    u.UrunIndirim = 0;
                }
                u.EkleyenMusteriID = Genel.KullaniciID;
                if (u.UrunleriGuncelle(u))
                {
                    MessageBox.Show("Güncellendi.");
                    Genel.UrunID = 0;
                    this.Close();
                }

            }
            else
            {
                if (txtEnUstKat.Text.Trim() != "" && txtUstKat.Text.Trim() != "" && txtMarkaID.Text.Trim() != "" && txtUrunAdı.Text.Trim() != "" && txtFiyat.Text.Trim() != "" && txtKritikSeviye.Text.Trim() != "")
                {
                    bool Sonuc = u.UrunVarmi(txtUrunKodu.Text, txtUrunAdı.Text, Convert.ToInt32(txtMarkaID.Text));
                    if (Sonuc)
                    {
                        MessageBox.Show("Bu Ürün Daha Önce Kayıt Edilmiştir");
                        txtUrunAdı.Focus();
                    }
                    else
                    {
                        u.UrunAdi = txtUrunAdı.Text;
                        u.UrunKodu = txtUrunKodu.Text;
                        u.MarkaID = Convert.ToInt32(txtMarkaID.Text);
                        u.KategoriID = Convert.ToInt32(txtAltKat.Text);
                        u.Aciklamasi = txtUrunAciklamasi.Text;
                        u.Fiyat = Convert.ToDouble(txtFiyat.Text);
                        u.Miktar = Convert.ToInt32(txtStokMiktarı.Text);
                        u.KritikSeviye = Convert.ToInt32(txtKritikSeviye.Text);
                        if (cbxKampanyaVarmi.Checked)
                        {
                            u.KampanyaVarMi = true;
                            u.KampanyaAciklamasi = txtIndirimAciklamasi.Text;
                            u.UrunIndirim = Convert.ToDouble(txtIndirimliFiyat.Text);
                        }
                        else
                        {
                            u.KampanyaVarMi = false;
                            u.UrunIndirim = 0;
                            u.KampanyaAciklamasi ="";
                        }
                        u.EkleyenMusteriID = Genel.KullaniciID;
                        if (u.UrunEkle(u))
                        {
                            MessageBox.Show("Urun Kaydedildi");
                            Temizle();
                            this.Close();
                        }
                    }
                }
            }               
                
        }

        private void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox=(TextBox)item;
                    tbox.Clear();
                }                
            }
            cbxKampanyaVarmi.Checked = false;
            txtUrunAdı.Focus();
        }
    }
}
