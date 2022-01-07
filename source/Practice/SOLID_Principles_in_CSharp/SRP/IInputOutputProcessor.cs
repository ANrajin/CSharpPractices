using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_in_CSharp.SRP
{
    interface IInputOutputProcessor
    {
        public int TakeInput();

        public void WriteOutput(string message);
    }
}
