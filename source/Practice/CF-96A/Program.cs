using System;

namespace CF_96A
{
    class Program
    {
        static void Main(string[] args)
        {
            //CF-96A : Football

            string players = Console.ReadLine();

            int TeamA = 0;
            int TeamB = 0;

            for (var i = 0; i < players.Length; i++)
            {
                if (players[i] == '0')
                {
                    TeamA += 1;
                    TeamB = 0;
                }
                else
                {
                    TeamB += 1;
                    TeamA = 0;
                }

                if (TeamA >= 7 || TeamB >= 7)
                {
                    break;
                }
            }

            if (TeamA >= 7 || TeamB >= 7)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}