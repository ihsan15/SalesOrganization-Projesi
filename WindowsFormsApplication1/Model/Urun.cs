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
    class Urun
    {
        private int _urunID;
        private string _urunAdi;
        private string _urunKodu;
        private int _markaID;
        private int _kategoriID;
        private double _urunIndirim;
        private string _urunIndirimAdi;
        private int _ekleyenMusteriID;
        private bool _silindiMi;
        private int _firmaNo;
        private int _altKategoriNo;
        private string _aciklamasi;
        private int _miktar;
        private int _kritikSeviye;
        private string _kampanyaAciklamasi;
        private double _fiyat;
        private bool _kampanyaVarMi;
        SqlConnection conn = new SqlConnection(Genel.connstr);

        #region Properties
        public int UrunID
        {
            get { return _urunID; }
            set { _urunID = value; }
        }

        public string UrunAdi
        {
            get { return _urunAdi; }
            set { _urunAdi = value; }
        }
        public string UrunKodu
        {
            get { return _urunKodu; }
            set { _urunKodu = value; }
        }
        public int MarkaID
        {
            get { return _markaID; }
            set { _markaID = value; }
        }
        public int KategoriID
        {
            get { return _kategoriID; }
            set { _kategoriID = value; }
        }
        public int FirmaNo
        {
            get { return _firmaNo; }
            set { _firmaNo = value; }
        }

        public int AltKategoriNo
        {
            get { return _altKategoriNo; }
            set { _altKategoriNo = value; }
        }

        public string Aciklamasi
        {
            get { return _aciklamasi; }
            set { _aciklamasi = value; }
        }

        public int Miktar
        {
            get { return _miktar; }
            set { _miktar = value; }
        }

        public int KritikSeviye
        {
            get { return _kritikSeviye; }
            set { _kritikSeviye = value; }
        }

        public double UrunIndirim
        {
            get { return _urunIndirim; }
            set { _urunIndirim = value; }
        }

        public string UrunIndirimAdi
        {
            get { return _urunIndirimAdi; }
            set { _urunIndirimAdi = value; }
        }
        public string KampanyaAciklamasi
        {
            get { return _kampanyaAciklamasi; }
            set { _kampanyaAciklamasi = value; }
        }

        public double Fiyat
        {
            get { return _fiyat; }
            set { _fiyat = value; }
        }
        public int EkleyenMusteriID
        {
            get { return _ekleyenMusteriID; }
            set { _ekleyenMusteriID = value; }
        }

        public bool KampanyaVarMi
        {
            get { return _kampanyaVarMi; }
            set { _kampanyaVarMi = value; }
        }
        public bool SilindiMi
        {
            get { return _silindiMi; }
            set { _silindiMi = value; }
        }
        #endregion

        public void UrunleriGetirFromAnasayfa(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select UrunID, UrunKodu, UrunAdi , MarkaAdi, Fiyat, KategoriAdi from Urunler inner join Markalar on Urunler.MarkaID=Markalar.MarkaID inner join Kategoriler on Urunler.KategoriID=Kategoriler.KategoriID where Urunler.SilindiMi=0 and StokAdet!=0 ", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
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
                    i++;
                }
                dr.Close();
            }
            conn.Close();
        }

        public void UrunleriGetirFromAnasayfaByUrunAdi(string UrunAdi, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select UrunID, UrunKodu, UrunAdi , MarkaAdi, Fiyat, KategoriAdi from Urunler inner join Markalar on Urunler.MarkaID=Markalar.MarkaID inner join Kategoriler on Urunler.KategoriID=Kategoriler.KategoriID where Urunler.SilindiMi=0  and UrunAdi like @UrunAdi+'%'", conn);
            comm.Parameters.Add("@UrunAdi", SqlDbType.VarChar).Value = UrunAdi;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
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
                    i++;
                }
                dr.Close();
            }
            conn.Close();
        }

        public void UrunleriGetirDetayli(int urunID, Label lblUrunID, Label lblMarka, Label lblUrunAdi, Label lblUrunKodu, TextBox txtAciklamasi, Label UrunFiyati)
        {
            SqlCommand comm = new SqlCommand("select UrunID, UrunKodu, UrunAdi , MarkaAdi , Fiyat, Urunler.Aciklama as Aciklama, Fiyat from Urunler inner join Markalar on Urunler.MarkaID=Markalar.MarkaID inner join Kategoriler on Urunler.KategoriID=Kategoriler.KategoriID where Urunler.SilindiMi=0 and UrunID=@UrunID ", conn);
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = urunID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();

                while (dr.Read())
                {
                    lblUrunID.Text = dr["UrunID"].ToString();
                    lblUrunKodu.Text = dr["UrunKodu"].ToString();
                    lblUrunAdi.Text = dr["UrunAdi"].ToString();
                    lblMarka.Text = dr["MarkaAdi"].ToString();
                    txtAciklamasi.Text = dr["Aciklama"].ToString();
                    UrunFiyati.Text = (Math.Round(Convert.ToDouble(dr["Fiyat"]), 2, MidpointRounding.AwayFromZero)).ToString();
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
        }

        public void UrunleriGetirFromAnasayfaByKategoriNo(ListView liste, string KategoriID)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select UrunID, UrunKodu, UrunAdi , MarkaAdi, Fiyat, KategoriAdi from Urunler inner join Markalar on Urunler.MarkaID=Markalar.MarkaID inner join Kategoriler on Urunler.KategoriID=Kategoriler.KategoriID where Urunler.SilindiMi=0  and Urunler.KategoriID=@KategoriID", conn);
            comm.Parameters.Add("@KategoriID", SqlDbType.Int).Value = Convert.ToInt32(KategoriID);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
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
                    i++;
                }
                dr.Close();
            }
            conn.Close();
        }

        public string[] UrunAdlariGetirForUrunArama()
        {
            string[] liste = new string[0];
            SqlCommand comm = new SqlCommand("select UrunAdi from Urunler", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Array.Resize(ref liste, liste.Length + 1);
                    liste[liste.Length - 1] = dr[0].ToString();
                }
                dr.Close();
            }
            conn.Close();
            return liste;
        }

        public void UrunleriGetirOnlyKampanyali(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select UrunID, UrunKodu, UrunAdi , UrunIndirim, UrunIndirimAdi from Urunler where SilindiMi=0 and KampanyaVarMi=1 ", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
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
                    i++;
                }
                dr.Close();
            }
            conn.Close();
        }

        public void UrunleriGetirOnlyKampanyaliByKategoriNo(ListView liste, string KategoriID)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select UrunID, UrunKodu, UrunAdi , UrunIndirim, UrunIndirimAdi from Urunler  where SilindiMi=0  and KategoriID=@KategoriID and KampanyaVarMi=1", conn);
            comm.Parameters.Add("@KategoriID", SqlDbType.Int).Value = Convert.ToInt32(KategoriID);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
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
                    i++;
                }
                dr.Close();
            }
            conn.Close();
        }

        public void UrunleriGetirOnlyKampanyaliByUrunAdi(string UrunAdi, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select UrunID, UrunKodu, UrunAdi , UrunIndirim, UrunIndirimAdi from Urunler where SilindiMi=0 and KampanyaVarMi=1 and UrunAdi like @UrunAdi+'%'", conn);
            comm.Parameters.Add("@UrunAdi", SqlDbType.VarChar).Value = UrunAdi;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
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
                    i++;
                }
                dr.Close();
            }
            conn.Close();
        }


        public string KampanyaMiktari()
        {
            string miktar = "";
            SqlCommand comm = new SqlCommand("select count(*) from Urunler where SilindiMi=0 and KampanyaVarMi=1 ", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                miktar = comm.ExecuteScalar().ToString();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            conn.Close();
            return miktar;
        }

        public int UrunMiktarOgren(int UrunID)
        {
            int miktar = 1;
            SqlCommand comm = new SqlCommand("select StokAdet from Urunler where UrunID=@UrunID", conn);
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = UrunID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                miktar = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return miktar;
        }

        public void StokGuncelleFromSiparisiTamamla(int UrunID, int Miktar)
        {
            SqlCommand comm = new SqlCommand("update Urunler set StokAdet=StokAdet-@Miktar where UrunID=@UrunID", conn);
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = UrunID;
            comm.Parameters.Add("@Miktar", SqlDbType.Int).Value = Miktar;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
        }

        public double KampanyaVarmi(int urunID)
        {
            double kampanyatutari = 0;
            SqlCommand comm = new SqlCommand("select UrunIndirim from Urunler where KampanyaVarMi=1 and UrunID=@UrunID", conn);
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = urunID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                kampanyatutari = Convert.ToDouble(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return kampanyatutari;
        }

        public void UrunleriGetirFromUrunBilgileri(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select UrunID, UrunKodu, UrunAdi,  MarkaAdi, KategoriAdi, Fiyat, StokAdet, StokKritikSeviye from Urunler inner join Markalar on Urunler.MarkaID=Markalar.MarkaID inner join Kategoriler on Urunler.KategoriID=Kategoriler.KategoriID where Urunler.SilindiMi=0 ", conn);
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
                        i++;
                    }
                    dr.Close();
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }

            finally { conn.Close(); }
        }


        public void UrunleriGetirFromUrunBilgileriForDetayliArama(string UrunKodu, string UrunAdi, string MarkaAdi, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select UrunID, UrunKodu, UrunAdi,  MarkaAdi, KategoriAdi, Fiyat, StokAdet, StokKritikSeviye from Urunler inner join Markalar on Urunler.MarkaID=Markalar.MarkaID inner join Kategoriler on Urunler.KategoriID=Kategoriler.KategoriID where Urunler.SilindiMi=0 and UrunKodu like @UrunKodu + '%' and  UrunAdi like @UrunAdi+'%' and MarkaAdi like  @MarkaAdi+'%' ", conn);
            comm.Parameters.Add("@UrunKodu", SqlDbType.VarChar).Value = UrunKodu;
            comm.Parameters.Add("@UrunAdi", SqlDbType.VarChar).Value = UrunAdi;
            comm.Parameters.Add("@MarkaAdi", SqlDbType.VarChar).Value = MarkaAdi;
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

        internal void UrunleriGetirFromUrunBilgileriByKategoriID(int KategoriId, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select UrunID, UrunKodu, UrunAdi,  MarkaAdi, KategoriAdi, Fiyat, StokAdet, StokKritikSeviye from Urunler inner join Markalar on Urunler.MarkaID=Markalar.MarkaID inner join Kategoriler on Urunler.KategoriID=Kategoriler.KategoriID where Urunler.SilindiMi=0 and Urunler.KategoriID=@KategoriId", conn);
            comm.Parameters.Add("@KategoriId", SqlDbType.Int).Value = KategoriId;
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
                        i++;
                    }
                    dr.Close();
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
        }

        public bool UrunBilgileriGetir(int UrunID, TextBox txtAltKat, TextBox txtAltKategori, TextBox txtMarkaAdı, TextBox txtFiyat, TextBox txtIndirimAciklamasi, TextBox txtIndirimliFiyat, TextBox txtKritikSeviye, TextBox txtMarkaID, TextBox txtStokMiktarı, TextBox txtUrunAciklamasi, TextBox txtUrunAdı, TextBox txtUrunID, TextBox txtUrunKodu)
        {
            bool kampanya = false;
            SqlCommand comm = new SqlCommand("select Urunler.KategoriID, KategoriAdi, MarkaAdi, Fiyat, UrunIndirimAdi, UrunIndirim, StokKritikSeviye,Urunler.MarkaID, StokAdet, Urunler.Aciklama, UrunAdi, UrunID, UrunKodu, KampanyaVarMi from Urunler inner join Markalar on Urunler.MarkaID=Markalar.MarkaID inner join Kategoriler on Urunler.KategoriID=Kategoriler.KategoriID where Urunler.SilindiMi=0 ", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtAltKat.Text = dr[0].ToString();
                        txtAltKategori.Text = dr[1].ToString();
                        txtMarkaAdı.Text = dr[2].ToString();
                        txtFiyat.Text = dr[3].ToString();
                        txtIndirimAciklamasi.Text = dr[4].ToString();
                        txtIndirimliFiyat.Text = dr[5].ToString();
                        txtKritikSeviye.Text = dr[6].ToString();
                        txtMarkaID.Text = dr[7].ToString();
                        txtStokMiktarı.Text = dr[8].ToString();
                        txtUrunAciklamasi.Text = dr[9].ToString();
                        txtUrunAdı.Text = dr[10].ToString();
                        txtUrunID.Text = dr[11].ToString();
                        txtUrunKodu.Text = dr[12].ToString();
                        kampanya = Convert.ToBoolean(dr[13]);
                    }
                    dr.Close();
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }

            finally { conn.Close(); }
            return kampanya;
        }

        internal bool UrunleriGuncelle(Urun u)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Update Urunler Set UrunAdi=@UrunAdi, UrunKodu=@UrunKodu, MarkaID=@MarkaID, KategoriID=@KategoriID, Fiyat=@Fiyat, Aciklama=@Aciklama, StokAdet=@StokAdet, StokKritikSeviye=@StokKritikSeviye, KampanyaVarMi=@KampanyaVarMi, UrunIndirim=@UrunIndirim, UrunIndirimAdi=@UrunIndirimAdi, EkleyenMusteriID=@EkleyenMusteriID where UrunID=@UrunID", conn);
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = u._urunID;
            comm.Parameters.Add("@UrunAdi", SqlDbType.VarChar).Value = u._urunAdi;
            comm.Parameters.Add("@UrunKodu", SqlDbType.VarChar).Value = u._urunKodu;
            comm.Parameters.Add("@MarkaID", SqlDbType.Int).Value = u._markaID;
            comm.Parameters.Add("@KategoriID", SqlDbType.Int).Value = u._kategoriID;
            comm.Parameters.Add("@Fiyat", SqlDbType.Money).Value = u._fiyat;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = u._aciklamasi;
            comm.Parameters.Add("@StokAdet", SqlDbType.Int).Value = u._miktar;
            comm.Parameters.Add("@StokKritikSeviye", SqlDbType.Int).Value = u._kritikSeviye;
            comm.Parameters.Add("@KampanyaVarMi", SqlDbType.Bit).Value = u._kampanyaVarMi;
            comm.Parameters.Add("@UrunIndirim", SqlDbType.Money).Value = u._urunIndirim;
            comm.Parameters.Add("@UrunIndirimAdi", SqlDbType.VarChar).Value = u._kampanyaAciklamasi;
            comm.Parameters.Add("@EkleyenMusteriID", SqlDbType.Int).Value = u._ekleyenMusteriID;

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
        public bool UrunSil(int UrunID)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Urunler set SilindiMi=1 where UrunID=@UrunID", conn);
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = UrunID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return Sonuc;
        }

        public bool UrunVarmi(string urunkodu, string urunadi, int markaID)
        {
            bool Varmi = false;
            SqlCommand comm = new SqlCommand("select Count(*) from Urunler where SilindiMi=0  and UrunKodu=@UrunKodu and UrunAdi=@UrunAdi and  MarkaID=@MarkaID ", conn);
            comm.Parameters.Add("@UrunKodu", SqlDbType.VarChar).Value = urunkodu;
            comm.Parameters.Add("@UrunAdi", SqlDbType.VarChar).Value = urunadi;
            comm.Parameters.Add("@MarkaID", SqlDbType.Int).Value = markaID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            int Sayisi = Convert.ToInt32(comm.ExecuteScalar());
            if (Sayisi > 0)
            {
                Varmi = true;
            }
            conn.Close();
            return Varmi;
        }

        public bool UrunEkle(Urun u)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("insert into Urunler (UrunAdi, UrunKodu , MarkaID, KategoriID, Aciklama,Fiyat,StokAdet,StokKritikSeviye,EkleyenMusteriID) values(@UrunAdi, @UrunKodu , @MarkaID, @KategoriID, @Aciklama,@Fiyat,@StokAdet,@StokKritikSeviye,@EkleyenMusteriID)", conn);

            comm.Parameters.Add("@UrunAdi", SqlDbType.VarChar).Value = u._urunAdi;
            comm.Parameters.Add("@UrunKodu", SqlDbType.VarChar).Value = u._urunKodu;
            comm.Parameters.Add("@MarkaID", SqlDbType.Int).Value = u._markaID;
            comm.Parameters.Add("@KategoriID", SqlDbType.Int).Value = u._kategoriID;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = u._aciklamasi;
            comm.Parameters.Add("@Fiyat", SqlDbType.Money).Value = u._fiyat;
            comm.Parameters.Add("@StokAdet", SqlDbType.Int).Value = u._miktar;
            comm.Parameters.Add("@StokKritikSeviye", SqlDbType.Int).Value = u._kritikSeviye;
            comm.Parameters.Add("@EkleyenMusteriID", SqlDbType.Int).Value = u._ekleyenMusteriID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return Sonuc;
        }
    }
}
