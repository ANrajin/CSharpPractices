using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterMaking
{
    public class ReverseTriangle
    {
        public void Run(int n)
        {
            for (var i = 0; i < n; i++)
            {
                for (var j = n; j > i; j--)
                {
                    Console.Write("* ");
                }

                Console.WriteLine("\n");
            }

            for (var i = 0; i < n; i++)
            {
                for (var j = n; j > i; j--)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine("\n");
            }

            for (var i = 0; i < n; i++)
            {
                for (var j = n; j > i; j--)
                {
                    Console.Write($"{n - (j - 1)} ");
                }
                Console.WriteLine("\n");
            }

            for (var i = 0; i < n; i++)
            {
                for (var j = n; j > i; j--)
                {
                    Console.Write($"{n - (j - i) + 1} ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
