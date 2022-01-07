using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class ClassA
    {
        public void Test()
        {
            Console.WriteLine("A::Test()");
        }

        protected virtual void Foo()
        {
            Console.WriteLine("A::foo()");
        }
    }
}
