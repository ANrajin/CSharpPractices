using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterMaking
{
    public class Box
    {
        public void Run(int n)
        {
            int charc = Convert.ToInt32('A');

            for (var i = 0; i <= n; i++)
            {
                for (var j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0 || i == n || j == n)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write($"{Convert.ToChar(charc)} ");
                        charc++;
                    }

                    if (charc > 'Z')
                        charc = Convert.ToInt32('A');
                }

                Console.WriteLine("\n");
            }
        }
    }
}
