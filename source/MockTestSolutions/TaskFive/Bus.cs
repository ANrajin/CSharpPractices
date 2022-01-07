using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFive
{
    public class Bus : Vehicle
    {
        public Bus(string name, string color) : base(name, color)
        {
        }

        public Bus(string name, string color, int weight) : base(name, color, weight)
        {
        }
    }
}
