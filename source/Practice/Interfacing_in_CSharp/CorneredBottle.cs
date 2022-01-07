using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacing_in_CSharp
{
    class CorneredBottle:Bottle
    {
        //defining a method in child class, which is already exist in base class
        //the child class method will hide the functionality of base class method
        //if it is indeed then use "new" keyword infront of method
        //using "new" keyword doesnot affact anything in method

        public new void Open()
        {
            //if we need the functionality of base class's method
            //then we can use that, like this
            base.Open();

            Console.WriteLine("Open from cornered bottle");
        }
    }
}
