using LinqExamples.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    public class Quantifiers
    {
        public List<Product> GetProductsList() => Products.ProductList;
        public List<Customer> GetCustomerList() => Customers.CustomerList;

        //All: The All operator evalutes each elements in the given collection on a specified condition
        //and returns True if all the elements satisfy a condition.

        public int AnyMatchingElement()
        {
            #region any-matches
            string[] words = { "believe", "relief", "receipt", "field" };

            bool result = words.Any(w => w.Contains("ie"));

            Console.WriteLine($"There is a word that contains in the list that contains 'ie': {result}");
            #endregion
            return 0;
        }

        public int GroupByAnyMatchedElement()
        {
            #region any-grouped
            var products = GetProductsList();

            var result = from p in products group p by p.Category into g where g.Any(p => p.UnitsInStock == 0) select (Category: g.Key, Products: g);

            foreach (var r in result)
            {
                Console.WriteLine($"Category : {r.Category}");

                foreach(var p in r.Products)
                {
                    Console.WriteLine(p.ProductName);
                }
                Console.WriteLine();
            }
            #endregion
            return 0;
        }
    }
}
