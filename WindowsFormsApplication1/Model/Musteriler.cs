using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Model
{
    class Musteriler
    {
        private int _musteriID;
        private string _musteriAdi;
        private string _musteriSoyadi;
        private string _musteriNick;
        private string _musterSifre;
        private string _musteriTelefon;
        private string _musteriMail;
        private string _musteriAdresi;
        private string _cinsiyet;
        private string _postaKodu;
        private DateTime _dogumTarihi;
        private string _tCKimlikNo;
        private int _musteriIlID;
        private int _musteriIlceID;
        private DateTime _musteriKayitTarihi;
        private DateTime _sonGirisTarihi;
        private double _alacagi;
        private double _borcu;
        private int _kullaniciMi;
        SqlConnection conn = new SqlConnection(Genel.connstr);

        #region Properties


        public int KullaniciMi
        {
            get { return _kullaniciMi; }
            set { _kullaniciMi = value; }
        }

        public string PostaKodu
        {
            get { return _postaKodu; }
            set { _postaKodu = value; }
        }

        public string TCKimlikNo
        {
            get { return _tCKimlikNo; }
            set { _tCKimlikNo = value; }
        }
        
        public DateTime DogumTarihi
        {
            get { return _dogumTarihi; }
            set { _dogumTarihi = value; }
        }
        
        public string Cinsiyet
        {
            get { return _cinsiyet; }
            set { _cinsiyet = value; }
        }

        public int MusteriIlID
        {
            get { return _musteriIlID; }
            set { _musteriIlID = value; }
        }

        public int MusteriIlceID
        {
            get { return _musteriIlceID; }
            set { _musteriIlceID = value; }
        }

        public int MusteriID
        {
            get { return _musteriID; }
            set { _musteriID = value; }
        }


        public string MusteriAdi
        {
            get { return _musteriAdi; }
            set { _musteriAdi = value; }
        }


        public string MusteriSoyadi
        {
            get { return _musteriSoyadi; }
            set { _musteriSoyadi = value; }
        }


        public string MusteriNick
        {
            get { return _musteriNick; }
            set { _musteriNick = value; }
        }


        public string MusterSifre
        {
            get { return _musterSifre; }
            set { _musterSifre = value; }
        }


        public string MusteriTelefon
        {
            get { return _musteriTelefon; }
            set { _musteriTelefon = value; }
        }


        public string MusteriMail
        {
            get { return _musteriMail; }
            set { _musteriMail = value; }
        }


        public string MusteriAdresi
        {
            get { return _musteriAdresi; }
            set { _musteriAdresi = value; }
        }

        public DateTime MusteriKayitTarihi
        {
            get { return _musteriKayitTarihi; }
            set { _musteriKayitTarihi = value; }
        }


        public DateTime SonGirisTarihi
        {
            get { return _sonGirisTarihi; }
            set { _sonGirisTarihi = value; }
        }


        public double Alacagi
        {
            get { return _alacagi; }
            set { _alacagi = value; }
        }


        public double Borcu
        {
            get { return _borcu; }
            set { _borcu = value; }
        }


        #endregion

        public bool KullaniciAdiVarmi(string KullaniciAdi)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("select count(*) from Musteriler where MusteriNick=@MusteriNick and MusteriSilindi=0",conn);
            comm.Parameters.Add("@MusteriNick", SqlDbType.VarChar).Value = KullaniciAdi;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return Sonuc;
        }

        public void IlleriGetir(ComboBox liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select Sehir from iller", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    liste.Items.Add(dr["Sehir"].ToString());
                }
                dr.Close();

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        public void IlceleriGetir(ComboBox liste,string ilId)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select Ilce from Ilceler where Sehir=@Sehir", conn);
            comm.Parameters.Add("@Sehir", SqlDbType.Int).Value = Convert.ToInt32(ilId);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    liste.Items.Add(dr["Ilce"].ToString());
                }
                dr.Close();

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool MusteriKaydet(Musteriler m)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Insert into Musteriler (MusteriAdi, MusteriSoyadi, MusteriNick, MusteriSifre, MusteriTelefon, MusteriMail, MusteriAdresi, MusteriIlce, MusteriIl, MusteriDogumTarihi, MusteriTC, Cinsiyet, MusteriPostaKodu, KullaniciMi) values (@MusteriAdi, @MusteriSoyadi, @MusteriNick, @MusteriSifre, @MusteriTelefon, @MusteriMail, @MusteriAdresi, @MusteriIlce, @MusteriIl, @MusteriDogumTarihi, @MusteriTC, @Cinsiyet, @MusteriPostaKodu,@KullaniciMi)", conn);
            comm.Parameters.Add("@MusteriAdi", SqlDbType.VarChar).Value = m._musteriAdi;
            comm.Parameters.Add("@MusteriSoyadi", SqlDbType.VarChar).Value = m._musteriSoyadi;
            comm.Parameters.Add("@MusteriNick", SqlDbType.VarChar).Value = m._musteriNick;
            comm.Parameters.Add("@MusteriSifre", SqlDbType.VarChar).Value = m._musterSifre;
            comm.Parameters.Add("@MusteriTelefon", SqlDbType.VarChar).Value = m._musteriTelefon;
            comm.Parameters.Add("@MusteriMail", SqlDbType.VarChar).Value = m._musteriMail;
            comm.Parameters.Add("@MusteriAdresi", SqlDbType.VarChar).Value = m._musteriAdresi;
            comm.Parameters.Add("@MusteriIlce", SqlDbType.Int).Value = m._musteriIlceID;
            comm.Parameters.Add("@MusteriIl", SqlDbType.Int).Value = m._musteriIlID;
            comm.Parameters.Add("@MusteriDogumTarihi", SqlDbType.DateTime).Value = m._dogumTarihi;
            comm.Parameters.Add("@MusteriTC", SqlDbType.VarChar).Value = m._tCKimlikNo;
            comm.Parameters.Add("@Cinsiyet", SqlDbType.VarChar).Value = m._cinsiyet;
            comm.Parameters.Add("@MusteriPostaKodu", SqlDbType.VarChar).Value = m._postaKodu;
            comm.Parameters.Add("@KullaniciMi", SqlDbType.VarChar).Value = m._kullaniciMi;
            
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery()); // hata çıkabilecek kodu try içine alıyoruz.
            }
            catch (SqlException ex) // hata durumunda programın çalışması catch bloğuna düşecektir.
            {
                string hata = ex.Message;
            }

            finally { conn.Close(); } // hata olsun olmasın mutlaka Finally bloğu çalışır.
            return sonuc;
        }

        internal bool MusteriSil(int musteriID)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("update Musteriler set MusteriSilindi=1 where MusteriID=@MusteriID", conn);
            comm.Parameters.Add("@MusteriID", SqlDbType.Int).Value = musteriID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex) // hata durumunda programın çalışması catch bloğuna düşecektir.
            {
                string hata = ex.Message;
            }

            finally { conn.Close(); } // hata olsun olmasın mutlaka Finally bloğu çalışır.
            return sonuc;
        }

        public string SehirNoGetir(string SehirAdi)
        {
            string SehirNo = "";
            SqlCommand comm = new SqlCommand("select Id from iller where Sehir=@Sehir ", conn);
            comm.Parameters.Add("@Sehir", SqlDbType.VarChar).Value = SehirAdi;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                SehirNo = comm.ExecuteScalar().ToString();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return SehirNo;
        }

        public string IlceNoGetir(string ilceAdi)
        {
            string İlceNo = "";
            SqlCommand comm = new SqlCommand("select ID from Ilceler where Ilce=@Ilce ", conn);
            comm.Parameters.Add("@Ilce", SqlDbType.VarChar).Value = ilceAdi;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                İlceNo = comm.ExecuteScalar().ToString();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return İlceNo;
        }

        public int MusteriAra(string KullaniciAdi, string Sifre)
        {
            int MusteriID = 0;
            SqlCommand comm = new SqlCommand("select MusteriID from Musteriler where KullaniciMi=0 and MusteriNick=@MusteriNick and MusteriSifre=@Sifre", conn);
            comm.Parameters.Add("@MusteriNick", SqlDbType.VarChar).Value = KullaniciAdi;
            comm.Parameters.Add("@Sifre", SqlDbType.VarChar).Value = Sifre;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                MusteriID = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return MusteriID;
        }

        public int KullaniciAra(string KullaniciAdi, string Sifre)
        {
            int KulaniciID = 0;
            SqlCommand comm = new SqlCommand("select MusteriID from Musteriler where KullaniciMi=1 and MusteriNick=@MusteriNick and MusteriSifre=@Sifre", conn);
            comm.Parameters.Add("@MusteriNick", SqlDbType.VarChar).Value = KullaniciAdi;
            comm.Parameters.Add("@Sifre", SqlDbType.VarChar).Value = Sifre;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                KulaniciID = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return KulaniciID;
        }

        public string KullaniciGetir(int KullaniciID)
        {
            string Kullanici="";
            SqlCommand comm = new SqlCommand("select MusteriAdi, MusteriSoyadi from Musteriler where MusteriID=@MusteriID and MusteriSilindi=0", conn);
            comm.Parameters.Add("@MusteriID", SqlDbType.Int).Value = KullaniciID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr= comm.ExecuteReader();
                while (dr.Read())
                {
                    Kullanici = dr[0] + " " + dr[1];
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return Kullanici;
        }


        public string HesapBilgileriniGetir(int MusteriID, TextBox txtAdres, TextBox txtEMail, TextBox txtIl, TextBox txtIlce, TextBox txtIlceNo, TextBox txtKullaniciAdi, TextBox txtPostaKodu, TextBox txtSehirNo, TextBox txtSifre, TextBox txtSifreTekrar1, MaskedTextBox mtxtDogumTarihi, MaskedTextBox mtxtTC, MaskedTextBox mtxtTelefon, TextBox txtAdi, TextBox txtSoyadi)
        {
            string Cinsiyet="";
            SqlCommand comm = new SqlCommand("select MusteriAdi, MusteriSoyadi, MusteriNick, MusteriAdresi, MusteriSifre, MusteriTelefon, MusteriMail, MusteriIlID, MusteriIlceID, MusteriDogumTarihi, MusteriTC, Cinsiyet,MusteriPostaKodu,il.Sehir as Sehir, ilce.Ilce as Ilce from Musteriler m inner join iller il on m.MusteriIlID=il.Id inner join Ilceler ilce on m.MusteriIlceID=ilce.ID where MusteriID=@MusteriID and MusteriSilindi=0", conn);
            comm.Parameters.Add("@MusteriID", SqlDbType.Int).Value = MusteriID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    txtSehirNo.Text = dr["MusteriIlID"].ToString();
                    Cinsiyet= dr["Cinsiyet"].ToString().ToUpper();
                    mtxtDogumTarihi.Text= dr["MusteriDogumTarihi"].ToString();
                    txtAdi.Text = dr["MusteriAdi"].ToString();
                    txtAdres.Text = dr["MusteriAdresi"].ToString();
                    txtIlceNo.Text = dr["MusteriIlceID"].ToString();
                    txtEMail.Text = dr["MusteriMail"].ToString();
                    txtKullaniciAdi.Text = dr["MusteriNick"].ToString();
                    txtSoyadi.Text = dr["MusteriSoyadi"].ToString();
                    mtxtTelefon.Text = dr["MusteriTelefon"].ToString();
                    txtSifre.Text = dr["MusteriSifre"].ToString();
                    txtSifreTekrar1.Text = dr["MusteriSifre"].ToString();
                    txtPostaKodu.Text= dr["MusteriPostaKodu"].ToString();
                    mtxtTC.Text= dr["MusteriTC"].ToString();
                    txtIl.Text = dr["Sehir"].ToString();
                    txtIlce.Text = dr["Ilce"].ToString();
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return Cinsiyet;
        }

        public bool KullaniciGuncelle(Musteriler m)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Update Musteriler Set MusteriAdi=@MusteriAdi, MusteriSoyadi=@MusteriSoyadi, MusteriNick=@MusteriNick, MusteriSifre=@MusteriSifre, MusteriTelefon=@MusteriTelefon, MusteriMail=@MusteriMail, MusteriAdresi=@MusteriAdresi, MusteriIlceID=@MusteriIlce, MusteriIlID=@MusteriIl, MusteriDogumTarihi=@MusteriDogumTarihi, MusteriTC=@MusteriTC, Cinsiyet=@Cinsiyet, MusteriPostaKodu=@MusteriPostaKodu where MusteriID=@MusteriID", conn);
            comm.Parameters.Add("@MusteriID", SqlDbType.Int).Value = m._musteriID;
            comm.Parameters.Add("@MusteriAdi", SqlDbType.VarChar).Value = m._musteriAdi;
            comm.Parameters.Add("@MusteriSoyadi", SqlDbType.VarChar).Value = m._musteriSoyadi;
            comm.Parameters.Add("@MusteriNick", SqlDbType.VarChar).Value = m._musteriNick;
            comm.Parameters.Add("@MusteriSifre", SqlDbType.VarChar).Value = m._musterSifre;
            comm.Parameters.Add("@MusteriTelefon", SqlDbType.VarChar).Value = m._musteriTelefon;
            comm.Parameters.Add("@MusteriMail", SqlDbType.VarChar).Value = m._musteriMail;
            comm.Parameters.Add("@MusteriAdresi", SqlDbType.VarChar).Value = m._musteriAdresi;
            comm.Parameters.Add("@MusteriIlce", SqlDbType.Int).Value = m._musteriIlceID;
            comm.Parameters.Add("@MusteriIl", SqlDbType.Int).Value = m._musteriIlID;
            comm.Parameters.Add("@MusteriDogumTarihi", SqlDbType.DateTime).Value = m._dogumTarihi;
            comm.Parameters.Add("@MusteriTC", SqlDbType.VarChar).Value = m._tCKimlikNo;
            comm.Parameters.Add("@Cinsiyet", SqlDbType.VarChar).Value = m._cinsiyet;
            comm.Parameters.Add("@MusteriPostaKodu", SqlDbType.VarChar).Value = m._postaKodu;

            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery()); // hata çıkabilecek kodu try içine alıyoruz.
            }
            catch (SqlException ex) // hata durumunda programın çalışması catch bloğuna düşecektir.
            {
                string hata = ex.Message;
            }

            finally { conn.Close(); } // hata olsun olmasın mutlaka Finally bloğu çalışır.
            return sonuc;
        }

        public DateTime IlkTarihGetir()
        {
            DateTime ilktarih=Convert.ToDateTime("01.01.1990");
            SqlCommand comm = new SqlCommand("select convert(datetime,MusteriKayitTarihi,104) from Musteriler where MusteriID=@MusteriID", conn);
            comm.Parameters.Add("@MusteriID", SqlDbType.Int).Value = Genel.MusteriID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                ilktarih = Convert.ToDateTime(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return ilktarih;

        }

        public bool MusteriBorcGuncelleme(Musteriler m)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("update Musteriler set Borcu += Borcu + @gelenborc where MusteriID=@MusteriID", conn);
            comm.Parameters.Add("@gelenborc", SqlDbType.Money).Value = m._borcu;
            comm.Parameters.Add("@MusteriID", SqlDbType.Int).Value = m._musteriID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return sonuc;
        }

        public void KullaniciGetirFromKullaniciBilgileri(bool KullaniciMi,ListView liste)
        {

            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select MusteriID,Convert(Datetime, MusteriKayitTarihi, 104) as KayitTarihi, Convert(Datetime, SonGirisTarihi, 104) as SonGirisTarihi,MusteriAdi, MusteriSoyadi, MusteriNick, MusteriSifre, MusteriTelefon, MusteriMail, il.Sehir,ilce.Ilce, MusteriAdresi, MusteriIlID, MusteriIlceID from Musteriler m inner join iller il on m.MusteriIlID=il.Id inner join Ilceler ilce on m.MusteriIlceID=ilce.ID where KullaniciMi=@KullaniciMi and MusteriSilindi=0", conn);
            comm.Parameters.Add("@KullaniciMi", SqlDbType.Bit).Value = Convert.ToInt32(KullaniciMi);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    int i = 0;
                    while (dr.Read())
                    {
                        liste.Items.Add(dr[0].ToString());
                        liste.Items[i].SubItems.Add(dr[1].ToString());
                        liste.Items[i].SubItems.Add(dr[2].ToString());
                        liste.Items[i].SubItems.Add(dr[3].ToString());
                        liste.Items[i].SubItems.Add(dr[4].ToString());
                        liste.Items[i].SubItems.Add(dr[5].ToString());
                        liste.Items[i].SubItems.Add(dr[6].ToString());
                        liste.Items[i].SubItems.Add(dr[7].ToString());
                        liste.Items[i].SubItems.Add(dr[8].ToString());
                        liste.Items[i].SubItems.Add(dr[9].ToString());
                        liste.Items[i].SubItems.Add(dr[10].ToString());
                        liste.Items[i].SubItems.Add(dr[11].ToString());
                        liste.Items[i].SubItems.Add(dr[12].ToString());
                        liste.Items[i].SubItems.Add(dr[13].ToString());
                        i++;
                    }
                    dr.Close();
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }   
        }

        public void MusterileriGetirFromMusteriBilgileri(bool KullaniciMi, string Ad, string Soyad, string Mail, string Adres, string Telefon, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select MusteriID,Convert(Datetime, MusteriKayitTarihi, 104) as KayitTarihi, Convert(Datetime, SonGirisTarihi, 104) as SonGirisTarihi, MusteriAdi, MusteriSoyadi, MusteriNick, MusteriSifre, MusteriTelefon, MusteriMail, il.Sehir,ilce.Ilce, MusteriAdresi, MusteriIl, MusteriIlce from Musteriler m inner join iller il on m.MusteriIl=il.Id inner join Ilceler ilce on m.MusteriIlce=ilce.ID where KullaniciMi=@KullaniciMi and MusteriAdi like @Ad+'%' and MusteriSoyadi like @Soyad+'%' and MusteriMail like @Mail+'%' and MusteriAdresi like @Adres+'%' and MusteriTelefon like @Telefon+'%' and MusteriSilindi=0", conn);
            comm.Parameters.Add("@KullaniciMi", SqlDbType.Bit).Value = Convert.ToInt32(KullaniciMi);
            comm.Parameters.Add("@Ad", SqlDbType.VarChar).Value = Ad;
            comm.Parameters.Add("@Soyad", SqlDbType.VarChar).Value = Soyad;
            comm.Parameters.Add("@Mail", SqlDbType.VarChar).Value = Mail;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = Adres;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = Telefon;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    int i = 0;
                    while (dr.Read())
                    {
                        liste.Items.Add(dr[0].ToString());
                        liste.Items[i].SubItems.Add(dr[1].ToString());
                        liste.Items[i].SubItems.Add(dr[2].ToString());
                        liste.Items[i].SubItems.Add(dr[3].ToString());
                        liste.Items[i].SubItems.Add(dr[4].ToString());
                        liste.Items[i].SubItems.Add(dr[5].ToString());
                        liste.Items[i].SubItems.Add(dr[6].ToString());
                        liste.Items[i].SubItems.Add(dr[7].ToString());
                        liste.Items[i].SubItems.Add(dr[8].ToString());
                        liste.Items[i].SubItems.Add(dr[9].ToString());
                        liste.Items[i].SubItems.Add(dr[10].ToString());
                        liste.Items[i].SubItems.Add(dr[11].ToString());
                        liste.Items[i].SubItems.Add(dr[12].ToString());
                        liste.Items[i].SubItems.Add(dr[13].ToString());
                        i++;
                    }
                    dr.Close();
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }   
        }

        internal void KullaniciGetirByIlceNo(bool KullaniciMi, int ilceno, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select MusteriID,Convert(Datetime, MusteriKayitTarihi, 104) as KayitTarihi, Convert(Datetime, SonGirisTarihi, 104) as SonGirisTarihi, MusteriAdi, MusteriSoyadi, MusteriNick, MusteriSifre, MusteriTelefon, MusteriMail, il.Sehir,ilce.Ilce, MusteriAdresi, MusteriIl, MusteriIlce from Musteriler m inner join iller il on m.MusteriIl=il.Id inner join Ilceler ilce on m.MusteriIlce=ilce.ID where KullaniciMi=@KullaniciMi and MusteriIlce=@IlceNo and MusteriSilindi=0", conn);
            comm.Parameters.Add("@KullaniciMi", SqlDbType.Bit).Value = Convert.ToInt32(KullaniciMi);
            comm.Parameters.Add("@IlceNo", SqlDbType.Int).Value = ilceno;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    int i = 0;
                    while (dr.Read())
                    {
                        liste.Items.Add(dr[0].ToString());
                        liste.Items[i].SubItems.Add(dr[1].ToString());
                        liste.Items[i].SubItems.Add(dr[2].ToString());
                        liste.Items[i].SubItems.Add(dr[3].ToString());
                        liste.Items[i].SubItems.Add(dr[4].ToString());
                        liste.Items[i].SubItems.Add(dr[5].ToString());
                        liste.Items[i].SubItems.Add(dr[6].ToString());
                        liste.Items[i].SubItems.Add(dr[7].ToString());
                        liste.Items[i].SubItems.Add(dr[8].ToString());
                        liste.Items[i].SubItems.Add(dr[9].ToString());
                        liste.Items[i].SubItems.Add(dr[10].ToString());
                        liste.Items[i].SubItems.Add(dr[11].ToString());
                        liste.Items[i].SubItems.Add(dr[12].ToString());
                        liste.Items[i].SubItems.Add(dr[13].ToString());
                        i++;
                    }
                    dr.Close();
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }   
        }

        internal void KullaniciGetirByIlNo(bool KullaniciMi, int ilno, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select MusteriID,Convert(Datetime, MusteriKayitTarihi, 104) as KayitTarihi, Convert(Datetime, SonGirisTarihi, 104) as SonGirisTarihi, MusteriAdi, MusteriSoyadi, MusteriNick, MusteriSifre, MusteriTelefon, MusteriMail, il.Sehir,ilce.Ilce, MusteriAdresi, MusteriIl, MusteriIlce from Musteriler m inner join iller il on m.MusteriIl=il.Id inner join Ilceler ilce on m.MusteriIlce=ilce.ID where KullaniciMi=@KullaniciMi and MusteriIl=@IlNo and MusteriSilindi=0", conn);
            comm.Parameters.Add("@KullaniciMi", SqlDbType.Bit).Value = Convert.ToInt32(KullaniciMi);
            comm.Parameters.Add("@IlNo", SqlDbType.Int).Value = ilno;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    int i = 0;
                    while (dr.Read())
                    {
                        liste.Items.Add(dr[0].ToString());
                        liste.Items[i].SubItems.Add(dr[1].ToString());
                        liste.Items[i].SubItems.Add(dr[2].ToString());
                        liste.Items[i].SubItems.Add(dr[3].ToString());
                        liste.Items[i].SubItems.Add(dr[4].ToString());
                        liste.Items[i].SubItems.Add(dr[5].ToString());
                        liste.Items[i].SubItems.Add(dr[6].ToString());
                        liste.Items[i].SubItems.Add(dr[7].ToString());
                        liste.Items[i].SubItems.Add(dr[8].ToString());
                        liste.Items[i].SubItems.Add(dr[9].ToString());
                        liste.Items[i].SubItems.Add(dr[10].ToString());
                        liste.Items[i].SubItems.Add(dr[11].ToString());
                        liste.Items[i].SubItems.Add(dr[12].ToString());
                        liste.Items[i].SubItems.Add(dr[13].ToString());
                        i++;
                    }
                    dr.Close();
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }   
        }


        internal bool kullaniciMi(int kullaniciID)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("select KullaniciMi from Musteriler where MusteriID=@kullaniciID", conn);
            comm.Parameters.Add("@kullaniciID", SqlDbType.Int).Value = kullaniciID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc= Convert.ToBoolean(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return Sonuc;
        }

        public bool DogumTarihi10AyliMi(int musteriID)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("select convert(datetime,MusteriDogumTarihi,104) from Musteriler where MusteriID=@MusteriID", conn);
            comm.Parameters.Add("@MusteriID", SqlDbType.Int).Value = musteriID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                DateTime tarih = Convert.ToDateTime(comm.ExecuteScalar());
                if (tarih.Month < 10)
                {
                    sonuc = true;
                }
                else
                    sonuc = false;
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return sonuc;
        }

    }
}
