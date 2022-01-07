using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterMaking
{
    public class Triangle
    {
        public void Run(int n)
        {
            for (var i = 1; i < n; i++)
            {
                for (var j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("\n");
            }

            for (var i = 1; i < n; i++)
            {
                for (var j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine("\n");
            }


            for (var i = 0; i < n; i++)
            {
                int c = Convert.ToInt32('A');

                for (var j = 0; j <= i; j++)
                {
                    Console.Write($"{Convert.ToChar(c)} ");
                    c++;
                }
                Console.WriteLine("\n");
            }

            for (var i = 0; i < n; i++)
            {
                for (var j = i; j < n - 1; j++)
                {
                    Console.Write(" ");
                }

                for (var k = 0; k <= i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("\n");
            }

            //using one nested loop
            for (var i = 0; i < n; i++)
            {
                var star = "*";
                Console.Write(star.PadLeft(n - i));

                for (var j = 0; j < i; j++)
                {
                    Console.Write(star);
                }

                Console.WriteLine("\n");
            }

            //reverse triangle
            for (var i = 0; i < n; i++)
            {
                for (var j = n; j > i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
