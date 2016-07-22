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
    public partial class MGiris : Form
    {
        public MGiris()
        {
            InitializeComponent();
        }

        private void MGiris_Load(object sender, EventArgs e)
        {
            this.Top = Genel.GirisyKonumu;
            this.Left = Genel.GirisxKonumu;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text.Trim() == "" || txtSifre.Text.Trim() == "")
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Boş Bırakılamaz!");
            }
            else
            {
                Musteriler m = new Musteriler();
                Genel.MusteriID = m.MusteriAra(txtKullaniciAdi.Text, txtSifre.Text);
                if (Genel.MusteriID!=0)
                {
                    Genel.FirmaGirisAcilsinMi = false;
                    this.Close();
                }
                else
                {
                    Genel.KullaniciID = m.KullaniciAra(txtKullaniciAdi.Text, txtSifre.Text);
                    if (Genel.KullaniciID==0)
                    {
                        MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        Genel.FirmaGirisAcilsinMi = true;
                        this.Close();
                    }
                }
            }
        }

        private void cbxSifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSifreyiGoster.Checked)
                txtSifre.PasswordChar = '\0';
            else
                txtSifre.PasswordChar = '*';
        }

        private void txtKullaniciAdi_Click(object sender, EventArgs e)
        {
            txtKullaniciAdi.Select(0, txtKullaniciAdi.Text.Length);
        }

        private void txtSifre_Click(object sender, EventArgs e)
        {
            txtSifre.Select(0, txtSifre.Text.Length);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }    
    }
}
