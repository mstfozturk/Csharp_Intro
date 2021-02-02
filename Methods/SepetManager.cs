using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        // naming convention
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi ! : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, int fiyat, int stokAdedi) 
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }

    }
}
