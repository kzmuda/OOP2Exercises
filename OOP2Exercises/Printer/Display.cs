using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2Exercises.Printer
{
    class Display : IDisplay
    {
        public void Print(string text)
        {
            Console.Out.WriteLine(text);
        }
    }
}
