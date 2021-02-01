using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            Musteri musteri2 = new Musteri();
            Musteri musteri3 = new Musteri();

            musteri1.Ad = "Yusuf";
            musteri1.Soyad = "CEYLAN";
            musteri1.Yas = 22;

            musteri2.Ad = "Ali";
            musteri2.Soyad = "Murat";
            musteri2.Yas = 24;

            musteri3.Ad = "Ayşe";
            musteri3.Soyad = "Fatma";
            musteri3.Yas = 21;

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3 };

            musteriManager.MusteriListele(musteriler);

            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriSil(musteri3);

        }
    }
}
