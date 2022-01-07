using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Discount:IPrice
    {
        public int DiscountAmount { get; set; }


        //abstract method. must be override on it's child
        public abstract int GetDiscountedAmount(int totalAmount);


        //virtual method. can be override on it's child
        public virtual int GetAmountAfterDiscount(int totalAmount)
        {
            throw new NotImplementedException();
        }

        public int BasePrice()
        {
            throw new NotImplementedException();
        }
    }
}
