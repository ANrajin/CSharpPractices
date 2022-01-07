using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Z:Y
    {
        public Z() : base()
        {
            Console.WriteLine("z");
        }

        public void Print()
        {
            Console.WriteLine("Hello");
        }
    }
}
