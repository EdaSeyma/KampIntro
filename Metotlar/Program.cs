using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Description = "Amasya Elması";

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Üzüm";
            product2.Price = 9;
            product2.Description = "İzmir Üzümü";

            Product product3 = new Product();
            product3.Id = 3;
            product3.Name = "Kayısı";
            product3.Price = 12;
            product3.Description = "Malatya Kayısısı";

            Product[] products = new Product[] { product1, product2, product3 };
            foreach(Product product in products)
            {
                Console.WriteLine(product.Id);
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
            }
            Console.WriteLine("--------------------------");
            //instance-örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
            sepetManager.Ekle(product3);

            sepetManager.Ekle2("Fındık", "Ordu", 50);
            sepetManager.Ekle2("Çay", "Rize", 30);
            sepetManager.Ekle2("Şeftali", "Bursa", 12);

        }
    }
}
