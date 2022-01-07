using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesInCSharp_18
{
    class ActionDelegate
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        public void StringBuild(string m, string n)
        {
            Console.WriteLine(m + n);
        }

        public void Run()
        {
            Action<int, int> add = Sum;
            add(5, 23);

            Action<int, int> mult = Multiply;

            mult(6, 7);

            ApplyFormula(StringBuild,"Hello ", "From Action Delegate");


            Action<int> printActionDel = delegate (int i)
            {
                Console.WriteLine(i);
            };

            printActionDel(10);


            Action<int> printActionDel2 = i => Console.WriteLine(i);

            printActionDel2(10);
        }

        public void ApplyFormula(Action<string, string> s, string m, string n)
        {
            s(m, n);
        }
    }
}
