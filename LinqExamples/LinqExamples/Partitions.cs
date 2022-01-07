using LinqExamples.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    public class Partitions
    {
        public List<Product> GetProductList() => Products.ProductList;

        public List<Customer> GetCustomerList() => Customers.CustomerList;

        public void TakeSyntex()
        {
            #region take-syntex
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //first 3 numbers
            var result = numbers.Take(3);

            foreach(var r in result)
            {
                Console.WriteLine(r);
            }
            #endregion
        }

        public void NestedTake()
        {
            #region Nested-Take
            List<Customer> customers = GetCustomerList();

            //first 3 orders from WA
            var result = (from c in customers from o in c.Orders where c.Region == "WA" select (c.CustomerID, o.OrderID, o.OrderDate)).Take(3);

            foreach(var r in result)
            {
                Console.WriteLine(r);
            }

            #endregion
        }

        public void SkipSyntex()
        {
            #region skip-syntex
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var result = numbers.Skip(4);

            foreach(var r in result)
            {
                Console.WriteLine(r);
            }
            #endregion
        }

        public void NestedSkipSyntex()
        {
            #region nested-skip-syntex
            List<Customer> customers = GetCustomerList();

            var result = (from c in customers
                          from o in c.Orders
                          where c.Region == "WA"
                          select (c.CustomerID, o.OrderID, o.OrderDate)).Skip(2);

            foreach (var r in result)
            {
                Console.WriteLine(r);
            }
            #endregion
        }

        public void TakeWhileSyntex()
        {

        }
    }
}
