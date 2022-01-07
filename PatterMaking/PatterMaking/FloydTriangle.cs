using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterMaking
{
    public class FloydTriangle
    {
        public void Run(int n)
        {
            int a = 1;

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j <= i; j++)
                {
                    Console.Write($"{a++} ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
