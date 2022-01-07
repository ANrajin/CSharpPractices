using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesInCSharp_18
{
    //Anonymous methods in C# can be defined using the delegate keyword and can be assigned to a variable of delegate type.
    public class AnnonymousMethod
    {
        public delegate void Print(int value);
        public void Run()
        {
            Print print = delegate (int val) {
                Console.WriteLine("Inside Anonymous method. Value: {0}", val);
            };

            print(100);
        }
    }
}
