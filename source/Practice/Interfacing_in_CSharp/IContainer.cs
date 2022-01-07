using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacing_in_CSharp
{
    interface IContainer
    {
        public double Capacity { get; set; }

        public void AddContent(double Amount);
        public void RemoveContent(double Amount);
    }
}
