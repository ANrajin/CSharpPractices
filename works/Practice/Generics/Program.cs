using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var isEqual = AreEqual<int>(10, 10);

            Console.WriteLine(isEqual);

            var isEqual2 = AreEqual<string>("rajin", "raj");

            Console.WriteLine(isEqual2);

            var dblIsEqual = AreEqual<double>(10.56, 2.36);

            Console.WriteLine(dblIsEqual);


            //Generic Class
            MyGenericClass<int> mg = new MyGenericClass<int>(20);

            Console.WriteLine(mg.GenericClassMethod(10));
        }

        public static bool AreEqual<T>(T valOne, T valTwo)
        {
            return valOne.Equals(valTwo);
        }
    }
}
