using System;

namespace ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            AmrStrongInRange();
        }

        static void AmrStrongNum()
        {
            var num = Console.ReadLine();
            int sum = default;
            int n = num.Length;

            for (var i = 0; i < n; i++)
            {
                int x = int.Parse(num[i].ToString());

                for(var j = 1; j < n; j++)
                {
                    x = x * int.Parse(num[i].ToString());
                }

                sum += x;
            }

            if(int.Parse(num) == sum)
                Console.WriteLine("It is Armstrong Number");
            else
                Console.WriteLine("It is not Armstrong Number");
        }

        static void AmrStrongInRange()
        {
            string[] n = Console.ReadLine().Split();

            int start = int.Parse(n[0]);
            int end = int.Parse(n[1]);

            for (var i = start; i < end; i++)
            {
                if(AmrStrongNum2(i))
                    Console.WriteLine(i);
            }
        }

        static bool AmrStrongNum2(int x)
        {
            var num = x.ToString();
            double sum = default;
            int n = num.Length;

            for(var i = 0; i < n; i++)
            {
                sum += Math.Pow(int.Parse(num[i].ToString()), n);
            }

            if (int.Parse(sum.ToString()) == x)
                return true;
            else
                return false;
        }
    }
}
