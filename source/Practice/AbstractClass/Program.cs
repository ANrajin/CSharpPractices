using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Discount discount = GetDiscount();
            discount.DiscountAmount = 50;

            int amount = discount.GetDiscountedAmount(500);

            Console.WriteLine(amount);
        }

        //this method will return an object called discount
        public static Discount GetDiscount()
        {
            var userInput = Console.ReadLine();

            if(userInput == "Flat")
            {
                return new FlatDiscount();
            }
            else
            {
                return new PercentageDiscount();
            }
        }
    }
}
