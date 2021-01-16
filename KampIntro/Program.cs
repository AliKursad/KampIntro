using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string KategoriEtiketi = "Kategori";
            int OgrenciSayisi = 32000;
            double FaizOrani = 1.45;
            bool SistemeGirisYapmisMi = true;
            double DolarDun = 7.35;
            double DolarBugun = 7.45;

            if (DolarDun>DolarBugun)
            {
                Console.WriteLine("Azalan Ok");
            }
            else if (DolarDun<DolarBugun)
            {
                Console.WriteLine("Artan ok");
            }
            else
            {
                Console.WriteLine("eşittir");
            }
           

            if (SistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }



            Console.WriteLine(KategoriEtiketi);
        }
    }
}
