using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterMaking
{
    public class EvenOddRow
    {
        public void Run(int n)
        {
            int a = 1;

            for (var i = 1; i <= n; i++)
            {
                int b = a + i - 1;

                for (var j = 1; j <= i; j++)
                {
                    if (i % 2 == 1)
                        Console.Write($"{a} ");
                    else
                        Console.Write($"{b--} ");

                    a++;
                }
                Console.WriteLine("\n");
            }

            // if row number + column number is odd then there is a star (*) symbol at that place else there is a dollar ($) symbol.
            for (var i = 1; i <= n; i++)
            {
                for (var j = 1; j <= i; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("$ ");
                    }
                }
                Console.WriteLine("\n");
            }

            //In this pattern, when the row number is odd then the same alphabet is printed in the row otherwise the same digit is printed in that row.
            int ch = Convert.ToInt32('A');
            int num = 1;

            for(var i = 1; i <=n; i++)
            {
                for(var j = 1; j <= i; j++)
                {
                    if (i % 2 == 1)
                        Console.Write($"{Convert.ToChar(ch)} ");
                    else
                        Console.Write($"{num} ");
                }

                if (i % 2 == 1)
                    ch++;
                else
                    num++;

                Console.WriteLine("\n");
            }
        }
    }
}
