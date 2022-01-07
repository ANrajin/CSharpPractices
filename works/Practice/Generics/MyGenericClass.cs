using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class MyGenericClass<T>
    {
        private T genericMember;

        public T GenericClassProperty { get; set; }

        public MyGenericClass(T value)
        {
            genericMember = value;
        }

        public T GenericClassMethod(T genericParam)
        {
            Console.WriteLine($"Parameter type: {typeof(T).ToString()}, value: {genericParam}");

            Console.WriteLine($"Return type: {typeof(T).ToString()}, value: {genericMember}");

            return genericMember;
        }
    }
}
