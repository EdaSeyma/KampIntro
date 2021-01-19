using System;

namespace DegerveReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1=? --> 30

            int[] sayi3 = new int[] { 99, 100, 110 };
            int[] sayi4 = new int[] { 199, 1100, 1110 };
            sayi3 = sayi4;
            sayi4[0] = 999;
            //sayi3[0]=?--> 999


        }
    }
}

