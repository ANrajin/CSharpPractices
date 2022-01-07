using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_in_CSharp
{
    public class PointClass
    {
        public int X { get; set; }
        public int Y { get; set; }

        //we can define empty constructor in a class

        public PointClass()
        {

        }

        public PointClass(int x, int y)
        {
            X = x;
            Y = y;
        }


        public double CalculatedDistance()
        {
            throw new NotImplementedException();
        }
    }
}
