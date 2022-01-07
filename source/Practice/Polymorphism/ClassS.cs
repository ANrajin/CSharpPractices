using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    sealed class ClassS
    {
        //A sealed class cannot introduce a protected member because no other class will be able to inherit from the sealed class and use the protected member.
        protected void Test()
        {
            Console.WriteLine("You cannot inherite me!");
        }
    }
}
