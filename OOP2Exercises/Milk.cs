using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2Exercises
{
    class Milk : Product
    {
        public int capacity { get; set; }

        public Milk(int capacity, string name, decimal price) : base(name, 1.03M * capacity, price)
        {
            this.capacity = capacity;
        }
    }
}
