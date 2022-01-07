using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesInCSharp_18
{
    //Generic Delegate
    public delegate T Add<T>(T param1, T param2);
    public class GenericDelegate
    {
        public void Run()
        {
            //The data type must be specified while setting the
            //Target Method
            Add<int> n = Sum;
            n(5, 8);

            Add<string> s = Concat;
            s("Hello", "World");
        }

        public int Sum(int val1, int val2)
        {
            return val1 + val2;
        }

        public string Concat(string str1, string str2)
        {
            return str1 + str2;
        }
    }
}
