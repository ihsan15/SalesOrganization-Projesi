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
    public partial class Hesabim : Form
    {
        public Hesabim()
        {
            InitializeComponent();
        }

        private void Hesabim_Load(object sender, EventArgs e)
        {
            Musteriler m = new Musteriler();
            if (m.DogumTarihi10AyliMi(Genel.MusteriID))
                mtxtDogumTarihi.Mask = "00/0/0000";
            else
                mtxtDogumTarihi.Mask = "00/00/0000";
            string cinsiyet = m.HesapBilgileriniGetir(Genel.MusteriID, txtAdres, txtEMail, txtIl, txtIlce, txtIlceNo, txtKullaniciAdi, txtPostaKodu, txtSehirNo, txtSifre, txtSifreTekrar, mtxtDogumTarihi, mtxtTC, mtxtTelefon, txtAdi, txtSoyadi);
            

            if (cinsiyet == "ERKEK")
                cbCinsiyet.SelectedIndex = 0;
            else if (cinsiyet == "KADIN")
                cbCinsiyet.SelectedIndex = 1;
            m.IlleriGetir(cbIl);

            EnableTrue();
            ReadonlyTrue();
        }

        private void tsDegistirGuncelle_Click(object sender, EventArgs e)
        {
            tsKaydet.Enabled = true;
            EnableTrue();
            EnableFalse();
        }

        private void ReadonlyTrue()
        {
            cbCinsiyet.Enabled = false;
            txtAdi.ReadOnly = true;
            txtAdres.ReadOnly = true;
            txtEMail.ReadOnly = true;
            txtIl.ReadOnly = true;
            txtIlce.ReadOnly = true;
            cbIl.Enabled = false;
            txtIlceNo.ReadOnly = true;
            txtKullaniciAdi.ReadOnly = true;
            txtPostaKodu.ReadOnly = true;
            txtSehirNo.ReadOnly = true;
            txtSifre.ReadOnly = true;
            txtSifreTekrar.ReadOnly = true;
            txtSoyadi.ReadOnly = true;
            mtxtDogumTarihi.ReadOnly = true;
            mtxtTC.ReadOnly = true;
            mtxtTelefon.ReadOnly = true;
        }

        private void EnableTrue()
        {
            cbCinsiyet.Enabled = true;
            txtAdi.Enabled = true;
            txtAdres.Enabled = true;
            txtEMail.Enabled = true;
            txtIl.Enabled = true;
            txtIlce.Enabled = true;
            cbIl.Enabled = true;
            txtIlceNo.Enabled = true;
            txtKullaniciAdi.Enabled = true;
            txtPostaKodu.Enabled = true;
            txtSehirNo.Enabled = true;
            txtSifre.Enabled = true;
            txtSifreTekrar.Enabled = true;
            txtSoyadi.Enabled = true;
            mtxtDogumTarihi.Enabled = true;
            mtxtTC.Enabled = true;
            mtxtTelefon.Enabled = true;
        }

        private void tsKaydet_Click(object sender, EventArgs e)
        {
            Musteriler m = new Musteriler();
            if (txtAdres.Text.Trim() != "" && txtIl.Text.Trim() != "" && txtIlce.Text.Trim() != "" && mtxtTelefon.Text != "(999) 000-0000" && txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "" && mtxtDogumTarihi.Text != "00/00/0000" && txtKullaniciAdi.Text.Trim() != "" && txtEMail.Text.Trim() != "" && txtSifre.Text.Trim() != "" && txtSifreTekrar.Text.Trim() != "" && txtSifre.Text.Length >= 4 )
            {
                
                m.MusteriID = Genel.MusteriID;
                m.MusteriMail = txtEMail.Text;
                m.MusteriNick = txtKullaniciAdi.Text;
                m.MusterSifre = txtSifre.Text;
                m.MusteriAdi = txtAdi.Text;
                m.MusteriSoyadi = txtSoyadi.Text;
                if (cbCinsiyet.SelectedIndex==0)
                    m.Cinsiyet = "erkek";
                else if (cbCinsiyet.SelectedIndex==0)
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
                    MessageBox.Show("Musteri Güncellendi");
                    ReadonlyTrue();
                }
            }
            else
            {
                string hatamessage = "";
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
                if (txtAdi.Text == "")
                {
                    hatamessage += "Adınız\n";
                    txtKullaniciAdi.Focus();
                }
                if (txtSoyadi.Text == "")
                {
                    hatamessage += "Soyadınız\n";
                }
                if (mtxtDogumTarihi.Text == "00/00/0000")
                {
                    hatamessage += "Doğum Tarihi\n";
                }
                if (txtIl.Text == "")
                {
                    hatamessage += "İl\n";
                }
                if (txtIlce.Text == "")
                {
                    hatamessage += "İlçe\n";
                }
                if (txtAdres.Text == "")
                {
                    hatamessage += "Adres\n";
                }
                if (mtxtTelefon.Text == "(999) 000-0000")
                {
                    hatamessage += "Telefon\n";
                }

                MessageBox.Show(hatamessage + "BOŞ GEÇİLEMEZ", "HATA!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void EnableFalse()
        {
            cbCinsiyet.Enabled = true;
            txtAdi.ReadOnly = false;
            txtAdres.ReadOnly = false;
            txtEMail.ReadOnly = false;
            txtIl.ReadOnly = false;
            txtIlce.ReadOnly = false;
            cbIl.Enabled = true;
            txtIlceNo.ReadOnly = false;
            txtKullaniciAdi.ReadOnly = false;
            txtPostaKodu.ReadOnly = false;
            txtSehirNo.ReadOnly = false;
            txtSifre.ReadOnly = false;
            txtSifreTekrar.ReadOnly = false;
            txtSoyadi.ReadOnly = false;
            mtxtDogumTarihi.ReadOnly = false;
            mtxtTC.ReadOnly = false;
            mtxtTelefon.ReadOnly = false;
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

        private void txtIlce_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void tsSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hesabınızı Silmek İstiyor musunuz?","Uyarı!",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Musteriler m = new Musteriler();
                if (m.MusteriSil(Genel.MusteriID))
                {
                    MessageBox.Show("Hesabınızı silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
            }
        }
    }
}
