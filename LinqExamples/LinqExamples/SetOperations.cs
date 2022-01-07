using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqExamples.DataSource;

namespace LinqExamples
{
    public class SetOperations
    {
        public List<Product> GetProducts() => Products.ProductList;
        public List<Customer> GetCustomers() => Customers.CustomerList;

        #region Distinct Returns distinct values from a collection
        public void DistinctSyntex()
        {
            int[] factorsOf300 = { 2, 2, 3, 5, 5 };

            var uniqueFactors = factorsOf300.Distinct();

            foreach(var uf in uniqueFactors)
            {
                Console.WriteLine(uf);
            }
        }
        #endregion

        #region Distinct Property value
        public void DistinctPropertyValue()
        {
            List<Product> products = GetProducts();

            var categoryName = (from p in products select p.Category).Distinct();

            foreach(var c in categoryName)
            {
                Console.WriteLine(c);
            }
        }
        #endregion

        #region Except Syntex; Returns the difference between two sequences
        public void ExceptSyntex()
        {
            int[] numA = { 11, 55, 74, 96, 23, 14 };
            int[] numB = { 11, 55, 74, 85, 25, 14 };

            //will return the elements of numA that are not present in numB;
            var ex = numA.Except(numB);

            Console.WriteLine("Numbers in first array but not second array:");
            foreach (var e in ex)
            {
                Console.WriteLine(e);
            }
        }
        #endregion

        #region Difference of queries
        public void DifferenceOfQueries()
        {
            List<Product> products = GetProducts();
            List<Customer> customers = GetCustomers();

            IEnumerable<char> productFirstChars = products.Select(p => p.ProductName[0]);
            IEnumerable<char> customerFirstChars = customers.Select(c => c.CompanyName[0]);

            var productOnlyFirstChars = productFirstChars.Except(customerFirstChars);

            Console.WriteLine("First letters from Product names, but not from Customer names:");
            foreach (var p in productOnlyFirstChars)
            {
                Console.WriteLine(p);
            }

        }
        #endregion

        #region Intersect-Syntex-the intersection of two sequences
        public void IntersectSyntex()
        {
            int[] numA = { 5, 6, 9, 8, 7, 1 };
            int[] numB = { 5, 8, 9, 7, 2, 3 };


            //returns the elements that are present in numA in comparision od numB
            IEnumerable<int> common = numA.Intersect(numB);

            foreach(var c in common)
            {
                Console.WriteLine(c);
            }
        }
        #endregion

        #region Intersect-query-result
        public void IntersectQueryResult()
        {
            List<Product> products = GetProducts();
            List<Customer> customers = GetCustomers();

            var productFirstChar = from p in products select p.ProductName[0];
            var customerFirstChar = from c in customers select c.CompanyName[0];

            var commonFirstChars = productFirstChar.Intersect(customerFirstChar);

            foreach(var cf in commonFirstChars)
            {
                Console.WriteLine(cf);
            }
        }
        #endregion

        #region Union-Syntex-Returns unique elements from two sequences
        public void UnionSyntex()
        {
            int[] numA = { 8, 5, 2, 3, 9, 6, 9 };
            int[] numB = { 1, 4, 7, 2, 4, 8, 6 };

            //returns unique elements that appear in either of the two sequences
            var uniqueElements = numA.Union(numB);

            foreach(var u in uniqueElements)
            {
                Console.WriteLine(u);
            }
        }
        #endregion

        #region Union Query Result
        public void UnionQueryResult()
        {
            List<Product> products = GetProducts();

            List<Customer> customers = GetCustomers();

            var productFirstCharacter = from p in products select p.ProductName[0];

            var customerFirstCharacter = from c in customers select c.CompanyName[0];

            var uniqueFirstCharacters = productFirstCharacter.Union(customerFirstCharacter);

            foreach(var u in uniqueFirstCharacters)
            {
                Console.WriteLine(u);
            }
        }
        #endregion
    }
}
