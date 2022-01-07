using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqExamples.DataSource;

namespace LinqExamples
{
    public class SelectQuery
    {
        public List<Product> GetProductList() => Products.ProductList;
        public List<Customer> GetCustomerList() => Customers.CustomerList;

        public int ExampleOne()
        {
            #region
            IList<Student> students = new List<Student>() 
            {
                new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };

            var result = from s in students select new { Name = s.StudentName, Age = s.Age };

            foreach (var r in result)
            {
                Console.WriteLine($"Sudnet Name: {r.Name} & Age: {r.Age}");
            }
            #endregion
            return 0;
        }

        public int ExampleTwo()
        {
            #region
            IList<Student> students = new List<Student>()
            {                
                new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };

            var result = students.Select(s => new { Name = s.StudentName, Age = s.Age });

            foreach (var r in result)
            {
                Console.WriteLine($"Sudnet Name: {r.Name} & Age: {r.Age}");
            }
            #endregion
            return 0;
        }

        public int DeferredExecution()
        {
            #region deferred-execution
            // Sequence operators form first-class queries that
            // are not executed until you enumerate over them.

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int i = 0;

            var result = from n in numbers select ++i;

            // Note, the local variable 'i' is not incremented
            // until each element is evaluated (as a side-effect):
            foreach(var r in result)
            {
                Console.WriteLine($"result: {r}, index: {i}");
            }

            #endregion
            return 0;
        }

        public int EagerExecution()
        {
            #region eager-execution
            // Methods like ToList() cause the query to be
            // executed immediately, caching the results.

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // The local variable i has already been fully
            // incremented before we iterate the results:
            int i = 0;
            var result = (from n in numbers select ++i).ToList();

            foreach(var r in result)
                Console.WriteLine($"result: {r}, index: {i}");

            #endregion
            return 0;
        }

        public int ReUseQueryExecution()
        {
            #region
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var lowNumbers = from n in numbers where n <= 3 select n;

            Console.WriteLine("First run numbers <= 3:");
            foreach (int n in lowNumbers)
            {
                Console.WriteLine(n);
            }

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = -numbers[i];
            }

            // During this second run, the same query object,
            // lowNumbers, will be iterating over the new state
            // of numbers[], producing different results:
            Console.WriteLine("Second run numbers <= 3:");
            foreach (int n in lowNumbers)
            {
                Console.WriteLine(n);
            }
            #endregion
            return 0;
        }
    }

}
