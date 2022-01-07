using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_in_CSharp
{
    struct Coordinates
    {
        public int x;
        public int y;

        public int a { get; set; }
        public int b { get; set; }

        public void SetOrigin()
        {
            a = 0;
            b = 0;
        }
    }
}
