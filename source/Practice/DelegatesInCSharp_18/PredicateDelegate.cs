using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesInCSharp_18
{
    public class PredicateDelegate
    {
        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }

        public void Run()
        {
            Predicate<string> x = IsUpperCase;

            Console.WriteLine(x("Hello World"));

            //Annonymous
            Predicate<string> isUpper = delegate (string s) { return s.Equals(s.ToUpper()); };
            bool result = isUpper("hello world!!");

            //Lambda
            Predicate<string> isUpper2 = s => s.Equals(s.ToUpper());
            bool result2 = isUpper2("hello world!!");
        }
    }
}
