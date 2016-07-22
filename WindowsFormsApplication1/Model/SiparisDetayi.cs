using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Model
{
    class SiparisDetayi
    {
        private int _siparisUrunID;
        private int _musteriID;
        private int _siparisID;
        private int _urunID;
        private string _urunAciklama;
        private int _urunAdet;
        private double _birimFiyat;
        private double _urunKDV;

        #region Properties

        public int SiparisUrunID
        {
            get { return _siparisUrunID; }
            set { _siparisUrunID = value; }
        }


        public int MusteriID
        {
            get { return _musteriID; }
            set { _musteriID = value; }
        }


        public int SiparisID
        {
            get { return _siparisID; }
            set { _siparisID = value; }
        }


        public int UrunID
        {
            get { return _urunID; }
            set { _urunID = value; }
        }


        public string UrunAciklama
        {
            get { return _urunAciklama; }
            set { _urunAciklama = value; }
        }


        public int UrunAdet
        {
            get { return _urunAdet; }
            set { _urunAdet = value; }
        }


        public double BirimFiyat
        {
            get { return _birimFiyat; }
            set { _birimFiyat = value; }
        }


        public double UrunKDV
        {
            get { return _urunKDV; }
            set { _urunKDV = value; }
        }

        #endregion

        SqlConnection conn = new SqlConnection(Genel.connstr);
        DataSet ds = new DataSet();
        public DataSet SiparisDetayiGetir(int SiparisID , int MusteriID)
        {
            ds.Clear();
            SqlDataAdapter da = new SqlDataAdapter("select SiparisUrunID, MusteriID, sd.UrunID, UrunAdi, UrunAciklama, UrunAdet, BirimFiyat, UrunKDV from SiparisDetayi sd inner join Urunler u on sd.UrunID=u.UrunID where SiparisID=@SiparisID and MusteriID=@MusteriID and Silindi=0", conn);
            da.SelectCommand.Parameters.Add("@MusteriID", SqlDbType.Int).Value = MusteriID;
            da.SelectCommand.Parameters.Add("@SiparisID", SqlDbType.Int).Value = SiparisID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                da.Fill(ds, "SiparisDetayi");
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return ds;
        }


        public bool SepeteUrunEkle(SiparisDetayi sd)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Insert into SiparisDetayi ( MusteriID, SiparisID, UrunID, UrunAciklama, UrunAdet, BirimFiyat, UrunKDV) values ( @MusteriID, @SiparisID, @UrunID, @UrunAciklama, @UrunAdet, @BirimFiyat, @UrunKDV)", conn);

            comm.Parameters.Add("@MusteriID", SqlDbType.Int).Value = sd._musteriID;
            comm.Parameters.Add("@SiparisID", SqlDbType.Int).Value = sd._siparisID;
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = sd._urunID;
            comm.Parameters.Add("@UrunAciklama", SqlDbType.VarChar).Value = sd._urunAciklama;
            comm.Parameters.Add("@UrunAdet", SqlDbType.Int).Value = sd._urunAdet;
            comm.Parameters.Add("@BirimFiyat", SqlDbType.Money).Value = sd._birimFiyat;
            comm.Parameters.Add("@UrunKDV", SqlDbType.Money).Value = sd._urunKDV;


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


        public DataSet SepetiGetir()
        {
            ds.Clear();
            SqlDataAdapter da = new SqlDataAdapter("Select SiparisUrunID, UrunKodu, UrunAdi, UrunAciklama, UrunAdet, BirimFiyat, UrunKDV,sd.UrunID from SiparisDetayi sd inner join Urunler u on sd.UrunID=u.UrunID where SiparisID= @SiparisID and Silindi=0", conn);
            da.SelectCommand.Parameters.Add("@SiparisID", SqlDbType.Int).Value = Genel.SiparisID;
            try
            {
                da.Fill(ds, "SiparisDetayi");
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return ds;
        }


        public bool SiparisDetayiKaydet(SiparisDetayi sd)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("insert into SiparisDetayi(MusteriID, SiparisID, UrunID, UrunAciklama, UrunAdet, BirimFiyat, UrunKDV) Values (@MusteriID, @SiparisID, @UrunID, @UrunAciklama, @UrunAdet, @BirimFiyat, @UrunKDV)", conn);
            comm.Parameters.Add("@MusteriID", SqlDbType.Int).Value = sd._musteriID;
            comm.Parameters.Add("@SiparisID", SqlDbType.Int).Value = sd._siparisID;
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = sd._urunID;
            comm.Parameters.Add("@UrunAciklama", SqlDbType.VarChar).Value = sd._urunAciklama;
            comm.Parameters.Add("@UrunAdet", SqlDbType.Int).Value = sd._urunAdet;
            comm.Parameters.Add("@BirimFiyat", SqlDbType.Money).Value = sd._birimFiyat;
            comm.Parameters.Add("@UrunKDV", SqlDbType.Money).Value = sd._urunKDV;
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

        public bool SepetGuncelle(int UrunID)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("update SiparisDetayi set Silindi=1 where UrunID=@UrunID", conn);
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = UrunID;
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

        public bool UrunMiktariGuncelle(int UrunID ,int Miktar)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("update SiparisDetayi set UrunAdet=@Miktar where UrunID=@UrunID", conn);
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = UrunID;
            comm.Parameters.Add("@Miktar", SqlDbType.Int).Value = Miktar;
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

        public bool SepetiSil()
        {
            bool sonuc=false;
            SqlCommand comm = new SqlCommand("delete from SiparisDetayi where SiparisID=@SiparisID");
            comm.Parameters.Add("@SiparisID", SqlDbType.Int).Value = Genel.SiparisID;
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

        public void OnayDurumGuncelleFromAlisveris(int siparisID)
        {
            SqlCommand comm = new SqlCommand("update Siparisler set SiparisDurum=1 where SiparisID=@SiparisID", conn);
            comm.Parameters.Add("@SiparisID", SqlDbType.Int).Value = siparisID;
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

        internal bool UrunVarmi(int UrunID, int SiparisID)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("select Count(*) from SiparisDetayi where SiparisID=@SiparisID and UrunID=@UrunID", conn);
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = UrunID;
            comm.Parameters.Add("@SiparisID", SqlDbType.Int).Value = SiparisID;
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

        internal bool SiparisDetayiGuncelle(int UrunID, int artisMiktari)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("update SiparisDetayi set UrunAdet+=@Miktar where UrunID=@UrunID", conn);
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = UrunID;
            comm.Parameters.Add("@Miktar", SqlDbType.Int).Value = artisMiktari;
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
    }
}
