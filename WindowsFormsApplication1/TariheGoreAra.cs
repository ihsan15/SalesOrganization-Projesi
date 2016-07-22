using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleOrganization
{
    public partial class TariheGoreAra : Form
    {
        public TariheGoreAra()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        private void dtpIlkTarih_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dtpSonTarih_ValueChanged(object sender, EventArgs e)
        {
        }

        private void TariheGoreAra_Load(object sender, EventArgs e)
        {
            Markalar m = new Markalar();
            dt = m.MarkalariGetirByTarihlerArasi(dtpIlkTarih.Value, dtpSonTarih.Value);
            dgvFirmalar.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Markalar m = new Markalar();
            dt=m.MarkalariGetirByTarihlerArasi(dtpIlkTarih.Value, dtpSonTarih.Value);
            dgvFirmalar.DataSource = dt;
        }

        private void dgvFirmalar_DoubleClick(object sender, EventArgs e)
        {
            Genel.MarkaID = Convert.ToInt32(dgvFirmalar.SelectedRows[0].Cells[0].Value);
            FirmaEkle frm = new FirmaEkle();
            frm.ShowDialog();
        }
    }
}
