using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım";
            string kurs2 = "resim";
            string kurs3 = "ticaret";

            //array-dizi
            //string[] kurslar=KurslarıGetir();
            string[] kurslar = new string[] { "yazılım","resim","ticaret"};

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            
        }
    }
}