using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2Exercises
{
    abstract class Product
    {
        public string name { get; set; }
        public decimal weigh { get; set; }
        public decimal price { get; set; }

        public Product(string name, decimal weigh, decimal price)
        {
            this.name = name;
            this.weigh = weigh;
            this.price = price;
        }
    }
}
