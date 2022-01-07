using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionInCSharp
{
    public class SpecialProduct:Product
    {
        public override double PriceAfterDiscount(double discount)
        {
            return Price;
        }
    }
}
