using LinqExamples.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    public class SequenceOperations
    {
        public List<Product> GetProducts() => Products.ProductList;

        public List<Customer> GetCustomers() => Customers.CustomerList;

        #region Matching the sequences of two array elements
        public void EqualSequence()
        {
            string[] wordA = new string[] { "cherry", "apple", "blueberry" };
            string[] wordB = new string[] { "cherry", "apple", "blueberry" };

            bool match = wordA.SequenceEqual(wordB);

            Console.WriteLine($"the sequence mathed: {match}");
        }
        #endregion

        #region Concate two array
        public void concateSeries()
        {
            int[] arr1 = { 0, 2, 6, 5, 8, 7, 9, 3};
            int[] arr2 = { 1, 3, 5, 7, 8 };

            var allNumbers = arr1.Concat(arr2);

            foreach(var num in allNumbers)
            {
                Console.WriteLine(num);
            }
        }
        #endregion

        #region Concate Projection
        public void ConcateProjection()
        {
            List<Product> products = GetProducts();
            List<Customer> customers = GetCustomers();

            var productName = from p in products select p.ProductName;

            var customerName = from c in customers select c.CompanyName;

            var allNames = customerName.Concat(productName);

            Console.WriteLine("Customers and products name: ");

            foreach(var a in allNames)
            {
                Console.WriteLine(a);
            }
        }
        #endregion

        #region Dot Product
        public void DotProduct()
        {
            int[] VactorA = { 1, 2, 6, 5, 9 };
            int[] VactorB = { 7, 8, 6, 4, 3 };

            //this will first multiply the elements of both array and sum it
            int dotProduct = VactorA.Zip(VactorB, (a, b) => a * b).Sum();

            Console.WriteLine(dotProduct);
        }
        #endregion
    }
}
