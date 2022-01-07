using System;

namespace DelegatesInCSharp_18
{
    class Program
    {
        /**
         * Delegates are used to pass methods as arguments to other methods.
         */

        //1. define a delegate
        public delegate void MyDelegate(string a);

        //2. define target method
        public static void MethodA(string a)
        {
            Console.WriteLine(a);
        }

        public static void MethodB(string a)
        {
            Console.WriteLine(a);
        }

        public static void MethodC(string a)
        {
            Console.WriteLine(a);
        }

        static void Main(string[] arg)
        {
            //3. Set the target method
            MyDelegate x = MethodA;
            MyDelegate y = MethodB;
            MyDelegate w = MethodC;

            //4. Invoke the delegate
            //x.Invoke("Hello World");
            //x("Hello World");

            //Pass delegate variable as argument
            //InvokeDelegateA(x);

            //Multicast Delegate. To add => +, +=. To remove -. -=
            //If a delegate returns a value, then the last assigned target method's value
            //will be return when a multicast delegate called

            MyDelegate z = x + y;
            z += w;

            InvokeDelegateA(z);

            z -= y;
            Console.WriteLine();
            InvokeDelegateA(z);

            FuncDelegate fnc = new FuncDelegate();

            Console.WriteLine("Func Delegate");

            fnc.Run();

            ActionDelegate act = new ActionDelegate();
            Console.WriteLine("Action Delegate");
            act.Run();


            Console.WriteLine("Predicate Delecate");
            PredicateDelegate pre = new PredicateDelegate();
            pre.Run();
        }

        //Pass delegate as method parameter
        static void InvokeDelegateA(MyDelegate del)
        {
            del("Hello Dolly");
        }
    }
}
