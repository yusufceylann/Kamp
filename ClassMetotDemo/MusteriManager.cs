using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
       
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklenmiştir ..." + musteri.Ad + " " + musteri.Soyad + " : " + musteri.Yas );
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("*****Müşteri Sil Fonksiyonu Çalıştı*****");
            Console.WriteLine("Müşteri Silinmiştir ..." + musteri.Ad + " " + musteri.Soyad + " : " + musteri.Yas);
        }

        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine( musteri.Ad + " " + musteri.Soyad + " : " + musteri.Yas);
            }
            
        }
    }
}
