using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqExamples.DataSource;

namespace LinqExamples
{
    public class Projections
    {
        public List<Product> GetProducts() => Products.ProductList;
        public List<Customer> GetCustomers() => Customers.CustomerList;

        //select each number from the array and add 1
        public void SelectSyntex()
        {
            #region Select
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var numPlusOne = from n in numbers select n + 1;

            Console.WriteLine("Numbers + 1");

            foreach(var num in numPlusOne)
            {
                Console.WriteLine(num);
            }
            #endregion
        }

        //Select property from a collection
        public void SelectProperty()
        {
            #region Select-Property
            List<Product> products = GetProducts();

            var productName = from p in products select p.ProductName;

            Console.WriteLine("Products Name");
            
            foreach(var name in productName)
            {
                Console.WriteLine(name);
            }
            #endregion
        }

        //Select numbers and transform it to it's string value
        public void TransformWithSelect()
        {
            #region Transfrom with select
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            string[] strs = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var transform = from n in numbers select strs[n];

            foreach(var t in transform)
            {
                Console.WriteLine(t);
            }
            #endregion
        }

        //Select by case anonymous
        public void SelectByCaseAnonymous()
        {
            #region Select case anonymous
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //make new anonymous object
            var upperLowerWords = from w in words select new { Upper = w.ToUpper(), Lower = w.ToLower() };

            foreach(var ul in upperLowerWords)
            {
                Console.WriteLine($"UpperCase: {ul.Upper} & LowerCase: {ul.Lower}");
            }
            #endregion
        }

        //Select by case tuple
        public void SelectByCaseTuple()
        {
            #region Select by case tuple
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //make a new Tuple
            var caseTuple = from w in words select (Upper: w.ToUpper(), Lower: w.ToLower());

            foreach(var ul in caseTuple)
            {
                Console.WriteLine($"Upper case = {ul.Upper} & Lower Case = {ul.Lower}");
            }
            #endregion
        }

        //Select anonymous construction
        public void SelectAnonumousConstruction()
        {
            #region AnonymousConstruction
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strs = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var digitsOddEven = from num in numbers select new { Digits = strs[num], Even = (num % 2 == 0) };

            foreach(var d in digitsOddEven)
            {
                Console.WriteLine($"Digit = {d.Digits} and It is an {(d.Even ? "even" : "odd")} number");
            }
            #endregion
        }

        //Select Tuple Construction
        public void SelectTupleConstruction()
        {
            #region Tuple construction
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strs = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var digitsOddEven = from num in numbers select (Digit: strs[num], Odd: (num % 2 == 0));

            foreach(var d in digitsOddEven)
            {
                Console.WriteLine($"Digit = {d.Digit} and it is an {(d.Odd ? "odd" : "even")} number");
            }
            #endregion
        }

        //Selecting Subset of property
        public void SelectPropertySubset()
        {
            #region select property subset
            List<Product> products = GetProducts();

            var productInfo = from p in products select (p.ProductName, p.Category, Price: p.UnitPrice);

            foreach(var pi in productInfo)
            {
                Console.WriteLine($"{pi.ProductName} is in the {pi.Category} category and costs {pi.Price.ToString("0.00")} per unit");
            }
            #endregion
        }

        //Select with index
        public void SelectWithIndex()
        {
            #region Select with index
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //match the number with it's index and return boolean
            var withIndex = numbers.Select((num, index) => (Number: num, InPlace: index == num));

            Console.WriteLine("Number in place");

            foreach(var w in withIndex)
            {
                Console.WriteLine($"{w.Number} is Inplace {w.InPlace}");
            }
            #endregion
        }

        //Conditionaly select
        public void SelectWithWhere()
        {
            #region select with where
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strs = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var lowNumbers = from num in numbers where num < 5 select strs[num];

            Console.WriteLine("Digits lower then 5");

            foreach(var ln in lowNumbers)
            {
                Console.WriteLine(ln);
            }
            #endregion
        }

        //Selecting elements from multiple arrays
        public void SelectFromMultipleSequences()
        {
            #region Select from multiple arrays
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            //select those elements from numberA that are less the the elements of numberB
            var pairs = from a in numbersA from b in numbersB where a < b select (a, b);

            foreach(var p in pairs)
            {
                Console.WriteLine($"{p.a} is less than {p.b}");
            }
            #endregion
        }

        //Select from child sequence
        public void SelectFromChildSequence()
        {
            #region Select From Child Sequence
            List<Customer> customers = GetCustomers();

            var orders = from c in customers from o in c.Orders where o.Total < 500.00M select (c.CustomerID, o.OrderID, o.Total);

            foreach(var order in orders)
            {
                Console.WriteLine($"Customer: {order.CustomerID}, Order: {order.OrderID}, Total value: {order.Total}");
            }
            #endregion
        }

        //Select many elements with where
        public void SelectManyWithWhere()
        {
            #region Select Many-filter
            List<Customer> customers = GetCustomers();

            var orders = from c in customers from o in c.Orders where o.OrderDate >= new DateTime(1988, 1, 1) select (c.CustomerID, o.OrderID, o.OrderDate);

            foreach(var o in orders)
            {
                Console.WriteLine($"Customer: {o.CustomerID}, Order: {o.OrderID}, Total date: {o.OrderDate.ToShortDateString()}");
            }
            #endregion
        }

        //Using multiple where clause
        public void SelectWithMultipleWhereClause()
        {
            #region multiple where clause
            List<Customer> customers = GetCustomers();

            DateTime cutOffDate = new DateTime(1997, 1, 1);

            var orders = from c in customers 
                         where c.Region == "WA" 
                         from o in c.Orders 
                         where o.OrderDate >= cutOffDate 
                         select (c.CustomerID, o.OrderID);

            foreach(var o in orders)
            {
                Console.WriteLine($"Customer: {o.CustomerID}, Order: {o.OrderID}");
            }
            #endregion
        }

        public void IndexedSelectMany()
        {
            #region index-select-many
            List<Customer> customers = GetCustomers();

            var customerOrders = customers.SelectMany((cust, index) => cust.Orders.Select(o => $"Customer #{index + 1} has an order with OrderID: {o.OrderID}"));

            foreach(var order in customerOrders)
            {
                Console.WriteLine(order);
            }
            #endregion
        }
    }
}
