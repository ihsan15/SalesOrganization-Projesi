using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;
using WindowsFormsApplication1.Model;

namespace SaleOrganization
{
    public partial class FirmaBilgileri : Form
    {
        public FirmaBilgileri()
        {
            InitializeComponent();
        }

        private void tsYeni_Click(object sender, EventArgs e)
        {
            FirmaEkle frm = new FirmaEkle();
            frm.ShowDialog();
            Markalar m = new Markalar();
            m.FirmalariGetir(lvFirmalar);
        }

        private void tsDegistirGuncelle_Click(object sender, EventArgs e)
        {
            Genel.MarkaID = Convert.ToInt32(lvFirmalar.SelectedItems[0].SubItems[0].Text);
            FirmaEkle frm = new FirmaEkle();
            frm.ShowDialog();
            Markalar m = new Markalar();
            m.FirmalariGetir(lvFirmalar);

        }

        private void btnTariheGore_Click(object sender, EventArgs e)
        {
            TariheGoreArama frm = new TariheGoreArama();
            frm.ShowDialog();
            Markalar m = new Markalar();
            m.FirmalariGetir(lvFirmalar);
        }

        private void FirmaBilgileri_Load(object sender, EventArgs e)
        {
            Musteriler mus = new Musteriler();
            mus.IlleriGetir(cbIl);
            Markalar m = new Markalar();
            m.FirmalariGetir(lvFirmalar);
            tsSil.Enabled = false;
            tsDegistirGuncelle.Enabled = false;

        }

        private void lvFirmalar_Click(object sender, EventArgs e)
        {
            tsSil.Enabled = true;
            tsDegistirGuncelle.Enabled = true;
            txtFirmaID.Text = lvFirmalar.SelectedItems[0].SubItems[0].Text;
        }

        private void lvFirmalar_DoubleClick(object sender, EventArgs e)
        {
            Genel.MarkaID = Convert.ToInt32(lvFirmalar.SelectedItems[0].SubItems[0].Text);
            FirmaEkle frm = new FirmaEkle();
            frm.ShowDialog();
            Markalar m = new Markalar();
            m.FirmalariGetir(lvFirmalar);
        }

        private void txtFirmaIsmi_TextChanged(object sender, EventArgs e)
        {
            DetayliSorgulama();
        }

        private void txtFirmaYetkili_TextChanged(object sender, EventArgs e)
        {
            DetayliSorgulama();
        }

        private void txtFirmaAdres_TextChanged(object sender, EventArgs e)
        {
            DetayliSorgulama();
        }

        private void txtVergiDairesi_TextChanged(object sender, EventArgs e)
        {
            DetayliSorgulama();
        }

        private void txtVergiNo_TextChanged(object sender, EventArgs e)
        {
            DetayliSorgulama();
        }

        private void txtKayitTarihi_TextChanged(object sender, EventArgs e)
        {
            //  DetayliSorgulama();
        }

        private void DetayliSorgulama()
        {
            Markalar m = new Markalar();
            m.FirmalariGetirByDetayliSorgulama(txtFirmaIsmi.Text, txtFirmaYetkili.Text, txtFirmaAdres.Text, txtVergiDairesi.Text, txtVergiNo.Text,txtSektor.Text, lvFirmalar);

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


        private void txtSehirNo_TextChanged(object sender, EventArgs e)
        {
            DetayliSorgulama();
        }

        private void txtIlceNo_TextChanged(object sender, EventArgs e)
        {
            DetayliSorgulama();
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
            if (MessageBox.Show("Silmek İstiyor Musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Markalar m = new Markalar();
                bool Sonuc = m.MarkaSil(Convert.ToInt32(txtFirmaID.Text));
                if (Sonuc)
                {
                    MessageBox.Show("Firma Bilgileri Silindi");
                    m.FirmalariGetir(lvFirmalar);
                    tsSil.Enabled = false;
                    tsDegistirGuncelle.Enabled = false;
                }
            }
        }

        private void txtSektor_TextChanged(object sender, EventArgs e)
        {
            DetayliSorgulama();
        }
    }
}
