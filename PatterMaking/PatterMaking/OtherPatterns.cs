using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterMaking
{
    public class OtherPatterns
    {
        public void Run(int n)
        {
            for(var i = n; i >= 1; i--)
            {
                for(var j = n-i; j >= 1; j--)
                {
                    Console.Write("* ");
                }

                for(var k = 1; k <= (i*2)-1; k++)
                {
                    Console.Write("  ");
                }

                for (var j = n - i; j >= 1; j--)
                {
                    Console.Write("* ");
                }

                Console.WriteLine("\n");
            }

            for (var i = 2 * n - 1; i >= 1; i--)
            {
                var star = i;

                if (i <= n)
                    star = (2 * n) - i;

                for (var j = star; j >= 1; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
