using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = "123";
            musteri1.Ad = "Mustafa";
            musteri1.Soyad = "ÖZTÜRK";

            Musteri musteri2 = new Musteri();
            musteri2.Id = "234";
            musteri2.Ad = "Merve";
            musteri2.Soyad = "Ceylan";

            Musteri musteri3 = new Musteri();
            musteri3.Id = "345";
            musteri3.Ad = "Sümbül";
            musteri3.Soyad = "ÖZTÜRK";

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Listele(musteriler);
                


        }
    }
}
