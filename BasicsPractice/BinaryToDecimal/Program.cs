using System;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = Console.ReadLine();

            Binary2Decimal1(b.ToCharArray());
            Binary2Decimal2(b);
        }

        static void Binary2Decimal1(char[] b)
        {
            double result = default;

            if (Char.GetNumericValue(b[0]) == 0)
                result = 1;
            else
            {
                int x = b.Length - 1;
                for (var i = 0; i < b.Length; i++)
                {
                    double y = Char.GetNumericValue(b[i]);

                    if (y > 1)
                        return;

                    result += y * Math.Pow(2, x);
                    x--;
                }
            }

            Console.WriteLine(result);
        }

        static void Binary2Decimal2(string b)
        {
            double result = Convert.ToInt32(b, 2);
            Console.WriteLine(result);
        }
    }
}
