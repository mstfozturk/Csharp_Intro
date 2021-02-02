using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety = tip güvenliği
            // do not repeat yourself - kendini tekrarlama !
            // değer tutucu, alias, takma isim

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış butonu göster");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artış butonu göster");
            }
            else
            {
                Console.WriteLine("değişim yok butonu");
            }

            if (sistemeGirisYapmisMi == true) 
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);


        }
    }
}
