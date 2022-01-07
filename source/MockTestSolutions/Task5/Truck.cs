using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTestSolutions
{
    public class Truck:Vehicle
    {
        public Truck(string name, string color) :base(name, color)
        {
        }

        public Truck(string name, string color, int weight):base(name, color, weight)
        {
        }
    }
}
