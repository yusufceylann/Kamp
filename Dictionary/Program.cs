using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> Ogrenci = new MyDictionary<int, string>();
            Ogrenci.Add(138, "Tolga Demirer");
            Ogrenci.Add(158, "Ümit Özkan");
            Ogrenci.Add(115, "Kadir Aydemir");
            Ogrenci.Add(174, "Cemal Çiftçi");

            Console.WriteLine("Öğrenci No Giriniz: ");
            int No = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(Ogrenci[No]);
            }
            catch
            {
                Console.WriteLine("Öğrenci Bulunamadı");
            }

        }
    }
}
