using System;
using Practice2.TestOne;
using Practice2.Test2;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Test One
            Items items = new Items();

            items.AddItem("Hello");
            items.AddItem("World");
            items.AddItem("Dolly");
            items.AddItem("Programming");

            foreach(var item in items)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Test2
            Person[] person = new Person[]
            {
                new Person("John", "Doe"),
                new Person("Rajin", "Akter"),
                new Person("Kamal", "Ahmed"),
                new Person("Steve", "Jobs")
            };

            People peoples = new People(person);

            foreach(var p in person)
            {
                Console.WriteLine(p.FirstName);
            }
            #endregion
        }
    }
}
