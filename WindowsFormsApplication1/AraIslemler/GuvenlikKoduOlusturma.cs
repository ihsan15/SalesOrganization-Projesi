using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.AraIslemler
{
    class GuvenlikKoduOlusturma
    {
        Random rnd = new Random();

        private string[] Karakterler = { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "W", "X", "Q", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        private int deger1, deger2, deger3, deger4, deger5;
        
        public void GuvenlikKoduOluştur(Label guvenlikkodu)
        {
            deger1 = rnd.Next(0, Karakterler.Length);
            deger2 = rnd.Next(0, Karakterler.Length);
            deger3 = rnd.Next(0, Karakterler.Length);
            deger4 = rnd.Next(0, Karakterler.Length);
            deger5 = rnd.Next(0, Karakterler.Length);

            guvenlikkodu.Text = Karakterler[deger1] + Karakterler[deger2] + Karakterler[deger3] + Karakterler[deger4] + Karakterler[deger5];

        }

    }
}
