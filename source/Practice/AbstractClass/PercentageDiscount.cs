using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class PercentageDiscount : Discount
    {
        //mandatory
        //override the abstract method
        public override int GetDiscountedAmount(int totalAmount)
        {
            return (totalAmount - ((totalAmount*DiscountAmount)/100));
        }
    }
}
