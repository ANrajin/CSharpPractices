using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacing_in_CSharp
{
    interface IColorable
    {
        public string Color { get; set; }

        //Interface can have default method implementation
        public string SetColor(string Color)
        {
            return "White";
        }
    }
}
