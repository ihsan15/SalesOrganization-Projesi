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
    public partial class KasaHareketleri : Form
    {
        public KasaHareketleri()
        {
            InitializeComponent();
        }
        private void KasaHareketleri_Load(object sender, EventArgs e)
        {
            cbSatisTipi.Items.Add("Tümü");
            cbSatisTipi.Items.Add("Alış");
            cbSatisTipi.Items.Add("Satış");
            cbSatisTipi.SelectedIndex = 0;

            KasaHareketi kh = new KasaHareketi();
            kh.KasaHareketiGetirByTarihler(lvKasaHareketler, dtpGun.Value);

            Hesapla();
            double ttopla = 0;

            for (int i = 0; i < lvKasaHareketler.Items.Count; i++)
            {
                ttopla += Convert.ToDouble(lvKasaHareketler.Items[i].SubItems[3].Text);
            }

            txtKasadaToplamtutar.Text = ttopla.ToString();
        }

        private void Hesapla()
        {
            double topla = 0;

            for (int i = 0; i < lvKasaHareketler.Items.Count; i++)
            {
                topla += Convert.ToDouble(lvKasaHareketler.Items[i].SubItems[3].Text);
            }

            txtToplamTutar.Text = topla.ToString();
        }

        private void cbSatisTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            KasaHareketi kh = new KasaHareketi();
            if (cbSatisTipi.SelectedIndex==0)
            {
                kh.KasaHareketiGetirByTarihler(lvKasaHareketler, dtpGun.Value);
            }
            if (cbSatisTipi.SelectedIndex == 1)
            {
                kh.KasaHareketiGetirByTarihlerAndSatisTipi(lvKasaHareketler, dtpGun.Value,0);
            }
            if (cbSatisTipi.SelectedIndex == 2)
            {
                kh.KasaHareketiGetirByTarihlerAndSatisTipi(lvKasaHareketler, dtpGun.Value, 1);
            }

            Hesapla();
            
        }

        private void dtpGun_ValueChanged(object sender, EventArgs e)
        {
            KasaHareketi kh = new KasaHareketi();
            if (cbSatisTipi.SelectedIndex == 0)
            {
                kh.KasaHareketiGetirByTarihler(lvKasaHareketler, dtpGun.Value);
            }
            if (cbSatisTipi.SelectedIndex == 1)
            {
                kh.KasaHareketiGetirByTarihlerAndSatisTipi(lvKasaHareketler, dtpGun.Value, 0);
            }
            if (cbSatisTipi.SelectedIndex == 2)
            {
                kh.KasaHareketiGetirByTarihlerAndSatisTipi(lvKasaHareketler, dtpGun.Value, 1);
            }
            Hesapla();
        }

        private void lvKasaHareketler_DoubleClick(object sender, EventArgs e)
        {
            Genel.KasadanCekilenMusteriID = Convert.ToInt32(lvKasaHareketler.SelectedItems[0].SubItems[7].Text);
            Genel.KasadanCekilenTarih = (Convert.ToDateTime(lvKasaHareketler.SelectedItems[0].SubItems[1].Text)).ToLongDateString();

            SiparişBilgileri frm = new SiparişBilgileri();
            frm.ShowDialog();
        }

    }
}
