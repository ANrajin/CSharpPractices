using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecurrsiveFunction
{
    public class Factorial
    {
        //Formula: n*F(n-1)
        public void Run()
        {
            var n = int.Parse(Console.ReadLine());

            var result = Factor(n);

            Console.WriteLine(result);
        }

        public int Factor(int n)
        {
            if(n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factor(n - 1);
            }
        }
    }
}
