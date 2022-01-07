using LinqExamples.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LinqExamples
{
    public class Joining
    {
        public List<Product> GetProductList() => Products.ProductList;
        public List<Customer> GetCustomerList() => Customers.CustomerList;

       // from... in outerSequence
       //join ... in innerSequence
       //on outerKey equals innerKey
       //select ...

        public int CrossJoinQuery()
        {
            #region
            string[] categories = {
                "Beverages",
                "Condiments",
                "Vegetables",
                "Dairy Products",
                "Seafood"
            };

            List<Product> products = GetProductList();

            //from t1 in table1 join t2 in table2 on t1(selector) equals t2(Selector) select (t1, t2) 


            var result = from c in categories join p in products on c equals p.Category select (Category: c, p.ProductName);

            foreach (var r in result)
            {
                Console.WriteLine($"Product Name: {r.ProductName} and Category: {r.Category}");
            }


            //var result = products.Join(categories, p => p.Category, c => c,  (p, c) => new { ProductName = p.ProductName, CategoryName = c });

            //foreach(var r in result)
            //{
            //    Console.WriteLine(r.ProductName, r.CategoryName);
            //}
            #endregion
            return 0;
        }

        public int GroupJoinQuery()
        {
            #region Group-join-query
            string[] categories = {
                "Beverages",
                "Condiments",
                "Vegetables",
                "Dairy Products",
                "Seafood"
            };

            List<Product> products = GetProductList();

            var results = from c in categories join p in products on c equals p.Category into ps select (Category: c, Items: ps);

            foreach(var r in results)
            {
                Console.WriteLine("\n" + r.Category);

                foreach(var p in r.Items)
                {
                    Console.WriteLine($"-- {p.ProductName}");
                }
            }
            #endregion
            return 0;
        }

        public int CrossGroupJoin()
        {
            #region
            string[] categories = {
                "Beverages",
                "Condiments",
                "Vegetables",
                "Dairy Products",
                "Seafood"
            };

            List<Product> products = GetProductList();

            var result = from c in categories join p in products on c equals p.Category into ps from p in ps select (Category: c, p.ProductName);

            foreach (var r in result)
            {
                Console.WriteLine($"{r.Category} & {r.ProductName}");
            }
            #endregion
            return 0;
        }

        public int LeftOuterJoin()
        {
            #region Left-outer-join
            string[] categories = {
                "Beverages",
                "Condiments",
                "Vegetables",
                "Dairy Products",
                "Seafood"
            };

            List<Product> products = GetProductList();

            var result = from c in categories join p in products 
                         on c equals p.Category into ps 
                         from p in ps.DefaultIfEmpty() 
                         select (Category: c, ProductName: p == null ? "(No Product)" : p.ProductName);

            foreach(var r in result)
            {
                Console.WriteLine($"{r.Category} - {r.ProductName}");
            }
            return 0;
            #endregion
        }
    }
}
