using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety-tip güvenliği
            // do not repeat yourself
            //Değer tutucu,alias
            string CategoryLabel = "Kategori";
            int NumberofStudent = 32000;
            double faizOrani = 1.45;
            bool isTrue = true;

            if (isTrue==true)
            {
                Console.WriteLine("Ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(CategoryLabel);
        }
    }
}
