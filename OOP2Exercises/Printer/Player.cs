using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2Exercises.Printer
{
    class Player
    {
        private string Name;
        private IDisplay display;

        public Player(string name, IDisplay display)
        {
            Name = name;
            //display = new DisplayToFile();
            this.display = display;
        }

        public void PrintName()
        {
            display.Print(this.Name);
        }
    }
}
