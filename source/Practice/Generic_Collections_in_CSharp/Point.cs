using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections_in_CSharp
{
    class Point<T, D, S>
    {
        public T x;
        public D y;
        public S a;


        public string Sum(T x, S a)
        {
            return x.ToString() + a;
        }

        public double Sum(T x, D y)
        {
            return Convert.ToDouble(x) + Convert.ToDouble(y);
        }
    }
}
