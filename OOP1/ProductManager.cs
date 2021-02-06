using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Addition(Product product)
        {
            Console.WriteLine(product.ProductName + " added.");
        }

        public void Updating(Product product)
        {
            Console.WriteLine(product.ProductName + " updated.");

        }
    }
}
