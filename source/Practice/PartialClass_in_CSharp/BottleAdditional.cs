using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass_in_CSharp
{
    public partial class Bottle
    {
        public void Close()
        {
            Console.WriteLine("Closed from Bottle additional file");
        }
    }
}
