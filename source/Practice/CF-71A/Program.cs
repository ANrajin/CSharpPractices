using System;

namespace CF_71A
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Problem: 71A - Way Too Long Words
            */

            int n = int.Parse(Console.ReadLine());

            for (var i = 0; i < n; i++)
            {
                string words = Console.ReadLine();
                if (words.Length > 10)
                {
                    var fw = words.Substring(0, 1);
                    var lw = words.Substring((words.Length - 1), 1);
                    var lenghtAfter = words.Length - 2;
                    Console.WriteLine($"{fw}{lenghtAfter}{lw}");
                }
                else
                {
                    Console.WriteLine(words);
                }
            }
        }
    }
}
