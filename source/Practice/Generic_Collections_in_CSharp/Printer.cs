using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections_in_CSharp
{
    /*
     * Here generic type U is available for the whole class members
     * But T is only available for the specific method
     */
    public class Printer<U>
    {
        public static void Print<T>(T item)where T: struct
        {
            Console.WriteLine(item.ToString());
        }

        public static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            U u = default(U);
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }
}
