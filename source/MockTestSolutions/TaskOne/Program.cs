using System;

namespace TaskOne
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<Class1> n = new GenericClass<Class1>(new Class1());

            Console.WriteLine(n._data.CallPrivate("Hello World"));
        }
    }
}
