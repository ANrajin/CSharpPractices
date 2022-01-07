using System;

namespace PalinDromeNumber
{
    class Program
    {
        //Numbers that are same when reverse
        static void Main(string[] args)
        {
            //CheckForPalindrome();
            //StringPalindrome();
            //StringPalinDromeUsingForeach();
            StringPalindromeUsingArray();
        }

        static void CheckForPlaindrome()
        {
            var n = int.Parse(Console.ReadLine());
            int reverse = default;
            var temp = n;

            while(temp != 0)
            {
                var lastDigit = temp % 10;
                reverse = (reverse * 10) + lastDigit;
                temp /= 10;
            }

            if(n == reverse)
                Console.WriteLine("It is plaindrome");
            else
                Console.WriteLine("It is not plaindrome");
        }

        static void StringPalindrome()
        {
            string str = Console.ReadLine();
            string temp = default;


            for(var i = str.Length; i > 0; i--)
            {
                temp += str[i-1];
            }

            if(str == temp)
            {
                Console.WriteLine("Plaindrome");
            }
            else
            {
                Console.WriteLine("Not Plaindrome");
            }
        }

        static void StringPalinDromeUsingForeach()
        {
            var str = Console.ReadLine();
            string temp = string.Empty;

            foreach(char c in str)
            {
                temp = c + temp;
            }

            if(str.Equals(temp, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Plaindrome");
        }

        static void StringPalindromeUsingArray()
        {
            char[] n = Console.ReadLine().ToCharArray();
            Array.Reverse(n);

            //convert the array into string
            string reverse = new string(n);

            Console.WriteLine(reverse);
        }
    }
}
