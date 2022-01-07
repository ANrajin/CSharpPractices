using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections_in_CSharp
{
    //Stack follow LIFO method
    class Generic_Stacks
    {
        public static void Index()
        {
            Stack<int> num = new Stack<int>();

            num.Push(3);
            num.Push(5);

            //pop() -> remove last inserted item and return it
            Console.WriteLine(num.Pop()); // 5

            //peek() -> returns the first inserted item
            Console.WriteLine(num.Peek());


        }
    }
}
