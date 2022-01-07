using LinqExamples.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    public class Ordering
    {
        public List<Product> GetProductList() => Products.ProductList;

        public List<Customer> GetCustomerList() => Customers.CustomerList;

        public int OrderBySyntex()
        {
            #region
            //asc order by alphabetically
            string[] words = { "cherry", "apple", "blueberry" };

            var result = from word in words orderby word select word;

            foreach(var r in result)
            {
                Console.WriteLine(r);
            }
            return 0;
            #endregion
        }

        public int OrderByProperty()
        {
            #region order-by-property
            string[] words = { "cherry", "apple", "blueberry" };

            var result = from word in words orderby word.Length select word;

            Console.WriteLine("The sorted list of words (by length):");

            foreach(var r in result)
            {
                Console.WriteLine(r);
            }
            #endregion

            return 0;
        }

        public int OrderByProducts()
        {
            #region Order-by-products
            List<Product> products = GetProductList();

            var result = from p in products orderby p.ProductName select p;

            foreach(var r in result)
            {
                Console.WriteLine(r.ProductName);
            }
            #endregion

            return 0;
        }

        public int OrderByWithCustomComparer()
        {
            #region Order-by-custom-comparer
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var result = words.OrderBy(a => a, new CaseInsensitiveComparer());

            foreach(var r in result)
            {
                Console.WriteLine(r);
            }

            #endregion

            return 0;
        }

        public int OrderByDescendingSyntax()
        {
            #region orderbydescending-syntax
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            //var result = doubles.OrderByDescending(d => d);
            var result = from d in doubles orderby d descending select d;

            foreach(var r in result)
            {
                Console.WriteLine(r);
            }

            #endregion

            return 0;
        }

        public int OrderProductsDescending()
        {
            #region order-by-product-decs
            List<Product> products = GetProductList();

            var result = from p in products orderby p.UnitsInStock descending select p;

            foreach(var r in result)
            {
                Console.WriteLine(r.ProductName);
            }
            #endregion
            return 0;
        }

        public int DescendingCustomComparer()
        {
            #region desc-custom-comparer
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var result = words.OrderByDescending(w => w, new CaseInsensitiveComparer());

            foreach(var r in result)
            {
                Console.WriteLine(r);
            }
            #endregion
            return 0;
        }

        public int ThenBySyntax()
        {
            #region thenby-syntax
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = from d in digits orderby d.Length, digits select d;
            var result = digits.OrderBy(d => d.Length).ThenBy(d => d);

            foreach (var r in result)
            {
                Console.WriteLine(r);
            }
            #endregion
            return 0;
        }

        public int ThenByCustom()
        {
            #region thenby-custom
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var result = words.OrderBy(w => w.Length).ThenBy(w => w, new CaseInsensitiveComparer());

            foreach(var r in result)
            {
                Console.WriteLine(r);
            }
            #endregion
            return 0;
        }

        public int ThenByDifferentOrdering()
        {
            #region thenby-ordering
            List<Product> products = GetProductList();

            //order by category then unitsale
            var result = from p in products orderby p.Category, p.UnitPrice descending select p;

            foreach(var r in result)
            {
                Console.WriteLine(r);
            }
            #endregion
            return 0;
        }

        public int CustomThenByDescending()
        {
            #region thenby-custom-descending
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var result = words.OrderBy(w => w.Length).ThenByDescending(w => w, new CaseInsensitiveComparer());

            foreach(var r in result)
            {
                Console.WriteLine(r);
            }
            #endregion
            return 0;
        }

        public int ReverseOrdering()
        {
            #region reverse-ordering
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var result = (from d in digits where d[1] == 'i' select d).Reverse();

            Console.WriteLine("A backwards list of the digits with a second character of 'i':");
            foreach (var r in result)
            {
                Console.WriteLine(r);
            }
            #endregion
            return 0;
        }
    }
}
