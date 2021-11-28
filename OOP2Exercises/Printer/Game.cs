using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2Exercises.Printer
{
    class Game
    {
        private IDisplay display;
        private string name;

        public List<Player> Players { get; set; } = new List<Player>();

        public GameState GameState { get; set; }

        public Game(string name, IDisplay display)
        {
            this.name = name;
            this.display = display;
            //this.display = new Display();
            this.GameState = new GameState(this.display);
        }

        public void PrintGameInfo()
        {
            this.display.Print(this.name);
            foreach (var player in Players)
            {
                player.PrintName();
            }
            GameState.PrintPlayersCount(Players.Count);
            GameState.PrintSumPfPoints(15);
        }

        public void AddPlayer(string playerName)
        {
            var player = new Player(playerName, this.display);
            this.Players.Add(player);
        }


    }
}
