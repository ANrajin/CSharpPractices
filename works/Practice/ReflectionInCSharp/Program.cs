using System;
using System.Reflection;

namespace ReflectionInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly(); //currently running assembly

            Type[] types = assembly.GetTypes(); //gives us the running files. ex - Product, Program, SpecialProduct

            var sr = 1;
            Console.WriteLine("Please select a product: ");
            foreach (var type in types)
            {
                //Console.WriteLine(type);
                if(type.Name.Contains("Product"))
                    Console.WriteLine($"{sr++}. {type.Name}");
            }

            var selectedProduct = Console.ReadLine();

            Console.WriteLine("Please Provide Price & Discount: ");
            var price = double.Parse(Console.ReadLine());
            var discount = double.Parse(Console.ReadLine());

            foreach(var type in types)
            {
                if(type.Name == selectedProduct)
                {
                    ConstructorInfo constructor = type.GetConstructor(new Type[] { }); //get the constructor of specified class/type
                    var item = constructor.Invoke(new object[] { }); //initialize the object by invoking the constructor

                    var property = type.GetProperty("Price"); //get the required property
                    property.SetValue(item, price);

                    MethodInfo method = type.GetMethod("PriceAfterDiscount", new Type[] { typeof(double) }); //get the required method with attributes
                    var priceAfterDiscount = method.Invoke(item, new object[] { discount });

                    Console.WriteLine(priceAfterDiscount);
                    break;
                }
            }
        }

        public static T Amount<T>()
        {
            Type t = typeof(T);
            ConstructorInfo constructor = t.GetConstructor(new Type[] { });
            var item = constructor.Invoke(new object[] { });

            return (T)item;
        }
    }
}
