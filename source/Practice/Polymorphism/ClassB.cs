using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class ClassB:ClassA
    {
        //public new void Test()
        //{
        //    Console.WriteLine("B::Test()");
        //}

        public new virtual void Test()
        {
            Console.WriteLine("B::Test()");
        }

        protected override void Foo()
        {

        }
    }
}
