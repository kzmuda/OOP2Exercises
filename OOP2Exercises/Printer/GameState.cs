using System;
using System.Collections.Generic;
using System.Text;
using OOP2Exercises.Printer;

namespace OOP2Exercises
{
    class GameState
    {
        private IDisplay display;

        public GameState(IDisplay display)
        {
            //this.display = new Display();
            this.display = display;
        }

        public void PrintPlayersCount(int count)
        {
            display.Print($"players count = {count}");
        }
        public void PrintSumPfPoints(int sum)
        {
            display.Print($"sum of points = {sum}");
        }

    }
}
