using System;

namespace CF_977A
{
    class Program
    {
        static void Main(string[] args)
        {
            //CF - 977A : Wrong Subtraction

            string[] userInput = Console.ReadLine().Split();
            int k = Convert.ToInt32(userInput[1]);

            string n = userInput[0];
            int result = Convert.ToInt32(n);

            for (var i = 0; i < k; i++)
            {
                int length = n.Length - 1;
                if (n[length] == '0')
                {
                    n = n.Remove(length, 1);
                    result /= 10;
                }
                else
                {
                    result -= 1;
                    n = result.ToString();
                }
            }


            Console.WriteLine(result);
        }
    }
}