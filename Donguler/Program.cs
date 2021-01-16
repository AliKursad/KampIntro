using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";


            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", 
                "Programlamaya Başlangıç için temel kurs", 
                "Java", "Python", "C++" };

            
            
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("\n\n");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }



            Console.WriteLine("\nSayfa Sonu - footer");
        }
    }
}
