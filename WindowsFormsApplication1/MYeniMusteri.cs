using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.AraIslemler;
using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1
{
    public partial class MYeniMusteri : Form
    {
        public MYeniMusteri()
        {
            InitializeComponent();
        }

        private void MYeniMusteri_Load(object sender, EventArgs e)
        {
            this.Top = 20;
            this.Left = 105;
            gbAdresBilgileri.Visible = false;
            gbKullaniciBilgileri.Visible = false;

            GuvenlikKoduOlusturma gko = new GuvenlikKoduOlusturma();
            gko.GuvenlikKoduOluştur(lblGuvenlikKodu);

            Musteriler m = new Musteriler();
            m.IlleriGetir(cbIl);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }

        private void btnDevamEt_Click(object sender, EventArgs e)
        {
            string hatamessage = "";
            Musteriler m = new Musteriler();
            if (txtKullaniciAdi.Text.Trim() != "" && txtEMail.Text.Trim() != "" && txtSifre.Text.Trim() != "" && txtSifreTekrar.Text.Trim() != "" && lblGuvenlikKodu.Text == txtGuvenlikKodu.Text && txtSifre.Text.Length >= 4 && m.KullaniciAdiVarmi(txtKullaniciAdi.Text)==false)
            {
                gbUyelikBilgileri.Visible = false;
                gbAdresBilgileri.Visible = false;
                gbKullaniciBilgileri.Visible = true;
            }
            else
            {
                if (txtKullaniciAdi.Text == "")
                {
                    hatamessage += "Kullanıcı Adı\n";
                    txtKullaniciAdi.Focus();
                }
                if (txtEMail.Text == "")
                {
                    hatamessage += "E-Mail\n";
                    txtEMail.Focus();
                }
                if (txtSifre.Text == "")
                {
                    hatamessage += "Sifre\n";
                }
                if (lblGuvenlikKodu.Text != txtGuvenlikKodu.Text)
                {
                    Temizle();
                    txtEMail.Focus();
                    hatamessage += "Güvenlik Kodu\n";
                }

                MessageBox.Show(hatamessage + "BOŞ GEÇİLEMEZ", "HATA!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
            
        }

        private void Temizle()
        {
            txtKullaniciAdi.Clear();
            txtEMail.Clear();
            txtSifre.Clear();
            txtSifreTekrar.Clear();
            txtGuvenlikKodu.Clear();
            txtKullaniciAdi.BackColor = Color.White;
            txtEMail.BackColor = Color.White;
            txtSifre.BackColor = Color.White;
            txtSifreTekrar.BackColor = Color.White;
        }

        private void btnDevamEt2_Click(object sender, EventArgs e)
        {
            string hatamessage = "";
            Musteriler m = new Musteriler();
            if (txtMusteriAdi.Text.Trim() != "" && txtSoyad.Text.Trim() != "" && mtxtDogumTarihi.Text != "00/00/0000" && (rbErkek.Checked || rbKadin.Checked) && mtxtTC.Text.Length==11)
            {
                gbUyelikBilgileri.Visible = false;
                gbAdresBilgileri.Visible = true;
                gbKullaniciBilgileri.Visible = false;
            }
            else
            {
                if (txtMusteriAdi.Text == "")
                {
                    hatamessage += "Adınız\n";
                    txtKullaniciAdi.Focus();
                }
                if (txtSoyad.Text == "")
                {
                    hatamessage += "Soyadınız\n";
                    txtSoyad.Focus();
                }
                if (mtxtDogumTarihi.Text == "00/00/0000")
                {
                    hatamessage += "Doğum Tarihi\n";
                }
                if (rbErkek.Checked==false && rbKadin.Checked==false)
                {
                    hatamessage += "Cinsiyet\n";
                }
                if(mtxtTC.Text.Length<11)
                {
                    hatamessage += "TC Kimlik No\n";
                }

                MessageBox.Show(hatamessage + "BOŞ GEÇİLEMEZ", "HATA!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGeriDon2_Click(object sender, EventArgs e)
        {
            GuvenlikKoduOlusturma gko = new GuvenlikKoduOlusturma();
            gko.GuvenlikKoduOluştur(lblGuvenlikKodu);

            gbUyelikBilgileri.Visible = true;
            gbAdresBilgileri.Visible = false;
            gbKullaniciBilgileri.Visible = false;
        }

        private void btnGeriDon3_Click(object sender, EventArgs e)
        {
            gbUyelikBilgileri.Visible = false;
            gbAdresBilgileri.Visible = false;
            gbKullaniciBilgileri.Visible = true;
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            
            if (txtAdresAdi.Text.Trim() != "" && txtIl.Text.Trim() != "" && txtIlce.Text.Trim() != "" && txtAdres.Text.Trim() != "" && mtxtTelefon.Text != "(999) 000-0000")
            {
                Musteriler m = new Musteriler();
                m.MusteriMail = txtEMail.Text;
                m.MusteriNick = txtKullaniciAdi.Text;
                m.MusterSifre = txtSifre.Text;
                m.MusteriAdi = txtMusteriAdi.Text;
                m.MusteriSoyadi = txtSoyad.Text;
                if (rbErkek.Checked)
                    m.Cinsiyet= "erkek";
                else if (rbKadin.Checked)
                    m.Cinsiyet = "kadın";
                m.DogumTarihi= Convert.ToDateTime(mtxtDogumTarihi.Text);
                m.MusteriTelefon = mtxtTelefon.Text;
                m.TCKimlikNo = mtxtTC.Text;
                m.MusteriAdresi = txtAdresAdi.Text + "\n" + txtAdres.Text;
                m.MusteriIlID = Convert.ToInt32(txtSehirNo.Text);
                m.MusteriIlceID = Convert.ToInt32(txtIlceNo.Text);
                m.PostaKodu = txtPostaKodu.Text;
                if (m.MusteriKaydet(m))
                {
                    MessageBox.Show("Musteri Kaydet");
                }
            }
            else
            {
                string hatamessage = "";
                if (txtAdresAdi.Text == "")
                {
                    hatamessage += "Adres Adı\n";
                    txtKullaniciAdi.Focus();
                }
                if (txtIl.Text == "")
                {
                    hatamessage += "İl\n";
                    txtSoyad.Focus();
                }
                if (txtIlce.Text == "")
                {
                    hatamessage += "İlçe\n";
                }
                if(txtAdres.Text == "")
                {
                    hatamessage += "Adres\n";
                }
                if (mtxtTelefon.Text == "(999) 000-0000")
                {
                    hatamessage += "Telefon\n";
                }

                MessageBox.Show(hatamessage + "BOŞ GEÇİLEMEZ", "HATA!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            this.Close();
        }

        private void btnYenileGuvenlikKodu_Click(object sender, EventArgs e)
        {
            GuvenlikKoduOlusturma gko = new GuvenlikKoduOlusturma();
            gko.GuvenlikKoduOluştur(lblGuvenlikKodu);
        }

        private void txtSifreTekrar_TextChanged(object sender, EventArgs e)
        {
            if (txtSifre.Text == txtSifreTekrar.Text)
            {
                txtSifreTekrar.BackColor = Color.White;
            }
            else
                txtSifreTekrar.BackColor = Color.OrangeRed;
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            Musteriler m = new Musteriler();
            if (txtKullaniciAdi.Text.Length >= 3)
            {
                if (m.KullaniciAdiVarmi(txtKullaniciAdi.Text))
                    txtKullaniciAdi.BackColor = Color.OrangeRed;
                else
                {
                    txtKullaniciAdi.BackColor = Color.White;
                }
            }
            
        }

        private void cbxSozlesmeSartlari_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSozlesmeSartlari.Checked == true)
                btnKaydet.Enabled = true;
            else
                btnKaydet.Enabled = false;

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

        private void dtpDogumTarihi_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDogumTarihi.Value.Month < 10)
                mtxtDogumTarihi.Mask = "00/0/0000";
            else
                mtxtDogumTarihi.Mask = "00/00/0000";
            mtxtDogumTarihi.Text = dtpDogumTarihi.Value.ToShortDateString();
        }
    }
}
