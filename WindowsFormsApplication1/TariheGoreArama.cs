using SaleOrganization;
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
    public partial class TariheGoreArama : Form
    {
        public TariheGoreArama()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private void TariheGoreArama_Load(object sender, EventArgs e)
        {
            Markalar m = new Markalar();
            dt = m.MarkalariGetirByTarihlerArasi(dtpIlkTarih.Value, dtpSonTarih.Value);
            dgvFirmalar.DataSource = dt;
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            Markalar m = new Markalar();
            dt = m.MarkalariGetirByTarihlerArasi(dtpIlkTarih.Value, dtpSonTarih.Value);
            dgvFirmalar.DataSource = dt;
        }

        private void dgvFirmalar_DoubleClick(object sender, EventArgs e)
        {
            Genel.MarkaID = Convert.ToInt32(dgvFirmalar.SelectedRows[0].Cells[0].Value);
            FirmaEkle frm = new FirmaEkle();
            frm.ShowDialog();
            Markalar m = new Markalar();
            dt = m.MarkalariGetirByTarihlerArasi(dtpIlkTarih.Value, dtpSonTarih.Value);
            dgvFirmalar.DataSource = dt;
        }
    }
}
