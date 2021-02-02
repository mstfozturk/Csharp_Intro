using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri) 
        {
            Console.WriteLine(musteri.Id +" numaralı " + musteri.Ad+ " "+musteri.Soyad + " hesabı eklendi");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " numaralı " + musteri.Ad + " " + musteri.Soyad + " hesabı silindi");
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("\n"+ musteri.Id + " numaralı " + musteri.Ad + " " + musteri.Soyad + " hesabı");
            }
            
        }
    }
}
