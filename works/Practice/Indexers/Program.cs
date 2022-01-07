using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();

            Console.WriteLine(company[101]);

            Console.WriteLine("Total Number Employees with Gender = Male:" + company["Male"]);
            Console.WriteLine("Total Number Employees with Gender = Female:" + company["Female"]);

            company["Male"] = "Female";

            Console.WriteLine();

            Console.WriteLine("Total Number Employees with Gender = Male:" + company["Male"]);
            Console.WriteLine("Total Number Employees with Gender = Female:" + company["Female"]);
        }
    }
}
