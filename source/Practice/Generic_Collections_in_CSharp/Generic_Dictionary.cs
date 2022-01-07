using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections_in_CSharp
{
    class Generic_Dictionary
    {
        public static void Index()
        {
            //The Dictionary<TKey, TValue> is a generic collection that stores key-value pairs in no particular order.

            Dictionary<string, int> employee = new Dictionary<string, int>();

            employee["Rajin"] = 25;
            employee["john"] = 36;
            employee["Doe"] = 40;

            Console.WriteLine(employee.Count);


            IDictionary<string, Tuple<int, double, bool>> course = new Dictionary<string, Tuple<int, double, bool>>();
        }
    }
}
