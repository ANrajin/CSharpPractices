using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_In_Csharp
{
    public class ChildClass:ParentClass
    {
        public new int OverrideThis()
        {
            return 1;
        }

        //can use new keyword also
        public override string OverrideThisVirtual()
        {
            return "World";
        }
    }
}
