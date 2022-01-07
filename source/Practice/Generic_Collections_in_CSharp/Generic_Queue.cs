using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections_in_CSharp
{
    //Queue follows FIFO method
    class Generic_Queue
    {
        public static void Index()
        {
            Queue<int> num = new Queue<int>();

            //enqueue method add item in Queue
            num.Enqueue(10);
            num.Enqueue(20);
            num.Enqueue(60);

            //Dequeue method remove the first inserted item first and return it
            Console.WriteLine(num.Dequeue());
        }
    }
}
