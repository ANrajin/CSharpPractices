using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_In_Csharp
{
    public class ParentClass
    {
        public string x { get; set; }

        protected string y { get; set; }

        private int a;


        public string GetData()
        {
            throw new NotImplementedException();
        }


        protected void PrintSomething()
        {
            Console.WriteLine("Hello");
        }


        public int OverrideThis()
        {
            return 0;
        }

        public virtual string OverrideThisVirtual()
        {
            return "Hello";
        }
    }
}
