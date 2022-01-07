using LinqExamples.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    public class Aggregations
    {
        List<Product> GetProductsList() => Products.ProductList;
        List<Customer> GetCustomerList() => Customers.CustomerList;

        IList<Student> GetStudentList() => Studnets.StudentsList;

        public int CountSyntex()
        {
            #region count-syntax
            int[] factorsOf300 = { 2, 2, 3, 5, 5 };

            int uniqueFactors = factorsOf300.Distinct().Count();

            Console.WriteLine($"There are {uniqueFactors} unique factors of 300.");
            #endregion
            return 0;
        }

        public int ConditionalCount()
        {
            #region Count-Conditionally
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var result = numbers.Count(n => n % 2 == 1);

            Console.WriteLine("There are {0} odd numbers in the list.", result);
            #endregion
            return 0;
        }

        public int NestedCount()
        {
            #region Nested-Count
            var customers = GetCustomerList();

            var result = from c in customers select (c.CustomerID, Orders: c.Orders.Count());

            foreach(var r in result)
            {
                Console.WriteLine($"Customer ID: {r.CustomerID}, Total Orders: {r.Orders}");
            }
            #endregion
            return 0;
        }

        public int GroupedCount()
        {
            #region Grouped-count
            List<Product> products = GetProductsList();

            var result = from p in products group p by p.Category into g select (Category: g.Key, TotalProducts: g.Count());

            foreach(var r in result)
            {
                Console.WriteLine($"Category: {r.Category}, Total Products: {r.TotalProducts}");
            }
            #endregion
            return 0;
        }

        public int SumSyntex()
        {
            #region Sum-Syntex
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var result = numbers.Sum();

            Console.WriteLine($"Total : {result}");
            #endregion
            return 0;
        }

        public int SumProjection()
        {
            #region Sum-of-projection
            string[] words = { "cherry", "apple", "blueberry" };

            double result = words.Sum(w => w.Length);

            Console.WriteLine(result);
            #endregion
            return 0;
        }

        public int SumGrouped()
        {
            #region grouped-sum
            List<Product> products = GetProductsList();

            var result = from p in products group p by p.Category into g select (Category: g.Key, TotalUnits: g.Sum(s => s.UnitsInStock));

            foreach(var r in result)
            {
                Console.WriteLine($"Category: {r.Category}, Units in stock: {r.TotalUnits}");
            }
            #endregion
            return 0;
        }

        public int MinSyntex()
        {
            #region Min-Syntex
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var result = numbers.Min();

            Console.WriteLine(result);
            #endregion
            return 0;
        }

        public int MinProjection()
        {
            #region Min-Projection
            string[] words = { "cherry", "apple", "blueberry" };

            var result = words.Min(w => w.Length);

            Console.WriteLine($"minmun word length: {result}");
            #endregion
            return 0;
        }

        public int MinGroup()
        {
            #region Min-group
            List<Product> products = GetProductsList();

            var result = from p in products 
                         group p by p.Category 
                         into g 
                         select (Category: g.Key, CheapestPrice: g.Min(u => u.UnitPrice));

            foreach(var r in result)
            {
                Console.WriteLine($"Category: {r.Category}, Lowest price: {r.CheapestPrice.ToString("0.00")}");
            }
            #endregion
            return 0;
        }

        public int MinEachGroup()
        {
            #region Min-each-group
            List<Product> products = GetProductsList();

            //Return ther cheapest product from each category
            var result = from p in products
                         group p by p.Category into g
                         let minPrice = g.Min(m => m.UnitPrice)
                         select (Category: g.Key, CheapestProducts: g.Where(p => p.UnitPrice == minPrice));

            foreach(var r in result)
            {
                Console.WriteLine($"Category: {r.Category}");
                foreach (var p in r.CheapestProducts)
                {
                    Console.WriteLine($"\tProduct: {p}");
                }
            }
            #endregion
            return 0;
        }

        public int MaxSyntex()
        {
            #region Max-Syntex
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var result = numbers.Max();

            Console.WriteLine(result);
            #endregion
            return 0;
        }

        public int MaxProjection()
        {
            #region Max-projection
            string[] words = { "cherry", "apple", "blueberry" };

            var result = words.Max(w => w.Length);

            Console.WriteLine($"Maximum word length: {result}");
            #endregion
            return 0;
        }

        public int MaxGroup()
        {
            # region Max-Group
            List<Product> products = GetProductsList();

            var result = from p in products
                         group p by p.Category into g
                         select (Category: g.Key, MostExpensiveProduct: g.Max(p => p.UnitPrice));

            foreach(var r in result)
            {
                Console.WriteLine($"Category: {r.Category}, Most expensive product: {r.MostExpensiveProduct.ToString("0.00")}");
            }
            #endregion
            return 0;
        }

        public int MaxInEachGroup()
        {
            #region Max-in-each-group
            List<Product> products = GetProductsList();

            var result = from p in products
                         group p by p.Category into g
                         let maxPrice = g.Max(m => m.UnitPrice)
                         select (Category: g.Key, MostExpensiveProducts: g.Where(p => p.UnitPrice == maxPrice));

            foreach(var r in result)
            {
                Console.WriteLine($"Category: {r.Category}");

                foreach (var p in r.MostExpensiveProducts)
                {
                    Console.WriteLine($"\t{p}");
                }
            }
            #endregion
            return 0;
        }

        public int AverageSyntex()
        {
            #region average-syntex
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            double result = numbers.Average();

            Console.WriteLine($"The average number is {result}");
            #endregion
            return 0;
        }

        public int AverageProjection()
        {
            #region Average-projection
            string[] words = { "cherry", "apple", "blueberry" };

            var result = words.Average(w => w.Length).ToString("0.00");

            Console.WriteLine($"The average word length is {result} character");
            #endregion
            return 0;
        }

        public int AverageGrouped()
        {
            #region Agerage-group
            List<Product> products = GetProductsList();

            var result = from p in products group p by p.Category into g select (Categroy: g.Key, AveragePrice: g.Average(p => p.UnitPrice).ToString("0.00"));

            foreach(var r in result)
            {
                Console.WriteLine($"Category: {r.Categroy} & Average Product Price: ${r.AveragePrice}");
            }
            #endregion
            return 0;
        }

        public int AggragateSyntex()
        {
            #region Aggragate-Syntex
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            var result = doubles.Aggregate((runningProject, nexfactor) => runningProject * nexfactor).ToString("0.00");

            Console.WriteLine($"Total product of all numbers: {result}");
            #endregion
            return 0;
        }

        public int SeededAggragate()
        {
            #region SeededAggragate
            double startBalance = 100.0;

            int[] attemptedWithdrawals = { 20, 10, 40, 50, 10, 70, 30 };

            var result = attemptedWithdrawals.Aggregate(startBalance, 
                (balance, nextWithdrawl) => (nextWithdrawl <= balance) ? balance - nextWithdrawl : balance).ToString("0.00");

            Console.WriteLine($"Ending balance: {result}");
            #endregion
            return 0;
        }

        public int AggregateWithResultSelector()
        {
            #region Aggragate-with-result-selector
            IList<Student> students = GetStudentList();

            var result = students.Aggregate<Student, string, string>(
                string.Empty, 
                (str, s) => str += s.StudentName + ",", 
                str => str.Substring(0, str.Length - 1)
                );

            Console.WriteLine(result);
            #endregion
            return 0;
        }
    }
}
