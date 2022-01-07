using LinqExamples.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    public class ElementOperations
    {
        List<Product> GetProducts() => Products.ProductList;

        List<Customer> GetCustomers() => Customers.CustomerList;

        public int FirstElement()
        {
            #region First-element
            List<Product> products = GetProducts();

            //var result = (from p in products where p.ProductID == 12 select p).First();
            var result = products.First(p => p.ProductID == 12);

            Console.WriteLine(result);
            #endregion
            return 0;
        }

        public int FirstMatchingElement()
        {
            #region first-matching-element
            string[] str = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //find the string started with o
            var result = str.First(s => s[0] == 'o');

            Console.WriteLine($"A string starting with 'o': {result}");

            #endregion
            return 0;
        }

        public void MayBeFirstElement()
        {
            #region First-or-Default
            int[] numbers = { };

            var result = numbers.FirstOrDefault();

            Console.WriteLine(result);
            #endregion
        }

        public void MayBeFirstMatchingElement()
        {
            #region first-or-default
            List<Product> products = GetProducts();

            var result = (from p in products where p.ProductID == 789 select p).FirstOrDefault();

            Console.WriteLine($"Product 789 exists: {result != null}");
            #endregion
        }

        public void ElementAtPosition()
        {
            #region Element-at
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var result = numbers.Where(n => n > 5).ElementAt(1);

            Console.WriteLine($"Second number > 5: {result}");
            #endregion
        }
    }
}
