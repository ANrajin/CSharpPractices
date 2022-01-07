using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    public class QueryExecutions
    {
        #region Deffered Execution
        //query will not execute untill we use the result
        public void DefferedExecution()
        {
            int[] num = { 5, 4, 2, 1, 3, 6, 9, 8, 7};

            var i = 0;

            var result = from n in num select ++i;

            //when the for loop start execute, the query will execute also
            foreach(var r in result)
            {
                Console.WriteLine($"{r}, index = {i}");
            }
        }
        #endregion

        #region Eager Execution
        //query will execute immidiatly and the result will cached
        public void EagerExecution()
        {
            int[] num = { 5, 4, 2, 1, 3, 6, 9, 8, 7 };

            var i = 0;

            var result = (from n in num select ++i).ToList();

            //here local variable i is already incremented, when the query immidiatly executes
            foreach(var r in result)
            {
                Console.WriteLine($"{r}, index = {i}");
            }
        }
        #endregion

        #region Reuse Query
        //Deffered execution gives us abaility to define a query once
        //and use it again
        public void ReuseQueryExecution()
        {
            int[] num = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var lowNumbers = from n in num where n <= 3 select n;

            Console.WriteLine("First run numbers <= 3:");

            foreach(int n in lowNumbers)
            {
                Console.WriteLine(n);
            }

            for(var i = 0; i < 10; i++)
            {
                num[i] = -num[i];
            }

            // During this second run, the same query object,
            // lowNumbers, will be iterating over the new state
            // of numbers[], producing different results:
            Console.WriteLine("Second run numbers <= 3:");

            foreach(var n in lowNumbers)
            {
                Console.WriteLine(n);
            }
        }
        #endregion
    }
}
