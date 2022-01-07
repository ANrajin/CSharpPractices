using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_in_CSharp.SRP
{
    public class ConsoleInputOutput : IInputOutputProcessor
    {
        public int TakeInput()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public void WriteOutput(string message)
        {
            Console.WriteLine(message);
        }
    }
}
