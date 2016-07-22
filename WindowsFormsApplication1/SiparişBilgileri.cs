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
    public partial class SiparişBilgileri : Form
    {
        public SiparişBilgileri()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();

        private void dgvSiparis_Click(object sender, EventArgs e)
        {
            dgvSiparisDetayi.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            txtAlisverisMiktari.Visible = false;
            txtAlisveriTutar.Visible = false;
        }

        private void dgvSiparis_DoubleClick(object sender, EventArgs e)
        {
            if (dgvSiparis.Rows.Count > 0)
            {
                dgvSiparisDetayi.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                txtAlisverisMiktari.Visible = true;
                txtAlisveriTutar.Visible = true;

                int SiparisID = Convert.ToInt32(dgvSiparis.SelectedRows[0].Cells[1].Value);
                int MusteriID = Convert.ToInt32(dgvSiparis.SelectedRows[0].Cells[2].Value);

                SiparisDetayi sd = new SiparisDetayi();
                ds = sd.SiparisDetayiGetir(SiparisID,MusteriID);
                dgvSiparisDetayi.DataSource = ds.Tables["SiparisDetayi"];

                dgvSiparisDetayi.Columns[1].Visible = false;
                dgvSiparisDetayi.Columns[2].Visible = false;

                txtAlisverisMiktari.Text = dgvSiparisDetayi.Rows.Count.ToString();
                double tutar = 0;
                for (int i = 0; i < dgvSiparisDetayi.Rows.Count; i++)
                {
                    tutar += Convert.ToDouble(dgvSiparisDetayi.Rows[i].Cells[6].Value)* Convert.ToDouble(dgvSiparisDetayi.Rows[i].Cells[5].Value);
                }
                txtAlisveriTutar.Text = tutar.ToString();
            }
            

        }

        private void SiparişBilgileri_Load(object sender, EventArgs e)
        {
            if (Genel.MusteriID == 0)
            {
                label1.Visible = false;
                label2.Visible = false;
                dtpIlkTarih.Visible = false;
                dtpSonTarih.Visible = false;

                Siparisler s = new Siparisler();
                ds = s.SiparisleriGetirByHesapHareket(Genel.KasadanCekilenMusteriID,Genel.KasadanCekilenTarih);
                dgvSiparis.DataSource = ds.Tables["Siparisler"];

                dgvSiparis.Columns[1].Visible = true;
                dgvSiparis.Columns[2].Visible = true;
                dgvSiparis.Columns[4].Visible = true;
            }
            else
            {
                Musteriler m = new Musteriler();
                dtpIlkTarih.Value = m.IlkTarihGetir();

                Siparisler s = new Siparisler();
                ds = s.SiparisleriGetir(dtpIlkTarih.Value, dtpSonTarih.Value);
                dgvSiparis.DataSource = ds.Tables["Siparisler"];

                dgvSiparis.Columns[1].Visible = true;
                dgvSiparis.Columns[2].Visible = true;
                dgvSiparis.Columns[4].Visible = true;
            }

            txtToplamAlisveris.Text = dgvSiparis.Rows.Count.ToString();


        }
    }
}
