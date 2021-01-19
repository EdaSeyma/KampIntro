using System;

namespace Metotlar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Coffee";
            product1.Price = 15;

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Tea";
            product2.Price = 8;

            Product product3 = new Product();
            product3.Id = 3;
            product3.Name = "Milk";
            product3.Price = 5;

            Product product4 = new Product();
            product4.Id = 3;
            product4.Name = "Orange Juice";
            product4.Price = 13;

            Product[] products = new Product[] { product1, product2, product3 };
            Console.WriteLine("Foreach ile");
            foreach (Product product in products)
            {
                Console.WriteLine("Ürün Id: " + product.Id);
                Console.WriteLine("Ürün Name: " + product.Name);
                Console.WriteLine("Ürün Price: " + product.Price);
            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("For ile");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Id + products[i].Name + products[i].Price);
            }
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("While ile");

            int j = 0;
            while (j < products.Length)
            {
                Console.WriteLine(products[j].Id + products[j].Name + products[j].Price);
                j++;
            }

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product4);


            
        }
    }
}
