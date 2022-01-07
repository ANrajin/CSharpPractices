using LinqExamples.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    class RestrictionOrFiltering
    {
        public List<Product> GetProductList() => Products.ProductList;
        public List<Customer> GetCustomerList() => Customers.CustomerList;
        public List<Student> GetStudentList() => Studnets.StudentsList;

        public int LowNumbers()
        {
            #region where-syntax
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var lowNumbers = from n in numbers where n < 5 select n;

            foreach(var lNum in lowNumbers)
            {
                Console.WriteLine($"{lNum} is less then 5");
            }

            #endregion

            return 0;
        }

        public void ProductsOutOfStock()
        {
            #region where-property
            List<Product> products = GetProductList();

            var outOfStock = from p in products where p.UnitsInStock == 0 select p;

            Console.WriteLine("Products out of stock");

            foreach(var p in outOfStock)
            {
                Console.WriteLine(p.ProductName);
            }
            #endregion
        }

        public void ExpensiveProductsInStock()
        {
            #region where-multiple-properties
            List<Product> products = GetProductList();

            var expensiveProducts = from p in products where p.UnitPrice > 3.00M && p.UnitsInStock > 0 select p;

            Console.WriteLine("In-stock products that cost more than 3.00:");
            foreach (var p in expensiveProducts)
            {
                Console.WriteLine($"{p.ProductName} is in stock and costs more than 3.00.");
            }
            #endregion
        }

        public int CustomerOrders()
        {
            #region where-drilldown
            List<Customer> customers = GetCustomerList();

            var orders = from c in customers where c.Region == "WA" select c;

            Console.WriteLine("Customers from Washington and their orders:");
            foreach (var customer in orders)
            {
                Console.WriteLine($"Customer {customer.CustomerID}: {customer.CompanyName}");

                foreach(var order in customer.Orders)
                {
                    Console.WriteLine($"  Order {order.OrderID}: {order.OrderDate}");
                }
            }
            #endregion
            return 0;
        }

        public int IndexedWhere()
        {
            #region where-index
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //Get the digits whos index is greater then its length
            var shortDigits = digits.Where(
                    (digit, index) => digit.Length < index
                );

            foreach(var d in shortDigits)
            {
                Console.WriteLine($"{d}'s length is shorter then its index");
            }
            #endregion

            return 0;
        }

        public void TeenAgers()
        {
            #region use-of-delegate-in-linq
            List<Student> students = GetStudentList();

            Func<Student, bool> isTeenAger = delegate (Student s)
            {
                return s.Age > 12 && s.Age < 20;
            };

            var filteredResult = from s in students where isTeenAger(s) select s;

            foreach(var r in filteredResult)
            {
                Console.WriteLine(r.StudentName);
            }
            #endregion
        }

        public void TeenAgersTwo()
        {
            #region multiple-where-clause
            List<Student> students = GetStudentList();

            //var filteredResult = from s in students where s.Age > 12 && s.Age < 20 select s;

            var filteredResult = students.Where(s => s.Age > 12).Where(s => s.Age < 20).ToArray();

            foreach(var r in filteredResult)
            {
                Console.WriteLine(r.StudentName);
            }
            #endregion
        }
    }
}
