using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete eklendi : "+product.Name);
        }
        public void Ekle2(string Name,string Description,double Price) {
            Console.WriteLine("Sepete eklendi : " + Name);
        }
    }
}
