using System;

namespace Inheritance_In_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ParentClass pcls = new ParentClass();

            ChildClass ccls = new ChildClass();

            Console.WriteLine(pcls.OverrideThis());

            Console.WriteLine(ccls.OverrideThis());

            ParentClass pccls = new ChildClass();

            Console.WriteLine(pccls.OverrideThis());

            //jodi parent class er kono method k child class e override 
            //korar jonno "override / new" keyword use kori
            //tahole sob kheterei child class er overrided method implementation kaaj korbe

            Console.WriteLine(pccls.OverrideThisVirtual());
            Console.WriteLine(ccls.OverrideThisVirtual());
            Console.WriteLine(pccls.OverrideThisVirtual());
        }
    }
}
