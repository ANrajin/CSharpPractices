using System;

namespace Generic_Collections_in_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Point<int, double, string> p1 = new Point<int, double, string>();

            p1.x = 10;
            p1.y = 20.5;
            p1.a = "Hello";

            double x1 = p1.Sum(p1.x, p1.y);

            string s1 = p1.Sum(p1.x, p1.a);

            Console.WriteLine(x1);

            Console.WriteLine(s1);


            //Tree<string> t1 = new Tree<string>();

            //t1.AddNodes("Dhaka");
            //t1.AddNodes("Cumilla");
            //t1.AddNodes("Barishal");

            //t1.TreeList();

            //string node = t1.DeleteNode("Barishal");

            ////Class, implements ISumbale interface 
            //NewGeneric<Maths, int> newOne = new NewGeneric<Maths, int>();

            //Printer<int>.Print<double>(5.5);

            //DataStore<string> cities = new DataStore<string>();
            //cities.AddOrUpdate(0, "Mumbai");
            //cities.AddOrUpdate(1, "Chicago");
            //cities.AddOrUpdate(2, "London");

            //var c = cities.GetItem(1);

            //Console.WriteLine(c);

            //DataStore<int> empIds = new DataStore<int>();
            //empIds.AddOrUpdate(0, 50);
            //empIds.AddOrUpdate(1, 65);
            //empIds.AddOrUpdate(2, 89);

            //var b = empIds.GetItem(1);

            //Console.WriteLine(b);

            //Generic_Dictionary.Index();

            //Generic_Stacks.Index();
        }
    }
}
