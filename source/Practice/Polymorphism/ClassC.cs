using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class ClassC:ClassB
    {
        //public new void Test()
        //{
        //    Console.WriteLine("C::Test()");
        //}

        public override void Test()
        {
            Console.WriteLine("C::Test(). Overrided method from ClassB to ClassC");
        }
    }
}
