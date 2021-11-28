using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace OOP2Exercises
{
    class Complex : IComparable<Complex>
    {
        public int Real { get; set; }
        public int Imaginery { get; set; }

        public Complex(int real, int imaginery)
        {
            Real = real;
            Imaginery = imaginery;
        }

        public override string ToString()
        {
            //return this.Real + " + " + this.Imaginery + "i";
            return $"{this.Real} + {this.Imaginery}i";
        }

        public int CompareTo(Complex other)
        {
            // 3 + 2i    1 + 5i
            if (this.Real < other.Real)
            {
                return -1;
            }
            else if (this.Real == other.Real)
            {
                if (this.Imaginery < other.Imaginery)
                {
                    return -1;
                }
                if (this.Imaginery > other.Imaginery)
                {
                    return 1;
                }
                return 0;
                    
            }
            else
            {
                return 1;
            }
        }
    }
}
