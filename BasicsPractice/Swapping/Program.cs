using System;

namespace Swapping
{
    class Program
    {
        //Swapping Program in C#
        static void Main(string[] args)
        {
            SwapTwoNumbers();

            Console.WriteLine("\n");

            SwapTwoNumbersWithoutTemp();

            Console.WriteLine("\n");

            SwapToStringWithoutTemp();
        }

        //Swapping two numbers using a third variable in C#
        static void SwapTwoNumbers()
        {
            int num1 = 10;
            int num2 = 20;

            Console.WriteLine($"Before Swap: num1 = {num1} & num2 = {num2}");

            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine($"After Swap: num1 = {num1} & num2 = {num2}");
        }

        static void SwapTwoNumbersWithoutTemp()
        {
            int num1 = 10;
            int num2 = 20;

            Console.WriteLine($"Before Swap: num1 = {num1} & num2 = {num2}");

            //num1 += num2;
            //num2 = num1 - num2;
            //num1 -= num2;

            num1 *= num2;
            num2 = num1 / num2;
            num1 /= num2;

            Console.WriteLine($"Before Swap: num1 = {num1} & num2 = {num2}");

        }

        //Swap two Strings without using the third variable
        static void SwapToStringWithoutTemp()
        {
            string str1 = "Hello";
            string str2 = "World";

            Console.WriteLine($"Before Swap: str1 = {str1} & str2 = {str2}");

            str1 += str2;
            str2 = str1.Substring(0, str1.Length - str2.Length);
            str1 = str1.Substring(str2.Length);

            Console.WriteLine($"After Swap: str1 = {str1} & str2 = {str2}");
        }
    }
}
