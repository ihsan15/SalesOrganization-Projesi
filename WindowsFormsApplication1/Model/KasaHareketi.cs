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
    class KasaHareketi
    {
        private int _kasaID;
        private int _musteriID;
        private bool _ıslemTuru; // 1 ise kasaya giren para 0 ise kasadan çıkan para
        private string _aciklama;
        private int _yetkiliID;
        private DateTime _tarih;
        private double _tutar;


        #region Properties
        public int KasaID
        {
            get { return _kasaID; }
            set { _kasaID = value; }
        }

        public int MusteriID
        {
            get { return _musteriID; }
            set { _musteriID = value; }
        }

        public bool IslemTuru
        {
            get { return _ıslemTuru; }
            set { _ıslemTuru = value; }
        }
        public double Tutar
        {
            get { return _tutar; }
            set { _tutar = value; }
        }

        public string Aciklama
        {
            get { return _aciklama; }
            set { _aciklama = value; }
        }

        public int YetkiliID
        {
            get { return _yetkiliID; }
            set { _yetkiliID = value; }
        }

        public DateTime Tarih
        {
            get { return _tarih; }
            set { _tarih = value; }
        }
        #endregion

        SqlConnection conn = new SqlConnection(Genel.connstr);
        public bool KasaHareketEkleFromSepet(KasaHareketi kh)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("insert into KasaHareketler (MusteriID, IslemTuru, Tutar, Aciklama, YetkiliID, Tarih) values (@MusteriID, @IslemTuru, @Tutar, @Aciklama,@YetkiliID, @Tarih)", conn);
            comm.Parameters.Add("@MusteriID", SqlDbType.Int).Value = kh._musteriID;
            comm.Parameters.Add("@IslemTuru", SqlDbType.Bit).Value = kh._ıslemTuru;
            comm.Parameters.Add("@Tutar", SqlDbType.Money).Value = kh._tutar;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = kh._aciklama;
            comm.Parameters.Add("@YetkiliID", SqlDbType.Int).Value = kh._yetkiliID;
            comm.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = kh._tarih;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc=Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return sonuc;
        }

        internal DataTable KasaHareketiGetirByTarihlerArasi(DateTime ilkTarih, DateTime sonTarih)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select KasaID,kh.MusteriID,(MusteriAdi + ' ' + MusteriSoyadi) as Musteri, IslemTuru,Tutar,YetkiliID,Tarih from KasaHareketler kh inner join Musteriler m on kh.MusteriID=m.MusteriID where kh.Silindi=0 and Convert(Date,Tarih,104) between Convert(Date,@Tarih1,104) and Convert(Date,@Tarih2,104)", conn);
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

        internal void KasaHareketiGetirByTarihler(ListView liste, DateTime dateTime)
        {
            liste.Items.Clear();
            string tarih = "";
            SqlCommand comm = new SqlCommand("select IslemTuru,convert(date, Tarih, 104), Tutar, kh.MusteriID, (MusteriAdi + ' ' + MusteriSoyadi) as Musteri, kh.Aciklama, KasaID from KasaHareketler kh inner join Musteriler m on kh.MusteriID=m.MusteriID where convert(date, Tarih, 104)=convert(date, @Tarih, 104) ", conn);
            comm.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = dateTime;
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
                        if (dr[0].ToString() == "False")
                        {
                            liste.Items.Add("Alış");
                        }
                        else if (dr[0].ToString() == "True")
                        {
                            liste.Items.Add("Satış");
                        }
                        tarih = (Convert.ToDateTime(dr[1])).ToLongDateString();
                        liste.Items[i].SubItems.Add(tarih.ToString());
                        tarih = (Convert.ToDateTime(dr[1])).ToLongTimeString();
                        liste.Items[i].SubItems.Add(tarih.ToString());
                        liste.Items[i].SubItems.Add(dr[2].ToString());
                        liste.Items[i].SubItems.Add(dr[4].ToString());
                        liste.Items[i].SubItems.Add(dr[5].ToString());
                        liste.Items[i].SubItems.Add(dr[6].ToString());
                        liste.Items[i].SubItems.Add(dr[3].ToString());
                        liste.Items[i].SubItems.Add(dr[0].ToString());
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

        internal void KasaHareketiGetirByTarihlerAndSatisTipi(ListView liste, DateTime dateTime, int IslemTuru)
        {
            liste.Items.Clear();
            string tarih = "";
            SqlCommand comm = new SqlCommand("select IslemTuru,convert(date, Tarih, 104), Tutar, kh.MusteriID, (MusteriAdi + ' ' + MusteriSoyadi) as Musteri, kh.Aciklama, KasaID from KasaHareketler kh inner join Musteriler m on kh.MusteriID=m.MusteriID where convert(date, Tarih, 104)=convert(date, @Tarih, 104) and IslemTuru=@IslemTuru ", conn);
            comm.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = dateTime;
            comm.Parameters.Add("@IslemTuru", SqlDbType.Bit).Value = IslemTuru;
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
                        if (dr[0].ToString() == "False")
                        {
                            liste.Items.Add("Alış");
                        }
                        else if (dr[0].ToString() == "True")
                        {
                            liste.Items.Add("Satış");
                        }
                        tarih = (Convert.ToDateTime(dr[1])).ToLongDateString();
                        liste.Items[i].SubItems.Add(tarih.ToString());
                        tarih = (Convert.ToDateTime(dr[1])).ToLongTimeString();
                        liste.Items[i].SubItems.Add(tarih.ToString());
                        liste.Items[i].SubItems.Add(dr[2].ToString());
                        liste.Items[i].SubItems.Add(dr[4].ToString());
                        liste.Items[i].SubItems.Add(dr[5].ToString());
                        liste.Items[i].SubItems.Add(dr[6].ToString());
                        liste.Items[i].SubItems.Add(dr[3].ToString());
                        liste.Items[i].SubItems.Add(dr[0].ToString());
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
    }
}
 