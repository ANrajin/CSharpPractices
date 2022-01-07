using System;

namespace CF___282A
{
    class Program
    {
        static void Main(string[] args)
        {
            //CF - 282A : Bit++
            int n = Convert.ToInt32(Console.ReadLine());

            var x = 0;

            for (var i = 0; i < n; i++)
            {
                string statement = Console.ReadLine().ToLower();

                if (statement == "x++" || statement == "++x")
                {
                    x += 1;
                }
                else if (statement == "--x" || statement == "x--")
                {
                    x -= 1;
                }
            }

            Console.WriteLine(x);
        }
    }
}
