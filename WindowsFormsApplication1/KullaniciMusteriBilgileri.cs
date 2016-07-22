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
    public partial class KullaniciMusteriBilgileri : Form
    {
        public KullaniciMusteriBilgileri()
        {
            InitializeComponent();
        }

        private void cbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKullaniciIlNo.Clear();
            txtKullaniciIl.Text = cbKullaniciIl.SelectedItem.ToString();            
        }

        private void cbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKullaniciIlceNo.Clear();
            txtKullaniciIlce.Text = cbKullaniciIlce.SelectedItem.ToString();

            Musteriler m = new Musteriler();
            txtKullaniciIlceNo.Text = m.IlceNoGetir(txtKullaniciIlce.Text);

            m.KullaniciGetirByIlceNo(true, Convert.ToInt32(txtKullaniciIlceNo.Text), lvKullaniciIslemleri);
        }

        private void txtIl_TextChanged(object sender, EventArgs e)
        {
            Musteriler m = new Musteriler();
            txtKullaniciIlNo.Text = m.SehirNoGetir(txtKullaniciIl.Text);
            m.IlceleriGetir(cbKullaniciIlce, txtKullaniciIlNo.Text);
            cbKullaniciIlce.Enabled = true;

            m.KullaniciGetirByIlNo(true, Convert.ToInt32(txtKullaniciIlNo.Text), lvKullaniciIslemleri);
        }

        private void KullaniciMusteriBilgileri_Load(object sender, EventArgs e)
        {
            Musteriler m = new Musteriler();
            m.IlleriGetir(cbKullaniciIl);
            m.IlleriGetir(cbMusteriIl);
            this.Top = 0;
            this.Left = 0;
            tabControl1.SelectedIndex = Genel.sayfano;
            if (tabControl1.SelectedIndex == 0)
            {
                m.KullaniciGetirFromKullaniciBilgileri(true, lvKullaniciIslemleri);
                Genel.SecilenMusteriID = 0;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                m.KullaniciGetirFromKullaniciBilgileri(false, lvMusteriIslemleri);
                Genel.SecilenKullaniciID = 0;
            }
        }

        private void cbMusteriIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMusteriIlNo.Clear();
            txtMusteriIl.Text = cbMusteriIl.SelectedItem.ToString();
        }

        private void cbMusteriIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMusteriIlceNo.Clear();
            txtMusteriIlce.Text = cbMusteriIlce.SelectedItem.ToString();

            Musteriler m = new Musteriler();
            txtMusteriIlceNo.Text = m.IlceNoGetir(txtMusteriIlce.Text);

            m.KullaniciGetirByIlceNo(false, Convert.ToInt32(txtMusteriIlceNo.Text), lvMusteriIslemleri);
        }

        private void txtMusteriIl_TextChanged(object sender, EventArgs e)
        {
            Musteriler m = new Musteriler();
            txtMusteriIlNo.Text = m.SehirNoGetir(txtMusteriIl.Text);
            m.IlceleriGetir(cbMusteriIlce, txtMusteriIlNo.Text);
            cbMusteriIlce.Enabled = true;

            m.KullaniciGetirByIlNo(false, Convert.ToInt32(txtMusteriIlNo.Text), lvMusteriIslemleri);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tsDegistirGuncelle.Enabled = false;
            tsSil.Enabled = false;
            if (tabControl1.SelectedIndex == 0)
            {
                Musteriler m = new Musteriler();
                m.KullaniciGetirFromKullaniciBilgileri(true, lvKullaniciIslemleri);
                Genel.SecilenMusteriID = 0;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                Musteriler m = new Musteriler();
                m.KullaniciGetirFromKullaniciBilgileri(false, lvMusteriIslemleri);
                Genel.SecilenKullaniciID = 0;
            }
        }

        private void txtMusteriAdi_TextChanged(object sender, EventArgs e)
        {
            DetayliMusteriAra();
        }

        private void txtMusteriSoyadi_TextChanged(object sender, EventArgs e)
        {
            DetayliMusteriAra();
        }

        private void DetayliMusteriAra()
        {
            Musteriler m = new Musteriler();
            m.MusterileriGetirFromMusteriBilgileri(false,txtMusteriAdi.Text, txtMusteriSoyadi.Text, txtMusteriMail.Text, txtMusteriAdres.Text, txtMusteriTelefon.Text, lvMusteriIslemleri);
        }

        private void txtMusteriMail_TextChanged(object sender, EventArgs e)
        {
            DetayliMusteriAra();
        }

        private void txtMusteriAdres_TextChanged(object sender, EventArgs e)
        {
            DetayliMusteriAra();
        }

        private void txtMusteriTelefon_TextChanged(object sender, EventArgs e)
        {
            DetayliMusteriAra();
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            DetayliKullaniciAra();
        }

        private void DetayliKullaniciAra()
        {
            Musteriler m = new Musteriler();
            m.MusterileriGetirFromMusteriBilgileri(true, txtKullaniciAdi.Text, txtKullaniciSoyadi.Text, txtKullaniciMail.Text, txtKullaniciAdres.Text, txtKullaniciTelefon.Text, lvKullaniciIslemleri);
        }

        private void txtKullaniciSoyadi_TextChanged(object sender, EventArgs e)
        {
            DetayliKullaniciAra();
        }

        private void txtKullaniciMail_TextChanged(object sender, EventArgs e)
        {
            DetayliKullaniciAra();
        }

        private void txtKullaniciAdres_TextChanged(object sender, EventArgs e)
        {
            DetayliKullaniciAra();
        }

        private void txtKullaniciTelefon_TextChanged(object sender, EventArgs e)
        {
            DetayliKullaniciAra();
        }

        private void tsYeni_Click(object sender, EventArgs e)
        {
            YeniKullaniciEkle frm = new YeniKullaniciEkle();
            frm.ShowDialog();
        }

        private void lvKullaniciIslemleri_Click(object sender, EventArgs e)
        {
            txtKullaniciID.Text = lvKullaniciIslemleri.SelectedItems[0].SubItems[0].Text;
            tsDegistirGuncelle.Enabled = true;
            tsSil.Enabled = true;
        }

        private void lvKullaniciIslemleri_DoubleClick(object sender, EventArgs e)
        {
            Genel.SecilenKullaniciID = Convert.ToInt32(txtKullaniciID.Text);
            YeniKullaniciEkle frm = new YeniKullaniciEkle();
            frm.ShowDialog();
        }

        private void lvMusteriIslemleri_DoubleClick(object sender, EventArgs e)
        {
            Genel.SecilenMusteriID = Convert.ToInt32(txtMusteriID.Text);
            YeniKullaniciEkle frm = new YeniKullaniciEkle();
            frm.ShowDialog();
        }

        private void lvMusteriIslemleri_Click(object sender, EventArgs e)
        {
            txtMusteriID.Text = lvMusteriIslemleri.SelectedItems[0].SubItems[0].Text;
            tsDegistirGuncelle.Enabled = true;
            tsSil.Enabled = true;
        }

        private void tsSil_Click(object sender, EventArgs e)
        {
            Musteriler m = new Musteriler();
            if (tabControl1.SelectedIndex == 0)
            {
                m.MusteriSil(Convert.ToInt32(txtKullaniciID.Text));
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                m.MusteriSil(Convert.ToInt32(txtMusteriID.Text));
            }
        }

        private void tsDegistirGuncelle_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                Genel.SecilenMusteriID = 0;
                Genel.SecilenKullaniciID = Convert.ToInt32(txtKullaniciID.Text);
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                Genel.SecilenKullaniciID = 0;
                Genel.SecilenMusteriID = Convert.ToInt32(txtMusteriID.Text);
            }
            YeniKullaniciEkle frm = new YeniKullaniciEkle();
            frm.ShowDialog();
        }
    }
}
