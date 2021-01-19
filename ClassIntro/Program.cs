using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Eğitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = "235";

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Eğitmen = "Derin Demiroğ";
            kurs2.IzlenmeOrani = "785";

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "RPA";
            kurs3.Eğitmen = "Eda Şeyma Güler";
            kurs3.IzlenmeOrani = "2154854";

            //Console.WriteLine(kurs3.Eğitmen + " " + kurs3.KursAdi + " " + kurs3.IzlenmeOrani);
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+ ": " + kurs.Eğitmen);
            }
            Console.WriteLine("Hello World!");
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Eğitmen { get; set; }
        public string IzlenmeOrani { get; set; }
    }
}
