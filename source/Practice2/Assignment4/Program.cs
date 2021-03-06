using System;
using Assignment4.Players;
using System.Collections.Generic;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Many Players?");

            int n = int.Parse(Console.ReadLine());

            if (n < 2 || n > 4)
            {
                Console.WriteLine("There should be atleast 2-4 players");
                Environment.Exit(1);
            }

            Game game = new Game();

            for(var i = 0; i< 2; i++)
            {
                Console.WriteLine($"Enter player-0{i + 1} name & piece color");
                game.Players[i].Name = Console.ReadLine();
            }

            game.Start(n);
        }
    }
}
