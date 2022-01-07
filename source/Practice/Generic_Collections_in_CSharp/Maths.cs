using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections_in_CSharp
{
    public class Maths : ISumable, ICloneable
    {
        public object Clone()
        {
            throw new NotImplementedException();
        }

        public string Sum()
        {
            throw new NotImplementedException();
        }
    }
}
