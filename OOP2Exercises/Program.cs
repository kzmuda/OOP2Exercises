using System;
using System.Collections.Generic;
using OOP2Exercises.Printer;

namespace OOP2Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            MagicArray<int> ma = new MagicArray<int>(3);
            ma.Add(1);
            ma.Add(2);
            ma.Add(3);
            ma.Add(4);

            ma.Print();


            MagicArray<string> ms = new MagicArray<string>(3);
            ms.Add("a");
            ms.Add("b");
            ms.Add("c");
            ms.Add("d");

            ms.Print();


            MagicArray<Bread> mb = new MagicArray<Bread>(3);
            mb.Add(new Bread(DateTime.Now, "chleb", 3.5M));


            // Bread bread1 = new Bread(DateTime.Now, "chleb", 3.5M);
            // Bread bread2 = new Bread(DateTime.Now, "chleb2", 3.5M);
            //
            // Basket basket = new Basket();
            //
            // basket.AddProductToBasket(bread1);
            // basket.AddProductToBasket(bread2);






            //var display = new DisplayToFile();
            //var game = new Game("super gra", display);
            //game.AddPlayer("player1");
            //game.AddPlayer("player2");
            //game.PrintGameInfo();



            // Complex complex = new Complex(5, 4);
            // List<Complex> list = new List<Complex>()
            // {
            //     new Complex(6,7),
            //     new Complex(1,5),
            //     new Complex(23,77),
            //     new Complex(1,3),
            //
            // };
            //
            // ComplexComparerByReal c = new ComplexComparerByReal();
            // list.Sort(c);
            //
            // foreach (var item in list)
            // {
            //     Console.WriteLine(item);
            // }

        }
    }
}
