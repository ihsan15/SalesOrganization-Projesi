using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication1.Model
{
    class Siparisler
    {
        private int _siparisID;
        private int _musteriID;
        private bool _siparisDurum;
        private int _onayVerenID;
        private DateTime _onayTarihi;

        #region Properties
        public int SiparisID
        {
            get { return _siparisID; }
            set { _siparisID = value; }
        }

        public int MusteriID
        {
            get { return _musteriID; }
            set { _musteriID = value; }
        }

        public bool SiparisDurum
        {
            get { return _siparisDurum; }
            set { _siparisDurum = value; }
        }

        public int OnayVerenID
        {
            get { return _onayVerenID; }
            set { _onayVerenID = value; }
        }

        public DateTime OnayTarihi
        {
            get { return _onayTarihi; }
            set { _onayTarihi = value; }
        } 
        #endregion


        SqlConnection conn = new SqlConnection(Genel.connstr);
        DataSet ds = new DataSet();

        public DataSet SiparisleriGetir(DateTime ilktarih, DateTime sontarih)
        {
            SqlDataAdapter da = new SqlDataAdapter("select convert(Datetime,SiparisZamani,104), SiparisID, s.MusteriID, SiparisDurum, OnayVerenID from Siparisler s inner join Musteriler m on s.MusteriID=m.MusteriID where s.MusteriID=@MusteriID and convert(Datetime,SiparisZamani,104) between convert(Datetime,@ilktarih,104) and convert(Datetime,@sontarih,104) and SiparisDurum=1", conn);
            da.SelectCommand.Parameters.Add("@MusteriID", SqlDbType.Int).Value = Genel.MusteriID;
            da.SelectCommand.Parameters.Add("@ilktarih", SqlDbType.DateTime).Value = ilktarih;
            da.SelectCommand.Parameters.Add("@sontarih", SqlDbType.DateTime).Value = sontarih;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                da.Fill(ds, "Siparisler");
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return ds;
        }

        public int SiparisNoOlustur(Siparisler s)
        {
            int siparisID = 0;
            SqlCommand comm = new SqlCommand("insert into Siparisler(MusteriID, SiparisDurum, OnayVerenID, SiparisZamani) Values (@MusteriID, @SiparisDurum, @OnayVerenID, @SiparisZamani); Select Scope_Identity()", conn);
            comm.Parameters.Add("@MusteriID", SqlDbType.Int).Value = s._musteriID;
            comm.Parameters.Add("@SiparisDurum", SqlDbType.Bit).Value = s._siparisDurum;
            comm.Parameters.Add("@OnayVerenID", SqlDbType.Int).Value = s._onayVerenID;
            comm.Parameters.Add("@SiparisZamani", SqlDbType.DateTime).Value = s._onayTarihi;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                siparisID = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return siparisID;
        }

        internal DataSet SiparisleriGetirByHesapHareket(int MusteriID, string Tarih)
        {
            SqlDataAdapter da = new SqlDataAdapter("select convert(Datetime,SiparisZamani,104), SiparisID, s.MusteriID, SiparisDurum, OnayVerenID, (MusteriAdi + ' ' + MusteriSoyadi) as OnayVeren from Siparisler s inner join Musteriler m on s.MusteriID=m.MusteriID where s.MusteriID=@MusteriID and convert(Datetime,SiparisZamani,104) = convert(Datetime,@ilktarih,104)", conn);
            da.SelectCommand.Parameters.Add("@MusteriID", SqlDbType.Int).Value = MusteriID;
            da.SelectCommand.Parameters.Add("@ilktarih", SqlDbType.DateTime).Value = Convert.ToDateTime(Tarih);
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                da.Fill(ds, "Siparisler");
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return ds;
        }
    }
}
