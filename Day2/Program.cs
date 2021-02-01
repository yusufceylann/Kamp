using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Telefon";
            urun1.Kategori = "Elektronik";
            urun1.Fiyati = 3200;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Bilgisayar";
            urun2.Kategori = "Elektronik";
            urun2.Fiyati = 7500;

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Süt";
            urun3.Kategori = "Gıda";
            urun3.Fiyati = 5;

            Urun urun4 = new Urun();
            urun4.UrunAdi = "Masa";
            urun4.Kategori = "Mobilya";
            urun4.Fiyati = 568;

            Urun[] Urunler = new Urun[] {urun1, urun2, urun3, urun4 };
            Console.WriteLine("*****With for*****");
            for (int i = 0; i <Urunler.Length; i++)
            {
                Console.WriteLine(Urunler[i].UrunAdi + " : " + Urunler[i].Fiyati + " TL " + " : " + Urunler[i].Kategori);
            }
            Console.WriteLine("*****With foreach*****");
            foreach (Urun urun in Urunler)
            {
                Console.WriteLine(urun.UrunAdi + " : " + urun.Fiyati + " TL " + " : " + urun.Kategori);
            }
            Console.WriteLine("*****With while*****");
            int j = 0;
            while (j < 3)
            {
                Console.WriteLine(Urunler[j].UrunAdi + " : " + Urunler[j].Fiyati + " TL " + " : " + Urunler[j].Kategori);
                j++;
            }
        }
    }

    class Urun
    {
        public string UrunAdi { get; set; }
        public string Kategori { get; set; }
        public int Fiyati { get; set; }
    }
}
