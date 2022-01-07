using System;

namespace CF___133A
{
    class Program
    {
        static void Main(string[] args)
        {
            //CF - 133A : HQ9+
            string p = Console.ReadLine();
            string instruction = "HQ9";

            var _result = "NO";

            for (var i = 0; i < instruction.Length; i++)
            {
                if (p.Contains(instruction[i]))
                {
                    _result = "YES";
                    break;
                }
            }

            Console.WriteLine(_result);
        }
    }
}