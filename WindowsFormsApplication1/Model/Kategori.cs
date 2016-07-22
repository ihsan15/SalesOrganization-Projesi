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
    class Kategori
    {
        private int _kategoriID;
        private int _ustKategori;
        private string _kategoriAdi;
        private string _aciklamasi;

        #region Properties

        public int KategoriID
        {
            get { return _kategoriID; }
            set { _kategoriID = value; }
        }


        public int UstKategori
        {
            get { return _ustKategori; }
            set { _ustKategori = value; }
        }


        public string KategoriAdi
        {
            get { return _kategoriAdi; }
            set { _kategoriAdi = value; }
        }


        public string Aciklamasi
        {
            get { return _aciklamasi; }
            set { _aciklamasi = value; }
        }


        #endregion

        SqlConnection conn = new SqlConnection(Genel.connstr);

        public void KategorileriGetir(ComboBox liste, string UstKategoriID)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select KategoriID, KategoriAdi from Kategoriler where VarMi=1 and UstKategori=@UstKategoriID", conn);
            comm.Parameters.Add("@UstKategoriID", SqlDbType.Int).Value = UstKategoriID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    Kategori k = new Kategori();
                    k._kategoriID = Convert.ToInt32(dr["KategoriID"].ToString());
                    k._kategoriAdi = dr["KategoriAdi"].ToString();
                    liste.Items.Add(k);
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
            return KategoriAdi;
        }
        

    }
}
