using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Model
{
    class Genel
    {
        public static string connstr = "Data Source=185-50-68-117\\MSSQLSERVER2012;Initial Catalog=SalesOrganization;Integrated Security=True";

        public static bool FirmaGirisAcilsinMi = false;

        public static int UrunID;

        public static bool girisYapilmismi = false;

        public static int GirisxKonumu;
        public static int GirisyKonumu;

        public static int KampanyaxKonumu;
        public static int KampanyayKonumu;
        public static bool KampanyaAcikKalsinMi = false;

        public static int MusteriID = 0;
        public static int KullaniciID = 0;

        public static int SiparisID = 0;

        public static int SepettekiUrunMiktari = 0;

        public static int MarkaID = 0;

        public static int SecilenKullaniciID = 0;

        public static int SecilenMusteriID = 0;

        public static int sayfano = 0;

        public static int KasadanCekilenMusteriID = 0;

        public static string KasadanCekilenTarih ;
    }
}
