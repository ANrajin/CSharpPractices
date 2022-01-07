using LinqExamples.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    public class Generators
    {
        List<Product> GetProducts() => Products.ProductList;
        List<Customer> GetCustomers() => Customers.CustomerList;
        public void RangeOfInteger()
        {
            #region Range-of-Integer
            var result = from n in Enumerable.Range(50, 20) select (Numbers: n, OddEven: n % 2 == 0 ? "even" : "odd");

            foreach(var r in result)
            {
                Console.WriteLine(r);
            }
            #endregion
        }

        public void RepeatNumber()
        {
            #region repeat-number
            var numbers = Enumerable.Repeat(7, 10);

            foreach(var n in numbers)
            {
                Console.WriteLine(n);
            }
            #endregion
        }
    }
}
