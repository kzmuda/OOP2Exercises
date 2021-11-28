using System;
using System.Collections.Generic;

namespace OOP2Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex = new Complex(5, 4);
            List<Complex> list = new List<Complex>()
            {
                new Complex(6,7),
                new Complex(1,5),
                new Complex(23,77),
                new Complex(1,3),

            };

            ComplexComparerByReal c = new ComplexComparerByReal();
            list.Sort(c);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}
