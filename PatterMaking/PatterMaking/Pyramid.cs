using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterMaking
{
    public class Pyramid
    {
        public void Run(int n)
        {
            //stars
            for (var i = 1; i <= n; i++)
            {
                //spaces
                for (var j = 1; j <= n - i; j++)
                {
                    Console.Write("  ");
                }

                for (var k = 1; k <= (2 * i) - 1; k++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine("\n");
            }

            //reverse pyramid
            for (var i = n; i >= 1; i--)
            {
                for (var k = n - i; k >= 1; k--)
                {
                    Console.Write("  ");
                }

                for (var j = 1; j <= (i * 2) - 1; j++)
                {
                    Console.Write($"* ");
                }

                Console.WriteLine("\n");
            }

            //numbers
            // when column number (except space) is less than row number then digits
            // are continuously increasing, and after that digits are decreasing.
            for (var i = 1; i <= n; i++)
            {
                //spaces
                for (var j = 1; j <= n - i; j++)
                {
                    Console.Write("  ");
                }

                int num = 1;

                for (var k = 1; k <= (i * 2) - 1; k++)
                {
                    if (k > i)
                    {
                        num -= 2;
                        Console.Write($"{num++} ");
                    }
                    else
                        Console.Write($"{num++} ");
                }

                Console.WriteLine("\n");
            }

            for (var i = n; i >= 1; i--)
            {
                for(var k = n - i; k >= 1; k--)
                {
                    Console.Write("  ");
                }

                int num = 1;

                for(var j = 1; j <= (i*2) - 1; j++)
                {
                    if (j > i)
                    {
                        num -= 2;
                        Console.Write($"{num++} ");
                    }
                    else
                        Console.Write($"{num++} ");
                    
                }
                Console.WriteLine("\n");
            }
        }
    }
}
