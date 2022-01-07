using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class FlatDiscount:Discount
    {
        //mandatory
        //override the abstract method
        public override int GetDiscountedAmount(int totalAmount)
        {
            return totalAmount - DiscountAmount;
        }

        //optinal
        //override the virtual method
        public override int GetAmountAfterDiscount(int totalAmount)
        {
            return base.GetAmountAfterDiscount(totalAmount);
        }
    }
}
