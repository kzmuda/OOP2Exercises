using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2Exercises
{
    class Basket : Weigh
    {
        List<Product> listOfProducts = new List<Product>();

        public void AddProductToBasket(Product product)
        {
            this.listOfProducts.Add(product);
        }

        public decimal GetWeigh()
        {
            throw new NotImplementedException();
        }
    }
}
