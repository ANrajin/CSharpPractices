using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections_in_CSharp
{
    //Applying restriction in type parameter
    public class NewGeneric<T, D>where T: ISumable, ICloneable
        where D: struct
    {
    }
}
