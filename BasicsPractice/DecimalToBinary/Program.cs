using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            DecimalToBinary(n);
        }

        public static void DecimalToBinary(int n)
        {
            string _result = default;

            for(var i = 0; n > 0; i++)
            {
                _result = n % 2 + _result;
                n = n / 2;
            }

            Console.WriteLine(_result);
        }
    }
}
