using System;
using System.Reflection;

namespace Reflactions_in_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //currently running assembly
            Assembly a = Assembly.GetExecutingAssembly();

            //get the types in assembly
            Type[] t = a.GetTypes();

            int serial = 1;

            Console.WriteLine("Please select a product: ");

            foreach(var type in t)
            {
                if(type.Name.Contains("Product"))
                    //print the parent and child classes
                    Console.WriteLine($"{serial++}. {type.Name}");
            }

            var selectedProduct = Console.ReadLine();

            Console.WriteLine("Please insert price and discount");

            var price = double.Parse(Console.ReadLine());
            var discount = double.Parse(Console.ReadLine());

            foreach(var type in t)
            {
                if(type.Name == selectedProduct)
                {
                    ConstructorInfo c = type.GetConstructor(new Type[] { });
                    var item = c.Invoke(new object[] { });

                    PropertyInfo p = type.GetProperty("Price");
                    p.SetValue(item, price);

                    MethodInfo method = type.GetMethod("PriceAfterDiscount", new Type[] { typeof(double) });

                    var  priceAfterDiscount = method.Invoke(item, new object[] { discount });

                    Console.WriteLine(priceAfterDiscount);

                    break;
                }
            }
        }
    }
}
