using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class CartManager
    {
        //syntax
        public void Addition(Product product)
        {
            Console.WriteLine(product.Name + " Added to the cart. ");
        }
        public void Addition2(string NameOfProduct, double Price)
        {
            Console.WriteLine(NameOfProduct + " Added to the cart. " + Price + "TL");
        }
    }
}
