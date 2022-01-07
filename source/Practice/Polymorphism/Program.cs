using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //A a = new A();
            //a.Test();

            //A b = new B();
            //b.Test();

            //B c = new C();
            //c.Test();

            ClassA a = new ClassA();
            ClassB b = new ClassB();
            ClassC c = new ClassC();

            a.Test();
            b.Test();
            c.Test();

            a = new ClassB();
            a.Test();

            b = new ClassC();
            b.Test();

            Console.ReadKey();
        }
    }

    class A
    {

    }

    class B : A
    {
        //will hide the base class (A) test method functionality

    }

    class C : B
    {
        //will hide the base class (B) test method functionality

    }
}
