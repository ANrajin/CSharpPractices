using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_in_CSharp
{
    struct NewPoint
    {
        public int x { get; set; }
        public int y { get; set; }

        public NewPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }


        public static NewPoint GetOrigin()
        {
            return new NewPoint();
        }
    }
}
