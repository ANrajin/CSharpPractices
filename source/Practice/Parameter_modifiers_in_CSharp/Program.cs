using System;

namespace Parameter_modifiers_in_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Params
            GetSomething("hello", 1,2,3,4,5,6,7); //upto ....n


            //ref
            int x = 10;
            int y = 15;

            //any changes in parameter will not refect here, as x & y are value type
            DoSomething(x, y);
            Console.WriteLine($"normal parameter x: {x}, y: {y}");

            //Any changes in parameter will also reflact here, as we changed it to reference type by 
            //using ref keyword
            DoSomethingWith_ref(ref x, ref y);
            Console.WriteLine($"ref type parameter x: {x}, y: {y}");

            DoSomethingWith_out(out x, out y);
            Console.WriteLine($"out type parameter x: {x}, y: {y}");


            /**
             * ref parameters can be changed
             * in parameter can not be changed
             * out parameters must be changed
             */
        }

        public static void GetSomething(string str, params int[] num)
        {

        }

        public static void DoSomething(int a, int b)
        {
            a = 20;
            b = 30;
        }

        public static void DoSomethingWith_ref(ref int a, ref int b)
        {
            a = 20;
            b = 30;
        }

        /*
         * in parameters makes sure that the arguments passed by in keyword are not changable
         */
        public static void TakeSomethingWith_in(in int a, in int b)
        {
            //a = 20; //a is readonly, we cannot change it. assigning a new value will cause compile time error
            //b = 30;
        }

        /*
         * arguments passed by out keyword must be changed in method body
         */
        public static void DoSomethingWith_out(out int a, out int b)
        {
            a = 60;
            b = 70;
        }
    }
}
