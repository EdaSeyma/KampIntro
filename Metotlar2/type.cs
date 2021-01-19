using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar2
{
    class type
    {
        public void tip()
        {
             int sayi1 = 10;
             int sayi2 = 20;
             sayi1=sayi2;
             sayi2 = 65;
            //sayi1=??
            Console.WriteLine("Sayı1= " + sayi1+"  " + "Sayi2=" + sayi2);

            int[] sayi3 = new int[] { 20, 30, 40 };

            int[] sayi4 = new int[] { 200, 300, 400 };
            sayi3 = sayi4;
            sayi4[0] = 500;
            //sayi3[0] ??
            Console.WriteLine("Sayı3= " + sayi3 + "  " + "Sayi4=" + sayi4);



        }


    }
}
