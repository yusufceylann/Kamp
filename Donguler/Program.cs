using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılm Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";

            //array - dizi

            string[] kurslar = new string[] { "Yazılm Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs",
                "Java", "Python", "C#"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For Bitti");
            //foreach dizi temelli yapıları tek tek dönmeye yarayan yapıdır. Her dönüşte her eleman kurs ismini alır, aşağıdaki örneğe göre.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("Sayfa Sonu - footer ");
        }
    }
}
