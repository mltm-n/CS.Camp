using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Watermelon";
            product1.Price = 20;
           

            Product product2 = new Product();
            product2.Name = "Pepper";
            product2.Price = 3;
            

            Product[] products = new Product[] { product1, product2 };

            foreach (var Product in products)
            {
                Console.WriteLine(Product.Name);
                Console.WriteLine(Product.Price);
            }

            Console.WriteLine("----------------------");

            //example of the instance class
            CartManager cartManager = new CartManager();
            cartManager.Addition(product2);
            cartManager.Addition(product1);

            cartManager.Addition2("Apple", 5);
        }
    }
}
