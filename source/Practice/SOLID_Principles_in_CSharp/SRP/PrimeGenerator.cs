using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_in_CSharp.SRP
{
    public class PrimeGenerator
    {
        public static List<int> Generate(int n)
        {
            var primes = new List<int>();

            for( var i = 2;  i <= n; i++)
            {
                bool flag = false;

                for(var j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        flag = true;
                        break;
                    }
                }

                if (flag == false)
                    primes.Add(i);
            }

            return primes;
        }
    }
}
