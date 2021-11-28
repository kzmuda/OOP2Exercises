using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2Exercises.Printer
{
    class DisplayToFile : IDisplay
    {
        public void Print(string text)
        {
            Console.Out.WriteLine("do pliku: " + text);
        }
    }
}
