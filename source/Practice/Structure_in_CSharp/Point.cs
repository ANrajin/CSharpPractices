using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_in_CSharp
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        //we cannot define empty constructor in struct

        public Point(int x, int y)
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
