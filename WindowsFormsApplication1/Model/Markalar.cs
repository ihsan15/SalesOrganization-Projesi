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
    class Markalar
    {
        private int _markaID;
        private string _markaAdi;
        private string _sektorAdi;
        private string _markaYetkiliAdi;
        private string _markaYetkiliSoyadi;
        private string _markaYetkiliTelefon;
        private string _markaYetkiliMail;
        private string _markaYetkiliAdres;
        private int _markaIl;
        private int _markaIlce;
        private string _aciklama;
        private string _markaVergiDairesi;
        private string _markaVergiNo;
        private DateTime _markaKayitTarihi;

        #region properties
        public int MarkaID
        {
            get { return _markaID; }
            set { _markaID = value; }
        }


        public string Aciklama
        {
            get { return _aciklama; }
            set { _aciklama = value; }
        }
        public string MarkaAdi
        {
            get { return _markaAdi; }
            set { _markaAdi = value; }
        }


        public string SektorAdi
        {
            get { return _sektorAdi; }
            set { _sektorAdi = value; }
        }


        public string MarkaYetkiliAdi
        {
            get { return _markaYetkiliAdi; }
            set { _markaYetkiliAdi = value; }
        }


        public string MarkaYetkiliSoyadi
        {
            get { return _markaYetkiliSoyadi; }
            set { _markaYetkiliSoyadi = value; }
        }


        public string MarkaYetkiliTelefon
        {
            get { return _markaYetkiliTelefon; }
            set { _markaYetkiliTelefon = value; }
        }


        public string MarkaYetkiliMail
        {
            get { return _markaYetkiliMail; }
            set { _markaYetkiliMail = value; }
        }


        public string MarkaYetkiliAdres
        {
            get { return _markaYetkiliAdres; }
            set { _markaYetkiliAdres = value; }
        }


        public int MarkaIl
        {
            get { return _markaIl; }
            set { _markaIl = value; }
        }


        public int MarkaIlce
        {
            get { return _markaIlce; }
            set { _markaIlce = value; }
        }


        public string MarkaVergiDairesi
        {
            get { return _markaVergiDairesi; }
            set { _markaVergiDairesi = value; }
        }


        public string MarkaVergiNo
        {
            get { return _markaVergiNo; }
            set { _markaVergiNo = value; }
        }


        public DateTime MarkaKayitTarihi
        {
            get { return _markaKayitTarihi; }
            set { _markaKayitTarihi = value; }
        }
        #endregion

        SqlConnection conn = new SqlConnection(Genel.connstr);

        public bool MarkaVarmi(string MarkaAdi, string VergiNo)
        {
            bool Varmi = false;
            SqlCommand comm = new SqlCommand("select Count(*) from Markalar where Silindi=0  and MarkaAdi=@MarkaAdi and MarkaVergiNo=@MarkaVergiNo", conn);
            comm.Parameters.Add("@MarkaAdi", SqlDbType.VarChar).Value = MarkaAdi;
            comm.Parameters.Add("@MarkaVergiNo", SqlDbType.VarChar).Value = VergiNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            int Sayisi = Convert.ToInt32(comm.ExecuteScalar());
            if (Sayisi > 0)
            {
                Varmi = true;
            }
            conn.Close();
            return Varmi;
        }
        public bool MarkaEkle(Markalar m)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("insert into Markalar (MarkaAdi,MarkaYetkiliAdi,MarkaYetkiliSoyadi,MarkaYetkiliTelefon,MarkaYetkiliMail,MarkaYetkiliAdres,MarkaIl,MarkaIlce,MarkaVergiDairesi,MarkaVergiNo,MarkaKayitTarihi,Aciklama,SektorAdi) values (@MarkaAdi,@MarkaYetkiliAdi,@MarkaYetkiliSoyadi,@MarkaYetkiliTelefon,@MarkaYetkiliMail,@MarkaYetkiliAdres,@MarkaIl,@MarkaIlce,@MarkaVergiDairesi,@MarkaVergiNo,@MarkaKayitTarihi,@Aciklama,@SektorAdi)", conn);
            comm.Parameters.Add("@MarkaAdi", SqlDbType.VarChar).Value = m._markaAdi;
            comm.Parameters.Add("@MarkaYetkiliAdi", SqlDbType.VarChar).Value = m._markaYetkiliAdi;
            comm.Parameters.Add("@MarkaYetkiliSoyadi", SqlDbType.VarChar).Value = m._markaYetkiliSoyadi;
            comm.Parameters.Add("@MarkaYetkiliTelefon", SqlDbType.VarChar).Value = m._markaYetkiliTelefon;
            comm.Parameters.Add("@MarkaYetkiliMail", SqlDbType.VarChar).Value = m._markaYetkiliMail;
            comm.Parameters.Add("@MarkaYetkiliAdres", SqlDbType.VarChar).Value = m._markaYetkiliAdres;
            comm.Parameters.Add("@MarkaIl", SqlDbType.Int).Value = m._markaIl;
            comm.Parameters.Add("@MarkaIlce", SqlDbType.Int).Value = m._markaIlce;
            comm.Parameters.Add("@MarkaVergiDairesi", SqlDbType.VarChar).Value = m._markaVergiDairesi;
            comm.Parameters.Add("@MarkaVergiNo", SqlDbType.VarChar).Value = m._markaVergiNo;
            comm.Parameters.Add("@MarkaKayitTarihi", SqlDbType.DateTime).Value = m._markaKayitTarihi;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = m._aciklama;
            comm.Parameters.Add("@SektorAdi", SqlDbType.VarChar).Value = m._sektorAdi;
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

        public bool MarkaGuncelle(Markalar m)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Markalar set MarkaAdi=@MarkaAdi,MarkaYetkiliAdi=@MarkaYetkiliAdi,MarkaYetkiliSoyadi=@MarkaYetkiliSoyadi,MarkaYetkiliTelefon=@MarkaYetkiliTelefon,MarkaYetkiliMail=@MarkaYetkiliMail,MarkaYetkiliAdres=@MarkaYetkiliAdres,MarkaIl=@MarkaIl,MarkaIlce=@MarkaIlce,MarkaVergiDairesi=@MarkaVergiDairesi,MarkaVergiNo=@MarkaVergiNo,MarkaKayitTarihi=@MarkaKayitTarihi,Aciklama=@Aciklama,SektorAdi=@SektorAdi where MarkaID=@MarkaID", conn);
            comm.Parameters.Add("@MarkaAdi", SqlDbType.VarChar).Value = m._markaAdi;
            comm.Parameters.Add("@MarkaYetkiliAdi", SqlDbType.VarChar).Value = m._markaYetkiliAdi;
            comm.Parameters.Add("@MarkaYetkiliSoyadi", SqlDbType.VarChar).Value = m._markaYetkiliSoyadi;
            comm.Parameters.Add("@MarkaYetkiliTelefon", SqlDbType.VarChar).Value = m._markaYetkiliTelefon;
            comm.Parameters.Add("@MarkaYetkiliMail", SqlDbType.VarChar).Value = m._markaYetkiliMail;
            comm.Parameters.Add("@MarkaYetkiliAdres", SqlDbType.VarChar).Value = m._markaYetkiliAdres;
            comm.Parameters.Add("@MarkaIl", SqlDbType.Int).Value = m._markaIl;
            comm.Parameters.Add("@MarkaIlce", SqlDbType.Int).Value = m._markaIlce;
            comm.Parameters.Add("@MarkaVergiDairesi", SqlDbType.VarChar).Value = m._markaVergiDairesi;
            comm.Parameters.Add("@MarkaVergiNo", SqlDbType.VarChar).Value = m._markaVergiNo;
            comm.Parameters.Add("@MarkaKayitTarihi", SqlDbType.DateTime).Value = m._markaKayitTarihi;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = m._aciklama;
            comm.Parameters.Add("@SektorAdi", SqlDbType.VarChar).Value = m._sektorAdi;
            comm.Parameters.Add("@MarkaID", SqlDbType.VarChar).Value = m._markaID;
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

        public bool MarkaSil(int FirmaID)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update Markalar set Silindi = 1 where MarkaID=@MarkaID", conn);
            comm.Parameters.Add("@MarkaID", SqlDbType.Int).Value = FirmaID;
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

        internal DataTable MarkalariGetirByTarihlerArasi(DateTime ilkTarih, DateTime sonTarih)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select MarkaID,MarkaAdi,SektorAdi,(MarkaYetkiliAdi + MarkaYetkiliSoyAdi) as MarkaYetkili, MarkaYetkiliTelefon,MarkaYetkiliMail,MarkaYetkiliAdres,Aciklama, Convert(Date,MarkaKayitTarihi,104) as Tarih from Markalar where Silindi=0 and Convert(Date,MarkaKayitTarihi,104)between Convert(Date,@Tarih1,104) and Convert(Date,@Tarih2,104)", conn);
            da.SelectCommand.Parameters.Add("@Tarih1", SqlDbType.DateTime).Value = ilkTarih;
            da.SelectCommand.Parameters.Add("@Tarih2", SqlDbType.DateTime).Value = sonTarih;
            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return dt;
        }
        internal void FirmalariGetirByDoubleClick(int markaID, TextBox txtFirmaID, TextBox txtFirmaIsmi, TextBox txtSektor, TextBox txtFirmaYetkiliAdi, TextBox txtFirmaYetkiliSoyadi, TextBox txtFirmaTel, TextBox txtYetkiliMail, TextBox txtFirmaAdres, TextBox txtIl, TextBox txtIlce, TextBox txtAciklama, TextBox txtVergiDairesi, TextBox txtVergiNo, TextBox txtKayitTarihi, TextBox txtSehirNo, TextBox txtIlceNo)
        {

            SqlCommand comm = new SqlCommand("select MarkaAdi,SektorAdi,MarkaYetkiliAdi,MarkaYetkiliSoyadi, MarkaYetkiliTelefon, MarkaYetkiliMail, MarkaYetkiliAdres, MarkaIl, MarkaIlce, MarkaVergiDairesi, MarkaVergiNo, MarkaKayitTarihi, Aciklama, il.Sehir as Sehir, ilce.Ilce as Ilce,m.MarkaIl,m.MarkaIlce from Markalar m inner join iller il on m.MarkaIl = il.Id inner join Ilceler ilce on m.MarkaIlce = ilce.ID  where MarkaID=@MarkaID", conn);
            comm.Parameters.Add("@MarkaID", SqlDbType.Int).Value = markaID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtFirmaID.Text = markaID.ToString();
                        txtFirmaIsmi.Text = dr[0].ToString();
                        txtSektor.Text = dr[1].ToString();
                        txtFirmaYetkiliAdi.Text = dr[2].ToString();
                        txtFirmaYetkiliSoyadi.Text = dr[3].ToString();
                        txtFirmaTel.Text = dr[4].ToString();
                        txtYetkiliMail.Text = dr[5].ToString();
                        txtFirmaAdres.Text = dr[6].ToString();
                        txtIl.Text = dr[13].ToString();
                        txtIlce.Text = dr[14].ToString();
                        txtAciklama.Text = dr[12].ToString();
                        txtVergiDairesi.Text = dr[9].ToString();
                        txtVergiNo.Text = dr[10].ToString();
                        txtKayitTarihi.Text = dr[11].ToString();
                        txtSehirNo.Text = dr[15].ToString();
                        txtIlceNo.Text = dr[16].ToString();

                    }
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
        }

        //public void FirmalariGetirByDetayliSorgulama(string firmaIsmi, string yetkili, string adres, string vergiDairesi, string VergiNo, ListView liste)
        //{
        //    liste.Items.Clear();
        //    SqlCommand comm = new SqlCommand("Select MarkaID,MarkaAdi,(MarkaYetkiliAdi + ' ' +  MarkaYetkiliSoyadi) as MarkaYetkili, MarkaYetkiliTelefon,MarkaYetkiliMail,MarkaYetkiliAdres,Aciklama, Convert(Date,MarkaKayitTarihi,104) as Tarih from Markalar where Silindi=0 and MarkaAdi like @firmaIsmi + '%' and  MarkaYetkili like @MarkaYetkili + '%' and MarkaYetkiliAdres like '%' +  @MarkaYetkiliAdres + ' %' and MarkaVergiDairesi like @MarkaVergiDairesi + '%' and MarkaVergiNo like @MarkaVergiNo +'%'", conn);
        //    comm.Parameters.Add("@firmaIsmi", SqlDbType.VarChar).Value = firmaIsmi;
        //    comm.Parameters.Add("@MarkaYetkili", SqlDbType.VarChar).Value = yetkili;
        //    comm.Parameters.Add("@MarkaYetkiliAdres", SqlDbType.VarChar).Value = adres;     
        //    comm.Parameters.Add("@MarkaVergiDairesi", SqlDbType.VarChar).Value = vergiDairesi;
        //    comm.Parameters.Add("@MarkaVergiNo", SqlDbType.VarChar).Value = VergiNo;

        //    if (conn.State == ConnectionState.Closed) conn.Open();
        //    SqlDataReader dr;
        //    try
        //    {
        //        dr = comm.ExecuteReader();
        //        if (dr.HasRows)
        //        {
        //            int i = 0;
        //            while (dr.Read())
        //            {
        //                liste.Items.Add(dr[0].ToString());
        //                liste.Items[i].SubItems.Add(dr[1].ToString());
        //                liste.Items[i].SubItems.Add(dr[2].ToString());
        //                liste.Items[i].SubItems.Add(dr[3].ToString());
        //                liste.Items[i].SubItems.Add(dr[4].ToString());
        //                liste.Items[i].SubItems.Add(dr[5].ToString());
        //                liste.Items[i].SubItems.Add(dr[6].ToString());
        //                liste.Items[i].SubItems.Add(dr[7].ToString());
        //                i++;
        //            }
        //            dr.Close();
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        string hata = ex.Message;
        //    }
        //    finally { conn.Close(); }
        //}
        public void FirmalariGetirByDetayliSorgulama(string firmaIsmi, string firmaYekili, string firmaAdres, string vergiDairesi, string vergiNo, string sektor, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select MarkaID,MarkaAdi,SektorAdi,(MarkaYetkiliAdi + ' ' +  MarkaYetkiliSoyadi) as MarkaYetkili, MarkaYetkiliTelefon,MarkaYetkiliMail,MarkaYetkiliAdres,Aciklama, Convert(Date,MarkaKayitTarihi,104) as Tarih from Markalar where Silindi=0 and MarkaAdi like @MarkaAdi + '%' and MarkaYetkiliAdi  like '%' +  @MarkaYetkili + '%' and MarkaYetkiliAdres like '%'+ @MarkaYetkiliAdres + '%' and MarkaVergiDairesi like @MarkaVergiDairesi + '%' and MarkaVergiNo like @MarkaVergiNo +'%' and SektorAdi like @SektorAdi + '%' ", conn);
            comm.Parameters.Add("@MarkaAdi", SqlDbType.VarChar).Value = firmaIsmi;
            comm.Parameters.Add("@MarkaYetkili", SqlDbType.VarChar).Value = firmaYekili;
            comm.Parameters.Add("@MarkaYetkiliAdres", SqlDbType.VarChar).Value = firmaAdres;
            comm.Parameters.Add("@MarkaVergiDairesi", SqlDbType.VarChar).Value = vergiDairesi;
            comm.Parameters.Add("@MarkaVergiNo", SqlDbType.VarChar).Value = vergiNo;
            comm.Parameters.Add("@SektorAdi", SqlDbType.VarChar).Value = sektor;

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

        public void FirmalariGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select MarkaID,MarkaAdi,SektorAdi,(MarkaYetkiliAdi + MarkaYetkiliSoyAdi) as MarkaYetkili, MarkaYetkiliTelefon,MarkaYetkiliMail,MarkaYetkiliAdres,Aciklama, Convert(Date,MarkaKayitTarihi,104) as Tarih from Markalar where Silindi=0", conn);
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

        public void FirmalariGetirByDoubleClick(int markaID, TextBox txtFirmaID, TextBox txtFirmaIsmi, TextBox txtFirmaYetkili, TextBox txtFirmaTel, TextBox txtYetkiliMail, TextBox txtFirmaAdres, TextBox txtIl, TextBox txtIlce, TextBox txtAciklama, TextBox txtVergiDairesi, TextBox txtVergiNo, TextBox txtKayitTarihi)
        {

            SqlCommand comm = new SqlCommand("select MarkaAdi, (MarkaYetkiliAdi + ' ' + MarkaYetkiliSoyadi) as MarkaYetkili, MarkaYetkiliTelefon, MarkaYetkiliMail, MarkaYetkiliAdres, MarkaIl, MarkaIlce, MarkaVergiDairesi, MarkaVergiNo, MarkaKayitTarihi, Aciklama, il.Sehir as Sehir, ilce.Ilce as Ilce from Markalar m inner join iller il on m.MarkaIl = il.Id inner join Ilceler ilce on m.MarkaIlce = ilce.ID  where MarkaID=@MarkaID", conn);
            comm.Parameters.Add("@MarkaID", SqlDbType.Int).Value = markaID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtFirmaID.Text = markaID.ToString();
                        txtFirmaIsmi.Text = dr[0].ToString();
                        txtFirmaYetkili.Text = dr[1].ToString();
                        txtFirmaTel.Text = dr[2].ToString();
                        txtYetkiliMail.Text = dr[3].ToString();
                        txtFirmaAdres.Text = dr[4].ToString();
                        txtIl.Text = dr[11].ToString();
                        txtIlce.Text = dr[12].ToString();
                        txtAciklama.Text = dr[10].ToString();
                        txtVergiDairesi.Text = dr[7].ToString();
                        txtVergiNo.Text = dr[8].ToString();
                        txtKayitTarihi.Text = dr[9].ToString();

                    }
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
        }

        //public void FirmalariGetirByDetayliSorgulama(string firmaIsmi, string firmaYekili, string firmaAdres, string vergiDairesi, string vergiNo, string sektor, ListView liste)
        //{
        //    liste.Items.Clear();
        //    SqlCommand comm = new SqlCommand("Select MarkaID,MarkaAdi,SektorAdi,(MarkaYetkiliAdi + ' ' +  MarkaYetkiliSoyadi) as MarkaYetkili, MarkaYetkiliTelefon,MarkaYetkiliMail,MarkaYetkiliAdres,Aciklama, Convert(Date,MarkaKayitTarihi,104) as Tarih from Markalar where Silindi=0 and MarkaAdi like @MarkaAdi + '%' and MarkaYetkiliAdi  like '%' +  @MarkaYetkili + '%' and MarkaYetkiliAdres like '%'+ @MarkaYetkiliAdres + '%' and MarkaVergiDairesi like @MarkaVergiDairesi + '%' and MarkaVergiNo like @MarkaVergiNo +'%' and SektorAdi like @SektorAdi + '%' ", conn);
        //    comm.Parameters.Add("@MarkaAdi", SqlDbType.VarChar).Value = firmaIsmi;
        //    comm.Parameters.Add("@MarkaYetkili", SqlDbType.VarChar).Value = firmaYekili;
        //    comm.Parameters.Add("@MarkaYetkiliAdres", SqlDbType.VarChar).Value = firmaAdres;
        //    comm.Parameters.Add("@MarkaVergiDairesi", SqlDbType.VarChar).Value = vergiDairesi;
        //    comm.Parameters.Add("@MarkaVergiNo", SqlDbType.VarChar).Value = vergiNo;
        //    comm.Parameters.Add("@SektorAdi", SqlDbType.VarChar).Value = sektor;

        //    if (conn.State == ConnectionState.Closed) conn.Open();
        //    SqlDataReader dr;
        //    try
        //    {
        //        dr = comm.ExecuteReader();
        //        if (dr.HasRows)
        //        {
        //            int i = 0;
        //            while (dr.Read())
        //            {
        //                liste.Items.Add(dr[0].ToString());
        //                liste.Items[i].SubItems.Add(dr[1].ToString());
        //                liste.Items[i].SubItems.Add(dr[2].ToString());
        //                liste.Items[i].SubItems.Add(dr[3].ToString());
        //                liste.Items[i].SubItems.Add(dr[4].ToString());
        //                liste.Items[i].SubItems.Add(dr[5].ToString());
        //                liste.Items[i].SubItems.Add(dr[6].ToString());
        //                liste.Items[i].SubItems.Add(dr[7].ToString());
        //                liste.Items[i].SubItems.Add(dr[8].ToString());
        //                i++;
        //            }
        //            dr.Close();
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        string hata = ex.Message;
        //    }
        //    finally { conn.Close(); }
        //}

        public void MarkaAdiGetir(ComboBox liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select MarkaID, MarkaAdi from Markalar where Silindi=0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    Markalar mar = new Markalar();
                    mar._markaID = Convert.ToInt32(dr["MarkaID"].ToString());
                    mar._markaAdi = dr["MarkaAdi"].ToString();
                    liste.Items.Add(mar);
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

        public override string ToString()
        {
            return MarkaAdi;
        }

        //internal bool MarkaSil(int p)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
