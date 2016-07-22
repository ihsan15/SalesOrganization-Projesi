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
    public partial class MSepet : Form
    {
        public MSepet()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();

        int sayi = 0;
        private void MSepet_Load(object sender, EventArgs e)
        {
            SiparisDetayi sd = new SiparisDetayi();
            ds = sd.SepetiGetir();
            dgvSepet.DataSource = ds.Tables["SiparisDetayi"];
            if (dgvSepet.Rows.Count == 0)
                MessageBox.Show("Sepetiniz boştur.");

            dgvSepet.Columns[1].Visible = false;
            dgvSepet.Columns[2].Visible = false;
            dgvSepet.Columns[3].Visible = false;

            Toplamhesapla();

        }

        private void Toplamhesapla()
        {
            double toplam = 0;
            double KDV = 0;

            if (dgvSepet.Rows.Count > 0)
                for (int i = 0; i < dgvSepet.Rows.Count; i++)
                {
                    toplam += Convert.ToDouble(dgvSepet.Rows[i].Cells[5].Value) * Convert.ToInt32(dgvSepet.Rows[i].Cells[4].Value);
                    KDV += Convert.ToDouble(dgvSepet.Rows[i].Cells[6].Value) * Convert.ToInt32(dgvSepet.Rows[i].Cells[4].Value);
                }
            txtToplamKDV.Text = KDV.ToString();
            txtToplamTutar.Text = toplam.ToString();
        }

        private void dgvSepet_Click(object sender, EventArgs e)
        {
            btnSepettenCikar.Enabled = true;
            txtUrunID.Text = dgvSepet.SelectedRows[0].Cells[7].Value.ToString();

            txtMiktar.Text = dgvSepet.SelectedRows[0].Cells[4].Value.ToString();
            sayi = Convert.ToInt32(txtMiktar.Text);
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            if (dgvSepet.Rows.Count == 0)
            {
                MessageBox.Show("Sepette ürün bulunmamaktadır.");
            }
            else
            {
                // urun stok güncelle
                Urun u = new Urun();
                string aciklama = "";
                for (int i = 0; i < dgvSepet.Rows.Count; i++)
                {
                    u.StokGuncelleFromSiparisiTamamla(Convert.ToInt32(dgvSepet.Rows[i].Cells[7].Value), Convert.ToInt32(dgvSepet.Rows[i].Cells[4].Value));
                    aciklama += dgvSepet.Rows[i].Cells[2].Value.ToString() + ", ";
                }

                // Kasaya toplam ücreti gir
                KasaHareketi kh = new KasaHareketi();
                kh.MusteriID = Genel.MusteriID;
                kh.Tarih = DateTime.Now;
                kh.Tutar = Convert.ToDouble(txtToplamTutar.Text) - Convert.ToDouble(txtToplamKDV.Text);
                kh.YetkiliID = 1;
                kh.IslemTuru = true;
                kh.Aciklama = aciklama;
                if (kh.KasaHareketEkleFromSepet(kh))
                {
                    // müşteriye borc gir
                    Musteriler m = new Musteriler();
                    m.MusteriID = Genel.MusteriID;
                    m.Borcu = Convert.ToDouble(txtToplamTutar.Text);
                    if(m.MusteriBorcGuncelleme(m))
                    {
                        // onay durumu
                        SiparisDetayi sd = new SiparisDetayi();
                        sd.OnayDurumGuncelleFromAlisveris(Genel.SiparisID);
                        // yazdırma işlemi yapılacak
                        k = 0;
                        ppdFis.ShowDialog();
                        MessageBox.Show("Siparişiniz Hazırlanıyor. En kısa zamanda sizinle..");
                        Siparisler s = new Siparisler();
                        s.MusteriID=Genel.MusteriID;
                        s.SiparisDurum=false;
                        s.OnayVerenID=1;
                        s.OnayTarihi=DateTime.Now;
                        Genel.SiparisID = s.SiparisNoOlustur(s);
                        this.Close();
                    }
                }
            }
            
            
        }

        private void btnSepettenCikar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Seçili ürünü sepetten çıkartalım mı?","Uyarı!",MessageBoxButtons.YesNo,MessageBoxIcon.Question))==DialogResult.Yes)
            {
                SiparisDetayi sd = new SiparisDetayi();
                if (sd.SepetGuncelle(Convert.ToInt32(txtUrunID.Text)))
                {
                    sd.SepetiGetir();
                    dgvSepet.DataSource = ds.Tables["SiparisDetayi"];
                    if (dgvSepet.Rows.Count == 0)
                        MessageBox.Show("Sepetiniz boştur.");
                }
            }
            // emin misiniz mesajı
            // seçilen ürün sipariş detayı veritabanından kaldırılacak
        }

        private void btneksi_Click(object sender, EventArgs e)
        {
            txtMiktar.Select(0, txtMiktar.Text.Length);
            if (txtMiktar.Text.Trim() != "")
            {
                btnarti.Enabled = true;
                if (sayi == 0)
                {
                    btneksi.Enabled = false;
                }
                else
                {
                    sayi--;
                    txtMiktar.Text = sayi.ToString();
                }
            }
        }

        private void btnarti_Click(object sender, EventArgs e)
        {
            txtMiktar.Select(0, txtMiktar.Text.Length);
            if (txtUrunID.Text.Trim() != "")
            {
                btneksi.Enabled = true;
                Urun u = new Urun();
                if (sayi < u.UrunMiktarOgren(Convert.ToInt32(txtUrunID.Text)))
                {
                    sayi++;
                    txtMiktar.Text = sayi.ToString();
                }
                else
                    btnarti.Enabled = false;
            }
            
        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            txtMiktar.Select(0, txtMiktar.Text.Length);

        }

        private void txtMiktar_Click(object sender, EventArgs e)
        {

            txtMiktar.Select(0, txtMiktar.Text.Length);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SiparisDetayi sd = new SiparisDetayi();
            if (sd.UrunMiktariGuncelle(Convert.ToInt32(txtUrunID.Text), Convert.ToInt32(txtMiktar.Text)))
            {
                ds= sd.SepetiGetir();
                dgvSepet.DataSource = ds.Tables["SiparisDetayi"];
            }

            Toplamhesapla();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            // siparis detayından ürünler silinecek.
            SiparisDetayi sd = new SiparisDetayi();
            if(sd.SepetiSil())
                this.Close();
        }

        private void btnDevamEt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Font fntBaslik = new Font("Times New Roman", 16, FontStyle.Bold);
        Font fntDetay = new Font("Times New Roman", 12, FontStyle.Regular);
        StringFormat fmt = new StringFormat();
        SolidBrush sb = new SolidBrush(Color.Black);
        int k = 0;
        
        private void pdocFis_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Musteriler m = new Musteriler();
            fmt.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Müşteri : " + m.KullaniciGetir(Genel.MusteriID), fntBaslik, sb, 100, 100, fmt);
            e.Graphics.DrawString("Sipariş No : " + Genel.SiparisID, fntBaslik, sb, 100, 130, fmt);
            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), fntBaslik, sb, 600, 110, fmt);
            e.Graphics.DrawString("SİPARİŞLER", fntBaslik, sb, 300, 200, fmt);
            e.Graphics.DrawString("Ürün Kodu    Ürün Adı                                                 Fiyat          Adet", fntBaslik, sb, 100, 250, fmt);
            e.Graphics.DrawString("________________________________________________________", fntBaslik, sb, 100, 270);

            int j = 0;

            for (int i = k; i < dgvSepet.Rows.Count; i++)
            {

                e.Graphics.DrawString(dgvSepet.Rows[i].Cells[1].Value.ToString(), fntDetay, sb, 120, 300 + j * 30, fmt);
                e.Graphics.DrawString(dgvSepet.Rows[i].Cells[2].Value.ToString(), fntDetay, sb, 200, 300 + j * 30, fmt);
                //e.Graphics.DrawString(dgvSepet.Rows[i].Cells[3].Value.ToString(), fntDetay, sb, 350, 300 + j * 30, fmt);
                //fmt.Alignment = StringAlignment.Far;
                //e.Graphics.DrawString(dgvSepet.Rows[i].Cells[4].Value.ToString(), fntDetay, sb, 600, 300 + j * 30, fmt);
                //fmt.Alignment = StringAlignment.Near;
                //e.Graphics.DrawString("X", fntDetay, sb, 640, 300 + j * 30, fmt);
                fmt.Alignment = StringAlignment.Far;
                e.Graphics.DrawString(dgvSepet.Rows[i].Cells[5].Value.ToString(), fntDetay, sb, 650, 300 + j * 30, fmt);
                e.Graphics.DrawString((Convert.ToInt32(dgvSepet.Rows[i].Cells[4].Value) * Convert.ToInt32(dgvSepet.Rows[i].Cells[4].Value)).ToString(), fntDetay, sb, 750, 300 + j * 30, fmt);


                if (i % 22 == 0 && i != 0)
                {
                    e.HasMorePages = true;
                    k++;
                    return;
                }
                else
                {
                    e.HasMorePages = false;
                    j++;
                    k++;
                }
            }
            e.Graphics.DrawString("________________________________________________________", fntBaslik, sb, 100, 300 + j * 30);
            j++;
            e.Graphics.DrawString("Toplam Tutar: " , fntBaslik, sb, 290, 300 + j * 30, fmt);
            fmt.Alignment = StringAlignment.Far;
            e.Graphics.DrawString(txtToplamTutar.Text +"  TL", fntBaslik, sb, 520, 300 + j * 30, fmt);
            fmt.Alignment = StringAlignment.Near;
            j++;

        }


        // sepet açıldığında listview ya da tek tek ürünlerin açıklanacağı bir blok oluşturacaz.
        // 1. satın al butonuna tıklanınca;
        // şimdilik alışveriş tanımlanacak.
        // stok taki ürün miktarı azalacak
        // ürün * alacak
        // kasanın alacak miktarı artacak
        // müşterinin borcu artacak.

        // 2. kapat butonuna tıklanınca;
        // sepetteki bilgiler kalacak ve form kapanacak

        // 3. kaldır butonuna tıklanınca;
        // ürün seçilmemişse hata vericek.
        // ürün seçilmişse seçilen ürün listeden silinecek.
    }
}
