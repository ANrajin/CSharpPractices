using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacing_in_CSharp
{
    class Bottle : IContainer, IColorable, ICloseable
    {
        public double Capacity { get; set; }
        public string Color { get; set; }

        private double contentAmount;

        private bool isOpen;

        public void AddContent(double Amount)
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void Open()
        {
            isOpen = true;
            Console.WriteLine("Open from bottle");
        }

        public void RemoveContent(double Amount)
        {
            throw new NotImplementedException();
        }
    }
}
