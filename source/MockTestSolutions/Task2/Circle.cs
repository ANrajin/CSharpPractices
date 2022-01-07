using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTestSolutions
{
    class Circle : Shape
    {
        public override void CalculateArea()
        {
            throw new NotImplementedException();
        }

        public override void CalculatePerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
