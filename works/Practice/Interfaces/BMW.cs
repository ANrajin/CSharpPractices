using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class BMW : ICar, IBike
    {
        public string Model { get; set; }
    }
}
