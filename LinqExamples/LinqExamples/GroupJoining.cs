using LinqExamples.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    public class GroupJoining
    {
        public List<Product> GetProductList() => Products.ProductList;
        public List<Customer> GetCustomerList() => Customers.CustomerList;


        //from... in outerSequence

        //join... in innerSequence

        //on outerKey equals innerKey

        //into groupedCollection

        //select...
        public int GroupingSyntax()
        {
            #region groupby-syntax
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var result = from n in numbers group n by n % 5 into g select (Numbers: g, Remainder: g.Key);


            foreach (var r in result)
            {
                Console.WriteLine($"Numbers with a remainder of {r.Remainder} when divided by 5:");

                foreach (var g in r.Numbers)
                {
                    Console.WriteLine(g);
                }
            }
            #endregion
            return 0;
        }

        public int GroupByProperty()
        {
            #region group-by-property
            string[] words = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };

            var result = from w in words group w by w[0] into g select (FirstLetter: g.Key, Word: g);
            //var result = from w in words group w by w[0] into g orderby g.Key select (FirstLetter: g.Key, Word: g);

            foreach (var r in result)
            {
                Console.WriteLine("Words that start with the letter '{0}':", r.FirstLetter);

                foreach (var x in r.Word)
                {
                    Console.WriteLine(x);
                }
            }
            #endregion
            return 0;
        }

        public int GroupByCategory()
        {
            #region groupby-category
            List<Product> products = GetProductList();

            var result = from p in products group p by p.Category into g select (Category: g.Key, Product: g);

            foreach (var r in result)
            {
                Console.WriteLine($"Products in {r.Category} category:");
                foreach (var product in r.Product)
                {
                    Console.WriteLine($"\t{product}");
                }
            }
            #endregion
            return 0;
        }

        public int NestedGrouBy()
        {
            #region nested-groupby
            List<Customer> customers = GetCustomerList();

            var result = from c in customers select (
                         c.CompanyName, YearGroups: from o in c.Orders group o by o.OrderDate.Year into yg
                         select (Year: yg.Key, MonthGroup: from o in yg group o by o.OrderDate.Month into mg select(Month: mg.Key, Orders: mg))
                         );

            foreach(var r in result)
            {
                Console.WriteLine($"Customer Name: {r.CompanyName}");

                foreach(var y in r.YearGroups)
                {
                    Console.WriteLine($"\tYear: {y.Year}");
                    foreach(var x in y.MonthGroup)
                    {
                        Console.WriteLine($"\t\tMonth: {x.Month}");

                        foreach (var o in x.Orders)
                        {
                            Console.WriteLine(o);
                        }
                    }
                }
            }
            #endregion
            return 0;
        }

        public int GroupByCustomComparer()
        {
            #region groupby-custom-comparer
            string[] anagrams = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };
            #endregion
            return 0;
        }

        public int GrpByCategory()
        {
            #region ToLookUp
            List<Product> products = GetProductList();

            var result = products.ToLookup(s => s.Category);

            foreach(var r in result)
            {
                Console.WriteLine($"Category: {r.Key}");

                foreach(var c in r)
                {
                    Console.WriteLine($"- {c.ProductName}");
                }

                Console.WriteLine();
            }

            #endregion
            return 0;
        }
    }
}
