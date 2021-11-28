using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace OOP2Exercises
{
    class ComplexComparerByReal : IComparer<Complex>
    {
        public int Compare(Complex x, Complex y)
        {
            //if (x.Real < y.Real)
            //{
            //    return -1;
            //}
            //else if (x.Real > y.Real)
            //{
            //    return 1;
            //}
            //return 0;
            return x.Real.CompareTo(y.Real);
        }
    }
}
