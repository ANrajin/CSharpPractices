using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesInCSharp_18
{
    class FuncDelegate
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public string StringBulid(string m, string n)
        {
            return m + n;
        }

        public void Run()
        {
            Func<int, int, int> add = Sum;

            Func<int, int, int> mult = Multiply;

            int x = 10;

            int y = 30;

            Console.WriteLine(add(x, y));
            Console.WriteLine(mult(x, y));

            Func<int> getRandomNumber = delegate ()
            {
                Random rand = new Random();
                return rand.Next(1, 100);
            };

            Console.WriteLine(getRandomNumber);

            //With lambda expression
            Func<int, int, int> sum = (x, y) => x + y;

            ApplyFormula(StringBulid, "Hello ", "From Func Delegate");
        }

        public void ApplyFormula(Func<string, string, string> s, string m, string n)
        {
            var z = s(m, n);

            Console.WriteLine(z);
        }
    }
}
