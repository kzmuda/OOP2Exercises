using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2Exercises
{
    class Bread : Product
    {
        public DateTime ExpiredDate { get; set; }

        public Bread(DateTime expiredDate, string name, decimal price) : base(name, 1, price)
        {
            ExpiredDate = expiredDate;

        }
    }
}
