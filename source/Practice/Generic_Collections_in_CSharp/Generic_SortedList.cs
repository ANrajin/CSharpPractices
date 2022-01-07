using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections_in_CSharp
{
    class Generic_SortedList
    {
        //Sort the stored item in Asc order based on key
        public static void Index()
        {
            SortedList<string, int> age = new SortedList<string, int>();

            age["Rajin"] = 25;
            age["abul"] = 63;
            age["kalam"] = 15;

            foreach(var i in age)
                Console.WriteLine($"Key: {i.Key} = {i.Value}");
        }
    }
}
