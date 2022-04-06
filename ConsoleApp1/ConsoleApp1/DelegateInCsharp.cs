using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate int AddNumbers(int[] numbers);
    public class DelegateInCsharp
    {
        public void Run()
        {
            int[] numbers = new int[]
            {
                10, 20, 30, 40
            };

            AddNumbers add = Formula1;
            Console.WriteLine(add(numbers));
            Formula2(add, numbers);


            //Generic Delegates
            Func<int[], int> funct = Formula1;
            Console.WriteLine(funct(numbers));
            Console.WriteLine(ApplyFomrula(funct, numbers));//pass func delegate as pararmeter

            Action<int, int> funct2 = Formula3;
            funct2(20, 25);
            funct2.Invoke(10, 20);
            ApplyFormula2(funct2, 50, 60);//pass action delegate as parameter

            var aa = funct2.Target;//get the class instance of the target method

        }

        public int Formula1(int[] numbers)
        {
            int result = default;

            for(var i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }

            return result;
        }

        public void Formula2(AddNumbers n, int[] nums)
        {
            Console.WriteLine(n(nums));
        }

        public void Formula3(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public int ApplyFomrula(Func<int[], int> n, int[] numbers)
        {
            return n(numbers);
        }

        public void ApplyFormula2(Action<int, int> m, int x, int y)
        {
            m(x, y);
        }
    }
}
